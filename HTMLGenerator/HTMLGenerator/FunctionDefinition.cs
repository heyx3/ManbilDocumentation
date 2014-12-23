using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLGenerator
{
	public partial class FunctionDefinition : ItemHTMLDefinition
	{
		public FunctionDefinition()
		{
			InitializeMyComponent();
		}
		public FunctionDefinition(ItemHTMLData data)
			: this()
		{
			SetData(data);
		}

		protected override void AddDefinition(string className, StringBuilder sbOut)
		{
			sbOut.Append(AccessModifierDropdown.SelectedItem.ToString());
			sbOut.Append(' ');
			sbOut.Append(ItemTypeText.Text);
			sbOut.Append(' ');
			sbOut.Append(ItemNameText.Text);
			sbOut.Append('(');
			sbOut.Append(functionArgsText.Text);
			sbOut.Append(')');
			if (isConstBox.Checked)
				sbOut.Append(" const");
			sbOut.Append(';');
		}
		public override ItemHTMLData GetData()
		{
			return new FunctionData(functionArgsText.Text, base.GetData());
		}
		public override void SetData(ItemHTMLData data)
		{
			base.SetData(data);
			(data as FunctionData).Arguments = functionArgsText.Text;
		}

		private void InitializeComponent()
		{
			this.functionStartLabel = new System.Windows.Forms.Label();
			this.functionArgsText = new System.Windows.Forms.TextBox();
			this.isConstBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// memberDefinitionEndLabel
			// 
			this.memberDefinitionEndLabel.Location = new System.Drawing.Point(422, 86);
			this.memberDefinitionEndLabel.Size = new System.Drawing.Size(13, 13);
			this.memberDefinitionEndLabel.Text = ");";
			// 
			// ItemNameText
			// 
			this.ItemNameText.Enabled = false;
			this.ItemNameText.Location = new System.Drawing.Point(177, 84);
			this.ItemNameText.Size = new System.Drawing.Size(45, 20);
			this.ItemNameText.Visible = false;
			// 
			// ItemTypeText
			// 
			this.ItemTypeText.Enabled = false;
			this.ItemTypeText.Location = new System.Drawing.Point(126, 84);
			this.ItemTypeText.Size = new System.Drawing.Size(45, 20);
			this.ItemTypeText.Visible = false;
			// 
			// functionStartLabel
			// 
			this.functionStartLabel.AutoSize = true;
			this.functionStartLabel.Location = new System.Drawing.Point(228, 86);
			this.functionStartLabel.Name = "functionStartLabel";
			this.functionStartLabel.Size = new System.Drawing.Size(10, 13);
			this.functionStartLabel.TabIndex = 23;
			this.functionStartLabel.Text = "(";
			// 
			// functionArgsText
			// 
			this.functionArgsText.Location = new System.Drawing.Point(244, 83);
			this.functionArgsText.Name = "functionArgsText";
			this.functionArgsText.Size = new System.Drawing.Size(172, 20);
			this.functionArgsText.TabIndex = 24;
			this.functionArgsText.Text = "void";
			// 
			// isConstBox
			// 
			this.isConstBox.AutoSize = true;
			this.isConstBox.Location = new System.Drawing.Point(231, 112);
			this.isConstBox.Name = "isConstBox";
			this.isConstBox.Size = new System.Drawing.Size(70, 17);
			this.isConstBox.TabIndex = 25;
			this.isConstBox.Text = "Is Const?";
			this.isConstBox.UseVisualStyleBackColor = true;
			// 
			// FunctionDefinition
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Controls.Add(this.isConstBox);
			this.Controls.Add(this.functionArgsText);
			this.Controls.Add(this.functionStartLabel);
			this.Name = "FunctionDefinition";
			this.Controls.SetChildIndex(this.IsTemplatedBox, 0);
			this.Controls.SetChildIndex(this.templateStartLabel, 0);
			this.Controls.SetChildIndex(this.TemplateArgsText, 0);
			this.Controls.SetChildIndex(this.AccessModifierDropdown, 0);
			this.Controls.SetChildIndex(this.ItemTypeText, 0);
			this.Controls.SetChildIndex(this.ItemNameText, 0);
			this.Controls.SetChildIndex(this.CodeSampleText, 0);
			this.Controls.SetChildIndex(this.ItemDescText, 0);
			this.Controls.SetChildIndex(this.AhrefName, 0);
			this.Controls.SetChildIndex(this.memberDefinitionEndLabel, 0);
			this.Controls.SetChildIndex(this.templateEndLabel, 0);
			this.Controls.SetChildIndex(this.isBreakBox, 0);
			this.Controls.SetChildIndex(this.functionStartLabel, 0);
			this.Controls.SetChildIndex(this.functionArgsText, 0);
			this.Controls.SetChildIndex(this.isConstBox, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}


	public class FunctionData : ItemHTMLData
	{
		public string Arguments = "";

		/// <summary>
		/// Creates a function that just represents a list break.
		/// </summary>
		public FunctionData () : base() { }
		/// <summary>
		/// Creates a function that isn't templated.
		/// </summary>
		public FunctionData (string accessModifier, string constructorArgs, string funcName,
							 string anchorLinkName, string constructorDesc, string codeSample)
		{
			IsListBreak = false;
			IsTemplated = false;

			AccessModifier = accessModifier;
			Arguments = constructorArgs;
			AnchorLinkName = anchorLinkName;
			ItemDesc = constructorDesc;
			CodeSample = codeSample;
		}
		/// <summary>
		/// Creates a function that is templated.
		/// </summary>
		public FunctionData (string templateArgs, string accessModifier, string funcName, string funcArgs,
							 string anchorLinkName, string constructorDesc, string codeSample)
		{
			IsListBreak = false;
			IsTemplated = true;

			TemplateArgs = templateArgs;
			AccessModifier = accessModifier;
			Arguments = funcArgs;
			AnchorLinkName = anchorLinkName;
			ItemDesc = constructorDesc;
			CodeSample = codeSample;
		}
		public FunctionData(string arguments, ItemHTMLData baseCopy)
			: base(baseCopy)
		{
			Arguments = arguments;
		}
		/// <summary>
		/// Creates a copy of the given function data.
		/// </summary>
		public FunctionData(FunctionData copy)
			: base(copy)
		{
			Arguments = copy.Arguments;
		}
	}
}
