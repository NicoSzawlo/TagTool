using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using TagTool.Models;
using TagTool.Services;
using TagTool.ViewModels;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace TagTool
{
    public partial class MainWindow : Form
    {
        //Initialze filepaths
        public string FilePath = "";
        public string ProjectPath = "";
        public string LibraryPath = Application.StartupPath + "Library.json";

        //Initialize Global bussiness objects
        public Project ActiveProject = new Project();
        public List<FunctionBlock> FbList = new List<FunctionBlock>();
        public List<Component> CompList = new List<Component>();
        public List<Unit> UnitList = new List<Unit>();
        public List<Alarm> AlarmList = new List<Alarm>();
        public List<AlarmArea> AlarmAreaList = new List<AlarmArea>();
        public int AddressType = new int(); // 1=Decimal, 2=Hexadecimal, 3=Mixed System

        //Initialize Ids
        public int SelectedFbId = 0;
        public int ComponentIdCounter = 0;
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
        private void btnNavAlarms_Click(object sender, EventArgs e)
        {
            ResetAllNavBtn();
            this.btnNavAlarms = FormsHelper.NavBtnSelect(this.btnNavAlarms);
            this.pnlAlarms.BringToFront();
        }
        private void btnNavExports_Click(object sender, EventArgs e)
        {
            ResetAllNavBtn();
            this.btnNavExports = FormsHelper.NavBtnSelect(this.btnNavExports);
            this.pnlExports.BringToFront();
        }

        //Initialize styling of Navigation buttons
        private void ResetAllNavBtn()
        {
            this.btnNavComponents = FormsHelper.NavBtnDeselect(this.btnNavComponents);
            this.btnNavLibrary = FormsHelper.NavBtnDeselect(this.btnNavLibrary);
            this.btnNavAlarms = FormsHelper.NavBtnDeselect(this.btnNavAlarms);
            this.btnNavExports = FormsHelper.NavBtnDeselect(this.btnNavExports);
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
            FbList.Add(new FunctionBlock { Name = "NewFb", Description = "This is a new Functionblock", Alarms = new List<Alarm>(), Parameters = new List<Parameter>() });
            refreshLibraryListView();
            InitCompControl();

        }
        //Set Function block properties in global Fb List when textboxes change
        private void txtLibraryFbName_TextChanged(object sender, EventArgs e)
        {
            FbList[SelectedFbId].Name = txtLibraryFbName.Text;
            refreshLibraryListView();
            loadDgvComboboxSelection();
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
            if (FbList.Count > 0)
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
            catch (Exception ex)
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
        //User FILE Interaction
        //##########################

        //Initially save/Create new project file
        private void btnComponentsCreateNew_Click(object sender, EventArgs e)
        {
            ProjectPath = FormsHelper.CallSaveFileDialog();
            ActiveProject.FbLibrary = FbList;
            ActiveProject.Components = CompList;
            ActiveProject.AlarmList = AlarmList;
            ActiveProject.Units = UnitList;
            ActiveProject.AlarmAreas = AlarmAreaList;
            ActiveProject.AddressType = AddressType;
            try
            {
                JsonHandler.SerializeProject(ActiveProject, ProjectPath);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        //Load components list from json file
        private void btnComponentLoad_Click(object sender, EventArgs e)
        {
            ProjectPath = FormsHelper.CallFileDialog();
            try
            {
                ActiveProject = JsonHandler.DeserializeProject(ProjectPath);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            CompList = ActiveProject.Components;
            AlarmList = ActiveProject.AlarmList;
            UnitList = ActiveProject.Units;
            AlarmAreaList = ActiveProject.AlarmAreas;
            AddressType = ActiveProject.AddressType;

            ComponentIdCounter = ComponentsViewModel.GetLastId(CompList);

            initProject();
        }
        //Save last saved/loaded components file 
        private void btnComponentsSave_Click(object sender, EventArgs e)
        {
            ActiveProject.FbLibrary = FbList;
            ActiveProject.Components = CompList;
            ActiveProject.AlarmList = AlarmList;
            ActiveProject.Units = UnitList;
            ActiveProject.AlarmAreas = AlarmAreaList;
            ActiveProject.AddressType = AddressType;
            if (ProjectPath != "")
            {
                try
                {
                    JsonHandler.SerializeProject(ActiveProject, ProjectPath);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            else
            {
                ProjectPath = FormsHelper.CallSaveFileDialog();
                JsonHandler.SerializeProject(ActiveProject, ProjectPath);
            }
        }

        //User Components Panel Interaction
        //##########################
        //Change Component list based on datagridview
        private void dgvComponents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CompList = ComponentsViewModel.ModifyComponentList(
                dgvComponents.CurrentCell.ColumnIndex,
                Convert.ToInt32(dgvComponents.CurrentRow.Cells["ID"].Value),
                dgvComponents.CurrentCell.Value.ToString(),
                CompList,
                FbList);
            checkComponentStartaddress();
            refreshUnits();
        }
        //Adds new default component to list
        private void btnComponentAdd_Click(object sender, EventArgs e)
        {
            ComponentIdCounter++;
            CompList.Add(ComponentsViewModel.GenerateNewComponent(ComponentIdCounter, FbList[0]));
            refreshComponentView();
        }
        //Deletes currently selected component
        private void btnComponentsDel_Click(object sender, EventArgs e)
        {
            CompList = ComponentsViewModel.DeleteComponentFromList(CompList, Convert.ToInt32(dgvComponents.CurrentRow.Cells["ID"].Value));
            refreshComponentView();
        }

        //Update UnitList when units datagridview has changed
        private void dgvCompUnits_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UnitList = Unit.UpdateUnitListWithId(UnitList, dgvCompUnits.Rows);
            CompList = ComponentsViewModel.UpdateUnitInComponentsPerId(UnitList, CompList);
            refreshComponentView();
        }

        //Components Backend calls
        //##########################

        //Refresh components datagridview after loading file
        private void refreshComponentView()
        {
            if (CompList.Count > 0)
            {
                if (dgvComponents.Rows.Count >= 1)
                {
                    dgvComponents.DataSource = null;
                    dgvComponents.Rows.Clear();
                }

                foreach (Component component in CompList)
                {
                    dgvComponents.Rows.Add(
                        component.Id,
                        component.Unit.Text,
                        component.Tag,
                        component.Description,
                        component.Fb.Name,
                        component.StartAddress,
                        component.AlarmAddress);
                }
                checkComponentStartaddress();
                refreshUnits();
            }
        }
        //Check for startaddress overlaps and color faulty components startaddress cells red
        private void checkComponentStartaddress()
        {
            //Get list of faulty Id's
            List<int> faultyComponents = ComponentsViewModel.CheckStartAddress(CompList);
            //Color every Startaddress cell white
            foreach (DataGridViewRow row in dgvComponents.Rows)
            {
                row.Cells["Startaddress of Structure"].Style.BackColor = Color.White;
            }
            //Check if any component faulty
            if (faultyComponents.Count > 0)
            {
                foreach (DataGridViewRow dgvr in dgvComponents.Rows)
                {
                    foreach (int faultyComponent in faultyComponents)
                    {
                        if (dgvr.Cells["ID"].Value.ToString() == faultyComponent.ToString())
                        {
                            dgvr.Cells["Startaddress of Structure"].Style.BackColor = Color.Red;
                        }

                    }
                }
            }
        }
        //Refresh Units Dgv
        private void refreshUnits()
        {
            //Clear datagridview
            dgvCompUnits.DataSource = null;
            dgvCompUnits.Rows.Clear();

            //Set backend data
            UnitList = ComponentsViewModel.UpdateUnitList(UnitList, dgvComponents.Rows);
            CompList = ComponentsViewModel.SetUnitToComponentsPerText(UnitList, CompList);

            //Setup datagridview for Units
            dgvCompUnits.DataSource = DataTableHandler.UnitsToDt(UnitList);
            dgvCompUnits.Columns["ID"].Visible = false;
            foreach (DataGridViewColumn col in dgvCompUnits.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion

        //##################################################################################################################################
        //Alarm Panel Handling
        //##################################################################################################################################
        #region
        //Refresh alarm datagridview
        private void btnAlmRefresh_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn AlarmTextCol = new DataGridViewTextBoxColumn();
            AlarmTextCol.Name = "Alarmtext";
            AlarmTextCol.ReadOnly = true;
            dgvAlarms.Columns.Add(AlarmTextCol);
            foreach (Alarm alarm in AlarmsViewModel.FillAlarmList("40000", 10000, "MB"))
            {
                dgvAlarms.Rows.Add(alarm.Text);
            }
        }
        //Delete selected alarm area
        private void btnAlmGroupDel_Click(object sender, EventArgs e)
        {
            int index = dgvAlarmGroups.CurrentRow.Index;

            if (AlarmAreaList.Count > 0)
            {
                AlarmAreaList.RemoveAt(index);
            }
            refreshAlarmGroups();
        }
        //Add new alarm area
        private void btnAlmGroupAdd_Click(object sender, EventArgs e)
        {
            AlarmAreaList.Add(new AlarmArea()
            {
                Text = "NewGroup",
                Tag = "NewGrp",
                Start = 0,
                End = 10
            });

            refreshAlarmGroups();
        }
        //Update alarm area list when cell value changed
        private void dgvAlarmGroups_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            AlarmAreaList = AlarmsViewModel.ModifyAlarmAreaList(AlarmAreaList, dgvAlarmGroups.Rows);
        }
        private void rdbSelectionChanged(object sender, EventArgs e)
        {
            if(rdbAlmMemSelDec.Checked)
            {
                AddressType = 1;
            }
            if (rdbAlmMemSelHex.Checked)
            {
                AddressType = 2;
            }
            if (rdbAlmMemSelMix.Checked)
            {
                AddressType = 3;
            }
        }
        //Alarms "Backend" calls
        //##########################
        private void refreshAlarmGroups()
        {
            if (AlarmAreaList.Count > 0)
            {
                if (dgvAlarmGroups.Rows.Count >= 1)
                {
                    dgvComponents.DataSource = null;
                    dgvComponents.Rows.Clear();
                }
            }

            dgvAlarmGroups.DataSource = DataTableHandler.AlarmAreasToDt(AlarmAreaList);
        }

        //Set radiobutton when addresstype is set
        private void setAddressTypeRdb()
        {
            switch (AddressType)
            {
                case 1:
                    rdbAlmMemSelDec.Checked = true;
                    break;
                case 2:
                    rdbAlmMemSelHex.Checked = true;
                    break;
                case 3:
                    rdbAlmMemSelMix.Checked = true;
                    break;
            }
        }
        #endregion
        
        //##################################################################################################################################
        //Application Initializaion
        //##################################################################################################################################
        #region

        //Initializing Views after loading a existing project
        private void initProject()
        {
            refreshComponentView();
            setAddressTypeRdb();
        }
        //Initializing summary method
        private void initApp()
        {
            //Initiate DataGridView for Components
            InitCompDgv();
            //Load Library View
            InitLibrary();
            //Add Components FbColumn content
            InitCompControl();
            //Reset Navigation
            ResetAllNavBtn();
            //Start on components view
            this.btnNavComponents = FormsHelper.NavBtnSelect(this.btnNavComponents);
            this.pnlComponents.BringToFront();
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

        //Initialize components controls
        private void InitCompControl()
        {
            //When Fb List empty disable adding of components
            if (FbList.Count == 0)
            {
                this.btnComponentAdd.Enabled = false;
            }
            //Else Activate and reload
            else
            {
                this.btnComponentAdd.Enabled = true;
                loadDgvComboboxSelection();
            }
        }

        //Initialize columns for Components Datagrid View
        private void InitCompDgv()
        {
            //Create columns for Components Datagridview
            DataGridViewTextBoxColumn IdCol = new DataGridViewTextBoxColumn();
            IdCol.Name = "ID";
            IdCol.ReadOnly = true;
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

            //Add columns to datagridview
            dgvComponents.Columns.Add(IdCol);
            dgvComponents.Columns.Add(UnitCol);
            dgvComponents.Columns.Add(TagCol);
            dgvComponents.Columns.Add(DescCol);
            dgvComponents.Columns.Add(FbCol);
            dgvComponents.Columns.Add(StartAdrCol);
            dgvComponents.Columns.Add(AlarmAdrCol);

        }

        //Load Library for Combobox column
        private void loadDgvComboboxSelection()
        {
            if (((DataGridViewComboBoxColumn)dgvComponents.Columns["Function Block"]).Items.Count != 0)
            {
                ((DataGridViewComboBoxColumn)dgvComponents.Columns["Function Block"]).Items.Clear();
            }

            //Add functionblocks for dropdown menu in datagridview
            foreach (FunctionBlock fb in FbList)
            {
                ((DataGridViewComboBoxColumn)dgvComponents.Columns["Function Block"]).Items.Add(fb.Name);
            }
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