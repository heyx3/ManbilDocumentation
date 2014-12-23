namespace HTMLGenerator
{
	partial class FileErrorPopup
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
			this.closePopupButton = new System.Windows.Forms.Button();
			this.errorIntroLabel = new System.Windows.Forms.Label();
			this.ErrorTypeLabel = new System.Windows.Forms.Label();
			this.ErrorMessageLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// closePopupButton
			// 
			this.closePopupButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.closePopupButton.Location = new System.Drawing.Point(68, 193);
			this.closePopupButton.Name = "closePopupButton";
			this.closePopupButton.Size = new System.Drawing.Size(75, 23);
			this.closePopupButton.TabIndex = 0;
			this.closePopupButton.Text = "OK";
			this.closePopupButton.UseVisualStyleBackColor = true;
			// 
			// errorIntroLabel
			// 
			this.errorIntroLabel.AutoSize = true;
			this.errorIntroLabel.Location = new System.Drawing.Point(12, 18);
			this.errorIntroLabel.Name = "errorIntroLabel";
			this.errorIntroLabel.Size = new System.Drawing.Size(81, 13);
			this.errorIntroLabel.TabIndex = 1;
			this.errorIntroLabel.Text = "Error writing file:";
			// 
			// ErrorTypeLabel
			// 
			this.ErrorTypeLabel.AutoSize = true;
			this.ErrorTypeLabel.Location = new System.Drawing.Point(41, 53);
			this.ErrorTypeLabel.Name = "ErrorTypeLabel";
			this.ErrorTypeLabel.Size = new System.Drawing.Size(87, 13);
			this.ErrorTypeLabel.TabIndex = 2;
			this.ErrorTypeLabel.Text = "[Exception Type]";
			// 
			// ErrorMessageLabel
			// 
			this.ErrorMessageLabel.AutoSize = true;
			this.ErrorMessageLabel.Location = new System.Drawing.Point(22, 111);
			this.ErrorMessageLabel.Name = "ErrorMessageLabel";
			this.ErrorMessageLabel.Size = new System.Drawing.Size(106, 13);
			this.ErrorMessageLabel.TabIndex = 3;
			this.ErrorMessageLabel.Text = "[Exception Message]";
			// 
			// FileErrorPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(206, 228);
			this.Controls.Add(this.ErrorMessageLabel);
			this.Controls.Add(this.ErrorTypeLabel);
			this.Controls.Add(this.errorIntroLabel);
			this.Controls.Add(this.closePopupButton);
			this.Name = "FileErrorPopup";
			this.Text = "File Error";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button closePopupButton;
		private System.Windows.Forms.Label errorIntroLabel;
		public System.Windows.Forms.Label ErrorTypeLabel;
		public System.Windows.Forms.Label ErrorMessageLabel;
	}
}