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
            this.btnNavComponents = new System.Windows.Forms.Button();
            this.pnlLibrary = new System.Windows.Forms.Panel();
            this.btnLibraryDeleteParameter = new System.Windows.Forms.Button();
            this.btnLibraryDeleteAlarm = new System.Windows.Forms.Button();
            this.lvLibraryFunctionblocks = new System.Windows.Forms.ListView();
            this.colLibviewBugged = new System.Windows.Forms.ColumnHeader();
            this.colLibviewName = new System.Windows.Forms.ColumnHeader();
            this.dgvLibraryAlarms = new System.Windows.Forms.DataGridView();
            this.btnLibraryAddAlarm = new System.Windows.Forms.Button();
            this.btnLibraryAddParameter = new System.Windows.Forms.Button();
            this.btnLibraryViewParameters = new System.Windows.Forms.Button();
            this.btnLibraryViewAlarms = new System.Windows.Forms.Button();
            this.dgvLibraryParameters = new System.Windows.Forms.DataGridView();
            this.lblLibraryFbDescription = new System.Windows.Forms.Label();
            this.txtLibraryDescription = new System.Windows.Forms.TextBox();
            this.lblLibrarySize = new System.Windows.Forms.Label();
            this.txtLibrarySize = new System.Windows.Forms.TextBox();
            this.lblLibraryFbName = new System.Windows.Forms.Label();
            this.txtLibraryFbName = new System.Windows.Forms.TextBox();
            this.btnLibrarySaveFileAs = new System.Windows.Forms.Button();
            this.btnLibraryTest = new System.Windows.Forms.Button();
            this.btnLibraryOpenFile = new System.Windows.Forms.Button();
            this.btnLibrarySaveFile = new System.Windows.Forms.Button();
            this.btnLibraryCreateFb = new System.Windows.Forms.Button();
            this.btnNavLibrary = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlComponents = new System.Windows.Forms.Panel();
            this.btnComponentLoad = new System.Windows.Forms.Button();
            this.btnComponentsSave = new System.Windows.Forms.Button();
            this.btnComponentsCreateNew = new System.Windows.Forms.Button();
            this.dgvComponents = new System.Windows.Forms.DataGridView();
            this.pnlLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibraryAlarms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibraryParameters)).BeginInit();
            this.pnlComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNavComponents
            // 
            this.btnNavComponents.BackColor = System.Drawing.Color.DarkGray;
            this.btnNavComponents.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNavComponents.FlatAppearance.BorderSize = 2;
            this.btnNavComponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavComponents.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavComponents.Image = ((System.Drawing.Image)(resources.GetObject("btnNavComponents.Image")));
            this.btnNavComponents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavComponents.Location = new System.Drawing.Point(4, 4);
            this.btnNavComponents.Name = "btnNavComponents";
            this.btnNavComponents.Size = new System.Drawing.Size(160, 78);
            this.btnNavComponents.TabIndex = 0;
            this.btnNavComponents.Text = "Components";
            this.btnNavComponents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNavComponents.UseVisualStyleBackColor = false;
            this.btnNavComponents.Click += new System.EventHandler(this.btnNavComponents_Click);
            // 
            // pnlLibrary
            // 
            this.pnlLibrary.BackColor = System.Drawing.Color.LightGray;
            this.pnlLibrary.Controls.Add(this.btnLibraryDeleteParameter);
            this.pnlLibrary.Controls.Add(this.btnLibraryDeleteAlarm);
            this.pnlLibrary.Controls.Add(this.lvLibraryFunctionblocks);
            this.pnlLibrary.Controls.Add(this.dgvLibraryAlarms);
            this.pnlLibrary.Controls.Add(this.btnLibraryAddAlarm);
            this.pnlLibrary.Controls.Add(this.btnLibraryAddParameter);
            this.pnlLibrary.Controls.Add(this.btnLibraryViewParameters);
            this.pnlLibrary.Controls.Add(this.btnLibraryViewAlarms);
            this.pnlLibrary.Controls.Add(this.dgvLibraryParameters);
            this.pnlLibrary.Controls.Add(this.lblLibraryFbDescription);
            this.pnlLibrary.Controls.Add(this.txtLibraryDescription);
            this.pnlLibrary.Controls.Add(this.lblLibrarySize);
            this.pnlLibrary.Controls.Add(this.txtLibrarySize);
            this.pnlLibrary.Controls.Add(this.lblLibraryFbName);
            this.pnlLibrary.Controls.Add(this.txtLibraryFbName);
            this.pnlLibrary.Controls.Add(this.btnLibrarySaveFileAs);
            this.pnlLibrary.Controls.Add(this.btnLibraryTest);
            this.pnlLibrary.Controls.Add(this.btnLibraryOpenFile);
            this.pnlLibrary.Controls.Add(this.btnLibrarySaveFile);
            this.pnlLibrary.Controls.Add(this.btnLibraryCreateFb);
            this.pnlLibrary.Location = new System.Drawing.Point(4, 84);
            this.pnlLibrary.Name = "pnlLibrary";
            this.pnlLibrary.Size = new System.Drawing.Size(1176, 672);
            this.pnlLibrary.TabIndex = 1;
            // 
            // btnLibraryDeleteParameter
            // 
            this.btnLibraryDeleteParameter.BackColor = System.Drawing.Color.DarkGray;
            this.btnLibraryDeleteParameter.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLibraryDeleteParameter.FlatAppearance.BorderSize = 0;
            this.btnLibraryDeleteParameter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryDeleteParameter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLibraryDeleteParameter.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryDeleteParameter.Image")));
            this.btnLibraryDeleteParameter.Location = new System.Drawing.Point(1020, 362);
            this.btnLibraryDeleteParameter.Name = "btnLibraryDeleteParameter";
            this.btnLibraryDeleteParameter.Size = new System.Drawing.Size(55, 55);
            this.btnLibraryDeleteParameter.TabIndex = 30;
            this.btnLibraryDeleteParameter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibraryDeleteParameter.UseVisualStyleBackColor = false;
            this.btnLibraryDeleteParameter.Click += new System.EventHandler(this.btnLibraryDeleteParameter_Click);
            // 
            // btnLibraryDeleteAlarm
            // 
            this.btnLibraryDeleteAlarm.BackColor = System.Drawing.Color.DarkGray;
            this.btnLibraryDeleteAlarm.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLibraryDeleteAlarm.FlatAppearance.BorderSize = 0;
            this.btnLibraryDeleteAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryDeleteAlarm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLibraryDeleteAlarm.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryDeleteAlarm.Image")));
            this.btnLibraryDeleteAlarm.Location = new System.Drawing.Point(1020, 90);
            this.btnLibraryDeleteAlarm.Name = "btnLibraryDeleteAlarm";
            this.btnLibraryDeleteAlarm.Size = new System.Drawing.Size(55, 55);
            this.btnLibraryDeleteAlarm.TabIndex = 29;
            this.btnLibraryDeleteAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibraryDeleteAlarm.UseVisualStyleBackColor = false;
            this.btnLibraryDeleteAlarm.Click += new System.EventHandler(this.btnLibraryDeleteAlarm_Click);
            // 
            // lvLibraryFunctionblocks
            // 
            this.lvLibraryFunctionblocks.CausesValidation = false;
            this.lvLibraryFunctionblocks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLibviewBugged,
            this.colLibviewName});
            this.lvLibraryFunctionblocks.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvLibraryFunctionblocks.FullRowSelect = true;
            this.lvLibraryFunctionblocks.GridLines = true;
            this.lvLibraryFunctionblocks.Location = new System.Drawing.Point(30, 152);
            this.lvLibraryFunctionblocks.MultiSelect = false;
            this.lvLibraryFunctionblocks.Name = "lvLibraryFunctionblocks";
            this.lvLibraryFunctionblocks.Size = new System.Drawing.Size(290, 489);
            this.lvLibraryFunctionblocks.TabIndex = 28;
            this.lvLibraryFunctionblocks.TileSize = new System.Drawing.Size(290, 40);
            this.lvLibraryFunctionblocks.UseCompatibleStateImageBehavior = false;
            this.lvLibraryFunctionblocks.View = System.Windows.Forms.View.List;
            this.lvLibraryFunctionblocks.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvLibraryFunctionblocks_ItemSelectionChanged);
            // 
            // colLibviewBugged
            // 
            this.colLibviewBugged.Width = 0;
            // 
            // colLibviewName
            // 
            this.colLibviewName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colLibviewName.Width = 290;
            // 
            // dgvLibraryAlarms
            // 
            this.dgvLibraryAlarms.AllowUserToAddRows = false;
            this.dgvLibraryAlarms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLibraryAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibraryAlarms.Location = new System.Drawing.Point(362, 152);
            this.dgvLibraryAlarms.MultiSelect = false;
            this.dgvLibraryAlarms.Name = "dgvLibraryAlarms";
            this.dgvLibraryAlarms.RowTemplate.Height = 25;
            this.dgvLibraryAlarms.Size = new System.Drawing.Size(774, 204);
            this.dgvLibraryAlarms.TabIndex = 27;
            this.dgvLibraryAlarms.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibraryAlarms_CellValueChanged);
            // 
            // btnLibraryAddAlarm
            // 
            this.btnLibraryAddAlarm.BackColor = System.Drawing.Color.DarkGray;
            this.btnLibraryAddAlarm.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLibraryAddAlarm.FlatAppearance.BorderSize = 0;
            this.btnLibraryAddAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryAddAlarm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLibraryAddAlarm.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryAddAlarm.Image")));
            this.btnLibraryAddAlarm.Location = new System.Drawing.Point(1081, 91);
            this.btnLibraryAddAlarm.Name = "btnLibraryAddAlarm";
            this.btnLibraryAddAlarm.Size = new System.Drawing.Size(55, 55);
            this.btnLibraryAddAlarm.TabIndex = 26;
            this.btnLibraryAddAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibraryAddAlarm.UseVisualStyleBackColor = false;
            this.btnLibraryAddAlarm.Click += new System.EventHandler(this.btnLibraryAddAlarm_Click);
            // 
            // btnLibraryAddParameter
            // 
            this.btnLibraryAddParameter.BackColor = System.Drawing.Color.DarkGray;
            this.btnLibraryAddParameter.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLibraryAddParameter.FlatAppearance.BorderSize = 0;
            this.btnLibraryAddParameter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryAddParameter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLibraryAddParameter.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryAddParameter.Image")));
            this.btnLibraryAddParameter.Location = new System.Drawing.Point(1081, 362);
            this.btnLibraryAddParameter.Name = "btnLibraryAddParameter";
            this.btnLibraryAddParameter.Size = new System.Drawing.Size(55, 55);
            this.btnLibraryAddParameter.TabIndex = 25;
            this.btnLibraryAddParameter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibraryAddParameter.UseVisualStyleBackColor = false;
            this.btnLibraryAddParameter.Click += new System.EventHandler(this.btnLibraryAddParameter_Click);
            // 
            // btnLibraryViewParameters
            // 
            this.btnLibraryViewParameters.BackColor = System.Drawing.Color.DarkGray;
            this.btnLibraryViewParameters.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLibraryViewParameters.FlatAppearance.BorderSize = 0;
            this.btnLibraryViewParameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryViewParameters.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLibraryViewParameters.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryViewParameters.Image")));
            this.btnLibraryViewParameters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibraryViewParameters.Location = new System.Drawing.Point(362, 362);
            this.btnLibraryViewParameters.Name = "btnLibraryViewParameters";
            this.btnLibraryViewParameters.Size = new System.Drawing.Size(148, 55);
            this.btnLibraryViewParameters.TabIndex = 24;
            this.btnLibraryViewParameters.Text = "Parameters";
            this.btnLibraryViewParameters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibraryViewParameters.UseVisualStyleBackColor = false;
            // 
            // btnLibraryViewAlarms
            // 
            this.btnLibraryViewAlarms.BackColor = System.Drawing.Color.DarkGray;
            this.btnLibraryViewAlarms.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLibraryViewAlarms.FlatAppearance.BorderSize = 0;
            this.btnLibraryViewAlarms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryViewAlarms.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLibraryViewAlarms.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryViewAlarms.Image")));
            this.btnLibraryViewAlarms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibraryViewAlarms.Location = new System.Drawing.Point(362, 91);
            this.btnLibraryViewAlarms.Name = "btnLibraryViewAlarms";
            this.btnLibraryViewAlarms.Size = new System.Drawing.Size(148, 55);
            this.btnLibraryViewAlarms.TabIndex = 23;
            this.btnLibraryViewAlarms.Text = "Alarms";
            this.btnLibraryViewAlarms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibraryViewAlarms.UseVisualStyleBackColor = false;
            // 
            // dgvLibraryParameters
            // 
            this.dgvLibraryParameters.AllowUserToAddRows = false;
            this.dgvLibraryParameters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLibraryParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibraryParameters.Location = new System.Drawing.Point(362, 423);
            this.dgvLibraryParameters.MultiSelect = false;
            this.dgvLibraryParameters.Name = "dgvLibraryParameters";
            this.dgvLibraryParameters.RowTemplate.Height = 25;
            this.dgvLibraryParameters.Size = new System.Drawing.Size(774, 218);
            this.dgvLibraryParameters.TabIndex = 22;
            this.dgvLibraryParameters.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibraryParameters_CellValueChanged);
            // 
            // lblLibraryFbDescription
            // 
            this.lblLibraryFbDescription.AutoSize = true;
            this.lblLibraryFbDescription.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLibraryFbDescription.Location = new System.Drawing.Point(784, 29);
            this.lblLibraryFbDescription.Name = "lblLibraryFbDescription";
            this.lblLibraryFbDescription.Size = new System.Drawing.Size(96, 23);
            this.lblLibraryFbDescription.TabIndex = 21;
            this.lblLibraryFbDescription.Text = "Description";
            // 
            // txtLibraryDescription
            // 
            this.txtLibraryDescription.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLibraryDescription.Location = new System.Drawing.Point(784, 54);
            this.txtLibraryDescription.Name = "txtLibraryDescription";
            this.txtLibraryDescription.Size = new System.Drawing.Size(352, 30);
            this.txtLibraryDescription.TabIndex = 20;
            this.txtLibraryDescription.TextChanged += new System.EventHandler(this.txtLibraryDescription_TextChanged);
            // 
            // lblLibrarySize
            // 
            this.lblLibrarySize.AutoSize = true;
            this.lblLibrarySize.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLibrarySize.Location = new System.Drawing.Point(573, 28);
            this.lblLibrarySize.Name = "lblLibrarySize";
            this.lblLibrarySize.Size = new System.Drawing.Size(40, 23);
            this.lblLibrarySize.TabIndex = 19;
            this.lblLibrarySize.Text = "Size";
            // 
            // txtLibrarySize
            // 
            this.txtLibrarySize.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLibrarySize.Location = new System.Drawing.Point(573, 54);
            this.txtLibrarySize.Name = "txtLibrarySize";
            this.txtLibrarySize.Size = new System.Drawing.Size(205, 30);
            this.txtLibrarySize.TabIndex = 18;
            this.txtLibrarySize.TextChanged += new System.EventHandler(this.txtLibrarySize_TextChanged);
            // 
            // lblLibraryFbName
            // 
            this.lblLibraryFbName.AutoSize = true;
            this.lblLibraryFbName.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLibraryFbName.Location = new System.Drawing.Point(362, 29);
            this.lblLibraryFbName.Name = "lblLibraryFbName";
            this.lblLibraryFbName.Size = new System.Drawing.Size(56, 23);
            this.lblLibraryFbName.TabIndex = 17;
            this.lblLibraryFbName.Text = "Name";
            // 
            // txtLibraryFbName
            // 
            this.txtLibraryFbName.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLibraryFbName.Location = new System.Drawing.Point(362, 55);
            this.txtLibraryFbName.Name = "txtLibraryFbName";
            this.txtLibraryFbName.Size = new System.Drawing.Size(205, 30);
            this.txtLibraryFbName.TabIndex = 16;
            this.txtLibraryFbName.TextChanged += new System.EventHandler(this.txtLibraryFbName_TextChanged);
            // 
            // btnLibrarySaveFileAs
            // 
            this.btnLibrarySaveFileAs.BackColor = System.Drawing.Color.DarkGray;
            this.btnLibrarySaveFileAs.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLibrarySaveFileAs.FlatAppearance.BorderSize = 0;
            this.btnLibrarySaveFileAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrarySaveFileAs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLibrarySaveFileAs.Image = ((System.Drawing.Image)(resources.GetObject("btnLibrarySaveFileAs.Image")));
            this.btnLibrarySaveFileAs.Location = new System.Drawing.Point(92, 30);
            this.btnLibrarySaveFileAs.Name = "btnLibrarySaveFileAs";
            this.btnLibrarySaveFileAs.Size = new System.Drawing.Size(55, 55);
            this.btnLibrarySaveFileAs.TabIndex = 14;
            this.btnLibrarySaveFileAs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibrarySaveFileAs.UseVisualStyleBackColor = false;
            this.btnLibrarySaveFileAs.Click += new System.EventHandler(this.btnLibrarySaveFileAs_Click);
            // 
            // btnLibraryTest
            // 
            this.btnLibraryTest.BackColor = System.Drawing.Color.DarkGray;
            this.btnLibraryTest.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLibraryTest.FlatAppearance.BorderSize = 0;
            this.btnLibraryTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryTest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLibraryTest.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryTest.Image")));
            this.btnLibraryTest.Location = new System.Drawing.Point(265, 30);
            this.btnLibraryTest.Name = "btnLibraryTest";
            this.btnLibraryTest.Size = new System.Drawing.Size(55, 55);
            this.btnLibraryTest.TabIndex = 13;
            this.btnLibraryTest.Text = "Test";
            this.btnLibraryTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibraryTest.UseVisualStyleBackColor = false;
            this.btnLibraryTest.Click += new System.EventHandler(this.btnLibraryTest_Click);
            // 
            // btnLibraryOpenFile
            // 
            this.btnLibraryOpenFile.BackColor = System.Drawing.Color.DarkGray;
            this.btnLibraryOpenFile.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLibraryOpenFile.FlatAppearance.BorderSize = 0;
            this.btnLibraryOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryOpenFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLibraryOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryOpenFile.Image")));
            this.btnLibraryOpenFile.Location = new System.Drawing.Point(153, 30);
            this.btnLibraryOpenFile.Name = "btnLibraryOpenFile";
            this.btnLibraryOpenFile.Size = new System.Drawing.Size(55, 55);
            this.btnLibraryOpenFile.TabIndex = 11;
            this.btnLibraryOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibraryOpenFile.UseVisualStyleBackColor = false;
            this.btnLibraryOpenFile.Click += new System.EventHandler(this.btnLibraryOpenFile_Click);
            // 
            // btnLibrarySaveFile
            // 
            this.btnLibrarySaveFile.BackColor = System.Drawing.Color.DarkGray;
            this.btnLibrarySaveFile.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLibrarySaveFile.FlatAppearance.BorderSize = 0;
            this.btnLibrarySaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrarySaveFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLibrarySaveFile.Image = ((System.Drawing.Image)(resources.GetObject("btnLibrarySaveFile.Image")));
            this.btnLibrarySaveFile.Location = new System.Drawing.Point(30, 30);
            this.btnLibrarySaveFile.Name = "btnLibrarySaveFile";
            this.btnLibrarySaveFile.Size = new System.Drawing.Size(55, 55);
            this.btnLibrarySaveFile.TabIndex = 10;
            this.btnLibrarySaveFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibrarySaveFile.UseVisualStyleBackColor = false;
            this.btnLibrarySaveFile.Click += new System.EventHandler(this.btnLibrarySaveFile_Click);
            // 
            // btnLibraryCreateFb
            // 
            this.btnLibraryCreateFb.BackColor = System.Drawing.Color.DarkGray;
            this.btnLibraryCreateFb.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLibraryCreateFb.FlatAppearance.BorderSize = 0;
            this.btnLibraryCreateFb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryCreateFb.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLibraryCreateFb.Image = global::TagTool.Properties.Resources.bearbeitensml;
            this.btnLibraryCreateFb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibraryCreateFb.Location = new System.Drawing.Point(30, 91);
            this.btnLibraryCreateFb.Name = "btnLibraryCreateFb";
            this.btnLibraryCreateFb.Size = new System.Drawing.Size(213, 55);
            this.btnLibraryCreateFb.TabIndex = 9;
            this.btnLibraryCreateFb.Text = "New Functionblock";
            this.btnLibraryCreateFb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibraryCreateFb.UseVisualStyleBackColor = false;
            this.btnLibraryCreateFb.Click += new System.EventHandler(this.btnLibraryCreateFb_Click);
            // 
            // btnNavLibrary
            // 
            this.btnNavLibrary.BackColor = System.Drawing.Color.LightGray;
            this.btnNavLibrary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNavLibrary.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNavLibrary.FlatAppearance.BorderSize = 2;
            this.btnNavLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLibrary.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavLibrary.Image = global::TagTool.Properties.Resources.folder38px;
            this.btnNavLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLibrary.Location = new System.Drawing.Point(170, 4);
            this.btnNavLibrary.Name = "btnNavLibrary";
            this.btnNavLibrary.Size = new System.Drawing.Size(160, 82);
            this.btnNavLibrary.TabIndex = 2;
            this.btnNavLibrary.Text = "FB Library";
            this.btnNavLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNavLibrary.UseVisualStyleBackColor = false;
            this.btnNavLibrary.Click += new System.EventHandler(this.btnNavLibrary_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(336, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 78);
            this.button2.TabIndex = 3;
            this.button2.Text = "Components";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(502, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 78);
            this.button3.TabIndex = 4;
            this.button3.Text = "Components";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Malgun Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(668, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 78);
            this.button4.TabIndex = 5;
            this.button4.Text = "Components";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pnlComponents
            // 
            this.pnlComponents.BackColor = System.Drawing.Color.LightGray;
            this.pnlComponents.Controls.Add(this.btnComponentLoad);
            this.pnlComponents.Controls.Add(this.btnComponentsSave);
            this.pnlComponents.Controls.Add(this.btnComponentsCreateNew);
            this.pnlComponents.Controls.Add(this.dgvComponents);
            this.pnlComponents.Location = new System.Drawing.Point(4, 84);
            this.pnlComponents.Name = "pnlComponents";
            this.pnlComponents.Size = new System.Drawing.Size(1176, 672);
            this.pnlComponents.TabIndex = 6;
            // 
            // btnComponentLoad
            // 
            this.btnComponentLoad.BackColor = System.Drawing.Color.DarkGray;
            this.btnComponentLoad.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnComponentLoad.FlatAppearance.BorderSize = 0;
            this.btnComponentLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComponentLoad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComponentLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnComponentLoad.Image")));
            this.btnComponentLoad.Location = new System.Drawing.Point(130, 7);
            this.btnComponentLoad.Name = "btnComponentLoad";
            this.btnComponentLoad.Size = new System.Drawing.Size(55, 55);
            this.btnComponentLoad.TabIndex = 8;
            this.btnComponentLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComponentLoad.UseVisualStyleBackColor = false;
            // 
            // btnComponentsSave
            // 
            this.btnComponentsSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnComponentsSave.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnComponentsSave.FlatAppearance.BorderSize = 0;
            this.btnComponentsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComponentsSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComponentsSave.Image = ((System.Drawing.Image)(resources.GetObject("btnComponentsSave.Image")));
            this.btnComponentsSave.Location = new System.Drawing.Point(69, 7);
            this.btnComponentsSave.Name = "btnComponentsSave";
            this.btnComponentsSave.Size = new System.Drawing.Size(55, 55);
            this.btnComponentsSave.TabIndex = 7;
            this.btnComponentsSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComponentsSave.UseVisualStyleBackColor = false;
            // 
            // btnComponentsCreateNew
            // 
            this.btnComponentsCreateNew.BackColor = System.Drawing.Color.DarkGray;
            this.btnComponentsCreateNew.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnComponentsCreateNew.FlatAppearance.BorderSize = 0;
            this.btnComponentsCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComponentsCreateNew.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComponentsCreateNew.Image = global::TagTool.Properties.Resources.bearbeitensml;
            this.btnComponentsCreateNew.Location = new System.Drawing.Point(8, 7);
            this.btnComponentsCreateNew.Name = "btnComponentsCreateNew";
            this.btnComponentsCreateNew.Size = new System.Drawing.Size(55, 55);
            this.btnComponentsCreateNew.TabIndex = 6;
            this.btnComponentsCreateNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComponentsCreateNew.UseVisualStyleBackColor = false;
            // 
            // dgvComponents
            // 
            this.dgvComponents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComponents.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponents.Location = new System.Drawing.Point(8, 67);
            this.dgvComponents.Name = "dgvComponents";
            this.dgvComponents.RowTemplate.Height = 25;
            this.dgvComponents.Size = new System.Drawing.Size(952, 598);
            this.dgvComponents.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnNavComponents);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNavLibrary);
            this.Controls.Add(this.pnlComponents);
            this.Controls.Add(this.pnlLibrary);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.pnlLibrary.ResumeLayout(false);
            this.pnlLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibraryAlarms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibraryParameters)).EndInit();
            this.pnlComponents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNavComponents;
        private Panel pnlLibrary;
        private Button btnNavLibrary;
        private Button button2;
        private Button button3;
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
    }
}