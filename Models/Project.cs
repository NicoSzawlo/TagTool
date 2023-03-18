using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagTool.Models
{
    //Class containing project specific configurations and copies of:
    //--Component List
    //--Alarm List
    //--FbLibrary used in this project
    //----Can later be used to initiate popup if FbLibrary wants to be importet in case they differ
    //--Units Defined in the components list
    public class Project
    {
        //List of components
        public List<Component> Components { get; set; }
        //List of generated and modified Alarms
        public List<Alarm> AlarmList { get; set; }
        //Functionblock library used in this project
        public List<FunctionBlock> FbLibrary { get; set; }
        //Units as generated from the Components list
        public List<Unit> Units { get; set; }
        //Short version of the memory area (e.g. MW, D,...)
        public string MemoryArea { get; set; }

    }
}
