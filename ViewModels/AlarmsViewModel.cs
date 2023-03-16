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
    }
}
