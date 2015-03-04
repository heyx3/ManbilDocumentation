using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


//Data definitions are indexed by their anchor link, which should always be unique.
using DefinitionDict = System.Collections.Generic.Dictionary<string, HTMLGenerator.ItemHTMLData>;


namespace HTMLGenerator
{
	public partial class MainForm : Form
	{
		//Data definitions are indexed by their anchor link, which should always be unique.
		public DefinitionDict memberFieldData = new DefinitionDict(),
							 staticFieldData = new DefinitionDict(),
							 constantData = new DefinitionDict(),
							 subtypeData = new DefinitionDict(),
							 constructorData = new DefinitionDict(),
							 memberFunctionData = new DefinitionDict(),
						     staticFunctionData = new DefinitionDict(),
						     operatorData = new DefinitionDict();

		private enum DefinitionTypes
		{
			MemberFields,
			StaticFields,
			MemberFunctions,
			StaticFunctions,
			Operators,
			Constants,
			Constructors,
			Subtypes,
		}
		private DefinitionTypes currentSelectedType;
		private string currentSelection = null;


		public MainForm()
		{
			InitializeComponent();

			docRootLabel.Text = docRootFolderBrowser.SelectedPath;
		}


		/// <summary>
		/// Writes the current selected item's data defintion to the proper dictionary.
		/// </summary>
		private void WriteSelection()
		{
			if (currentSelection != null)
			{
				DefinitionDict toWrite = null;
				ItemHTMLDefinition defSetup = null;
				ListView itemlist = null;
				switch (currentSelectedType)
				{
					case DefinitionTypes.MemberFields:
						toWrite = memberFieldData;
						defSetup = dataDefSetup;
						itemlist = memberFieldsList;
						break;
					case DefinitionTypes.StaticFields:
						toWrite = staticFieldData;
						defSetup = dataDefSetup;
						itemlist = staticFieldsList;
						break;
					case DefinitionTypes.MemberFunctions:
						toWrite = memberFunctionData;
						defSetup = functionDefSetup;
						itemlist = memberFunctionsList;
						break;
					case DefinitionTypes.StaticFunctions:
						toWrite = staticFunctionData;
						defSetup = functionDefSetup;
						itemlist = staticFunctionsList;
						break;
					case DefinitionTypes.Operators:
						toWrite = operatorData;
						defSetup = functionDefSetup;
						itemlist = operatorsList;
						break;
					case DefinitionTypes.Constants:
						toWrite = constantData;
						defSetup = dataDefSetup;
						itemlist = constantsList;
						break;
					case DefinitionTypes.Constructors:
						toWrite = constructorData;
						defSetup = constructorDefSetup;
						itemlist = constructorsList;
						break;
					case DefinitionTypes.Subtypes:
						toWrite = subtypeData;
						defSetup = dataDefSetup;
						itemlist = subtypesList;
						break;
				}

				if (currentSelection == defSetup.AhrefName.Text)
				{
					toWrite[currentSelection] = defSetup.GetData();
				}
				else if (!toWrite.ContainsKey(defSetup.AhrefName.Text))
				{
					itemlist.FindItemWithText(currentSelection).Text = defSetup.AhrefName.Text;
					toWrite.Remove(currentSelection);
					toWrite.Add(defSetup.AhrefName.Text, defSetup.GetData());
				}
				else
				{
					MessageBox.Show("The item '" + defSetup.AhrefName.Text +
									"' already exists. Reverting the current item's name to '" +
									currentSelection + "'...");
					defSetup.AhrefName.Text = currentSelection;
					toWrite[currentSelection] = defSetup.GetData();
				}

				currentSelection = null;
			}
		}
		private void SwitchTo(DefinitionTypes newType)
		{
			currentSelectedType = newType;
			switch (newType)
			{
				case DefinitionTypes.MemberFields:
				case DefinitionTypes.StaticFields:
				case DefinitionTypes.Subtypes:
				case DefinitionTypes.Constants:
					dataDefSetup.Enabled = true;
					dataDefSetup.Visible = true;
					functionDefSetup.Enabled = false;
					functionDefSetup.Visible = false;
					constructorDefSetup.Enabled = false;
					constructorDefSetup.Visible = false;
					break;
				case DefinitionTypes.Constructors:
					dataDefSetup.Enabled = false;
					dataDefSetup.Visible = false;
					functionDefSetup.Enabled = false;
					functionDefSetup.Visible = false;
					constructorDefSetup.Enabled = true;
					constructorDefSetup.Visible = true;
					break;
				case DefinitionTypes.MemberFunctions:
				case DefinitionTypes.StaticFunctions:
				case DefinitionTypes.Operators:
					dataDefSetup.Enabled = false;
					dataDefSetup.Visible = false;
					functionDefSetup.Enabled = true;
					functionDefSetup.Visible = true;
					constructorDefSetup.Enabled = false;
					constructorDefSetup.Visible = false;
					break;
			}
		}
		
		private string GetNewName(IEnumerable<string> currentKeys)
		{
			int n = 1;
			while (currentKeys.Contains("new" + n.ToString()))
				n += 1;
			return "new" + n.ToString();
		}


		private void chooseDocRootButton_Click(object sender, EventArgs e)
		{
			DialogResult res = docRootFolderBrowser.ShowDialog();
			if (res == System.Windows.Forms.DialogResult.OK)
				docRootLabel.Text = docRootFolderBrowser.SelectedPath;
		}

		private void memberFields_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (memberFieldsList.SelectedItems.Count == 0) return;

			WriteSelection();
			string name = memberFieldsList.SelectedItems[memberFieldsList.SelectedItems.Count - 1].Text;
			dataDefSetup.SetData(memberFieldData[name]);

			SwitchTo(DefinitionTypes.MemberFields);
			currentSelection = name;
		}
		private void memberFunctionsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (memberFunctionsList.SelectedItems.Count == 0) return;

			WriteSelection();
			string name = memberFunctionsList.SelectedItems[memberFunctionsList.SelectedItems.Count - 1].Text;
			functionDefSetup.SetData(memberFunctionData[name]);
			
			SwitchTo(DefinitionTypes.MemberFunctions);
			currentSelection = name;
		}
		private void operatorsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (operatorsList.SelectedItems.Count == 0) return;

			WriteSelection();
			string name = operatorsList.SelectedItems[operatorsList.SelectedItems.Count - 1].Text;
			functionDefSetup.SetData(operatorData[name]);

			SwitchTo(DefinitionTypes.Operators);
			currentSelection = name;
		}
		private void constructorsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (constructorsList.SelectedItems.Count == 0) return;

			WriteSelection();
			string name = constructorsList.SelectedItems[constructorsList.SelectedItems.Count - 1].Text;
			constructorDefSetup.SetData(constructorData[name]);

			SwitchTo(DefinitionTypes.Constructors);
			currentSelection = name;
		}
		private void staticFieldsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (staticFieldsList.SelectedItems.Count == 0) return;

			WriteSelection();
			string name = staticFieldsList.SelectedItems[staticFieldsList.SelectedItems.Count - 1].Text;
			dataDefSetup.SetData(staticFieldData[name]);

			SwitchTo(DefinitionTypes.StaticFields);
			currentSelection = name;
		}
		private void staticFunctionsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (staticFunctionsList.SelectedItems.Count == 0) return;

			WriteSelection();
			string name = staticFunctionsList.SelectedItems[staticFunctionsList.SelectedItems.Count - 1].Text;
			functionDefSetup.SetData(staticFunctionData[name]);

			SwitchTo(DefinitionTypes.StaticFunctions);
			currentSelection = name;
		}
		private void constantsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (constantsList.SelectedItems.Count == 0) return;

			WriteSelection();
			string name = constantsList.SelectedItems[constantsList.SelectedItems.Count - 1].Text;
			dataDefSetup.SetData(constantData[name]);

			SwitchTo(DefinitionTypes.Constants);
			currentSelection = name;
		}
		private void subtypesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (subtypesList.SelectedItems.Count == 0) return;

			WriteSelection();
			string name = subtypesList.SelectedItems[subtypesList.SelectedItems.Count - 1].Text;
			dataDefSetup.SetData(subtypeData[name]);

			SwitchTo(DefinitionTypes.Subtypes);
			currentSelection = name;
		}

		private void addMemberFieldButton_Click(object sender, EventArgs e)
		{
			string name = GetNewName(memberFieldData.Keys);

			memberFieldData.Add(name, new ItemHTMLData());
			memberFieldData[name].AnchorLinkName = name;
			
			memberFieldsList.Items.Add(new ListViewItem(new string[] { name }));
		}
		private void addMemberFunctionButton_Click(object sender, EventArgs e)
		{
			string name = GetNewName(memberFunctionData.Keys);

			memberFunctionData.Add(name, new FunctionData());
			memberFunctionData[name].AnchorLinkName = name;

			memberFunctionsList.Items.Add(new ListViewItem(new string[] { name }));
		}
		private void addOperatorButton_Click(object sender, EventArgs e)
		{
			string name = GetNewName(operatorData.Keys);

			operatorData.Add(name, new FunctionData());
			operatorData[name].AnchorLinkName = name;

			operatorsList.Items.Add(new ListViewItem(new string[] { name }));
		}
		private void addConstructorButton_Click(object sender, EventArgs e)
		{
			string name = GetNewName(constructorData.Keys);

			constructorData.Add(name, new ConstructorData());
			constructorData[name].AnchorLinkName = name;

			constructorsList.Items.Add(new ListViewItem(new string[] { name }));
		}
		private void addStaticFieldButton_Click(object sender, EventArgs e)
		{
			string name = GetNewName(staticFieldData.Keys);

			staticFieldData.Add(name, new ItemHTMLData());
			staticFieldData[name].AnchorLinkName = name;
			
			staticFieldsList.Items.Add(new ListViewItem(new string[] { name }));
		}
		private void addStaticFunctionButton_Click(object sender, EventArgs e)
		{
			string name = GetNewName(staticFunctionData.Keys);

			staticFunctionData.Add(name, new FunctionData());
			staticFunctionData[name].AnchorLinkName = name;

			staticFunctionsList.Items.Add(new ListViewItem(new string[] { name }));
		}
		private void addConstantButton_Click(object sender, EventArgs e)
		{
			string name = GetNewName(constantData.Keys);

			constantData.Add(name, new ItemHTMLData());
			constantData[name].AnchorLinkName = name;
			
			constantsList.Items.Add(new ListViewItem(new string[] { name }));
		}
		private void addSubtypeButton_Click(object sender, EventArgs e)
		{
			string name = GetNewName(subtypeData.Keys);

			subtypeData.Add(name, new ItemHTMLData());
			subtypeData[name].AnchorLinkName = name;
			
			subtypesList.Items.Add(new ListViewItem(new string[] { name }));
		}


		private void classNameText_TextChanged(object sender, EventArgs e)
		{
			htmlFileLocationText.Text = systemNameText.Text + "/" + classNameText.Text;
		}

		private void systemNameText_TextChanged(object sender, EventArgs e)
		{
			htmlFileLocationText.Text = systemNameText.Text + "/" + classNameText.Text;
			systemHTMLText.Text = systemNameText.Text + ".html";
		}
		

		private void AddDefinitionList(DefinitionDict items, ItemHTMLDefinition defSetup,
									   string headerName, StringBuilder sb, int nTabs = 2)
		{
			StringGenerators.AddTabs(nTabs, sb);
			sb.Append("<h2>");
			sb.Append(headerName);
			sb.AppendLine("</h2>");

			if (items.Count == 0)
			{
				StringGenerators.AddTabs(nTabs, sb);
				sb.AppendLine("<p>None.</p>");
			}
			else
			{
				StringGenerators.AddTabs(nTabs, sb);
				sb.AppendLine("<ul class=\"DeclarationList\">");

					foreach (ItemHTMLData dat in items.Values)
					{
						defSetup.SetData(dat);
						defSetup.AddElement(classNameText.Text, nTabs + 1, sb);
					}

				StringGenerators.AddTabs(nTabs, sb);
				sb.AppendLine("</ul>");
			}
		}
		private void AddSectionDivider(int nTabs, StringBuilder sb)
		{
			sb.AppendLine();
			StringGenerators.AddTabs(nTabs, sb);
			sb.AppendLine("<br class=\"SectionDivider\" />");
			sb.AppendLine();
		}
		private void genHTMLButton_Click(object sender, EventArgs e)
		{
			//See if another file is going to be overwritten.
			string path = Path.Combine(docRootLabel.Text, htmlFileLocationText.Text) + ".html";
			if (File.Exists(path))
			{
				ConfirmOverwriteForm dlg = new ConfirmOverwriteForm();
				if (dlg.ShowDialog() != DialogResult.OK)
					return;
			}


			//Save the currently-selected data.
			if (currentSelection != null)
				WriteSelection();


			//Generate the file.
			StringBuilder sb = new StringBuilder("<!DOCTYPE HTML>");
			sb.AppendLine();
			sb.AppendLine("<html>");

				sb.AppendLine();
				sb.AppendLine("\t<head>");

					sb.Append("\t\t<title>Class: ");
					sb.Append(classNameText.Text);
					sb.AppendLine("</title>");

					sb.AppendLine("\t\t<link type=\"text/cs\" rel=\"stylesheet\" href=\"../MainCSS.css\" />");
					sb.AppendLine("\t\t<script src=\"../google-code-prettify/run_prettify.js\"></script>");

				sb.AppendLine("\t</head>");

				sb.AppendLine();
				sb.AppendLine("\t<body>");

					if (TODOTextbox.Text.Length > 0)
					{
						sb.AppendLine();
						sb.AppendLine("\t\t<TODO><ul>");
							sb.Append("\t\t\t<li>");
								StringBuilder toRepl = new StringBuilder(TODOTextbox.Text);
								StringGenerators.ReplaceLineBreaks(toRepl, "</li>" +
																		   System.Environment.NewLine +
																		   "\t\t\t<li>");
							sb.Append(toRepl.ToString());
							sb.AppendLine("</li>");

						sb.AppendLine("\t\t</ul></TODO>");

						AddSectionDivider(2, sb);
					}

					sb.AppendLine();
					sb.Append("\t\t<h1>");
					sb.Append(classNameText.Text);
					sb.AppendLine("</h1>");

					sb.Append("\t\t<p>");
					sb.Append(classSummaryText.Text);
					sb.AppendLine("</p>");

					AddSectionDivider(2, sb);

					sb.AppendLine("\t\t<h2>Metadata</h2>");
					sb.Append("\t\t<p>Located in \"");
					sb.Append(hFileLocationText.Text);
					sb.Append("\". ");
					if (hasCppFileCheck.Checked)
						sb.Append("Has a .cpp file in the same location.");
					else
						sb.Append("Does not have a .cpp file.");
					sb.Append(" Part of the <a href=\"../");
					sb.Append(systemHTMLText.Text);
					sb.Append("\">");
					sb.Append(systemNameText.Text);
					sb.AppendLine("</a> system.</p>");

					AddSectionDivider(2, sb);

					sb.AppendLine("\t\t<h2>Declaration</h2>");
					sb.Append("\t\t<code class=\"CodeDecl prettyprint\">");
						if (isTemplatedBox.Checked)
						{
							sb.AppendLine();

							sb.Append("\t\t\ttemplate&lt;");
							sb.Append(templateArgsText.Text);
							sb.AppendLine("&gt; <br />");

							sb.Append("\t\t\tclass ");
							sb.Append(classNameText.Text);
							sb.AppendLine(";");

							sb.Append("\t\t");
						}
						else
						{
							sb.Append("class ");
							sb.Append(classNameText.Text);
							sb.Append(';');
						}
					sb.AppendLine("</code>");
					sb.AppendLine("\t\t<p />");

					AddSectionDivider(2, sb);

					AddDefinitionList(subtypeData, dataDefSetup, "Sub-types", sb, 2);

					AddSectionDivider(2, sb);

					AddDefinitionList(constantData, dataDefSetup, "Constants", sb, 2);

					AddSectionDivider(2, sb);

					AddDefinitionList(staticFieldData, dataDefSetup, "Static Fields", sb, 2);

					AddSectionDivider(2, sb);

					AddDefinitionList(memberFieldData, dataDefSetup, "Member Fields", sb, 2);

					AddSectionDivider(2, sb);

					AddDefinitionList(operatorData, functionDefSetup, "Operators", sb, 2);

					AddSectionDivider(2, sb);

					AddDefinitionList(staticFunctionData, functionDefSetup, "Static Functions", sb, 2);

					AddSectionDivider(2, sb);

					AddDefinitionList(constructorData, constructorDefSetup, "Constructors", sb, 2);

					AddSectionDivider(2, sb);

					AddDefinitionList(memberFunctionData, functionDefSetup, "Member Functions", sb, 2);

					AddSectionDivider(2, sb);

					sb.AppendLine("\t\t<div class=\"TextSection\">");

						sb.AppendLine("\t\t\t<h2>Usage</h2>");
					
						if (classDescText.Text.Length == 0 && codeSampleText.Text.Length == 0)
						{
							StringGenerators.AddTabs(2, sb);
							sb.AppendLine("\t\t\t<h1 style: \"color: red\">ERROR NEEDS 'USAGE' TEXT</h1>");
						}
						else
						{
							if (classDescText.Text.Length > 0)
							{
								sb.AppendLine("\t\t\t<ul>");
									sb.Append("\t\t\t\t<li>");
										StringBuilder classDesc = new StringBuilder(classDescText.Text);
										StringGenerators.ReplaceLineBreaks(classDesc,
																		   "</li>" +
																			System.Environment.NewLine +
																			"\t\t\t\t<li>");
										sb.Append(classDesc.ToString());
									sb.AppendLine("</li>");
								sb.AppendLine("\t\t\t</ul>");
							}
							if (codeSampleText.Text.Length > 0)
							{
								StringGenerators.AddCodeSampleElement(3, false, codeSampleText.Text, sb);
							}
						}

					sb.AppendLine("\t\t</div>");

				sb.AppendLine("\t\t</body>");

			sb.Append("</html>");


			//Write the file.
			try
			{
				File.WriteAllText(path, sb.ToString());
			}
			catch (Exception exc)
			{
				FileErrorPopup dlg = new FileErrorPopup();
				dlg.ErrorTypeLabel.Text = exc.GetType().ToString();
				dlg.ErrorMessageLabel.Text = exc.Message;
				dlg.ShowDialog();
			}
		}

		private void isTemplatedBox_CheckedChanged(object sender, EventArgs e)
		{
			templateArgsText.Enabled = isTemplatedBox.Checked;
		}
	}
}
