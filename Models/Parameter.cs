using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagTool.Models
{
    //Paramter Object of a functionblock
    //Tag should be the whole tag of the paramter from the functionblock structure
    //DataType has to be set to either bit,word,long,float
    //Value is the value that can later be set for documentation purposes
    //AddressOffset should be the address of the parameter starting from 0
    public class Parameter
    {
        public string Tag { get; set; }
        public string DataType { get; set; }
        public string Value { get; set; }
        public int AddressOffset { get; set; }

    }
}
