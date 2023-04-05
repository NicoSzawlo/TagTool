namespace TagTool
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            btnNavComponents = new Button();
            pnlLibrary = new Panel();
            btnLibraryDeleteParameter = new Button();
            btnLibraryDeleteAlarm = new Button();
            lvLibraryFunctionblocks = new ListView();
            colLibviewBugged = new ColumnHeader();
            colLibviewName = new ColumnHeader();
            dgvLibraryAlarms = new DataGridView();
            btnLibraryAddAlarm = new Button();
            btnLibraryAddParameter = new Button();
            btnLibraryViewParameters = new Button();
            btnLibraryViewAlarms = new Button();
            dgvLibraryParameters = new DataGridView();
            lblLibraryFbDescription = new Label();
            txtLibraryDescription = new TextBox();
            lblLibrarySize = new Label();
            txtLibrarySize = new TextBox();
            lblLibraryFbName = new Label();
            txtLibraryFbName = new TextBox();
            btnLibrarySaveFileAs = new Button();
            btnLibraryTest = new Button();
            btnLibraryOpenFile = new Button();
            btnLibrarySaveFile = new Button();
            btnLibraryCreateFb = new Button();
            btnNavLibrary = new Button();
            btnNavAlarms = new Button();
            btnNavExports = new Button();
            button4 = new Button();
            pnlComponents = new Panel();
            btnComponentsDel = new Button();
            lblCompUnits = new Label();
            dgvCompUnits = new DataGridView();
            btnComponentAdd = new Button();
            btnComponentLoad = new Button();
            btnComponentsSave = new Button();
            btnComponentsCreateNew = new Button();
            dgvComponents = new DataGridView();
            pnlAlarms = new Panel();
            btnAlmGroupDel = new Button();
            btnAlmGroupAdd = new Button();
            lblAlarmGroups = new Label();
            dgvAlarmGroups = new DataGridView();
            rdbAlmMemSelMix = new RadioButton();
            rdbAlmMemSelHex = new RadioButton();
            rdbAlmMemSelDec = new RadioButton();
            lblAlmSize = new Label();
            txtAlmSize = new TextBox();
            btnAlmRefresh = new Button();
            lblAlmStartAdr = new Label();
            txtAlmStartAddr = new TextBox();
            lblAlmMemArea = new Label();
            txtAlmMemArea = new TextBox();
            dgvAlarms = new DataGridView();
            pnlExports = new Panel();
            pnlLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibraryAlarms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibraryParameters).BeginInit();
            pnlComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvComponents).BeginInit();
            pnlAlarms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlarmGroups).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlarms).BeginInit();
            SuspendLayout();
            // 
            // btnNavComponents
            // 
            btnNavComponents.BackColor = Color.DarkGray;
            btnNavComponents.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnNavComponents.FlatAppearance.BorderSize = 2;
            btnNavComponents.FlatStyle = FlatStyle.Flat;
            btnNavComponents.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavComponents.Image = (Image)resources.GetObject("btnNavComponents.Image");
            btnNavComponents.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavComponents.Location = new Point(4, 4);
            btnNavComponents.Name = "btnNavComponents";
            btnNavComponents.Size = new Size(160, 78);
            btnNavComponents.TabIndex = 0;
            btnNavComponents.Text = "Components";
            btnNavComponents.TextAlign = ContentAlignment.MiddleRight;
            btnNavComponents.UseVisualStyleBackColor = false;
            btnNavComponents.Click += btnNavComponents_Click;
            // 
            // pnlLibrary
            // 
            pnlLibrary.BackColor = Color.LightGray;
            pnlLibrary.Controls.Add(btnLibraryDeleteParameter);
            pnlLibrary.Controls.Add(btnLibraryDeleteAlarm);
            pnlLibrary.Controls.Add(lvLibraryFunctionblocks);
            pnlLibrary.Controls.Add(dgvLibraryAlarms);
            pnlLibrary.Controls.Add(btnLibraryAddAlarm);
            pnlLibrary.Controls.Add(btnLibraryAddParameter);
            pnlLibrary.Controls.Add(btnLibraryViewParameters);
            pnlLibrary.Controls.Add(btnLibraryViewAlarms);
            pnlLibrary.Controls.Add(dgvLibraryParameters);
            pnlLibrary.Controls.Add(lblLibraryFbDescription);
            pnlLibrary.Controls.Add(txtLibraryDescription);
            pnlLibrary.Controls.Add(lblLibrarySize);
            pnlLibrary.Controls.Add(txtLibrarySize);
            pnlLibrary.Controls.Add(lblLibraryFbName);
            pnlLibrary.Controls.Add(txtLibraryFbName);
            pnlLibrary.Controls.Add(btnLibrarySaveFileAs);
            pnlLibrary.Controls.Add(btnLibraryTest);
            pnlLibrary.Controls.Add(btnLibraryOpenFile);
            pnlLibrary.Controls.Add(btnLibrarySaveFile);
            pnlLibrary.Controls.Add(btnLibraryCreateFb);
            pnlLibrary.Location = new Point(4, 84);
            pnlLibrary.Name = "pnlLibrary";
            pnlLibrary.Size = new Size(1176, 672);
            pnlLibrary.TabIndex = 1;
            // 
            // btnLibraryDeleteParameter
            // 
            btnLibraryDeleteParameter.BackColor = Color.DarkGray;
            btnLibraryDeleteParameter.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnLibraryDeleteParameter.FlatAppearance.BorderSize = 0;
            btnLibraryDeleteParameter.FlatStyle = FlatStyle.Flat;
            btnLibraryDeleteParameter.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLibraryDeleteParameter.Image = (Image)resources.GetObject("btnLibraryDeleteParameter.Image");
            btnLibraryDeleteParameter.Location = new Point(1020, 362);
            btnLibraryDeleteParameter.Name = "btnLibraryDeleteParameter";
            btnLibraryDeleteParameter.Size = new Size(55, 55);
            btnLibraryDeleteParameter.TabIndex = 30;
            btnLibraryDeleteParameter.TextAlign = ContentAlignment.MiddleRight;
            btnLibraryDeleteParameter.UseVisualStyleBackColor = false;
            btnLibraryDeleteParameter.Click += btnLibraryDeleteParameter_Click;
            // 
            // btnLibraryDeleteAlarm
            // 
            btnLibraryDeleteAlarm.BackColor = Color.DarkGray;
            btnLibraryDeleteAlarm.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnLibraryDeleteAlarm.FlatAppearance.BorderSize = 0;
            btnLibraryDeleteAlarm.FlatStyle = FlatStyle.Flat;
            btnLibraryDeleteAlarm.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLibraryDeleteAlarm.Image = (Image)resources.GetObject("btnLibraryDeleteAlarm.Image");
            btnLibraryDeleteAlarm.Location = new Point(1020, 90);
            btnLibraryDeleteAlarm.Name = "btnLibraryDeleteAlarm";
            btnLibraryDeleteAlarm.Size = new Size(55, 55);
            btnLibraryDeleteAlarm.TabIndex = 29;
            btnLibraryDeleteAlarm.TextAlign = ContentAlignment.MiddleRight;
            btnLibraryDeleteAlarm.UseVisualStyleBackColor = false;
            btnLibraryDeleteAlarm.Click += btnLibraryDeleteAlarm_Click;
            // 
            // lvLibraryFunctionblocks
            // 
            lvLibraryFunctionblocks.CausesValidation = false;
            lvLibraryFunctionblocks.Columns.AddRange(new ColumnHeader[] { colLibviewBugged, colLibviewName });
            lvLibraryFunctionblocks.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lvLibraryFunctionblocks.FullRowSelect = true;
            lvLibraryFunctionblocks.GridLines = true;
            lvLibraryFunctionblocks.Location = new Point(30, 152);
            lvLibraryFunctionblocks.MultiSelect = false;
            lvLibraryFunctionblocks.Name = "lvLibraryFunctionblocks";
            lvLibraryFunctionblocks.Size = new Size(290, 489);
            lvLibraryFunctionblocks.TabIndex = 28;
            lvLibraryFunctionblocks.TileSize = new Size(290, 40);
            lvLibraryFunctionblocks.UseCompatibleStateImageBehavior = false;
            lvLibraryFunctionblocks.View = View.List;
            lvLibraryFunctionblocks.ItemSelectionChanged += lvLibraryFunctionblocks_ItemSelectionChanged;
            // 
            // colLibviewBugged
            // 
            colLibviewBugged.Width = 0;
            // 
            // colLibviewName
            // 
            colLibviewName.TextAlign = HorizontalAlignment.Right;
            colLibviewName.Width = 290;
            // 
            // dgvLibraryAlarms
            // 
            dgvLibraryAlarms.AllowUserToAddRows = false;
            dgvLibraryAlarms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLibraryAlarms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibraryAlarms.Location = new Point(362, 152);
            dgvLibraryAlarms.MultiSelect = false;
            dgvLibraryAlarms.Name = "dgvLibraryAlarms";
            dgvLibraryAlarms.RowTemplate.Height = 25;
            dgvLibraryAlarms.Size = new Size(774, 204);
            dgvLibraryAlarms.TabIndex = 27;
            dgvLibraryAlarms.CellValueChanged += dgvLibraryAlarms_CellValueChanged;
            // 
            // btnLibraryAddAlarm
            // 
            btnLibraryAddAlarm.BackColor = Color.DarkGray;
            btnLibraryAddAlarm.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnLibraryAddAlarm.FlatAppearance.BorderSize = 0;
            btnLibraryAddAlarm.FlatStyle = FlatStyle.Flat;
            btnLibraryAddAlarm.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLibraryAddAlarm.Image = (Image)resources.GetObject("btnLibraryAddAlarm.Image");
            btnLibraryAddAlarm.Location = new Point(1081, 91);
            btnLibraryAddAlarm.Name = "btnLibraryAddAlarm";
            btnLibraryAddAlarm.Size = new Size(55, 55);
            btnLibraryAddAlarm.TabIndex = 26;
            btnLibraryAddAlarm.TextAlign = ContentAlignment.MiddleRight;
            btnLibraryAddAlarm.UseVisualStyleBackColor = false;
            btnLibraryAddAlarm.Click += btnLibraryAddAlarm_Click;
            // 
            // btnLibraryAddParameter
            // 
            btnLibraryAddParameter.BackColor = Color.DarkGray;
            btnLibraryAddParameter.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnLibraryAddParameter.FlatAppearance.BorderSize = 0;
            btnLibraryAddParameter.FlatStyle = FlatStyle.Flat;
            btnLibraryAddParameter.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLibraryAddParameter.Image = (Image)resources.GetObject("btnLibraryAddParameter.Image");
            btnLibraryAddParameter.Location = new Point(1081, 362);
            btnLibraryAddParameter.Name = "btnLibraryAddParameter";
            btnLibraryAddParameter.Size = new Size(55, 55);
            btnLibraryAddParameter.TabIndex = 25;
            btnLibraryAddParameter.TextAlign = ContentAlignment.MiddleRight;
            btnLibraryAddParameter.UseVisualStyleBackColor = false;
            btnLibraryAddParameter.Click += btnLibraryAddParameter_Click;
            // 
            // btnLibraryViewParameters
            // 
            btnLibraryViewParameters.BackColor = Color.DarkGray;
            btnLibraryViewParameters.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnLibraryViewParameters.FlatAppearance.BorderSize = 0;
            btnLibraryViewParameters.FlatStyle = FlatStyle.Flat;
            btnLibraryViewParameters.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLibraryViewParameters.Image = (Image)resources.GetObject("btnLibraryViewParameters.Image");
            btnLibraryViewParameters.ImageAlign = ContentAlignment.MiddleLeft;
            btnLibraryViewParameters.Location = new Point(362, 362);
            btnLibraryViewParameters.Name = "btnLibraryViewParameters";
            btnLibraryViewParameters.Size = new Size(148, 55);
            btnLibraryViewParameters.TabIndex = 24;
            btnLibraryViewParameters.Text = "Parameters";
            btnLibraryViewParameters.TextAlign = ContentAlignment.MiddleRight;
            btnLibraryViewParameters.UseVisualStyleBackColor = false;
            // 
            // btnLibraryViewAlarms
            // 
            btnLibraryViewAlarms.BackColor = Color.DarkGray;
            btnLibraryViewAlarms.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnLibraryViewAlarms.FlatAppearance.BorderSize = 0;
            btnLibraryViewAlarms.FlatStyle = FlatStyle.Flat;
            btnLibraryViewAlarms.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLibraryViewAlarms.Image = (Image)resources.GetObject("btnLibraryViewAlarms.Image");
            btnLibraryViewAlarms.ImageAlign = ContentAlignment.MiddleLeft;
            btnLibraryViewAlarms.Location = new Point(362, 91);
            btnLibraryViewAlarms.Name = "btnLibraryViewAlarms";
            btnLibraryViewAlarms.Size = new Size(148, 55);
            btnLibraryViewAlarms.TabIndex = 23;
            btnLibraryViewAlarms.Text = "Alarms";
            btnLibraryViewAlarms.TextAlign = ContentAlignment.MiddleRight;
            btnLibraryViewAlarms.UseVisualStyleBackColor = false;
            // 
            // dgvLibraryParameters
            // 
            dgvLibraryParameters.AllowUserToAddRows = false;
            dgvLibraryParameters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLibraryParameters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibraryParameters.Location = new Point(362, 423);
            dgvLibraryParameters.MultiSelect = false;
            dgvLibraryParameters.Name = "dgvLibraryParameters";
            dgvLibraryParameters.RowTemplate.Height = 25;
            dgvLibraryParameters.Size = new Size(774, 218);
            dgvLibraryParameters.TabIndex = 22;
            dgvLibraryParameters.CellValueChanged += dgvLibraryParameters_CellValueChanged;
            // 
            // lblLibraryFbDescription
            // 
            lblLibraryFbDescription.AutoSize = true;
            lblLibraryFbDescription.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLibraryFbDescription.Location = new Point(784, 29);
            lblLibraryFbDescription.Name = "lblLibraryFbDescription";
            lblLibraryFbDescription.Size = new Size(96, 23);
            lblLibraryFbDescription.TabIndex = 21;
            lblLibraryFbDescription.Text = "Description";
            // 
            // txtLibraryDescription
            // 
            txtLibraryDescription.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLibraryDescription.Location = new Point(784, 54);
            txtLibraryDescription.Name = "txtLibraryDescription";
            txtLibraryDescription.Size = new Size(352, 30);
            txtLibraryDescription.TabIndex = 20;
            txtLibraryDescription.TextChanged += txtLibraryDescription_TextChanged;
            // 
            // lblLibrarySize
            // 
            lblLibrarySize.AutoSize = true;
            lblLibrarySize.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLibrarySize.Location = new Point(573, 28);
            lblLibrarySize.Name = "lblLibrarySize";
            lblLibrarySize.Size = new Size(40, 23);
            lblLibrarySize.TabIndex = 19;
            lblLibrarySize.Text = "Size";
            // 
            // txtLibrarySize
            // 
            txtLibrarySize.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLibrarySize.Location = new Point(573, 54);
            txtLibrarySize.Name = "txtLibrarySize";
            txtLibrarySize.Size = new Size(205, 30);
            txtLibrarySize.TabIndex = 18;
            txtLibrarySize.TextChanged += txtLibrarySize_TextChanged;
            // 
            // lblLibraryFbName
            // 
            lblLibraryFbName.AutoSize = true;
            lblLibraryFbName.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLibraryFbName.Location = new Point(362, 29);
            lblLibraryFbName.Name = "lblLibraryFbName";
            lblLibraryFbName.Size = new Size(56, 23);
            lblLibraryFbName.TabIndex = 17;
            lblLibraryFbName.Text = "Name";
            // 
            // txtLibraryFbName
            // 
            txtLibraryFbName.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLibraryFbName.Location = new Point(362, 55);
            txtLibraryFbName.Name = "txtLibraryFbName";
            txtLibraryFbName.Size = new Size(205, 30);
            txtLibraryFbName.TabIndex = 16;
            txtLibraryFbName.TextChanged += txtLibraryFbName_TextChanged;
            // 
            // btnLibrarySaveFileAs
            // 
            btnLibrarySaveFileAs.BackColor = Color.DarkGray;
            btnLibrarySaveFileAs.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnLibrarySaveFileAs.FlatAppearance.BorderSize = 0;
            btnLibrarySaveFileAs.FlatStyle = FlatStyle.Flat;
            btnLibrarySaveFileAs.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLibrarySaveFileAs.Image = (Image)resources.GetObject("btnLibrarySaveFileAs.Image");
            btnLibrarySaveFileAs.Location = new Point(92, 30);
            btnLibrarySaveFileAs.Name = "btnLibrarySaveFileAs";
            btnLibrarySaveFileAs.Size = new Size(55, 55);
            btnLibrarySaveFileAs.TabIndex = 14;
            btnLibrarySaveFileAs.TextAlign = ContentAlignment.MiddleRight;
            btnLibrarySaveFileAs.UseVisualStyleBackColor = false;
            btnLibrarySaveFileAs.Click += btnLibrarySaveFileAs_Click;
            // 
            // btnLibraryTest
            // 
            btnLibraryTest.BackColor = Color.DarkGray;
            btnLibraryTest.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnLibraryTest.FlatAppearance.BorderSize = 0;
            btnLibraryTest.FlatStyle = FlatStyle.Flat;
            btnLibraryTest.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLibraryTest.Image = (Image)resources.GetObject("btnLibraryTest.Image");
            btnLibraryTest.Location = new Point(265, 30);
            btnLibraryTest.Name = "btnLibraryTest";
            btnLibraryTest.Size = new Size(55, 55);
            btnLibraryTest.TabIndex = 13;
            btnLibraryTest.Text = "Test";
            btnLibraryTest.TextAlign = ContentAlignment.MiddleRight;
            btnLibraryTest.UseVisualStyleBackColor = false;
            btnLibraryTest.Click += btnLibraryTest_Click;
            // 
            // btnLibraryOpenFile
            // 
            btnLibraryOpenFile.BackColor = Color.DarkGray;
            btnLibraryOpenFile.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnLibraryOpenFile.FlatAppearance.BorderSize = 0;
            btnLibraryOpenFile.FlatStyle = FlatStyle.Flat;
            btnLibraryOpenFile.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLibraryOpenFile.Image = (Image)resources.GetObject("btnLibraryOpenFile.Image");
            btnLibraryOpenFile.Location = new Point(153, 30);
            btnLibraryOpenFile.Name = "btnLibraryOpenFile";
            btnLibraryOpenFile.Size = new Size(55, 55);
            btnLibraryOpenFile.TabIndex = 11;
            btnLibraryOpenFile.TextAlign = ContentAlignment.MiddleRight;
            btnLibraryOpenFile.UseVisualStyleBackColor = false;
            btnLibraryOpenFile.Click += btnLibraryOpenFile_Click;
            // 
            // btnLibrarySaveFile
            // 
            btnLibrarySaveFile.BackColor = Color.DarkGray;
            btnLibrarySaveFile.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnLibrarySaveFile.FlatAppearance.BorderSize = 0;
            btnLibrarySaveFile.FlatStyle = FlatStyle.Flat;
            btnLibrarySaveFile.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLibrarySaveFile.Image = (Image)resources.GetObject("btnLibrarySaveFile.Image");
            btnLibrarySaveFile.Location = new Point(30, 30);
            btnLibrarySaveFile.Name = "btnLibrarySaveFile";
            btnLibrarySaveFile.Size = new Size(55, 55);
            btnLibrarySaveFile.TabIndex = 10;
            btnLibrarySaveFile.TextAlign = ContentAlignment.MiddleRight;
            btnLibrarySaveFile.UseVisualStyleBackColor = false;
            btnLibrarySaveFile.Click += btnLibrarySaveFile_Click;
            // 
            // btnLibraryCreateFb
            // 
            btnLibraryCreateFb.BackColor = Color.DarkGray;
            btnLibraryCreateFb.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnLibraryCreateFb.FlatAppearance.BorderSize = 0;
            btnLibraryCreateFb.FlatStyle = FlatStyle.Flat;
            btnLibraryCreateFb.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLibraryCreateFb.Image = Properties.Resources.bearbeitensml;
            btnLibraryCreateFb.ImageAlign = ContentAlignment.MiddleLeft;
            btnLibraryCreateFb.Location = new Point(30, 91);
            btnLibraryCreateFb.Name = "btnLibraryCreateFb";
            btnLibraryCreateFb.Size = new Size(213, 55);
            btnLibraryCreateFb.TabIndex = 9;
            btnLibraryCreateFb.Text = "New Functionblock";
            btnLibraryCreateFb.TextAlign = ContentAlignment.MiddleRight;
            btnLibraryCreateFb.UseVisualStyleBackColor = false;
            btnLibraryCreateFb.Click += btnLibraryCreateFb_Click;
            // 
            // btnNavLibrary
            // 
            btnNavLibrary.BackColor = Color.LightGray;
            btnNavLibrary.BackgroundImageLayout = ImageLayout.Zoom;
            btnNavLibrary.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnNavLibrary.FlatAppearance.BorderSize = 2;
            btnNavLibrary.FlatStyle = FlatStyle.Flat;
            btnNavLibrary.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavLibrary.Image = Properties.Resources.folder38px;
            btnNavLibrary.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavLibrary.Location = new Point(170, 4);
            btnNavLibrary.Name = "btnNavLibrary";
            btnNavLibrary.Size = new Size(160, 82);
            btnNavLibrary.TabIndex = 2;
            btnNavLibrary.Text = "FB Library";
            btnNavLibrary.TextAlign = ContentAlignment.MiddleRight;
            btnNavLibrary.UseVisualStyleBackColor = false;
            btnNavLibrary.Click += btnNavLibrary_Click;
            // 
            // btnNavAlarms
            // 
            btnNavAlarms.BackColor = Color.DarkGray;
            btnNavAlarms.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnNavAlarms.FlatAppearance.BorderSize = 2;
            btnNavAlarms.FlatStyle = FlatStyle.Flat;
            btnNavAlarms.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavAlarms.Location = new Point(336, 4);
            btnNavAlarms.Name = "btnNavAlarms";
            btnNavAlarms.Size = new Size(160, 78);
            btnNavAlarms.TabIndex = 3;
            btnNavAlarms.Text = "Alarms";
            btnNavAlarms.TextAlign = ContentAlignment.MiddleRight;
            btnNavAlarms.UseVisualStyleBackColor = false;
            btnNavAlarms.Click += btnNavAlarms_Click;
            // 
            // btnNavExports
            // 
            btnNavExports.BackColor = Color.DarkGray;
            btnNavExports.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnNavExports.FlatAppearance.BorderSize = 2;
            btnNavExports.FlatStyle = FlatStyle.Flat;
            btnNavExports.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavExports.Location = new Point(502, 4);
            btnNavExports.Name = "btnNavExports";
            btnNavExports.Size = new Size(160, 78);
            btnNavExports.TabIndex = 4;
            btnNavExports.Text = "Exports";
            btnNavExports.TextAlign = ContentAlignment.MiddleRight;
            btnNavExports.UseVisualStyleBackColor = false;
            btnNavExports.Click += btnNavExports_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGray;
            button4.FlatAppearance.BorderColor = Color.DodgerBlue;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(668, 4);
            button4.Name = "button4";
            button4.Size = new Size(160, 78);
            button4.TabIndex = 5;
            button4.Text = "Components";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            // 
            // pnlComponents
            // 
            pnlComponents.BackColor = Color.LightGray;
            pnlComponents.Controls.Add(btnComponentsDel);
            pnlComponents.Controls.Add(lblCompUnits);
            pnlComponents.Controls.Add(dgvCompUnits);
            pnlComponents.Controls.Add(btnComponentAdd);
            pnlComponents.Controls.Add(btnComponentLoad);
            pnlComponents.Controls.Add(btnComponentsSave);
            pnlComponents.Controls.Add(btnComponentsCreateNew);
            pnlComponents.Controls.Add(dgvComponents);
            pnlComponents.Location = new Point(4, 84);
            pnlComponents.Name = "pnlComponents";
            pnlComponents.Size = new Size(1176, 672);
            pnlComponents.TabIndex = 6;
            // 
            // btnComponentsDel
            // 
            btnComponentsDel.BackColor = Color.DarkGray;
            btnComponentsDel.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnComponentsDel.FlatAppearance.BorderSize = 0;
            btnComponentsDel.FlatStyle = FlatStyle.Flat;
            btnComponentsDel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnComponentsDel.Image = (Image)resources.GetObject("btnComponentsDel.Image");
            btnComponentsDel.Location = new Point(844, 7);
            btnComponentsDel.Name = "btnComponentsDel";
            btnComponentsDel.Size = new Size(55, 55);
            btnComponentsDel.TabIndex = 38;
            btnComponentsDel.TextAlign = ContentAlignment.MiddleRight;
            btnComponentsDel.UseVisualStyleBackColor = false;
            btnComponentsDel.Click += btnComponentsDel_Click;
            // 
            // lblCompUnits
            // 
            lblCompUnits.AutoSize = true;
            lblCompUnits.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompUnits.Location = new Point(966, 39);
            lblCompUnits.Name = "lblCompUnits";
            lblCompUnits.Size = new Size(111, 23);
            lblCompUnits.TabIndex = 29;
            lblCompUnits.Text = "Units/Groups";
            // 
            // dgvCompUnits
            // 
            dgvCompUnits.AllowUserToResizeRows = false;
            dgvCompUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCompUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompUnits.Location = new Point(966, 67);
            dgvCompUnits.Name = "dgvCompUnits";
            dgvCompUnits.RowTemplate.Height = 25;
            dgvCompUnits.Size = new Size(202, 178);
            dgvCompUnits.TabIndex = 28;
            dgvCompUnits.CellValueChanged += dgvCompUnits_CellValueChanged;
            // 
            // btnComponentAdd
            // 
            btnComponentAdd.BackColor = Color.DarkGray;
            btnComponentAdd.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnComponentAdd.FlatAppearance.BorderSize = 0;
            btnComponentAdd.FlatStyle = FlatStyle.Flat;
            btnComponentAdd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnComponentAdd.Image = (Image)resources.GetObject("btnComponentAdd.Image");
            btnComponentAdd.Location = new Point(905, 7);
            btnComponentAdd.Name = "btnComponentAdd";
            btnComponentAdd.Size = new Size(55, 55);
            btnComponentAdd.TabIndex = 27;
            btnComponentAdd.TextAlign = ContentAlignment.MiddleRight;
            btnComponentAdd.UseVisualStyleBackColor = false;
            btnComponentAdd.Click += btnComponentAdd_Click;
            // 
            // btnComponentLoad
            // 
            btnComponentLoad.BackColor = Color.DarkGray;
            btnComponentLoad.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnComponentLoad.FlatAppearance.BorderSize = 0;
            btnComponentLoad.FlatStyle = FlatStyle.Flat;
            btnComponentLoad.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnComponentLoad.Image = (Image)resources.GetObject("btnComponentLoad.Image");
            btnComponentLoad.Location = new Point(130, 7);
            btnComponentLoad.Name = "btnComponentLoad";
            btnComponentLoad.Size = new Size(55, 55);
            btnComponentLoad.TabIndex = 8;
            btnComponentLoad.TextAlign = ContentAlignment.MiddleRight;
            btnComponentLoad.UseVisualStyleBackColor = false;
            btnComponentLoad.Click += btnComponentLoad_Click;
            // 
            // btnComponentsSave
            // 
            btnComponentsSave.BackColor = Color.DarkGray;
            btnComponentsSave.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnComponentsSave.FlatAppearance.BorderSize = 0;
            btnComponentsSave.FlatStyle = FlatStyle.Flat;
            btnComponentsSave.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnComponentsSave.Image = (Image)resources.GetObject("btnComponentsSave.Image");
            btnComponentsSave.Location = new Point(69, 7);
            btnComponentsSave.Name = "btnComponentsSave";
            btnComponentsSave.Size = new Size(55, 55);
            btnComponentsSave.TabIndex = 7;
            btnComponentsSave.TextAlign = ContentAlignment.MiddleRight;
            btnComponentsSave.UseVisualStyleBackColor = false;
            btnComponentsSave.Click += btnComponentsSave_Click;
            // 
            // btnComponentsCreateNew
            // 
            btnComponentsCreateNew.BackColor = Color.DarkGray;
            btnComponentsCreateNew.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnComponentsCreateNew.FlatAppearance.BorderSize = 0;
            btnComponentsCreateNew.FlatStyle = FlatStyle.Flat;
            btnComponentsCreateNew.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnComponentsCreateNew.Image = Properties.Resources.bearbeitensml;
            btnComponentsCreateNew.Location = new Point(8, 7);
            btnComponentsCreateNew.Name = "btnComponentsCreateNew";
            btnComponentsCreateNew.Size = new Size(55, 55);
            btnComponentsCreateNew.TabIndex = 6;
            btnComponentsCreateNew.TextAlign = ContentAlignment.MiddleRight;
            btnComponentsCreateNew.UseVisualStyleBackColor = false;
            btnComponentsCreateNew.Click += btnComponentsCreateNew_Click;
            // 
            // dgvComponents
            // 
            dgvComponents.AllowUserToAddRows = false;
            dgvComponents.AllowUserToDeleteRows = false;
            dgvComponents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComponents.BackgroundColor = Color.DarkGray;
            dgvComponents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComponents.Location = new Point(8, 67);
            dgvComponents.Name = "dgvComponents";
            dgvComponents.RowTemplate.Height = 25;
            dgvComponents.Size = new Size(952, 598);
            dgvComponents.TabIndex = 0;
            dgvComponents.CellValueChanged += dgvComponents_CellValueChanged;
            // 
            // pnlAlarms
            // 
            pnlAlarms.BackColor = Color.LightGray;
            pnlAlarms.Controls.Add(btnAlmGroupDel);
            pnlAlarms.Controls.Add(btnAlmGroupAdd);
            pnlAlarms.Controls.Add(lblAlarmGroups);
            pnlAlarms.Controls.Add(dgvAlarmGroups);
            pnlAlarms.Controls.Add(rdbAlmMemSelMix);
            pnlAlarms.Controls.Add(rdbAlmMemSelHex);
            pnlAlarms.Controls.Add(rdbAlmMemSelDec);
            pnlAlarms.Controls.Add(lblAlmSize);
            pnlAlarms.Controls.Add(txtAlmSize);
            pnlAlarms.Controls.Add(btnAlmRefresh);
            pnlAlarms.Controls.Add(lblAlmStartAdr);
            pnlAlarms.Controls.Add(txtAlmStartAddr);
            pnlAlarms.Controls.Add(lblAlmMemArea);
            pnlAlarms.Controls.Add(txtAlmMemArea);
            pnlAlarms.Controls.Add(dgvAlarms);
            pnlAlarms.Location = new Point(4, 84);
            pnlAlarms.Name = "pnlAlarms";
            pnlAlarms.Size = new Size(1176, 672);
            pnlAlarms.TabIndex = 7;
            // 
            // btnAlmGroupDel
            // 
            btnAlmGroupDel.BackColor = Color.DarkGray;
            btnAlmGroupDel.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnAlmGroupDel.FlatAppearance.BorderSize = 0;
            btnAlmGroupDel.FlatStyle = FlatStyle.Flat;
            btnAlmGroupDel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlmGroupDel.Image = (Image)resources.GetObject("btnAlmGroupDel.Image");
            btnAlmGroupDel.Location = new Point(1040, 84);
            btnAlmGroupDel.Name = "btnAlmGroupDel";
            btnAlmGroupDel.Size = new Size(55, 55);
            btnAlmGroupDel.TabIndex = 37;
            btnAlmGroupDel.TextAlign = ContentAlignment.MiddleRight;
            btnAlmGroupDel.UseVisualStyleBackColor = false;
            btnAlmGroupDel.Click += btnAlmGroupDel_Click;
            // 
            // btnAlmGroupAdd
            // 
            btnAlmGroupAdd.BackColor = Color.DarkGray;
            btnAlmGroupAdd.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnAlmGroupAdd.FlatAppearance.BorderSize = 0;
            btnAlmGroupAdd.FlatStyle = FlatStyle.Flat;
            btnAlmGroupAdd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlmGroupAdd.Image = (Image)resources.GetObject("btnAlmGroupAdd.Image");
            btnAlmGroupAdd.Location = new Point(1101, 84);
            btnAlmGroupAdd.Name = "btnAlmGroupAdd";
            btnAlmGroupAdd.Size = new Size(55, 55);
            btnAlmGroupAdd.TabIndex = 36;
            btnAlmGroupAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAlmGroupAdd.UseVisualStyleBackColor = false;
            btnAlmGroupAdd.Click += btnAlmGroupAdd_Click;
            // 
            // lblAlarmGroups
            // 
            lblAlarmGroups.AutoSize = true;
            lblAlarmGroups.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlarmGroups.Location = new Point(893, 116);
            lblAlarmGroups.Name = "lblAlarmGroups";
            lblAlarmGroups.Size = new Size(116, 23);
            lblAlarmGroups.TabIndex = 35;
            lblAlarmGroups.Text = "Alarm Groups";
            // 
            // dgvAlarmGroups
            // 
            dgvAlarmGroups.AllowUserToAddRows = false;
            dgvAlarmGroups.AllowUserToDeleteRows = false;
            dgvAlarmGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlarmGroups.Location = new Point(737, 142);
            dgvAlarmGroups.Name = "dgvAlarmGroups";
            dgvAlarmGroups.RowTemplate.Height = 25;
            dgvAlarmGroups.Size = new Size(419, 271);
            dgvAlarmGroups.TabIndex = 34;
            dgvAlarmGroups.CellValueChanged += dgvAlarmGroups_CellValueChanged;
            // 
            // rdbAlmMemSelMix
            // 
            rdbAlmMemSelMix.AutoSize = true;
            rdbAlmMemSelMix.Location = new Point(607, 53);
            rdbAlmMemSelMix.Name = "rdbAlmMemSelMix";
            rdbAlmMemSelMix.Size = new Size(144, 19);
            rdbAlmMemSelMix.TabIndex = 33;
            rdbAlmMemSelMix.TabStop = true;
            rdbAlmMemSelMix.Text = "Mixed Address System";
            rdbAlmMemSelMix.UseVisualStyleBackColor = true;
            rdbAlmMemSelMix.CheckedChanged += rdbSelectionChanged;
            // 
            // rdbAlmMemSelHex
            // 
            rdbAlmMemSelHex.AutoSize = true;
            rdbAlmMemSelHex.Location = new Point(607, 32);
            rdbAlmMemSelHex.Name = "rdbAlmMemSelHex";
            rdbAlmMemSelHex.Size = new Size(180, 19);
            rdbAlmMemSelHex.TabIndex = 32;
            rdbAlmMemSelHex.TabStop = true;
            rdbAlmMemSelHex.Text = "Hexadecimal Address System";
            rdbAlmMemSelHex.UseVisualStyleBackColor = true;
            rdbAlmMemSelHex.CheckedChanged += rdbSelectionChanged;
            // 
            // rdbAlmMemSelDec
            // 
            rdbAlmMemSelDec.AutoSize = true;
            rdbAlmMemSelDec.Location = new Point(607, 11);
            rdbAlmMemSelDec.Name = "rdbAlmMemSelDec";
            rdbAlmMemSelDec.Size = new Size(154, 19);
            rdbAlmMemSelDec.TabIndex = 31;
            rdbAlmMemSelDec.TabStop = true;
            rdbAlmMemSelDec.Text = "Decimal Address System";
            rdbAlmMemSelDec.UseVisualStyleBackColor = true;
            rdbAlmMemSelDec.CheckedChanged += rdbSelectionChanged;
            // 
            // lblAlmSize
            // 
            lblAlmSize.AutoSize = true;
            lblAlmSize.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlmSize.Location = new Point(358, 15);
            lblAlmSize.Name = "lblAlmSize";
            lblAlmSize.Size = new Size(175, 23);
            lblAlmSize.TabIndex = 30;
            lblAlmSize.Text = "Alarm Area Size [bits]";
            // 
            // txtAlmSize
            // 
            txtAlmSize.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlmSize.Location = new Point(358, 40);
            txtAlmSize.Name = "txtAlmSize";
            txtAlmSize.Size = new Size(205, 30);
            txtAlmSize.TabIndex = 29;
            // 
            // btnAlmRefresh
            // 
            btnAlmRefresh.BackColor = Color.DarkGray;
            btnAlmRefresh.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnAlmRefresh.FlatAppearance.BorderSize = 0;
            btnAlmRefresh.FlatStyle = FlatStyle.Flat;
            btnAlmRefresh.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlmRefresh.Image = (Image)resources.GetObject("btnAlmRefresh.Image");
            btnAlmRefresh.Location = new Point(793, 15);
            btnAlmRefresh.Name = "btnAlmRefresh";
            btnAlmRefresh.Size = new Size(55, 55);
            btnAlmRefresh.TabIndex = 28;
            btnAlmRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnAlmRefresh.UseVisualStyleBackColor = false;
            btnAlmRefresh.Click += btnAlmRefresh_Click;
            // 
            // lblAlmStartAdr
            // 
            lblAlmStartAdr.AutoSize = true;
            lblAlmStartAdr.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlmStartAdr.Location = new Point(141, 15);
            lblAlmStartAdr.Name = "lblAlmStartAdr";
            lblAlmStartAdr.Size = new Size(206, 23);
            lblAlmStartAdr.TabIndex = 25;
            lblAlmStartAdr.Text = "Start Address [Bitaddress]";
            // 
            // txtAlmStartAddr
            // 
            txtAlmStartAddr.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlmStartAddr.Location = new Point(141, 40);
            txtAlmStartAddr.Name = "txtAlmStartAddr";
            txtAlmStartAddr.Size = new Size(205, 30);
            txtAlmStartAddr.TabIndex = 24;
            // 
            // lblAlmMemArea
            // 
            lblAlmMemArea.AutoSize = true;
            lblAlmMemArea.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlmMemArea.Location = new Point(18, 15);
            lblAlmMemArea.Name = "lblAlmMemArea";
            lblAlmMemArea.Size = new Size(115, 23);
            lblAlmMemArea.TabIndex = 23;
            lblAlmMemArea.Text = "Memory Area";
            // 
            // txtAlmMemArea
            // 
            txtAlmMemArea.Font = new Font("Malgun Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlmMemArea.Location = new Point(18, 41);
            txtAlmMemArea.Name = "txtAlmMemArea";
            txtAlmMemArea.Size = new Size(115, 30);
            txtAlmMemArea.TabIndex = 22;
            // 
            // dgvAlarms
            // 
            dgvAlarms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlarms.Location = new Point(18, 84);
            dgvAlarms.Name = "dgvAlarms";
            dgvAlarms.RowTemplate.Height = 25;
            dgvAlarms.Size = new Size(713, 571);
            dgvAlarms.TabIndex = 0;
            // 
            // pnlExports
            // 
            pnlExports.BackColor = Color.LightGray;
            pnlExports.Location = new Point(4, 84);
            pnlExports.Name = "pnlExports";
            pnlExports.Size = new Size(1176, 672);
            pnlExports.TabIndex = 8;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1184, 761);
            Controls.Add(btnNavComponents);
            Controls.Add(button4);
            Controls.Add(btnNavExports);
            Controls.Add(btnNavAlarms);
            Controls.Add(btnNavLibrary);
            Controls.Add(pnlAlarms);
            Controls.Add(pnlComponents);
            Controls.Add(pnlLibrary);
            Controls.Add(pnlExports);
            Name = "MainWindow";
            ShowIcon = false;
            Text = "Form1";
            pnlLibrary.ResumeLayout(false);
            pnlLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibraryAlarms).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibraryParameters).EndInit();
            pnlComponents.ResumeLayout(false);
            pnlComponents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvComponents).EndInit();
            pnlAlarms.ResumeLayout(false);
            pnlAlarms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlarmGroups).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlarms).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNavComponents;
        private Panel pnlLibrary;
        private Button btnNavLibrary;
        private Button btnNavAlarms;
        private Button btnNavExports;
        private Button button4;
        private Panel pnlComponents;
        private Button btnComponentsCreateNew;
        private DataGridView dgvComponents;
        private Button btnComponentLoad;
        private Button btnComponentsSave;
        private Button btnLibraryOpenFile;
        private Button btnLibrarySaveFile;
        private Button btnLibraryCreateFb;
        private Button btnLibraryTest;
        private Button btnLibrarySaveFileAs;
        private Label lblLibraryFbName;
        private TextBox txtLibraryFbName;
        private Label lblLibraryFbDescription;
        private TextBox txtLibraryDescription;
        private Label lblLibrarySize;
        private TextBox txtLibrarySize;
        private Button btnLibraryViewParameters;
        private Button btnLibraryViewAlarms;
        private DataGridView dgvLibraryParameters;
        private Button btnLibraryAddParameter;
        private DataGridView dgvLibraryAlarms;
        private Button btnLibraryAddAlarm;
        private ListView lvLibraryFunctionblocks;
        private ColumnHeader colLibviewBugged;
        private ColumnHeader colLibviewName;
        private Button btnLibraryDeleteAlarm;
        private Button btnLibraryDeleteParameter;
        private Button btnComponentAdd;
        private Panel pnlAlarms;
        private Panel pnlExports;
        private DataGridView dgvAlarms;
        private Label lblAlmStartAdr;
        private TextBox txtAlmStartAddr;
        private Label lblAlmMemArea;
        private TextBox txtAlmMemArea;
        private Button btnAlmRefresh;
        private Label lblAlmSize;
        private TextBox txtAlmSize;
        private DataGridView dgvCompUnits;
        private Label lblCompUnits;
        private RadioButton rdbAlmMemSelMix;
        private RadioButton rdbAlmMemSelHex;
        private RadioButton rdbAlmMemSelDec;
        private Label lblAlarmGroups;
        private DataGridView dgvAlarmGroups;
        private Button btnAlmGroupDel;
        private Button btnAlmGroupAdd;
        private Button btnComponentsDel;
    }
}