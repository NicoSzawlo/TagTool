using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagTool.Models
{
    //Function block object for selection in the components list
    //Name of the function block
    //Tag is the short variant later displayed in the plcs fb library
    //Description should show the components that fb is used for
    //Size is the space that a function block has, it is used to check for memory overlapping
    //Parameters contains a list of parameter objects
    //Alarms contains a list of alarm objects
    public class FunctionBlock
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }
        public List<Parameter>? Parameters { get; set; }
        public List<Alarm>? Alarms { get; set; }
    }
}
