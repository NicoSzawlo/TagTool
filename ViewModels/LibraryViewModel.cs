using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Models;
using TagTool.Services;

namespace TagTool.ViewModels
{
    public class LibraryViewModel
    {
        public static void loadFbListView(List<FunctionBlock> fbs, ListView lv)
        {
            lv.Clear();
            foreach (FunctionBlock functionBlock in fbs)
            {
                ListViewItem item = new ListViewItem(functionBlock.Name);
                lv.Items.Add(item);
            }
        }

        public static void loadFb(FunctionBlock fb, TextBox txtName, TextBox txtSize, TextBox txtDescription, DataGridView dgvAlarms, DataGridView dgvParameters)
        {
            txtName.Text = fb.Name;
            txtSize.Text = fb.Size.ToString();
            txtDescription.Text = fb.Description;
        }
        
        public static int selectedFb(List<FunctionBlock> fbs,ListView.SelectedIndexCollection lv) 
        {
            int selectedId = 0;
            foreach(int index in lv)
            {
                selectedId= index;
            }
            return selectedId;
        }

        public static DataGridView loadAlarmDgv(FunctionBlock fb, DataGridView dgv)
        {
            DataTable dt = DataTableHandler.AlarmsToDt(fb.Alarms);
            dgv.DataSource = dt;
            return dgv;
        }
        public static List<Alarm> NewAlarm(List<Alarm> alarms)
        {
            Alarm alarm = new Alarm();
            alarm.Id = 1;
            alarm.Tag = "NewAlm";
            alarm.Text = "This is a new Alarm";
            try
                {
                    if (alarms == null)
                    {
                        List<Alarm> newAlarms = new List<Alarm>();
                        newAlarms.Add(alarm);
                        alarms = newAlarms;
                    }
                    else
                    {
                        alarms.Add(alarm);
                    }
                    
                }
            catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            return alarms;
        }
        public static List<Alarm> ModifyAlarmList(int cellPosX, int cellPosY, string cellValue, List<Alarm> alarmList) 
        {
            switch (cellPosX)
            {
                case 0:
                    try
                    {
                        alarmList[cellPosY].Id = int.Parse(cellValue);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Please only enter numbers in the id column." + System.Environment.NewLine + ex.Message);
                        alarmList[cellPosY].Id = 1;
                    }
                    break;
                case 1:
                    alarmList[cellPosY].Tag = cellValue;
                    break;
                case 2:
                    alarmList[cellPosY].Text = cellValue;
                    break;
            }
            return alarmList;
        }

    }
}
