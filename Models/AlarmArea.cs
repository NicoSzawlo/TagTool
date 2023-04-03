using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagTool.Models
{
    public class AlarmArea
    {
        //Longtext for AlarmList
        public string Text { get; set; }
        //Tag Text for Taglist
        public string Tag { get; set; }

        //Start and End of AlarmArea
        public int Start { get; set; }
        public int End { get; set; }

    }
}
