using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagTool.Models
{
    //Alarm object of a functionblock
    //ID must be set in the ascending order of the different alarm signals for mapping in export files
    //Text should be the long information text added to the Alarm text list for later HMI import
    //Tag should be the short version of the Alarm for export to Alarm Taglist for later PLC import

    public class Alarm
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Tag { get; set; }
    }
}
