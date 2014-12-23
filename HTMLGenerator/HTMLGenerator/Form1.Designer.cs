namespace HTMLGenerator
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
			this.definitionsPanel = new System.Windows.Forms.Panel();
			this.addSubtypeButton = new System.Windows.Forms.Button();
			this.addConstantButton = new System.Windows.Forms.Button();
			this.addStaticFunctionButton = new System.Windows.Forms.Button();
			this.addStaticFieldButton = new System.Windows.Forms.Button();
			this.addConstructorButton = new System.Windows.Forms.Button();
			this.addOperatorButton = new System.Windows.Forms.Button();
			this.addMemberFunctionButton = new System.Windows.Forms.Button();
			this.addMemberFieldButton = new System.Windows.Forms.Button();
			this.subtypesLabel = new System.Windows.Forms.Label();
			this.subtypesList = new System.Windows.Forms.ListView();
			this.constantsLabel = new System.Windows.Forms.Label();
			this.constantsList = new System.Windows.Forms.ListView();
			this.staticFunctionsLabel = new System.Windows.Forms.Label();
			this.staticFunctionsList = new System.Windows.Forms.ListView();
			this.staticFieldsLabel = new System.Windows.Forms.Label();
			this.staticFieldsList = new System.Windows.Forms.ListView();
			this.constructorsLabel = new System.Windows.Forms.Label();
			this.constructorsList = new System.Windows.Forms.ListView();
			this.operatorsLabel = new System.Windows.Forms.Label();
			this.operatorsList = new System.Windows.Forms.ListView();
			this.memberFunctionsLabel = new System.Windows.Forms.Label();
			this.memberFunctionsList = new System.Windows.Forms.ListView();
			this.memberFieldsLabel = new System.Windows.Forms.Label();
			this.memberFieldsList = new System.Windows.Forms.ListView();
			this.TODOTextbox = new System.Windows.Forms.TextBox();
			this.todoLabel = new System.Windows.Forms.Label();
			this.genHTMLButton = new System.Windows.Forms.Button();
			this.htmlFileLocationText = new System.Windows.Forms.TextBox();
			this.classNameLabel = new System.Windows.Forms.Label();
			this.classNameText = new System.Windows.Forms.TextBox();
			this.hFileLocationLabel = new System.Windows.Forms.Label();
			this.hFileLocationText = new System.Windows.Forms.TextBox();
			this.hasCppFileCheck = new System.Windows.Forms.CheckBox();
			this.systemHTMLText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.systemNameText = new System.Windows.Forms.TextBox();
			this.systemNameLabel = new System.Windows.Forms.Label();
			this.classDescText = new System.Windows.Forms.RichTextBox();
			this.codeSampleText = new System.Windows.Forms.RichTextBox();
			this.classSummaryLabel = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.constructorDefSetup = new HTMLGenerator.ConstructorDefinition();
			this.functionDefSetup = new HTMLGenerator.FunctionDefinition();
			this.dataDefSetup = new HTMLGenerator.DataDefinition();
			this.chooseDocRootButton = new System.Windows.Forms.Button();
			this.docRootFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
			this.docRootLabel = new System.Windows.Forms.Label();
			this.definitionsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// definitionsPanel
			// 
			this.definitionsPanel.Controls.Add(this.constructorDefSetup);
			this.definitionsPanel.Controls.Add(this.functionDefSetup);
			this.definitionsPanel.Controls.Add(this.addSubtypeButton);
			this.definitionsPanel.Controls.Add(this.addConstantButton);
			this.definitionsPanel.Controls.Add(this.addStaticFunctionButton);
			this.definitionsPanel.Controls.Add(this.addStaticFieldButton);
			this.definitionsPanel.Controls.Add(this.addConstructorButton);
			this.definitionsPanel.Controls.Add(this.addOperatorButton);
			this.definitionsPanel.Controls.Add(this.addMemberFunctionButton);
			this.definitionsPanel.Controls.Add(this.addMemberFieldButton);
			this.definitionsPanel.Controls.Add(this.subtypesLabel);
			this.definitionsPanel.Controls.Add(this.subtypesList);
			this.definitionsPanel.Controls.Add(this.constantsLabel);
			this.definitionsPanel.Controls.Add(this.constantsList);
			this.definitionsPanel.Controls.Add(this.staticFunctionsLabel);
			this.definitionsPanel.Controls.Add(this.staticFunctionsList);
			this.definitionsPanel.Controls.Add(this.staticFieldsLabel);
			this.definitionsPanel.Controls.Add(this.staticFieldsList);
			this.definitionsPanel.Controls.Add(this.constructorsLabel);
			this.definitionsPanel.Controls.Add(this.constructorsList);
			this.definitionsPanel.Controls.Add(this.operatorsLabel);
			this.definitionsPanel.Controls.Add(this.operatorsList);
			this.definitionsPanel.Controls.Add(this.memberFunctionsLabel);
			this.definitionsPanel.Controls.Add(this.memberFunctionsList);
			this.definitionsPanel.Controls.Add(this.memberFieldsLabel);
			this.definitionsPanel.Controls.Add(this.memberFieldsList);
			this.definitionsPanel.Controls.Add(this.dataDefSetup);
			this.definitionsPanel.Location = new System.Drawing.Point(332, 189);
			this.definitionsPanel.Name = "definitionsPanel";
			this.definitionsPanel.Size = new System.Drawing.Size(828, 563);
			this.definitionsPanel.TabIndex = 5;
			// 
			// addSubtypeButton
			// 
			this.addSubtypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addSubtypeButton.Location = new System.Drawing.Point(331, 416);
			this.addSubtypeButton.Name = "addSubtypeButton";
			this.addSubtypeButton.Size = new System.Drawing.Size(31, 24);
			this.addSubtypeButton.TabIndex = 26;
			this.addSubtypeButton.Text = "+";
			this.addSubtypeButton.UseVisualStyleBackColor = true;
			this.addSubtypeButton.Click += new System.EventHandler(this.addSubtypeButton_Click);
			// 
			// addConstantButton
			// 
			this.addConstantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addConstantButton.Location = new System.Drawing.Point(331, 275);
			this.addConstantButton.Name = "addConstantButton";
			this.addConstantButton.Size = new System.Drawing.Size(31, 24);
			this.addConstantButton.TabIndex = 25;
			this.addConstantButton.Text = "+";
			this.addConstantButton.UseVisualStyleBackColor = true;
			this.addConstantButton.Click += new System.EventHandler(this.addConstantButton_Click);
			// 
			// addStaticFunctionButton
			// 
			this.addStaticFunctionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addStaticFunctionButton.Location = new System.Drawing.Point(331, 132);
			this.addStaticFunctionButton.Name = "addStaticFunctionButton";
			this.addStaticFunctionButton.Size = new System.Drawing.Size(31, 24);
			this.addStaticFunctionButton.TabIndex = 24;
			this.addStaticFunctionButton.Text = "+";
			this.addStaticFunctionButton.UseVisualStyleBackColor = true;
			this.addStaticFunctionButton.Click += new System.EventHandler(this.addStaticFunctionButton_Click);
			// 
			// addStaticFieldButton
			// 
			this.addStaticFieldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addStaticFieldButton.Location = new System.Drawing.Point(331, 3);
			this.addStaticFieldButton.Name = "addStaticFieldButton";
			this.addStaticFieldButton.Size = new System.Drawing.Size(31, 24);
			this.addStaticFieldButton.TabIndex = 23;
			this.addStaticFieldButton.Text = "+";
			this.addStaticFieldButton.UseVisualStyleBackColor = true;
			this.addStaticFieldButton.Click += new System.EventHandler(this.addStaticFieldButton_Click);
			// 
			// addConstructorButton
			// 
			this.addConstructorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addConstructorButton.Location = new System.Drawing.Point(143, 417);
			this.addConstructorButton.Name = "addConstructorButton";
			this.addConstructorButton.Size = new System.Drawing.Size(31, 24);
			this.addConstructorButton.TabIndex = 22;
			this.addConstructorButton.Text = "+";
			this.addConstructorButton.UseVisualStyleBackColor = true;
			this.addConstructorButton.Click += new System.EventHandler(this.addConstructorButton_Click);
			// 
			// addOperatorButton
			// 
			this.addOperatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addOperatorButton.Location = new System.Drawing.Point(143, 276);
			this.addOperatorButton.Name = "addOperatorButton";
			this.addOperatorButton.Size = new System.Drawing.Size(31, 24);
			this.addOperatorButton.TabIndex = 21;
			this.addOperatorButton.Text = "+";
			this.addOperatorButton.UseVisualStyleBackColor = true;
			this.addOperatorButton.Click += new System.EventHandler(this.addOperatorButton_Click);
			// 
			// addMemberFunctionButton
			// 
			this.addMemberFunctionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addMemberFunctionButton.Location = new System.Drawing.Point(143, 133);
			this.addMemberFunctionButton.Name = "addMemberFunctionButton";
			this.addMemberFunctionButton.Size = new System.Drawing.Size(31, 24);
			this.addMemberFunctionButton.TabIndex = 20;
			this.addMemberFunctionButton.Text = "+";
			this.addMemberFunctionButton.UseVisualStyleBackColor = true;
			this.addMemberFunctionButton.Click += new System.EventHandler(this.addMemberFunctionButton_Click);
			// 
			// addMemberFieldButton
			// 
			this.addMemberFieldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addMemberFieldButton.Location = new System.Drawing.Point(143, 4);
			this.addMemberFieldButton.Name = "addMemberFieldButton";
			this.addMemberFieldButton.Size = new System.Drawing.Size(31, 24);
			this.addMemberFieldButton.TabIndex = 19;
			this.addMemberFieldButton.Text = "+";
			this.addMemberFieldButton.UseVisualStyleBackColor = true;
			this.addMemberFieldButton.Click += new System.EventHandler(this.addMemberFieldButton_Click);
			// 
			// subtypesLabel
			// 
			this.subtypesLabel.AutoSize = true;
			this.subtypesLabel.Location = new System.Drawing.Point(198, 428);
			this.subtypesLabel.Name = "subtypesLabel";
			this.subtypesLabel.Size = new System.Drawing.Size(51, 13);
			this.subtypesLabel.TabIndex = 17;
			this.subtypesLabel.Text = "Subtypes";
			// 
			// subtypesList
			// 
			this.subtypesList.Location = new System.Drawing.Point(195, 446);
			this.subtypesList.Name = "subtypesList";
			this.subtypesList.Size = new System.Drawing.Size(170, 110);
			this.subtypesList.TabIndex = 16;
			this.subtypesList.UseCompatibleStateImageBehavior = false;
			this.subtypesList.SelectedIndexChanged += new System.EventHandler(this.subtypesList_SelectedIndexChanged);
			// 
			// constantsLabel
			// 
			this.constantsLabel.AutoSize = true;
			this.constantsLabel.Location = new System.Drawing.Point(196, 287);
			this.constantsLabel.Name = "constantsLabel";
			this.constantsLabel.Size = new System.Drawing.Size(54, 13);
			this.constantsLabel.TabIndex = 15;
			this.constantsLabel.Text = "Constants";
			// 
			// constantsList
			// 
			this.constantsList.Location = new System.Drawing.Point(197, 303);
			this.constantsList.Name = "constantsList";
			this.constantsList.Size = new System.Drawing.Size(170, 110);
			this.constantsList.TabIndex = 14;
			this.constantsList.UseCompatibleStateImageBehavior = false;
			this.constantsList.SelectedIndexChanged += new System.EventHandler(this.constantsList_SelectedIndexChanged);
			// 
			// staticFunctionsLabel
			// 
			this.staticFunctionsLabel.AutoSize = true;
			this.staticFunctionsLabel.Location = new System.Drawing.Point(194, 144);
			this.staticFunctionsLabel.Name = "staticFunctionsLabel";
			this.staticFunctionsLabel.Size = new System.Drawing.Size(83, 13);
			this.staticFunctionsLabel.TabIndex = 13;
			this.staticFunctionsLabel.Text = "Static Functions";
			// 
			// staticFunctionsList
			// 
			this.staticFunctionsList.Location = new System.Drawing.Point(197, 160);
			this.staticFunctionsList.Name = "staticFunctionsList";
			this.staticFunctionsList.Size = new System.Drawing.Size(170, 110);
			this.staticFunctionsList.TabIndex = 12;
			this.staticFunctionsList.UseCompatibleStateImageBehavior = false;
			this.staticFunctionsList.SelectedIndexChanged += new System.EventHandler(this.staticFunctionsList_SelectedIndexChanged);
			// 
			// staticFieldsLabel
			// 
			this.staticFieldsLabel.AutoSize = true;
			this.staticFieldsLabel.Location = new System.Drawing.Point(194, 10);
			this.staticFieldsLabel.Name = "staticFieldsLabel";
			this.staticFieldsLabel.Size = new System.Drawing.Size(64, 13);
			this.staticFieldsLabel.TabIndex = 11;
			this.staticFieldsLabel.Text = "Static Fields";
			// 
			// staticFieldsList
			// 
			this.staticFieldsList.Location = new System.Drawing.Point(195, 29);
			this.staticFieldsList.Name = "staticFieldsList";
			this.staticFieldsList.Size = new System.Drawing.Size(170, 102);
			this.staticFieldsList.TabIndex = 10;
			this.staticFieldsList.UseCompatibleStateImageBehavior = false;
			this.staticFieldsList.SelectedIndexChanged += new System.EventHandler(this.staticFieldsList_SelectedIndexChanged);
			// 
			// constructorsLabel
			// 
			this.constructorsLabel.AutoSize = true;
			this.constructorsLabel.Location = new System.Drawing.Point(7, 428);
			this.constructorsLabel.Name = "constructorsLabel";
			this.constructorsLabel.Size = new System.Drawing.Size(66, 13);
			this.constructorsLabel.TabIndex = 9;
			this.constructorsLabel.Text = "Constructors";
			// 
			// constructorsList
			// 
			this.constructorsList.Location = new System.Drawing.Point(4, 446);
			this.constructorsList.Name = "constructorsList";
			this.constructorsList.Size = new System.Drawing.Size(170, 110);
			this.constructorsList.TabIndex = 8;
			this.constructorsList.UseCompatibleStateImageBehavior = false;
			this.constructorsList.SelectedIndexChanged += new System.EventHandler(this.constructorsList_SelectedIndexChanged);
			// 
			// operatorsLabel
			// 
			this.operatorsLabel.AutoSize = true;
			this.operatorsLabel.Location = new System.Drawing.Point(5, 287);
			this.operatorsLabel.Name = "operatorsLabel";
			this.operatorsLabel.Size = new System.Drawing.Size(53, 13);
			this.operatorsLabel.TabIndex = 7;
			this.operatorsLabel.Text = "Operators";
			// 
			// operatorsList
			// 
			this.operatorsList.Location = new System.Drawing.Point(6, 303);
			this.operatorsList.Name = "operatorsList";
			this.operatorsList.Size = new System.Drawing.Size(170, 110);
			this.operatorsList.TabIndex = 6;
			this.operatorsList.UseCompatibleStateImageBehavior = false;
			this.operatorsList.SelectedIndexChanged += new System.EventHandler(this.operatorsList_SelectedIndexChanged);
			// 
			// memberFunctionsLabel
			// 
			this.memberFunctionsLabel.AutoSize = true;
			this.memberFunctionsLabel.Location = new System.Drawing.Point(3, 144);
			this.memberFunctionsLabel.Name = "memberFunctionsLabel";
			this.memberFunctionsLabel.Size = new System.Drawing.Size(94, 13);
			this.memberFunctionsLabel.TabIndex = 5;
			this.memberFunctionsLabel.Text = "Member Functions";
			// 
			// memberFunctionsList
			// 
			this.memberFunctionsList.Location = new System.Drawing.Point(6, 160);
			this.memberFunctionsList.Name = "memberFunctionsList";
			this.memberFunctionsList.Size = new System.Drawing.Size(170, 110);
			this.memberFunctionsList.TabIndex = 4;
			this.memberFunctionsList.UseCompatibleStateImageBehavior = false;
			this.memberFunctionsList.SelectedIndexChanged += new System.EventHandler(this.memberFunctionsList_SelectedIndexChanged);
			// 
			// memberFieldsLabel
			// 
			this.memberFieldsLabel.AutoSize = true;
			this.memberFieldsLabel.Location = new System.Drawing.Point(3, 10);
			this.memberFieldsLabel.Name = "memberFieldsLabel";
			this.memberFieldsLabel.Size = new System.Drawing.Size(75, 13);
			this.memberFieldsLabel.TabIndex = 3;
			this.memberFieldsLabel.Text = "Member Fields";
			// 
			// memberFieldsList
			// 
			this.memberFieldsList.Location = new System.Drawing.Point(4, 29);
			this.memberFieldsList.Name = "memberFieldsList";
			this.memberFieldsList.Size = new System.Drawing.Size(170, 102);
			this.memberFieldsList.TabIndex = 0;
			this.memberFieldsList.UseCompatibleStateImageBehavior = false;
			this.memberFieldsList.SelectedIndexChanged += new System.EventHandler(this.memberFields_SelectedIndexChanged);
			// 
			// TODOTextbox
			// 
			this.TODOTextbox.Location = new System.Drawing.Point(360, 102);
			this.TODOTextbox.Multiline = true;
			this.TODOTextbox.Name = "TODOTextbox";
			this.TODOTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TODOTextbox.Size = new System.Drawing.Size(614, 56);
			this.TODOTextbox.TabIndex = 1;
			// 
			// todoLabel
			// 
			this.todoLabel.AutoSize = true;
			this.todoLabel.Location = new System.Drawing.Point(361, 86);
			this.todoLabel.Name = "todoLabel";
			this.todoLabel.Size = new System.Drawing.Size(131, 13);
			this.todoLabel.TabIndex = 2;
			this.todoLabel.Text = "TODO after file generation";
			// 
			// genHTMLButton
			// 
			this.genHTMLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.genHTMLButton.Location = new System.Drawing.Point(360, 11);
			this.genHTMLButton.Name = "genHTMLButton";
			this.genHTMLButton.Size = new System.Drawing.Size(92, 20);
			this.genHTMLButton.TabIndex = 6;
			this.genHTMLButton.Text = "Generate File";
			this.genHTMLButton.UseVisualStyleBackColor = true;
			this.genHTMLButton.Click += new System.EventHandler(this.genHTMLButton_Click);
			// 
			// htmlFileLocationText
			// 
			this.htmlFileLocationText.Location = new System.Drawing.Point(458, 12);
			this.htmlFileLocationText.Name = "htmlFileLocationText";
			this.htmlFileLocationText.Size = new System.Drawing.Size(236, 20);
			this.htmlFileLocationText.TabIndex = 7;
			this.htmlFileLocationText.Text = "System Folder/Class_Name_Without_Extension";
			// 
			// classNameLabel
			// 
			this.classNameLabel.AutoSize = true;
			this.classNameLabel.Location = new System.Drawing.Point(13, 15);
			this.classNameLabel.Name = "classNameLabel";
			this.classNameLabel.Size = new System.Drawing.Size(66, 13);
			this.classNameLabel.TabIndex = 8;
			this.classNameLabel.Text = "Class Name:";
			// 
			// classNameText
			// 
			this.classNameText.Location = new System.Drawing.Point(91, 12);
			this.classNameText.Name = "classNameText";
			this.classNameText.Size = new System.Drawing.Size(102, 20);
			this.classNameText.TabIndex = 9;
			this.classNameText.Text = "ClassName";
			this.classNameText.TextChanged += new System.EventHandler(this.classNameText_TextChanged);
			// 
			// hFileLocationLabel
			// 
			this.hFileLocationLabel.AutoSize = true;
			this.hFileLocationLabel.Location = new System.Drawing.Point(10, 36);
			this.hFileLocationLabel.Name = "hFileLocationLabel";
			this.hFileLocationLabel.Size = new System.Drawing.Size(75, 13);
			this.hFileLocationLabel.TabIndex = 10;
			this.hFileLocationLabel.Text = ".h file location:";
			// 
			// hFileLocationText
			// 
			this.hFileLocationText.Location = new System.Drawing.Point(91, 33);
			this.hFileLocationText.Name = "hFileLocationText";
			this.hFileLocationText.Size = new System.Drawing.Size(232, 20);
			this.hFileLocationText.TabIndex = 11;
			this.hFileLocationText.Text = "Math/Lower Math/ClassName.h";
			// 
			// hasCppFileCheck
			// 
			this.hasCppFileCheck.AutoSize = true;
			this.hasCppFileCheck.Checked = true;
			this.hasCppFileCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.hasCppFileCheck.Location = new System.Drawing.Point(16, 59);
			this.hasCppFileCheck.Name = "hasCppFileCheck";
			this.hasCppFileCheck.Size = new System.Drawing.Size(91, 17);
			this.hasCppFileCheck.TabIndex = 12;
			this.hasCppFileCheck.Text = "Has .cpp file?";
			this.hasCppFileCheck.UseVisualStyleBackColor = true;
			// 
			// systemHTMLText
			// 
			this.systemHTMLText.Location = new System.Drawing.Point(91, 103);
			this.systemHTMLText.Name = "systemHTMLText";
			this.systemHTMLText.Size = new System.Drawing.Size(232, 20);
			this.systemHTMLText.TabIndex = 16;
			this.systemHTMLText.Text = "System Name.html";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "System HTML:";
			// 
			// systemNameText
			// 
			this.systemNameText.Location = new System.Drawing.Point(91, 82);
			this.systemNameText.Name = "systemNameText";
			this.systemNameText.Size = new System.Drawing.Size(102, 20);
			this.systemNameText.TabIndex = 14;
			this.systemNameText.Text = "System Name";
			this.systemNameText.TextChanged += new System.EventHandler(this.systemNameText_TextChanged);
			// 
			// systemNameLabel
			// 
			this.systemNameLabel.AutoSize = true;
			this.systemNameLabel.Location = new System.Drawing.Point(13, 85);
			this.systemNameLabel.Name = "systemNameLabel";
			this.systemNameLabel.Size = new System.Drawing.Size(75, 13);
			this.systemNameLabel.TabIndex = 13;
			this.systemNameLabel.Text = "System Name:";
			// 
			// classDescText
			// 
			this.classDescText.Location = new System.Drawing.Point(5, 157);
			this.classDescText.Name = "classDescText";
			this.classDescText.Size = new System.Drawing.Size(318, 276);
			this.classDescText.TabIndex = 20;
			this.classDescText.Text = "This is a description of the item.\nEach new line represents a different bullet po" +
    "int.";
			this.classDescText.WordWrap = false;
			// 
			// codeSampleText
			// 
			this.codeSampleText.Location = new System.Drawing.Point(5, 439);
			this.codeSampleText.Name = "codeSampleText";
			this.codeSampleText.Size = new System.Drawing.Size(318, 312);
			this.codeSampleText.TabIndex = 19;
			this.codeSampleText.Text = "//The following code prints \'hello\'.\nstd::cout << \"hello\";\n//Make sure to use spa" +
    "ces instead of tabs!";
			// 
			// classSummaryLabel
			// 
			this.classSummaryLabel.AutoSize = true;
			this.classSummaryLabel.Location = new System.Drawing.Point(361, 56);
			this.classSummaryLabel.Name = "classSummaryLabel";
			this.classSummaryLabel.Size = new System.Drawing.Size(109, 13);
			this.classSummaryLabel.TabIndex = 21;
			this.classSummaryLabel.Text = "Quick class summary:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(475, 53);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(236, 20);
			this.textBox2.TabIndex = 22;
			// 
			// constructorDefSetup
			// 
			this.constructorDefSetup.Location = new System.Drawing.Point(378, 82);
			this.constructorDefSetup.Name = "constructorDefSetup";
			this.constructorDefSetup.Size = new System.Drawing.Size(450, 388);
			this.constructorDefSetup.TabIndex = 28;
			// 
			// functionDefSetup
			// 
			this.functionDefSetup.Location = new System.Drawing.Point(378, 82);
			this.functionDefSetup.Name = "functionDefSetup";
			this.functionDefSetup.Size = new System.Drawing.Size(450, 388);
			this.functionDefSetup.TabIndex = 27;
			// 
			// dataDefSetup
			// 
			this.dataDefSetup.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.dataDefSetup.Location = new System.Drawing.Point(376, 76);
			this.dataDefSetup.Name = "dataDefSetup";
			this.dataDefSetup.Size = new System.Drawing.Size(452, 394);
			this.dataDefSetup.TabIndex = 18;
			// 
			// chooseDocRootButton
			// 
			this.chooseDocRootButton.Location = new System.Drawing.Point(760, 11);
			this.chooseDocRootButton.Name = "chooseDocRootButton";
			this.chooseDocRootButton.Size = new System.Drawing.Size(154, 23);
			this.chooseDocRootButton.TabIndex = 23;
			this.chooseDocRootButton.Text = "Choose Documentation Root";
			this.chooseDocRootButton.UseVisualStyleBackColor = true;
			this.chooseDocRootButton.Click += new System.EventHandler(this.chooseDocRootButton_Click);
			// 
			// docRootFolderBrowser
			// 
			this.docRootFolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
			this.docRootFolderBrowser.SelectedPath = "C:\\Git Repos\\ManbilDocumentation";
			// 
			// docRootLabel
			// 
			this.docRootLabel.AutoSize = true;
			this.docRootLabel.Location = new System.Drawing.Point(947, 18);
			this.docRootLabel.Name = "docRootLabel";
			this.docRootLabel.Size = new System.Drawing.Size(111, 13);
			this.docRootLabel.TabIndex = 24;
			this.docRootLabel.Text = "[Documentation Root]";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1202, 757);
			this.Controls.Add(this.docRootLabel);
			this.Controls.Add(this.chooseDocRootButton);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.classSummaryLabel);
			this.Controls.Add(this.classDescText);
			this.Controls.Add(this.codeSampleText);
			this.Controls.Add(this.systemHTMLText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.systemNameText);
			this.Controls.Add(this.systemNameLabel);
			this.Controls.Add(this.hasCppFileCheck);
			this.Controls.Add(this.hFileLocationText);
			this.Controls.Add(this.hFileLocationLabel);
			this.Controls.Add(this.classNameText);
			this.Controls.Add(this.classNameLabel);
			this.Controls.Add(this.htmlFileLocationText);
			this.Controls.Add(this.genHTMLButton);
			this.Controls.Add(this.definitionsPanel);
			this.Controls.Add(this.todoLabel);
			this.Controls.Add(this.TODOTextbox);
			this.Name = "MainForm";
			this.Text = "HTML Generator";
			this.definitionsPanel.ResumeLayout(false);
			this.definitionsPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView memberFieldsList;
		private System.Windows.Forms.TextBox TODOTextbox;
		private System.Windows.Forms.Label todoLabel;
		private System.Windows.Forms.Label memberFieldsLabel;
		private System.Windows.Forms.Panel definitionsPanel;
		private System.Windows.Forms.Button genHTMLButton;
		private System.Windows.Forms.TextBox htmlFileLocationText;
		private System.Windows.Forms.Label memberFunctionsLabel;
		private System.Windows.Forms.ListView memberFunctionsList;
		private System.Windows.Forms.Label operatorsLabel;
		private System.Windows.Forms.ListView operatorsList;
		private System.Windows.Forms.Label constructorsLabel;
		private System.Windows.Forms.ListView constructorsList;
		private System.Windows.Forms.Label subtypesLabel;
		private System.Windows.Forms.ListView subtypesList;
		private System.Windows.Forms.Label constantsLabel;
		private System.Windows.Forms.ListView constantsList;
		private System.Windows.Forms.Label staticFunctionsLabel;
		private System.Windows.Forms.ListView staticFunctionsList;
		private System.Windows.Forms.Label staticFieldsLabel;
		private System.Windows.Forms.ListView staticFieldsList;
		private System.Windows.Forms.Label classNameLabel;
		private System.Windows.Forms.TextBox classNameText;
		private System.Windows.Forms.Label hFileLocationLabel;
		private System.Windows.Forms.TextBox hFileLocationText;
		private System.Windows.Forms.CheckBox hasCppFileCheck;
		private System.Windows.Forms.TextBox systemHTMLText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox systemNameText;
		private System.Windows.Forms.Label systemNameLabel;
		protected System.Windows.Forms.RichTextBox classDescText;
		protected System.Windows.Forms.RichTextBox codeSampleText;
		private System.Windows.Forms.Label classSummaryLabel;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button addMemberFieldButton;
		private System.Windows.Forms.Button addConstructorButton;
		private System.Windows.Forms.Button addOperatorButton;
		private System.Windows.Forms.Button addMemberFunctionButton;
		private System.Windows.Forms.Button addSubtypeButton;
		private System.Windows.Forms.Button addConstantButton;
		private System.Windows.Forms.Button addStaticFunctionButton;
		private System.Windows.Forms.Button addStaticFieldButton;
		private DataDefinition dataDefSetup;
		private FunctionDefinition functionDefSetup;
		private ConstructorDefinition constructorDefSetup;
		private System.Windows.Forms.Button chooseDocRootButton;
		private System.Windows.Forms.FolderBrowserDialog docRootFolderBrowser;
		private System.Windows.Forms.Label docRootLabel;
	}
}

