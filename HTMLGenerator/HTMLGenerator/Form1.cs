using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
				else
				{
					itemlist.FindItemWithText(currentSelection).Text = defSetup.AhrefName.Text;
					toWrite.Remove(currentSelection);
					toWrite.Add(defSetup.AhrefName.Text, defSetup.GetData());
				}
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


		private string GetNewName(IEnumerable<string> currentKeys)
		{
			int n = 1;
			while (currentKeys.Contains("new" + n.ToString()))
				n += 1;
			return "new" + n.ToString();
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
		

		private void genHTMLButton_Click(object sender, EventArgs e)
		{
			//TODO: Implement.
		}
	}
}
