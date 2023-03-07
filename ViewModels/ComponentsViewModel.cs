using System;
using System.Collections.Generic;
using System.Data;
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
        //Checks component list for overlapping startaddresses
        public static List<int> CheckStartAddress(List<Component>components)
        {
            List<int> faultyComponents = new List<int>();
            int endaddress = 0;
            //Order list by startadresses, so checking for overlaps is easier
            List<Component> sortedComponents = components.OrderBy(c=>c.StartAddress).ToList();
            
            //Go through sorted list
            for (int i = 0; i < sortedComponents.Count; i++)
            {
                //Check if component has Fb and Startaddress set
                if (components[i].StartAddress != 0 && components[i].Fb.Name != "")
                {
                    //Check if last element
                    if (i + 1 < sortedComponents.Count)
                    {
                        //Add Startaddress and Fb Size
                        endaddress = sortedComponents[i].StartAddress + sortedComponents[i].Fb.Size;
                        //Check if startaddress+size > startaddress of next component
                        if (endaddress > sortedComponents[i + 1].StartAddress)
                        {
                            faultyComponents.Add(sortedComponents[i+1].Id);
                        }
                    }
                }
            }
            return faultyComponents;
        }

        public static int GetLastId(List<Component> components)
        {
            int lastid = 0;

            foreach(Component component in components)
            {
                if(component.Id > lastid)
                {
                    lastid = component.Id;
                }
            }

            return lastid;
        }
    }
}
