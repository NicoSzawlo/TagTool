using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Models;
using System.Data;

namespace TagTool.Services
{
    public class DataTableHandler
    {   
        //Write Alarmlist to datatable to display in DataGridView
        public static DataTable AlarmsToDt(List<Alarm> alarms)
        {
            DataTable dt = InitAlarmsDt();
            foreach(Alarm alarm in alarms)
            {
                dt.Rows.Add(alarm.Id, alarm.Tag, alarm.Text);
            }
            return dt;
        }
        //Initialize Alarm datatable
        private static DataTable InitAlarmsDt()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Tag");
            dt.Columns.Add("Text");
            return dt;
        }
        //Write Parameterlist to datatable to display in DataGridView
        public static DataTable ParametersToDt(List<Parameter> parameter)
        {
            DataTable dt = InitParameterDt();
            foreach (Parameter param in parameter)
            {
                dt.Rows.Add(param.Tag, param.DataType, param.AddressOffset, param.Value);
            }
            return dt;
        }
        
        //Initialize Alarm datatable
        private static DataTable InitParameterDt()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tag");
            dt.Columns.Add("DataType");
            dt.Columns.Add("AddressOffset");
            dt.Columns.Add("Value");
            return dt;
        }

        //Method to get Unit Texts from Components DataGridView 
        public static List<string> ConvertDgvUnitsToStrings(DataGridViewRowCollection rows)
        {
            List<string> str = new List<string>();

            foreach (DataGridViewRow row in rows)
            {
                str.Add(row.Cells["Unit/Group"].Value.ToString());
            }

            return str;
        }
        //Generate DataTable from Units List to display in datagridview
        public static DataTable UnitsToDt(List<Unit> units)
        {
            DataTable dt = InitUnitsDt();

            foreach (Unit unit in units)
            {
                dt.Rows.Add(unit.Text, unit.Tag);
            }
            return dt;
        }
        //Initialize datatable for Unit list
        private static DataTable InitUnitsDt()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Full Text");
            dt.Columns.Add("Tag");

            return dt;
        }

    }
}
