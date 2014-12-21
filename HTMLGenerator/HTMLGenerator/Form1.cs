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
using MemberDefDict = System.Collections.Generic.Dictionary<string, HTMLGenerator.ItemHTMLData>;


namespace HTMLGenerator
{
	public partial class MainForm : Form
	{
		//Data definitions are indexed by their anchor link, which should always be unique.
		public MemberDefDict memberFieldData = new MemberDefDict(),
							 staticFieldData = new MemberDefDict(),
							 constantData = new MemberDefDict(),
							 subtypeData = new MemberDefDict();

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
				switch (currentSelectedType)
				{
					case DefinitionTypes.MemberFields:
						if (currentSelection == definitionSetup.AhrefName.Text)
						{
							memberFieldData[currentSelection] = definitionSetup.GetData();
						}
						else
						{
							memberFieldData.Remove(currentSelection);
							memberFieldData.Add(definitionSetup.AhrefName.Text, definitionSetup.GetData());
						}
						break;
					case DefinitionTypes.StaticFields:
						if (currentSelection == definitionSetup.AhrefName.Text)
						{
							staticFieldData[currentSelection] = definitionSetup.GetData();
						}
						else
						{
							staticFieldData.Remove(currentSelection);
							staticFieldData.Add(definitionSetup.AhrefName.Text, definitionSetup.GetData());
						}
						break;
					case DefinitionTypes.MemberFunctions:

						break;
					case DefinitionTypes.StaticFunctions:

						break;
					case DefinitionTypes.Operators:

						break;
					case DefinitionTypes.Constants:
						if (currentSelection == definitionSetup.AhrefName.Text)
						{
							constantData[currentSelection] = definitionSetup.GetData();
						}
						else
						{
							constantData.Remove(currentSelection);
							constantData.Add(definitionSetup.AhrefName.Text, definitionSetup.GetData());
						}
						break;
					case DefinitionTypes.Constructors:

						break;
					case DefinitionTypes.Subtypes:
						if (currentSelection == definitionSetup.AhrefName.Text)
						{
							subtypeData[currentSelection] = definitionSetup.GetData();
						}
						else
						{
							subtypeData.Remove(currentSelection);
							subtypeData.Add(definitionSetup.AhrefName.Text, definitionSetup.GetData());
						}
						break;
				}
			}
		}


		private void memberFields_SelectedIndexChanged(object sender, EventArgs e)
		{
			WriteSelection();
			string name = memberFieldsList.SelectedItems[memberFieldsList.SelectedItems.Count - 1].Text;
			definitionSetup = new MemberFieldDefinition(memberFieldData[name]);

			currentSelectedType = DefinitionTypes.MemberFields;
			currentSelection = memberFieldsList.SelectedItems[memberFieldsList.SelectedItems.Count - 1].Text;
		}
		private void memberFunctionsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			WriteSelection();
			string name = memberFunctionsList.SelectedItems[memberFunctionsList.SelectedItems.Count - 1].Text;
			definitionSetup = new ();

			currentSelectedType = DefinitionTypes.MemberFunctions;
			currentSelection = memberFunctionsList.SelectedItems[memberFunctionsList.SelectedItems.Count - 1].Text;
		}
		private void operatorsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			WriteSelection();
			string name = operatorsList.SelectedItems[operatorsList.SelectedItems.Count - 1].Text;
			definitionSetup = new ();

			currentSelectedType = DefinitionTypes.Operators;
			currentSelection = operatorsList.SelectedItems[operatorsList.SelectedItems.Count - 1].Text;
		}
		private void constructorsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			WriteSelection();
			string name = constructorsList.SelectedItems[constructorsList.SelectedItems.Count - 1].Text;
			definitionSetup = new ();

			currentSelectedType = DefinitionTypes.Constructors;
			currentSelection = constructorsList.SelectedItems[constructorsList.SelectedItems.Count - 1].Text;
		}
		private void staticFieldsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			WriteSelection();
			string name = staticFieldsList.SelectedItems[staticFieldsList.SelectedItems.Count - 1].Text;
			definitionSetup = new MemberFieldDefinition(staticFieldData[name]);

			currentSelectedType = DefinitionTypes.StaticFields;
			currentSelection = staticFieldsList.SelectedItems[staticFieldsList.SelectedItems.Count - 1].Text;
		}
		private void staticFunctionsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			WriteSelection();
			string name = staticFunctionsList.SelectedItems[staticFunctionsList.SelectedItems.Count - 1].Text;
			definitionSetup = ()

			currentSelectedType = DefinitionTypes.StaticFunctions;
			currentSelection = staticFunctionsList.SelectedItems[staticFunctionsList.SelectedItems.Count - 1].Text;
		}
		private void constantsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			WriteSelection();
			string name = constantsList.SelectedItems[constantsList.SelectedItems.Count - 1].Text;
			definitionSetup = new MemberFieldDefinition(constantData[name]);

			currentSelectedType = DefinitionTypes.Constants;
			currentSelection = constantsList.SelectedItems[constantsList.SelectedItems.Count - 1].Text;
		}
		private void subtypesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			WriteSelection();
			string name = subtypesList.SelectedItems[subtypesList.SelectedItems.Count - 1].Text;
			definitionSetup = new MemberFieldDefinition(subtypeData[name]);

			currentSelectedType = DefinitionTypes.Subtypes;
			currentSelection = subtypesList.SelectedItems[subtypesList.SelectedItems.Count - 1].Text;
		}


		private void addMemberFieldButton_Click(object sender, EventArgs e)
		{

		}
		private void addMemberFunctionButton_Click(object sender, EventArgs e)
		{

		}
		private void addOperatorButton_Click(object sender, EventArgs e)
		{

		}
		private void addConstructorButton_Click(object sender, EventArgs e)
		{

		}
		private void addStaticFieldButton_Click(object sender, EventArgs e)
		{

		}
		private void addStaticFunctionButton_Click(object sender, EventArgs e)
		{

		}
		private void addConstantButton_Click(object sender, EventArgs e)
		{

		}
		private void addSubtypeButton_Click(object sender, EventArgs e)
		{

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

		}
	}
}
