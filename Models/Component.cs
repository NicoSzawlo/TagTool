using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagTool.Models
{
    public class Component
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public FunctionBlock Fb { get; set; }
        public int StartAddress { get; set; }
        public int AlarmAddress { get; set; }
        public string MemoryArea { get; set; }

    }
}
