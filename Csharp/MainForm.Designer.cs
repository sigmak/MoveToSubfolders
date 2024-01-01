/*
 * Created by SharpDevelop.
 * User: sigmak
 * Date: 2024-01-02
 * Time: 오전 12:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MoveToSubFolders
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TextBox txt101;
		private System.Windows.Forms.TextBox txt201Ext;
		private System.Windows.Forms.Label lbl201;
		private System.Windows.Forms.Button btn202Path;
		private System.Windows.Forms.TextBox txt202FolderPath;
		private System.Windows.Forms.Label lbl202;
		private System.Windows.Forms.ListView listView301;
		private System.Windows.Forms.Button btn301Run;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.txt101 = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txt201Ext = new System.Windows.Forms.TextBox();
			this.lbl201 = new System.Windows.Forms.Label();
			this.btn202Path = new System.Windows.Forms.Button();
			this.txt202FolderPath = new System.Windows.Forms.TextBox();
			this.lbl202 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.listView301 = new System.Windows.Forms.ListView();
			this.btn301Run = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(898, 444);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.txt101);
			this.tabPage1.Location = new System.Drawing.Point(4, 28);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(890, 412);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "01설명";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// txt101
			// 
			this.txt101.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txt101.Location = new System.Drawing.Point(3, 3);
			this.txt101.Multiline = true;
			this.txt101.Name = "txt101";
			this.txt101.Size = new System.Drawing.Size(884, 406);
			this.txt101.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.txt201Ext);
			this.tabPage2.Controls.Add(this.lbl201);
			this.tabPage2.Controls.Add(this.btn202Path);
			this.tabPage2.Controls.Add(this.txt202FolderPath);
			this.tabPage2.Controls.Add(this.lbl202);
			this.tabPage2.Location = new System.Drawing.Point(4, 28);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(890, 412);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "02설정";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txt201Ext
			// 
			this.txt201Ext.Location = new System.Drawing.Point(165, 10);
			this.txt201Ext.Name = "txt201Ext";
			this.txt201Ext.Size = new System.Drawing.Size(100, 28);
			this.txt201Ext.TabIndex = 21;
			// 
			// lbl201
			// 
			this.lbl201.Location = new System.Drawing.Point(16, 16);
			this.lbl201.Name = "lbl201";
			this.lbl201.Size = new System.Drawing.Size(153, 22);
			this.lbl201.TabIndex = 20;
			this.lbl201.Text = "프로젝트 확장자 :";
			// 
			// btn202Path
			// 
			this.btn202Path.Location = new System.Drawing.Point(531, 63);
			this.btn202Path.Name = "btn202Path";
			this.btn202Path.Size = new System.Drawing.Size(70, 29);
			this.btn202Path.TabIndex = 19;
			this.btn202Path.Text = "...";
			this.btn202Path.UseVisualStyleBackColor = true;
			this.btn202Path.Click += new System.EventHandler(this.Btn202PathClick);
			// 
			// txt202FolderPath
			// 
			this.txt202FolderPath.Location = new System.Drawing.Point(76, 63);
			this.txt202FolderPath.Name = "txt202FolderPath";
			this.txt202FolderPath.Size = new System.Drawing.Size(449, 28);
			this.txt202FolderPath.TabIndex = 18;
			// 
			// lbl202
			// 
			this.lbl202.Location = new System.Drawing.Point(16, 68);
			this.lbl202.Name = "lbl202";
			this.lbl202.Size = new System.Drawing.Size(58, 22);
			this.lbl202.TabIndex = 17;
			this.lbl202.Text = "경로 :";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.listView301);
			this.tabPage3.Controls.Add(this.btn301Run);
			this.tabPage3.Location = new System.Drawing.Point(4, 28);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(890, 412);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "03분류";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 28);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(890, 412);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "04결과표시";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// listView301
			// 
			this.listView301.Location = new System.Drawing.Point(18, 59);
			this.listView301.Name = "listView301";
			this.listView301.Size = new System.Drawing.Size(741, 264);
			this.listView301.TabIndex = 4;
			this.listView301.UseCompatibleStateImageBehavior = false;
			// 
			// btn301Run
			// 
			this.btn301Run.Location = new System.Drawing.Point(7, 10);
			this.btn301Run.Name = "btn301Run";
			this.btn301Run.Size = new System.Drawing.Size(115, 29);
			this.btn301Run.TabIndex = 3;
			this.btn301Run.Text = "추출Run";
			this.btn301Run.UseVisualStyleBackColor = true;
			this.btn301Run.Click += new System.EventHandler(this.Btn301RunClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 444);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "MoveToSubFolders";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
