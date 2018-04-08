namespace ProjectSetupTool
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CreateProjectBtn = new System.Windows.Forms.Button();
			this.RootFolderLable = new System.Windows.Forms.Label();
			this.ProjectTypeLable = new System.Windows.Forms.Label();
			this.RootFolderTxtBox = new System.Windows.Forms.TextBox();
			this.ProjectTypeListBox = new System.Windows.Forms.ListBox();
			this.ProjectNameLable = new System.Windows.Forms.Label();
			this.ProjectNameTxtBox = new System.Windows.Forms.TextBox();
			this.ProjectNamePrefixLable = new System.Windows.Forms.Label();
			this.ProjectNamePrefixTxtBox = new System.Windows.Forms.TextBox();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.SourceListBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ServerTargetFileBtn = new System.Windows.Forms.CheckBox();
			this.UseSlateBtn = new System.Windows.Forms.CheckBox();
			this.UsePublicBtn = new System.Windows.Forms.CheckBox();
			this.UseSteamBtn = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// CreateProjectBtn
			// 
			this.CreateProjectBtn.Location = new System.Drawing.Point(12, 379);
			this.CreateProjectBtn.Name = "CreateProjectBtn";
			this.CreateProjectBtn.Size = new System.Drawing.Size(89, 42);
			this.CreateProjectBtn.TabIndex = 7;
			this.CreateProjectBtn.Text = "Create Project";
			this.CreateProjectBtn.UseVisualStyleBackColor = true;
			this.CreateProjectBtn.Click += new System.EventHandler(this.CreateProjectBtn_Click);
			// 
			// RootFolderLable
			// 
			this.RootFolderLable.AutoSize = true;
			this.RootFolderLable.ForeColor = System.Drawing.SystemColors.Control;
			this.RootFolderLable.Location = new System.Drawing.Point(9, 11);
			this.RootFolderLable.Name = "RootFolderLable";
			this.RootFolderLable.Size = new System.Drawing.Size(93, 13);
			this.RootFolderLable.TabIndex = 2;
			this.RootFolderLable.Text = "Setup Root Folder";
			// 
			// ProjectTypeLable
			// 
			this.ProjectTypeLable.AutoSize = true;
			this.ProjectTypeLable.ForeColor = System.Drawing.SystemColors.Control;
			this.ProjectTypeLable.Location = new System.Drawing.Point(9, 74);
			this.ProjectTypeLable.Name = "ProjectTypeLable";
			this.ProjectTypeLable.Size = new System.Drawing.Size(67, 13);
			this.ProjectTypeLable.TabIndex = 4;
			this.ProjectTypeLable.Text = "Project Type";
			// 
			// RootFolderTxtBox
			// 
			this.RootFolderTxtBox.Location = new System.Drawing.Point(12, 28);
			this.RootFolderTxtBox.Name = "RootFolderTxtBox";
			this.RootFolderTxtBox.Size = new System.Drawing.Size(269, 20);
			this.RootFolderTxtBox.TabIndex = 1;
			this.RootFolderTxtBox.Text = "E:\\";
			this.RootFolderTxtBox.TextChanged += new System.EventHandler(this.RootFolderTxtBox_TextChanged);
			// 
			// ProjectTypeListBox
			// 
			this.ProjectTypeListBox.DisplayMember = "UE4 Project";
			this.ProjectTypeListBox.FormattingEnabled = true;
			this.ProjectTypeListBox.Items.AddRange(new object[] {
            "Normal UE4 Project",
            "Empty UE4 Project",
            "Code Project"});
			this.ProjectTypeListBox.Location = new System.Drawing.Point(12, 91);
			this.ProjectTypeListBox.Name = "ProjectTypeListBox";
			this.ProjectTypeListBox.Size = new System.Drawing.Size(269, 56);
			this.ProjectTypeListBox.TabIndex = 2;
			this.ProjectTypeListBox.ValueMember = "UE4 Project";
			this.ProjectTypeListBox.SelectedIndexChanged += new System.EventHandler(this.ProjectTypeListBox_SelectedIndexChanged);
			// 
			// ProjectNameLable
			// 
			this.ProjectNameLable.AutoSize = true;
			this.ProjectNameLable.ForeColor = System.Drawing.SystemColors.Control;
			this.ProjectNameLable.Location = new System.Drawing.Point(10, 170);
			this.ProjectNameLable.Name = "ProjectNameLable";
			this.ProjectNameLable.Size = new System.Drawing.Size(71, 13);
			this.ProjectNameLable.TabIndex = 7;
			this.ProjectNameLable.Text = "Project Name";
			// 
			// ProjectNameTxtBox
			// 
			this.ProjectNameTxtBox.Location = new System.Drawing.Point(13, 187);
			this.ProjectNameTxtBox.MaxLength = 25;
			this.ProjectNameTxtBox.Name = "ProjectNameTxtBox";
			this.ProjectNameTxtBox.Size = new System.Drawing.Size(131, 20);
			this.ProjectNameTxtBox.TabIndex = 3;
			this.ProjectNameTxtBox.TextChanged += new System.EventHandler(this.ProjectNameTxtBox_TextChanged);
			// 
			// ProjectNamePrefixLable
			// 
			this.ProjectNamePrefixLable.AutoSize = true;
			this.ProjectNamePrefixLable.ForeColor = System.Drawing.SystemColors.Control;
			this.ProjectNamePrefixLable.Location = new System.Drawing.Point(11, 235);
			this.ProjectNamePrefixLable.Name = "ProjectNamePrefixLable";
			this.ProjectNamePrefixLable.Size = new System.Drawing.Size(100, 13);
			this.ProjectNamePrefixLable.TabIndex = 8;
			this.ProjectNamePrefixLable.Text = "Project Name Prefix";
			// 
			// ProjectNamePrefixTxtBox
			// 
			this.ProjectNamePrefixTxtBox.Location = new System.Drawing.Point(14, 251);
			this.ProjectNamePrefixTxtBox.MaxLength = 4;
			this.ProjectNamePrefixTxtBox.Name = "ProjectNamePrefixTxtBox";
			this.ProjectNamePrefixTxtBox.Size = new System.Drawing.Size(130, 20);
			this.ProjectNamePrefixTxtBox.TabIndex = 4;
			this.ProjectNamePrefixTxtBox.TextChanged += new System.EventHandler(this.ProjectNamePrefixTxtBox_TextChanged);
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(195, 379);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(85, 42);
			this.ExitBtn.TabIndex = 9;
			this.ExitBtn.Text = "Exit";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// SourceListBox
			// 
			this.SourceListBox.FormattingEnabled = true;
			this.SourceListBox.Items.AddRange(new object[] {
            "Player",
            "Environment",
            "Components",
            "Core",
            "Online",
            "Types"});
			this.SourceListBox.Location = new System.Drawing.Point(162, 189);
			this.SourceListBox.Name = "SourceListBox";
			this.SourceListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.SourceListBox.Size = new System.Drawing.Size(120, 82);
			this.SourceListBox.TabIndex = 5;
			this.SourceListBox.SelectedIndexChanged += new System.EventHandler(this.SourceListBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(159, 170);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Subfolders (Optional)";
			// 
			// ServerTargetFileBtn
			// 
			this.ServerTargetFileBtn.AutoSize = true;
			this.ServerTargetFileBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.ServerTargetFileBtn.Location = new System.Drawing.Point(14, 297);
			this.ServerTargetFileBtn.Name = "ServerTargetFileBtn";
			this.ServerTargetFileBtn.Size = new System.Drawing.Size(148, 17);
			this.ServerTargetFileBtn.TabIndex = 12;
			this.ServerTargetFileBtn.Text = "Include Server Target File";
			this.ServerTargetFileBtn.UseVisualStyleBackColor = true;
			this.ServerTargetFileBtn.CheckedChanged += new System.EventHandler(this.ServerTargetFileBtn_CheckedChanged);
			// 
			// UseSlateBtn
			// 
			this.UseSlateBtn.AutoSize = true;
			this.UseSlateBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.UseSlateBtn.Location = new System.Drawing.Point(14, 320);
			this.UseSlateBtn.Name = "UseSlateBtn";
			this.UseSlateBtn.Size = new System.Drawing.Size(72, 17);
			this.UseSlateBtn.TabIndex = 16;
			this.UseSlateBtn.Text = "Use Slate";
			this.UseSlateBtn.UseVisualStyleBackColor = true;
			this.UseSlateBtn.CheckedChanged += new System.EventHandler(this.UseSlateBtn_CheckedChanged);
			// 
			// UsePublicBtn
			// 
			this.UsePublicBtn.AutoSize = true;
			this.UsePublicBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.UsePublicBtn.Location = new System.Drawing.Point(162, 297);
			this.UsePublicBtn.Name = "UsePublicBtn";
			this.UsePublicBtn.Size = new System.Drawing.Size(114, 17);
			this.UsePublicBtn.TabIndex = 17;
			this.UsePublicBtn.Text = "Use Public Folders";
			this.UsePublicBtn.UseVisualStyleBackColor = true;
			this.UsePublicBtn.CheckedChanged += new System.EventHandler(this.UsePublicBtn_CheckedChanged);
			// 
			// UseSteamBtn
			// 
			this.UseSteamBtn.AutoSize = true;
			this.UseSteamBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.UseSteamBtn.Location = new System.Drawing.Point(162, 320);
			this.UseSteamBtn.Name = "UseSteamBtn";
			this.UseSteamBtn.Size = new System.Drawing.Size(78, 17);
			this.UseSteamBtn.TabIndex = 18;
			this.UseSteamBtn.Text = "Use Steam";
			this.UseSteamBtn.UseVisualStyleBackColor = true;
			this.UseSteamBtn.CheckedChanged += new System.EventHandler(this.UseSteamBtn_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(294, 435);
			this.ControlBox = false;
			this.Controls.Add(this.UseSteamBtn);
			this.Controls.Add(this.UsePublicBtn);
			this.Controls.Add(this.UseSlateBtn);
			this.Controls.Add(this.ServerTargetFileBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SourceListBox);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.ProjectNamePrefixTxtBox);
			this.Controls.Add(this.ProjectNamePrefixLable);
			this.Controls.Add(this.ProjectNameTxtBox);
			this.Controls.Add(this.ProjectNameLable);
			this.Controls.Add(this.ProjectTypeListBox);
			this.Controls.Add(this.RootFolderTxtBox);
			this.Controls.Add(this.ProjectTypeLable);
			this.Controls.Add(this.RootFolderLable);
			this.Controls.Add(this.CreateProjectBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Project Setup Tool";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CreateProjectBtn;
		private System.Windows.Forms.Label RootFolderLable;
		private System.Windows.Forms.Label ProjectTypeLable;
		private System.Windows.Forms.TextBox RootFolderTxtBox;
		private System.Windows.Forms.ListBox ProjectTypeListBox;
		private System.Windows.Forms.Label ProjectNameLable;
		private System.Windows.Forms.TextBox ProjectNameTxtBox;
		private System.Windows.Forms.Label ProjectNamePrefixLable;
		private System.Windows.Forms.TextBox ProjectNamePrefixTxtBox;
		private System.Windows.Forms.Button ExitBtn;
		private System.Windows.Forms.ListBox SourceListBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox ServerTargetFileBtn;
		private System.Windows.Forms.CheckBox UseSlateBtn;
		private System.Windows.Forms.CheckBox UsePublicBtn;
		private System.Windows.Forms.CheckBox UseSteamBtn;
	}
}

