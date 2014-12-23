namespace HTMLGenerator
{
	partial class ItemHTMLDefinition
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.memberDefinitionEndLabel = new System.Windows.Forms.Label();
			this.AhrefName = new System.Windows.Forms.TextBox();
			this.ItemDescText = new System.Windows.Forms.RichTextBox();
			this.CodeSampleText = new System.Windows.Forms.RichTextBox();
			this.ItemNameText = new System.Windows.Forms.TextBox();
			this.ItemTypeText = new System.Windows.Forms.TextBox();
			this.AccessModifierDropdown = new System.Windows.Forms.ComboBox();
			this.TemplateArgsText = new System.Windows.Forms.TextBox();
			this.templateStartLabel = new System.Windows.Forms.Label();
			this.IsTemplatedBox = new System.Windows.Forms.CheckBox();
			this.templateEndLabel = new System.Windows.Forms.Label();
			this.isBreakBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// memberDefinitionEndLabel
			// 
			this.memberDefinitionEndLabel.AutoSize = true;
			this.memberDefinitionEndLabel.Location = new System.Drawing.Point(375, 86);
			this.memberDefinitionEndLabel.Name = "memberDefinitionEndLabel";
			this.memberDefinitionEndLabel.Size = new System.Drawing.Size(10, 13);
			this.memberDefinitionEndLabel.TabIndex = 20;
			this.memberDefinitionEndLabel.Text = ";";
			// 
			// AhrefName
			// 
			this.AhrefName.Location = new System.Drawing.Point(82, 110);
			this.AhrefName.Name = "AhrefName";
			this.AhrefName.Size = new System.Drawing.Size(117, 20);
			this.AhrefName.TabIndex = 19;
			this.AhrefName.Text = "Name of anchor link";
			// 
			// ItemDescText
			// 
			this.ItemDescText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ItemDescText.Location = new System.Drawing.Point(0, 142);
			this.ItemDescText.Name = "ItemDescText";
			this.ItemDescText.Size = new System.Drawing.Size(450, 123);
			this.ItemDescText.TabIndex = 18;
			this.ItemDescText.Text = "This is a description of the item.\nEach new line represents a different bullet po" +
    "int.";
			this.ItemDescText.WordWrap = false;
			// 
			// CodeSampleText
			// 
			this.CodeSampleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CodeSampleText.Location = new System.Drawing.Point(0, 265);
			this.CodeSampleText.Name = "CodeSampleText";
			this.CodeSampleText.Size = new System.Drawing.Size(450, 123);
			this.CodeSampleText.TabIndex = 17;
			this.CodeSampleText.Text = "//The following code prints \'hello\'.\nstd::cout << \"hello\";\n//Make sure to use spa" +
    "ces instead of tabs!";
			// 
			// ItemNameText
			// 
			this.ItemNameText.Location = new System.Drawing.Point(218, 83);
			this.ItemNameText.Name = "ItemNameText";
			this.ItemNameText.Size = new System.Drawing.Size(151, 20);
			this.ItemNameText.TabIndex = 16;
			this.ItemNameText.Text = "Name";
			this.ItemNameText.TextChanged += new System.EventHandler(this.ItemNameText_TextChanged);
			// 
			// ItemTypeText
			// 
			this.ItemTypeText.Location = new System.Drawing.Point(127, 83);
			this.ItemTypeText.Name = "ItemTypeText";
			this.ItemTypeText.Size = new System.Drawing.Size(85, 20);
			this.ItemTypeText.TabIndex = 15;
			this.ItemTypeText.Text = "Type";
			// 
			// AccessModifierDropdown
			// 
			this.AccessModifierDropdown.FormattingEnabled = true;
			this.AccessModifierDropdown.Items.AddRange(new object[] {
            "public",
            "protected",
            "private"});
			this.AccessModifierDropdown.Location = new System.Drawing.Point(17, 83);
			this.AccessModifierDropdown.Name = "AccessModifierDropdown";
			this.AccessModifierDropdown.Size = new System.Drawing.Size(103, 21);
			this.AccessModifierDropdown.TabIndex = 14;
			this.AccessModifierDropdown.Text = "Access Modifier";
			// 
			// TemplateArgsText
			// 
			this.TemplateArgsText.Enabled = false;
			this.TemplateArgsText.ForeColor = System.Drawing.SystemColors.ControlText;
			this.TemplateArgsText.Location = new System.Drawing.Point(178, 46);
			this.TemplateArgsText.Name = "TemplateArgsText";
			this.TemplateArgsText.Size = new System.Drawing.Size(248, 20);
			this.TemplateArgsText.TabIndex = 13;
			this.TemplateArgsText.Text = "typename Func";
			// 
			// templateStartLabel
			// 
			this.templateStartLabel.AutoSize = true;
			this.templateStartLabel.Location = new System.Drawing.Point(119, 49);
			this.templateStartLabel.Name = "templateStartLabel";
			this.templateStartLabel.Size = new System.Drawing.Size(56, 13);
			this.templateStartLabel.TabIndex = 12;
			this.templateStartLabel.Text = "template <";
			// 
			// IsTemplatedBox
			// 
			this.IsTemplatedBox.AutoSize = true;
			this.IsTemplatedBox.Location = new System.Drawing.Point(17, 48);
			this.IsTemplatedBox.Name = "IsTemplatedBox";
			this.IsTemplatedBox.Size = new System.Drawing.Size(89, 17);
			this.IsTemplatedBox.TabIndex = 11;
			this.IsTemplatedBox.Text = "Is templated?";
			this.IsTemplatedBox.UseVisualStyleBackColor = true;
			// 
			// templateEndLabel
			// 
			this.templateEndLabel.AutoSize = true;
			this.templateEndLabel.Location = new System.Drawing.Point(432, 49);
			this.templateEndLabel.Name = "templateEndLabel";
			this.templateEndLabel.Size = new System.Drawing.Size(13, 13);
			this.templateEndLabel.TabIndex = 21;
			this.templateEndLabel.Text = ">";
			// 
			// isBreakBox
			// 
			this.isBreakBox.AutoSize = true;
			this.isBreakBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.isBreakBox.Location = new System.Drawing.Point(17, 14);
			this.isBreakBox.Name = "isBreakBox";
			this.isBreakBox.Size = new System.Drawing.Size(90, 17);
			this.isBreakBox.TabIndex = 22;
			this.isBreakBox.Text = "Is List Break?";
			this.isBreakBox.UseVisualStyleBackColor = true;
			// 
			// ItemHTMLDefinition
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.isBreakBox);
			this.Controls.Add(this.templateEndLabel);
			this.Controls.Add(this.memberDefinitionEndLabel);
			this.Controls.Add(this.AhrefName);
			this.Controls.Add(this.ItemDescText);
			this.Controls.Add(this.CodeSampleText);
			this.Controls.Add(this.ItemNameText);
			this.Controls.Add(this.ItemTypeText);
			this.Controls.Add(this.AccessModifierDropdown);
			this.Controls.Add(this.TemplateArgsText);
			this.Controls.Add(this.templateStartLabel);
			this.Controls.Add(this.IsTemplatedBox);
			this.Name = "ItemHTMLDefinition";
			this.Size = new System.Drawing.Size(450, 388);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		protected System.Windows.Forms.Label memberDefinitionEndLabel;
		protected System.Windows.Forms.Label templateStartLabel;
		protected System.Windows.Forms.Label templateEndLabel;
		protected System.Windows.Forms.CheckBox isBreakBox;
		protected System.Windows.Forms.RichTextBox ItemDescText;
		protected System.Windows.Forms.RichTextBox CodeSampleText;
		protected System.Windows.Forms.TextBox ItemNameText;
		protected System.Windows.Forms.TextBox ItemTypeText;
		protected System.Windows.Forms.ComboBox AccessModifierDropdown;
		protected System.Windows.Forms.TextBox TemplateArgsText;
		protected System.Windows.Forms.CheckBox IsTemplatedBox;
		public System.Windows.Forms.TextBox AhrefName;

	}
}
