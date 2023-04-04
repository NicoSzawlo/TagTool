using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Models;
using TagTool.Services;

namespace TagTool.ViewModels
{
    public class AlarmsViewModel
    {
        private static List<Alarm> GenerateAlarmList(int size)
        {
            List<Alarm> alarmList = new List<Alarm>();

            for (int i = 1; i <= size; i++)
            {
                alarmList.Add(new Alarm() { Id = i });
            }

            return alarmList;
        }

        public static List<Alarm> FillAlarmList(string startAddress, int size, string prefix)
        {
            List<Alarm> alarmList = GenerateAlarmList(size);

            List<string> addressList = AddressListGenerator.MixList(startAddress, size, prefix);

            for (int i = 0; i < alarmList.Count; i++)
            {
                alarmList[i].Text = addressList[i];
            }

            return alarmList;
        }
        //Function to modify list of alarmarea with datagridviewrowcollection
        public static List<AlarmArea> ModifyAlarmAreaList(List<AlarmArea> alarmAreas, DataGridViewRowCollection rows)
        {
            for (int i = 0; i < rows.Count; i++)
            {
                alarmAreas[i].Text = rows[i].Cells["Text"].Value.ToString();
                alarmAreas[i].Tag = rows[i].Cells["Tag"].Value.ToString();
                alarmAreas[i].Start = Convert.ToInt32(rows[i].Cells["Startaddress"].Value.ToString());
                alarmAreas[i].End = Convert.ToInt32(rows[i].Cells["Endaddress"].Value.ToString());
            }
            return alarmAreas;
        }   
        //Function to check if alarmarea text is equal to a text in the unit list
        public static bool CheckAlarmAreaText(AlarmArea alarmArea, List<Unit> units)
        {
            bool check = true;
            
            foreach (Unit unit in units)
            {
                if (alarmArea.Text == unit.Text)
                {
                    check = false;
                }
            }

            return check;
        }
    }
}
