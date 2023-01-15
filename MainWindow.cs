using System.Diagnostics;
using TagTool.Models;
using TagTool.Services;
using TagTool.ViewModels;
using static System.Net.Mime.MediaTypeNames;

namespace TagTool
{
    public partial class MainWindow : Form
    {
        public string FilePath = "";

        public List<FunctionBlock> FbList = new List<FunctionBlock>();
        public int SelectedFbId = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        //##########################
        //Navigation Button handling
        //##########################
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
        private void btnLibraryTest_Click(object sender, EventArgs e)
        {
        }
        //##########################
        //Libray Panel Handling
        //##########################

        //User/File Interaction
        private void btnLibraryOpenFile_Click(object sender, EventArgs e)
        {
            FilePath = FormsHelper.CallFileDialog();
            if (FilePath != null)
            {
                try
                {
                    FbList = JsonHandler.DeserializeLibrary(FilePath);
                    refreshLibraryListView();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }
        private void btnLibrarySaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                JsonHandler.SerializeLibrary(FbList, FilePath);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        private void btnLibrarySaveFileAs_Click(object sender, EventArgs e)
        {
            FilePath = FormsHelper.CallSaveFileDialog();
            try
            {
                JsonHandler.SerializeLibrary(FbList, FilePath);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        //User FbList interaction
        private void btnLibraryCreateFb_Click(object sender, EventArgs e)
        {
            FbList.Add(new FunctionBlock { Name = "NewFunctionBlock" });
            refreshLibraryListView();
        }

        //Get index of selected functionblock and load selection into control elements
        private void lvLibraryFunctionblocks_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if(lvLibraryFunctionblocks.SelectedIndices.Count == 1)
                {
                    SelectedFbId = LibraryViewModel.selectedFb(FbList, lvLibraryFunctionblocks.SelectedIndices);
                    LibraryViewModel.loadFb(FbList[SelectedFbId], this.txtLibraryFbName, this.txtLibrarySize, this.txtLibraryDescription, this.dgvLibraryAlarms, this.dgvLibraryParameters);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
        }
        private void txtLibraryFbName_TextChanged(object sender, EventArgs e)
        {
            FbList[SelectedFbId].Name= txtLibraryFbName.Text;
            refreshLibraryListView();
        }
        private void txtLibrarySize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FbList[SelectedFbId].Size = int.Parse(txtLibrarySize.Text);
            }
            catch(Exception ex) 
            {
                Debug.WriteLine(ex.Message);
            }   
        }
        private void txtLibraryDescription_TextChanged(object sender, EventArgs e)
        {
            FbList[SelectedFbId].Description = txtLibraryDescription.Text;
        }

        //Library Backend calls
        private void refreshLibraryListView()
        {
            LibraryViewModel.loadLibraryFbListView(FbList, this.lvLibraryFunctionblocks);
        }

        //##########################
        //Application Initializaion
        private void initApp()
        {

        }

        
    }
}