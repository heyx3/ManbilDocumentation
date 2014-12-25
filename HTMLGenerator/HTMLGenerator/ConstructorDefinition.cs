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
	public partial class ConstructorDefinition : ItemHTMLDefinition
	{
		public ConstructorDefinition()
		{
			InitializeMyComponent();
			InitializeComponent();
		}
		public ConstructorDefinition(ItemHTMLData data)
			: this()
		{
			SetData(data);
		}

		protected override void AddDefinition(string className, StringBuilder sbOut)
		{
			sbOut.Append(AccessModifierDropdown.SelectedItem.ToString());
			sbOut.Append(" ");
			sbOut.Append(className);
			sbOut.Append("(");
			sbOut.Append(constructorArgsText.Text);
			sbOut.Append(");");
		}
		public override ItemHTMLData GetData()
		{
			return new ConstructorData(constructorArgsText.Text, base.GetData());
		}
		public override void SetData(ItemHTMLData data)
		{
			base.SetData(data);
			(data as ConstructorData).Arguments = constructorArgsText.Text;
		}

		private void InitializeComponent()
		{
			this.constructorStartLabel = new System.Windows.Forms.Label();
			this.constructorArgsText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// memberDefinitionEndLabel
			// 
			this.memberDefinitionEndLabel.Size = new System.Drawing.Size(13, 13);
			this.memberDefinitionEndLabel.Text = ");";
			// 
			// ItemNameText
			// 
			this.ItemNameText.Enabled = false;
			this.ItemNameText.Location = new System.Drawing.Point(416, 116);
			this.ItemNameText.Size = new System.Drawing.Size(0, 20);
			this.ItemNameText.Visible = false;
			// 
			// ItemTypeText
			// 
			this.ItemTypeText.Enabled = false;
			this.ItemTypeText.Location = new System.Drawing.Point(300, 110);
			this.ItemTypeText.Size = new System.Drawing.Size(0, 20);
			this.ItemTypeText.Visible = false;
			// 
			// constructorStartLabel
			// 
			this.constructorStartLabel.AutoSize = true;
			this.constructorStartLabel.Location = new System.Drawing.Point(127, 86);
			this.constructorStartLabel.Name = "constructorStartLabel";
			this.constructorStartLabel.Size = new System.Drawing.Size(64, 13);
			this.constructorStartLabel.TabIndex = 23;
			this.constructorStartLabel.Text = "Constructor(";
			// 
			// constructorArgsText
			// 
			this.constructorArgsText.Location = new System.Drawing.Point(197, 83);
			this.constructorArgsText.Name = "constructorArgsText";
			this.constructorArgsText.Size = new System.Drawing.Size(172, 20);
			this.constructorArgsText.TabIndex = 24;
			this.constructorArgsText.Text = "void";
			// 
			// ConstructorDefinition
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Controls.Add(this.constructorArgsText);
			this.Controls.Add(this.constructorStartLabel);
			this.Name = "ConstructorDefinition";
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
			this.Controls.SetChildIndex(this.constructorStartLabel, 0);
			this.Controls.SetChildIndex(this.constructorArgsText, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}


	public class ConstructorData : ItemHTMLData
	{
		public string Arguments = "";

		/// <summary>
		/// Creates a ConstructorData that just represents a list break.
		/// </summary>
		public ConstructorData() : base() { }
		/// <summary>
		/// Creates a constructor that isn't templated.
		/// </summary>
		public ConstructorData(string accessModifier, string constructorArgs, string anchorLinkName,
							   string constructorDesc, string codeSample)
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
		/// Creates a constructor that is templated.
		/// </summary>
		public ConstructorData(string templateArgs, string accessModifier, string constructorArgs,
							   string anchorLinkName, string constructorDesc, string codeSample)
		{
			IsListBreak = false;
			IsTemplated = true;

			TemplateArgs = templateArgs;
			AccessModifier = accessModifier;
			Arguments = constructorArgs;
			AnchorLinkName = anchorLinkName;
			ItemDesc = constructorDesc;
			CodeSample = codeSample;
		}
		public ConstructorData(string constructorArgs, ItemHTMLData baseCopy)
			: base(baseCopy)
		{
			Arguments = constructorArgs;
		}
		/// <summary>
		/// Creates a copy of the given constructor data.
		/// </summary>
		public ConstructorData(ConstructorData copy)
			: base(copy)
		{
			Arguments = copy.Arguments;
		}
	}
}
