using System.Data;
using System.Diagnostics;
using TagTool.Models;
using TagTool.Services;
using TagTool.ViewModels;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace TagTool
{
    public partial class MainWindow : Form
    {
        public string FilePath = "";
        public string LibraryPath = Application.StartupPath + "Library.json";
        //Global Library View Properties
        public List<FunctionBlock> FbList = new List<FunctionBlock>();
        public int SelectedFbId = 0;
        public MainWindow()
        {
            InitializeComponent();
            initApp();
        }

        //##################################################################################################################################
        //Navigation Button handling
        //##################################################################################################################################
        #region
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

        //Initialize styling of Navigation buttons
        private void ResetAllNavBtn()
        {
            this.btnNavComponents = FormsHelper.NavBtnDeselect(this.btnNavComponents);
            this.btnNavLibrary = FormsHelper.NavBtnDeselect(this.btnNavLibrary);
            this.button2 = FormsHelper.NavBtnDeselect(this.button2);
            this.button3 = FormsHelper.NavBtnDeselect(this.button3);
            this.button4 = FormsHelper.NavBtnDeselect(this.button4);
        }
        #endregion

        //##################################################################################################################################
        //Libray Panel Handling
        //##################################################################################################################################
        #region
        //User FILE Interaction
        //##########################

        //Opens file dialog to select a file from the explorer
        private void btnLibraryOpenFile_Click(object sender, EventArgs e)
        {
            FilePath = FormsHelper.CallFileDialog();
            if (FilePath != null)
            {
                try
                {
                    FbList = JsonHandler.DeserializeLibrary(FilePath);
                    refreshLibraryListView();
                    refreshLibraryAlarmView();
                    LibraryViewModel.loadFb(FbList[0], this.txtLibraryFbName, this.txtLibrarySize, this.txtLibraryDescription);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }
        //Saves currently loaded file
        private void btnLibrarySaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                JsonHandler.SerializeLibrary(FbList, LibraryPath);
            }
            catch (Exception ex)
            {
                
                Debug.WriteLine(ex.Message);
            }
            

        }
        //Saves current file under new name with savefiledialog
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

        //User FBLIST interaction
        //##########################

        //Get index of selected functionblock and load selection into control elements
        private void lvLibraryFunctionblocks_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (lvLibraryFunctionblocks.SelectedIndices.Count == 1)
                {
                    SelectedFbId = LibraryViewModel.selectedFb(FbList, lvLibraryFunctionblocks.SelectedIndices);
                    LibraryViewModel.loadFb(FbList[SelectedFbId], this.txtLibraryFbName, this.txtLibrarySize, this.txtLibraryDescription);
                    refreshLibraryAlarmView();
                    refreshLibraryParameterView();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }
        //Add a new Functionblock to the list
        private void btnLibraryCreateFb_Click(object sender, EventArgs e)
        {
            FbList.Add(new FunctionBlock { Name = "NewFb", Description = "This is a new Functionblock", Alarms = new List<Alarm>(), Parameters = new List<Parameter>()});
            refreshLibraryListView();
        }
        //Set Function block properties in global Fb List when textboxes change
        private void txtLibraryFbName_TextChanged(object sender, EventArgs e)
        {
            FbList[SelectedFbId].Name = txtLibraryFbName.Text;
            refreshLibraryListView();
        }
        private void txtLibrarySize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FbList[SelectedFbId].Size = int.Parse(txtLibrarySize.Text);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        private void txtLibraryDescription_TextChanged(object sender, EventArgs e)
        {
            FbList[SelectedFbId].Description = txtLibraryDescription.Text;
        }

        //User ALARM interaction
        //##########################

        //Add alarm to currently selected functionblock
        private void btnLibraryAddAlarm_Click(object sender, EventArgs e)
        {
            if(FbList.Count> 0)
            {
                FbList[SelectedFbId].Alarms = LibraryViewModel.NewAlarm(FbList[SelectedFbId].Alarms);
                refreshLibraryAlarmView();
            }
        }
        //Delete Selected Alarm
        private void btnLibraryDeleteAlarm_Click(object sender, EventArgs e)
        {
            FbList[SelectedFbId].Alarms = LibraryViewModel.RemoveAlarm(FbList[SelectedFbId].Alarms, dgvLibraryAlarms.CurrentCell.RowIndex);
            refreshLibraryAlarmView();
        }
        //Change Alarm List value based on cell value
        private void dgvLibraryAlarms_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FbList[SelectedFbId].Alarms = LibraryViewModel.ModifyAlarmList(
                    dgvLibraryAlarms.CurrentCell.ColumnIndex,
                    dgvLibraryAlarms.CurrentCell.RowIndex, 
                    dgvLibraryAlarms.CurrentCell.Value.ToString(), 
                    FbList[SelectedFbId].Alarms);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            refreshLibraryAlarmView();
        }

        //User PARAMETER interaction
        //##########################

        //Add parameter to list
        private void btnLibraryAddParameter_Click(object sender, EventArgs e)
        {
            if (FbList.Count > 0)
            {
                FbList[SelectedFbId].Parameters = LibraryViewModel.NewParameter(FbList[SelectedFbId].Parameters);
                refreshLibraryParameterView();
            }
        }
        //Remove a parameter from the list
        private void btnLibraryDeleteParameter_Click(object sender, EventArgs e)
        {
            FbList[SelectedFbId].Parameters = LibraryViewModel.RemoveParameter(FbList[SelectedFbId].Parameters, dgvLibraryParameters.CurrentCell.RowIndex);
            refreshLibraryParameterView();
        }
        //Modify parameters in list according to change in datagridview
        private void dgvLibraryParameters_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FbList[SelectedFbId].Parameters = LibraryViewModel.ModifyParameterList(
                    dgvLibraryAlarms.CurrentCell.ColumnIndex,
                    dgvLibraryAlarms.CurrentCell.RowIndex,
                    dgvLibraryAlarms.CurrentCell.Value.ToString(),
                    FbList[SelectedFbId].Parameters);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            refreshLibraryParameterView();
        }
        //Library Backend calls
        //##########################

        //Refreshes the List view for the functionblocks after changes have been done
        private void refreshLibraryListView()
        {
            lvLibraryFunctionblocks.Clear();
            foreach (FunctionBlock functionBlock in FbList)
            {
                ListViewItem item = new ListViewItem(functionBlock.Name);
                lvLibraryFunctionblocks.Items.Add(item);
            }
        }
        private void refreshLibraryAlarmView()
        {
            DataTable dt = DataTableHandler.AlarmsToDt(FbList[SelectedFbId].Alarms);
            dgvLibraryAlarms.DataSource = dt;
        }
        private void refreshLibraryParameterView()
        {
            DataTable dt = DataTableHandler.ParametersToDt(FbList[SelectedFbId].Parameters);
            dgvLibraryParameters.DataSource = dt;
        }
        #endregion

        //##################################################################################################################################
        //Components Panel Handling
        //##################################################################################################################################
        #region
        private void dgvComponents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvComponents_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }
        #endregion
        //##################################################################################################################################
        //Application Initializaion
        //##################################################################################################################################
        #region

        //Initializing summary method
        private void initApp()
        {
            InitLibrary();
            InitComponents();
        }
        //Initialisation method for library panel
        private void InitLibrary()
        {

            //Initialize Functionblock Listview
            var columnToRemove = lvLibraryFunctionblocks.Columns["colLibviewBugged"];
            this.lvLibraryFunctionblocks.Columns.Remove(columnToRemove);

            //Load library file
            try
            {
                FbList = JsonHandler.DeserializeLibrary(LibraryPath);
                refreshLibraryListView();
                refreshLibraryAlarmView();
                LibraryViewModel.loadFb(FbList[0], this.txtLibraryFbName, this.txtLibrarySize, this.txtLibraryDescription);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        //Initialization method of components panel
        private void InitComponents()
        {
            //Create columns for Components Datagridview
            DataGridViewTextBoxColumn UnitCol = new DataGridViewTextBoxColumn();
            UnitCol.Name = "Unit/Group";
            DataGridViewTextBoxColumn TagCol = new DataGridViewTextBoxColumn();
            TagCol.Name = "Tagname of Structure";
            DataGridViewTextBoxColumn DescCol = new DataGridViewTextBoxColumn();
            DescCol.Name = "Description";
            DataGridViewTextBoxColumn StartAdrCol = new DataGridViewTextBoxColumn();
            StartAdrCol.Name = "Startaddress of Structure";
            DataGridViewTextBoxColumn AlarmAdrCol = new DataGridViewTextBoxColumn();
            AlarmAdrCol.Name = "Address for Alarmmapping";
            DataGridViewComboBoxColumn FbCol = new DataGridViewComboBoxColumn();
            FbCol.Name = "Function Block";

            //Add functionblocks for dropdown menu in datagridview
            foreach (FunctionBlock fb in FbList)
            {
                FbCol.Items.Add(fb.Name);
            }

            //Add columns to datagridview
            dgvComponents.Columns.Add(UnitCol);
            dgvComponents.Columns.Add(TagCol);
            dgvComponents.Columns.Add(DescCol);
            dgvComponents.Columns.Add(FbCol);
            dgvComponents.Columns.Add(StartAdrCol);
            dgvComponents.Columns.Add(AlarmAdrCol);
        }
        #endregion



        //##################################################################################################################################
        //TESTING AREA
        //##################################################################################################################################
        private void btnLibraryTest_Click(object sender, EventArgs e)
        {

        }

        
    }
}