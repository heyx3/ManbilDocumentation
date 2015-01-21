using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StrGen = StringGenerators;

namespace HTMLGenerator
{
	public partial class ItemHTMLDefinition : UserControl
	{
		/// <summary>
		/// Creates an item that just represents a break in the declaration list.
		/// </summary>
		public ItemHTMLDefinition()
		{
			InitializeComponent();

			IsTemplatedBox.CheckedChanged += (s, e) =>
				{
					SetEnabledControl(TemplateArgsText, IsTemplatedBox.Checked);
				};
			IsTemplatedBox.EnabledChanged += (s, e) =>
				{
					SetEnabledControl(TemplateArgsText, (IsTemplatedBox.Checked && IsTemplatedBox.Enabled));
				};

			isBreakBox.CheckedChanged += (s, e) =>
				{
					bool enableOthers = !isBreakBox.Checked;
			
					SetEnabledControl(IsTemplatedBox, enableOthers);
					SetEnabledControl(AccessModifierDropdown, enableOthers);
					SetEnabledControl(ItemTypeText, enableOthers);
					SetEnabledControl(ItemNameText, enableOthers);
					SetEnabledControl(AhrefName, enableOthers);
					SetEnabledControl(ItemDescText, enableOthers);
					SetEnabledControl(CodeSampleText, enableOthers);
				};
			

			isBreakBox.Checked = true;
		}
		/// <summary>
		/// Creates an item with no template arguments.
		/// </summary>
		public ItemHTMLDefinition(string accessModifier, string itemType, string itemName,
								  string anchorLinkName, string itemDesc, string codeSample)
			: this()
		{
			isBreakBox.Checked = false;

			IsTemplatedBox.Checked = false;
			AccessModifierDropdown.SelectedItem = accessModifier;
			ItemTypeText.Text = itemType;
			ItemNameText.Text = itemName;
			AhrefName.Text = anchorLinkName;
			ItemDescText.Text = itemDesc;
			CodeSampleText.Text = codeSample;
		}
		/// <summary>
		/// Creates an item with template arguments.
		/// </summary>
		public ItemHTMLDefinition(string templateArgs,
								  string accessModifier, string itemType, string itemName,
								  string anchorLinkName, string itemDesc, string codeSample)
			: this(accessModifier, itemType, itemName, anchorLinkName, itemDesc, codeSample)
		{
			IsTemplatedBox.Checked = true;
			TemplateArgsText.Text = templateArgs;
		}
		/// <summary>
		/// Creates an item with the given data.
		/// </summary>
		public ItemHTMLDefinition(ItemHTMLData data) : this() { SetData(data); }


		/// <summary>
		/// Adds the HTML element for this item definition to the end of the given string.
		/// </summary>
		/// <param name="tabLevel">The base tab level of this element.</param>
		public void AddElement(string className, int tabLevel, StringBuilder sbOut)
		{
			if (isBreakBox.Checked)
			{
				StrGen.AddTabs(tabLevel - 1, sbOut);
				sbOut.AppendLine("</ul>");
				StrGen.AddTabs(tabLevel - 1, sbOut);
				sbOut.AppendLine("<ul class=\"DeclarationList\">");

				return;
			}


			StrGen.AddTabs(tabLevel, sbOut);
			sbOut.AppendLine("<li>");
			
				StrGen.AddTabs(tabLevel + 1, sbOut);
				sbOut.Append("<a name=\"");
				sbOut.Append(AhrefName.Text);
				sbOut.AppendLine("\" />");

				StrGen.AddTabs(tabLevel + 1, sbOut);
				sbOut.Append("<code class=\"CodeDecl prettyprint\">");

					StringBuilder baseDecl = new StringBuilder("");
					AddDefinition(className, baseDecl);
					StrGen.ReplaceSpecialChars(baseDecl);

					if (IsTemplatedBox.Checked)
					{
						sbOut.AppendLine();
						StrGen.AddTabs(tabLevel + 2, sbOut);
						sbOut.Append("template&lt;");
						sbOut.Append(TemplateArgsText.Text);
						sbOut.AppendLine("&gt; <br />");

						StrGen.AddTabs(tabLevel + 2, sbOut);
						sbOut.Append(baseDecl.ToString());
						sbOut.AppendLine(";");
						StrGen.AddTabs(tabLevel + 1, sbOut);
						sbOut.AppendLine("</code>");
					}
					else
					{
						sbOut.Append(baseDecl.ToString());
						sbOut.AppendLine(";</code>");
					}

				StrGen.AddTabs(tabLevel + 1, sbOut);
				sbOut.AppendLine("<ul>");

					StrGen.AddTabs(tabLevel + 2, sbOut);
					sbOut.Append("<li>");

						StringBuilder replacement = new StringBuilder("</li>");
						replacement.AppendLine();
						StrGen.AddTabs(tabLevel + 2, replacement);
						replacement.Append("<li>");

						StringBuilder replaced = new StringBuilder(ItemDescText.Text);
						StrGen.ReplaceLineBreaks(replaced, replacement.ToString());
						sbOut.Append(replaced.ToString());

					sbOut.AppendLine("</li>");

					if (CodeSampleText.Text.Trim().Length > 0)
						StrGen.AddCodeSampleElement(tabLevel + 2, true, CodeSampleText.Text, sbOut);

				StrGen.AddTabs(tabLevel + 1, sbOut);
				sbOut.AppendLine("</ul>");

			StrGen.AddTabs(tabLevel, sbOut);
			sbOut.AppendLine("</li>");
		}


		/// <summary>
		/// Sets this control to have the given data.
		/// Any child classes that override this must call base.SetData()!
		/// </summary>
		public virtual void SetData(ItemHTMLData data)
		{
			TemplateArgsText.Text = data.TemplateArgs;
			AccessModifierDropdown.SelectedItem = data.AccessModifier;
			ItemTypeText.Text = data.ItemType;
			ItemNameText.Text = data.ItemName;
			AhrefName.Text = data.AnchorLinkName;
			ItemDescText.Text = data.ItemDesc;
			CodeSampleText.Text = data.CodeSample;

			IsTemplatedBox.Checked = data.IsTemplated;

			isBreakBox.Checked = data.IsListBreak;
		}
		/// <summary>
		/// Gets this control's data.
		/// Any child classes that override this should use the return value of this base implementation.
		/// </summary>
		public virtual ItemHTMLData GetData()
		{
			ItemHTMLData dat = new ItemHTMLData();
			
			dat.TemplateArgs = TemplateArgsText.Text;
			dat.AccessModifier = AccessModifierDropdown.Text;
			dat.ItemType = ItemTypeText.Text;
			dat.ItemName = ItemNameText.Text;
			dat.AnchorLinkName = AhrefName.Text;
			dat.ItemDesc = ItemDescText.Text;
			dat.CodeSample = CodeSampleText.Text;
			dat.IsTemplated = IsTemplatedBox.Checked;
			dat.IsListBreak = isBreakBox.Checked;
			
			return dat;
		}


		/// <summary>
		/// This function MUST be overridden to add behavior!
		/// It can't be abstract because the WinForms designer can't handle abstract base controls.
		/// Adds the code definition of this item to the end of the given string.
		/// The definition should NOT include the beginning "template<>" declaration if one is necessary.
		/// It should also NOT include the semicolon at the end of the definition.
		/// </summary>
		protected virtual void AddDefinition(string className, StringBuilder sbOut) { throw new NotImplementedException(); }

		private void ItemNameText_TextChanged(object sender, EventArgs e)
		{
			AhrefName.Text = ItemNameText.Text;
		}

		protected void SetEnabledControl(Control contr, bool enabled)
		{
			if (enabled)
			{
				//contr.ForeColor = SystemColors.Control;
				contr.Enabled = true;
			}
			else
			{
				//contr.ForeColor = SystemColors.ControlDark;
				contr.Enabled = false;
			}
		}
	}
	

	public class ItemHTMLData
	{
		public bool IsListBreak = true,
					IsTemplated = false;
		public string TemplateArgs = "",
				      AccessModifier = "",
					  ItemType = "",
					  ItemName = "",
					  AnchorLinkName = "",
					  ItemDesc = "",
					  CodeSample = "";

		public ItemHTMLData() { }
		public ItemHTMLData(ItemHTMLData copy)
		{
			IsListBreak = copy.IsListBreak;
			IsTemplated = copy.IsTemplated;
			TemplateArgs = copy.TemplateArgs;
			AccessModifier = copy.AccessModifier;
			ItemType = copy.ItemType;
			ItemName = copy.ItemName;
			AnchorLinkName = copy.AnchorLinkName;
			ItemDesc = copy.ItemDesc;
			CodeSample = copy.CodeSample;
		}
	}
}
