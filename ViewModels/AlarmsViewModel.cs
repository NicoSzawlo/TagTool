using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Models;

namespace TagTool.ViewModels
{
    public class AlarmsViewModel
    {
        public static List<Alarm> InitiateAlarmList(int size)
        {
            List<Alarm> alarmList = new List<Alarm>();

            for (int i = 1; i <= size; i++)
            {
                alarmList.Add(new Alarm() { Id = i });
            }

            return alarmList;
        }
    }
}
