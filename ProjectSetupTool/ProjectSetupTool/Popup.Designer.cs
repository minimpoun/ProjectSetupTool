namespace ProjectSetupTool
{
	partial class Popup
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
			this.ErrorMessageTxtBox = new System.Windows.Forms.RichTextBox();
			this.CloseBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ErrorMessageTxtBox
			// 
			this.ErrorMessageTxtBox.Location = new System.Drawing.Point(12, 12);
			this.ErrorMessageTxtBox.Name = "ErrorMessageTxtBox";
			this.ErrorMessageTxtBox.ReadOnly = true;
			this.ErrorMessageTxtBox.Size = new System.Drawing.Size(179, 53);
			this.ErrorMessageTxtBox.TabIndex = 1;
			this.ErrorMessageTxtBox.Text = "";
			// 
			// CloseBtn
			// 
			this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CloseBtn.Location = new System.Drawing.Point(64, 74);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(75, 23);
			this.CloseBtn.TabIndex = 2;
			this.CloseBtn.Text = "Close";
			this.CloseBtn.UseVisualStyleBackColor = true;
			// 
			// Popup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(203, 109);
			this.Controls.Add(this.CloseBtn);
			this.Controls.Add(this.ErrorMessageTxtBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Popup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Popup";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox ErrorMessageTxtBox;
		private System.Windows.Forms.Button CloseBtn;
	}
}