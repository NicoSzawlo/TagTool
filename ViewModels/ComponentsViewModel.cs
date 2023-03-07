using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Models;

namespace TagTool.ViewModels
{
    public class ComponentsViewModel
    {
        //Go through datagridview data and convert to list of components
        public static List<Component> ModifyComponentList(int cellPosX, int cellPosY, string cellValue, List<Component> components, List<FunctionBlock> fbList)
        {
            //Modify Componentlist based on cell position of the datagridview
            switch (cellPosX)
            {
                //Write Unit to Componentlist
                case 0:
                    components[cellPosY].Unit = cellValue;
                    break;
                //Write Tag name into componentlist
                case 1:
                    components[cellPosY].Tag = cellValue;
                    break;
                //Write description into componentlist
                case 2:
                    components[cellPosY].Description = cellValue;
                    break;
                //Look up functionblock with same name in List and insert it into componentlist
                case 3:
                    foreach(FunctionBlock fb in fbList)
                    {
                        if(fb.Name == cellValue)
                        {
                            components[cellPosY].Fb = fb;
                        }
                    }
                    break;
                //Convert value to int and write startaddress into componentlist
                case 4:
                    components[cellPosY].StartAddress = Convert.ToInt32(cellValue);
                    break;
                //Convert value to int and write alarmaddress into componentlist
                case 5:
                    components[cellPosY].AlarmAddress = Convert.ToInt32(cellValue);
                    break;
            }
            return components;
        }
    }
}
