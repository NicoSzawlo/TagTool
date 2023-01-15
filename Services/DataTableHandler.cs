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
        public static DataTable AlarmsToDt(List<Alarm> alarms)
        {
            DataTable dt = InitAlarmsDt();
            foreach(Alarm alarm in alarms)
            {
                dt.Rows.Add(alarm.Id, alarm.Tag, alarm.Text);
            }
            return dt;
        }

        private static DataTable InitAlarmsDt()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Tag");
            dt.Columns.Add("Text");
            return dt;
        }

    }
}
