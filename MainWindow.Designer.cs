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
            this.btnLibraryTest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLibraryOpenFile = new System.Windows.Forms.Button();
            this.btnLibrarySaveFile = new System.Windows.Forms.Button();
            this.btnLibraryCreateNewFile = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNavLibrary = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlComponents = new System.Windows.Forms.Panel();
            this.btnComponentLoad = new System.Windows.Forms.Button();
            this.btnComponentsSave = new System.Windows.Forms.Button();
            this.btnComponentsCreateNew = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pnlLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNavComponents
            // 
            this.btnNavComponents.BackColor = System.Drawing.Color.DarkGray;
            this.btnNavComponents.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNavComponents.FlatAppearance.BorderSize = 2;
            this.btnNavComponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavComponents.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNavComponents.Image = ((System.Drawing.Image)(resources.GetObject("btnNavComponents.Image")));
            this.btnNavComponents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavComponents.Location = new System.Drawing.Point(4, 4);
            this.btnNavComponents.Name = "btnNavComponents";
            this.btnNavComponents.Size = new System.Drawing.Size(148, 78);
            this.btnNavComponents.TabIndex = 0;
            this.btnNavComponents.Text = "Components";
            this.btnNavComponents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNavComponents.UseVisualStyleBackColor = false;
            this.btnNavComponents.Click += new System.EventHandler(this.btnNavComponents_Click);
            // 
            // pnlLibrary
            // 
            this.pnlLibrary.BackColor = System.Drawing.Color.LightGray;
            this.pnlLibrary.Controls.Add(this.btnLibraryTest);
            this.pnlLibrary.Controls.Add(this.textBox1);
            this.pnlLibrary.Controls.Add(this.btnLibraryOpenFile);
            this.pnlLibrary.Controls.Add(this.btnLibrarySaveFile);
            this.pnlLibrary.Controls.Add(this.btnLibraryCreateNewFile);
            this.pnlLibrary.Controls.Add(this.comboBox1);
            this.pnlLibrary.Controls.Add(this.dataGridView1);
            this.pnlLibrary.Location = new System.Drawing.Point(4, 84);
            this.pnlLibrary.Name = "pnlLibrary";
            this.pnlLibrary.Size = new System.Drawing.Size(1176, 672);
            this.pnlLibrary.TabIndex = 1;
            // 
            // btnLibraryTest
            // 
            this.btnLibraryTest.BackColor = System.Drawing.Color.DarkGray;
            this.btnLibraryTest.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLibraryTest.FlatAppearance.BorderSize = 0;
            this.btnLibraryTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryTest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLibraryTest.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryTest.Image")));
            this.btnLibraryTest.Location = new System.Drawing.Point(600, 199);
            this.btnLibraryTest.Name = "btnLibraryTest";
            this.btnLibraryTest.Size = new System.Drawing.Size(55, 55);
            this.btnLibraryTest.TabIndex = 13;
            this.btnLibraryTest.Text = "Test";
            this.btnLibraryTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibraryTest.UseVisualStyleBackColor = false;
            this.btnLibraryTest.Click += new System.EventHandler(this.btnLibraryTest_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(832, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 597);
            this.textBox1.TabIndex = 12;
            // 
            // btnLibraryOpenFile
            // 
            this.btnLibraryOpenFile.BackColor = System.Drawing.Color.DarkGray;
            this.btnLibraryOpenFile.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLibraryOpenFile.FlatAppearance.BorderSize = 0;
            this.btnLibraryOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryOpenFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLibraryOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryOpenFile.Image")));
            this.btnLibraryOpenFile.Location = new System.Drawing.Point(130, 7);
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
            this.btnLibrarySaveFile.Location = new System.Drawing.Point(69, 7);
            this.btnLibrarySaveFile.Name = "btnLibrarySaveFile";
            this.btnLibrarySaveFile.Size = new System.Drawing.Size(55, 55);
            this.btnLibrarySaveFile.TabIndex = 10;
            this.btnLibrarySaveFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibrarySaveFile.UseVisualStyleBackColor = false;
            // 
            // btnLibraryCreateNewFile
            // 
            this.btnLibraryCreateNewFile.BackColor = System.Drawing.Color.DarkGray;
            this.btnLibraryCreateNewFile.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLibraryCreateNewFile.FlatAppearance.BorderSize = 0;
            this.btnLibraryCreateNewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryCreateNewFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLibraryCreateNewFile.Image = global::TagTool.Properties.Resources.bearbeitensml;
            this.btnLibraryCreateNewFile.Location = new System.Drawing.Point(8, 7);
            this.btnLibraryCreateNewFile.Name = "btnLibraryCreateNewFile";
            this.btnLibraryCreateNewFile.Size = new System.Drawing.Size(55, 55);
            this.btnLibraryCreateNewFile.TabIndex = 9;
            this.btnLibraryCreateNewFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibraryCreateNewFile.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1047, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(465, 597);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNavLibrary
            // 
            this.btnNavLibrary.BackColor = System.Drawing.Color.LightGray;
            this.btnNavLibrary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNavLibrary.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNavLibrary.FlatAppearance.BorderSize = 2;
            this.btnNavLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLibrary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNavLibrary.Image = global::TagTool.Properties.Resources.folder38px;
            this.btnNavLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLibrary.Location = new System.Drawing.Point(154, 4);
            this.btnNavLibrary.Name = "btnNavLibrary";
            this.btnNavLibrary.Size = new System.Drawing.Size(148, 82);
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
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(304, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 78);
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
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(454, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 78);
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
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(604, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 78);
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
            this.pnlComponents.Controls.Add(this.dataGridView2);
            this.pnlComponents.Location = new System.Drawing.Point(4, 84);
            this.pnlComponents.Name = "pnlComponents";
            this.pnlComponents.Size = new System.Drawing.Size(1176, 672);
            this.pnlComponents.TabIndex = 6;
            this.pnlComponents.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlComponents_Paint);
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
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(952, 598);
            this.dataGridView2.TabIndex = 0;
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
            this.Controls.Add(this.pnlLibrary);
            this.Controls.Add(this.pnlComponents);
            this.Controls.Add(this.btnNavLibrary);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.pnlLibrary.ResumeLayout(false);
            this.pnlLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlComponents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button btnComponentsCreateNew;
        private DataGridView dataGridView2;
        private Button btnComponentLoad;
        private Button btnComponentsSave;
        private TextBox textBox1;
        private Button btnLibraryOpenFile;
        private Button btnLibrarySaveFile;
        private Button btnLibraryCreateNewFile;
        private Button btnLibraryTest;
    }
}