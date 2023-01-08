using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TagTool.Services;

namespace TagTool
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Navigation Button handling

        private void btnNavComponents_Click(object sender, EventArgs e)
        {
            ResetAllNavBtn();
            this.btnNavComponents = FormsHelper.NavBtnSelect(this.btnNavComponents);
            this.pnlComponents.BringToFront();
            
        }

        private void btnNavLibrary_Click(object sender, EventArgs e)
        {
            ResetAllNavBtn();
            this.btnNavLibrary = FormsHelper.NavBtnSelect(this.btnNavLibrary);
            this.pnlLibrary.BringToFront();
        }

        private void ResetAllNavBtn()
        {
            this.btnNavComponents = FormsHelper.NavBtnDeselect(this.btnNavComponents);
            this.btnNavLibrary = FormsHelper.NavBtnDeselect(this.btnNavLibrary);
            this.button2 = FormsHelper.NavBtnDeselect(this.button2);
            this.button3 = FormsHelper.NavBtnDeselect(this.button3);
            this.button4 = FormsHelper.NavBtnDeselect(this.button4);
        }

        private void pnlComponents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLibraryTest_Click(object sender, EventArgs e)
        {
        }

        private void btnLibraryOpenFile_Click(object sender, EventArgs e)
        {
            string filepath = FormsHelper.CallFileDialog();
            if (filepath != null)
            {
                try
                {
                    JsonHandler.JsonTest();
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        private void btnLibraryCreateFb_Click(object sender, EventArgs e)
        {

        }
    }
}