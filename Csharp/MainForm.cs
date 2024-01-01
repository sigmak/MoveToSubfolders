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
	
		}
	}
}
