using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagTool.Models
{
    public class AlarmText
    {
        public int Id { get; set; }
        //Bitaddress of the Alarm
        public string Address { get; set; }
        //Area where the alarm is located within
        public AlarmArea Area { get; set; }
        //Component ID (0 if its not a component alarm)
        public int ComponentID { get; set; }
        //Individual text of the alarm, only the last part (between **)
        //EG: MB4000: Winding S1 Axis **Drive Error**
        public string Text { get; set; }


    }
}
