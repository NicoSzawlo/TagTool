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
        //Loads the content of the Functionblock into the textboxes for editing
        public static void loadFb(FunctionBlock fb, TextBox txtName, TextBox txtSize, TextBox txtDescription)
        {
            txtName.Text = fb.Name;
            txtSize.Text = fb.Size.ToString();
            txtDescription.Text = fb.Description;
        }
        //Returns the index of the currently selected functionblock
        public static int selectedFb(List<FunctionBlock> fbs,ListView.SelectedIndexCollection lv) 
        {
            int selectedId = 0;
            foreach(int index in lv)
            {
                selectedId= index;
            }
            return selectedId;
        }

        //Adds a new alarm to the alarm list
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
        //Removes alarm from List and generates new alarmlist with remaining items to reset listindices
        public static List<Alarm> RemoveAlarm(List<Alarm> oldList, int dtIndex)
        {
            List<Alarm> newList = new List<Alarm>();
            oldList.Remove(oldList[dtIndex]);
            foreach(Alarm alarm in oldList)
            {
                newList.Add(alarm);
            }
            return newList;
        }
        //Modifies the content of an alarmlist according to changes in datatable
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
        //Adds a parameter to the parameter list
        public static List<Parameter> NewParameter(List<Parameter> oldList)
        {
            Parameter parameter = new Parameter();
            parameter.Tag = "NewParam";
            parameter.DataType = "Word";
            parameter.AddressOffset = 0;
            parameter.Value = "1";
            try
            {
                if (oldList == null)
                {
                    List<Parameter> newList = new List<Parameter>();
                    newList.Add(parameter);
                    oldList = newList;
                }
                else
                {
                    oldList.Add(parameter);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return oldList;
        }
        //Removes parameter from the list and generates a new parameter list with remaining items
        public static List<Parameter> RemoveParameter(List<Parameter> oldList, int dtIndex)
        {
            List<Parameter> newList = new List<Parameter>();
            oldList.Remove(oldList[dtIndex]);
            foreach(Parameter param in oldList)
            {
                newList.Add(param);
            }
            return newList;
        }
        //Modify parameter list content
        public static List<Parameter> ModifyParameterList(int cellPosX, int cellPosY, string cellValue, List<Parameter> paramList)
        {
            switch (cellPosX)
            {
                case 0:
                    paramList[cellPosY].Tag = cellValue;
                    break;
                case 1:
                    paramList[cellPosY].DataType = cellValue;
                    break;
                case 2:
                    try
                    {
                        paramList[cellPosY].AddressOffset = int.Parse(cellValue);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Please only enter numbers in the Addressoffset column." + System.Environment.NewLine + ex.Message);
                        paramList[cellPosY].AddressOffset = 1;
                    }
                    paramList[cellPosY].AddressOffset = int.Parse(cellValue);
                    break;
                case 3:
                    paramList[cellPosY].Value = cellValue;
                    break;
            }
            return paramList;
        }

    }
}
