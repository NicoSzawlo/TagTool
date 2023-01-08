using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagTool.Models
{
    public class FunctionBlock
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }
        public List<Parameter>? Parameters { get; set; }
        public List<Alarm>? Alarms { get; set; }
    }
}
