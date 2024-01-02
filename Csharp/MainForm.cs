/*
 * Created by SharpDevelop.
 * User: sigmak
 * Date: 2024-01-02
 * Time: 오전 12:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq; // OrderByDescending 사용을 위해


// CS 201 : Properites\AssemblyInfo.cs 파일이 없다는 오류메세지 나오면
// Properites 폴더 만들고 그 폴더 안에 AssemblyInfo.cs 파일 생성(내용 없어도 됨) 후
// 새로 빌드 하면 오류 나타나지 않음.


namespace MoveToSubFolders
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			txt101.Text ="";
			txt101.Text += "\r\n";
			txt101.Text += "[MoveToSubFolders] " + "\r\n" + "\r\n";
			txt101.Text += "한 폴더에 여러가지 프로젝트 소스코드들이 섞여 있어서" + "\r\n" + "\r\n";
			txt101.Text += "프로젝트 파일명 기준으로 그 하위 폴더들을 생성해서 " + "\r\n" + "\r\n";
			txt101.Text += "프로젝트 파일명 패턴으로 분류하기 위해 작성됨. " + "\r\n" + "\r\n";
			txt101.Text += "프로젝트 파일명 추출해서 정렬할때 문자열 길이가 긴 순서대로 정렬이 되기때문에 " + "\r\n" + "\r\n";
			txt101.Text += "_XXX로 분기되는 패턴이 먼저 분류가 되기 때문에 "  + "\r\n" + "\r\n";
			txt101.Text += "_XXX로 분기 안된 프로젝트와 섞이지 않게 됨.  " + "\r\n" + "\r\n";
	
			txt201Ext.Text ="vbp";  //vb6 프로젝트 파일 확장자
			
			//출처 : https://w9526819.tistory.com/20
			txt202FolderPath.Text = System.IO.Directory.GetCurrentDirectory(); // 현재 실행파일 경로 가져오기
			
			toolStripStatusLabel1.Text ="https://github.com/sigmak/MoveToSubfolders";
			toolStripProgressBar1.Minimum = 0;
			toolStripProgressBar1.Maximum = 100;
			toolStripProgressBar1.Step =1;
			
			toolStripStatusLabel2.Text ="";
			
		}
		
		//2-1. 폴더 경로 찾기
		void Btn202PathClick(object sender, EventArgs e)
		{
			//출처 : https://zzangwoo.tistory.com/entry/CWinform-%ED%8F%B4%EB%8D%94-%EB%B0%8F-%ED%8C%8C%EC%9D%BC-%EC%84%A0%ED%83%9D-CommonOpenFileDialog-OpenFileDialog-FolderBrowserDialog
			//경로 찾기
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.SelectedPath = txt202FolderPath.Text; // 기존경로 세팅
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				//MessageBox.Show(folderBrowserDialog.SelectedPath);
				txt202FolderPath.Text = folderBrowserDialog.SelectedPath;
			}			
	
		}
		
		//3-1 분류 run
		void Btn301RunClick(object sender, EventArgs e)
		{
			// 파일명
			
			DirectoryInfo myDirectory = new DirectoryInfo(txt202FolderPath.Text);
			FileInfo[] files = myDirectory.GetFiles("*." + txt201Ext.Text).OrderByDescending(file => System.Text.Encoding.Default.GetByteCount(file.Name)).ToArray();
			
			//출처 : https://www.csharpstudy.com/WinForms/WinForms-listview.aspx
			// 리스트뷰 아이템을 업데이트 하기 시작.
			// 업데이트가 끝날 때까지 UI 갱신 중지.
			listView301.BeginUpdate();		
			
			// 뷰모드 지정
			listView301.View = View.Details;
			
			// 아이콘을 위해 이미지 지정
			//listView301.LargeImageList = imageList1;
			//listView301.SmallImageList = imageList2;
			
			foreach (var fi in files)
			{
				// 각 파일별로 ListViewItem객체를 하나씩 만듦
				// 파일명, 사이즈, 날짜 정보를 추가
				string fileNameOnly = Path.GetFileNameWithoutExtension(fi.Name);
				ListViewItem lvi = new ListViewItem(fileNameOnly); //파일명만
				lvi.SubItems.Add(Path.GetExtension(fi.Name)); // 확장자만 ex) .vbp
				lvi.SubItems.Add(FormatFileSize(System.Text.Encoding.Default.GetByteCount(fileNameOnly))); // 파일명길이
				
 				//lvi.SubItems.Add(fi.Length.ToString());
				lvi.SubItems.Add(FormatFileSize(fi.Length)); // 천단위마다 콤마 표시
				lvi.SubItems.Add(fi.LastWriteTime.ToString());
				lvi.ImageIndex = 0;
				
				// ListViewItem객체를 Items 속성에 추가
				listView301.Items.Add(lvi);
			}
			
			// 컬럼명과 컬럼사이즈 지정
			listView301.Columns.Add("파일명", 160, HorizontalAlignment.Left);
			listView301.Columns.Add("확장자", 60, HorizontalAlignment.Left);
			listView301.Columns.Add("파일명 길이", 50, HorizontalAlignment.Right);
			listView301.Columns.Add("사이즈", 70, HorizontalAlignment.Right);
			listView301.Columns.Add("날짜", 150, HorizontalAlignment.Left);

			// 리스뷰를 Refresh하여 보여줌
			listView301.EndUpdate();			
			
			txt401.Text ="";
			toolStripProgressBar1.Value = 0;
			int vbpCnt = 0;
	    	foreach (ListViewItem lvi in listView301.Items)
	    	{
	    		txt401.Text += lvi.SubItems[0].Text + "\r\n";
	    		
	    		// 프로젝트파일명 (확장자없이) 으로
	    		//1. 디렉토리가 없으면 생성
	    		//2. 디렉토리가 있으면 생성하지 않음
	    		//3. "*" + "프로젝트파일명" + "*.*" 패턴으로 프로젝트파일명 폴더에 복사
	    		FileInfo[] subfiles = myDirectory.GetFiles("*" + lvi.SubItems[0].Text + ".*").OrderByDescending(file => System.Text.Encoding.Default.GetByteCount(file.Name)).ToArray();
	    		string source_path = txt202FolderPath.Text;
	    		string target_path = txt202FolderPath.Text +"\\" + lvi.SubItems[0].Text;
	    		
	    		bool exists = System.IO.Directory.Exists(target_path); // sub 폴더 존재하는지 체크
	    		if(!exists)
	    		{
	    			System.IO.Directory.CreateDirectory(target_path); // 없으면 폴더 생성
	    			txt401.Text += target_path + " 폴더 새로 생성"+ "\r\n";
	    		} else {
	    			txt401.Text += target_path + " 폴더 이미 존재"+ "\r\n";
	    		}
	    			
	    			
	    		foreach (var sfi in subfiles)
	    		{
	    			//출처 : https://jinuk97-dev.tistory.com/8
	    			string source_file = System.IO.Path.Combine(source_path, sfi.Name);
	    			string dest_file = System.IO.Path.Combine(target_path, sfi.Name);
	    			txt401.Text += source_file + " --> " + dest_file + "\r\n";
	    			System.IO.File.Move(source_file, dest_file); //이동
	    		}
	    		vbpCnt++;
	    		toolStripProgressBar1.Value =  vbpCnt/listView301.Items.Count * 100;
	    		toolStripStatusLabel2.Text =toolStripProgressBar1.Value.ToString() + "%";
	    		
	    	}
	    	txt401.Text += "파일분류완료!!!" + "\r\n";
	    	MessageBox.Show("파일분류완료!!!");
	
		}

		static string FormatFileSize(long fileSize)
		{
			// 파일 크기를 천 단위로 쉼표로 구분하여 형식 지정
			return string.Format("{0:#,0}", fileSize);
		}		
		
	}
}
