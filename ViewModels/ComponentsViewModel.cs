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
        public static List<Component> ModifyComponentList(int cellPosX, int id, string cellValue, List<Component> components, List<FunctionBlock> fbList)
        {
            //Modify Componentlist based on cell position of the datagridview
            switch (cellPosX)
            {
                //Write Unit to Componentlist
                case 1:
                    //Go through components list
                    foreach(Component component in components)
                    {
                        //When Id of component and passed id are the same change value of component in list
                        if(component.Id == id)
                        {
                            component.Unit.Text = cellValue;
                        }
                    }
                    break;
                //Write Tag name into componentlist
                case 2:
                    foreach (Component component in components)
                    {
                        if (component.Id == id)
                        {
                            component.Tag = cellValue;
                        }
                    }
                    break;
                //Write description into componentlist
                case 3:
                    foreach (Component component in components)
                    {
                        if (component.Id == id)
                        {
                            component.Description = cellValue;
                        }
                    }
                    
                    break;
                //Look up functionblock with same name in List and insert it into componentlist
                case 4:
                    foreach(FunctionBlock fb in fbList)
                    {
                        if(fb.Name == cellValue)
                        {
                            foreach (Component component in components)
                            {
                                if (component.Id == id)
                                {
                                    component.Fb = fb;
                                }
                            }
                        }
                    }
                    break;
                //Convert value to int and write startaddress into componentlist
                case 5:
                    foreach (Component component in components)
                    {
                        if (component.Id == id)
                        {
                            component.StartAddress = Convert.ToInt32(cellValue);
                        }
                    }
                    break;
                //Convert value to int and write alarmaddress into componentlist
                case 6:
                    foreach (Component component in components)
                    {
                        if (component.Id == id)
                        {
                            component.AlarmAddress = Convert.ToInt32(cellValue);
                        }
                    }
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

        public static Component GenerateNewComponent(int id, FunctionBlock fb)
        {
            Component comp = new Component()
            {
                Id = id,
                Unit = new Unit() { Tag = "NewUnit", Text = "New Unit" },
                Tag = "NewTag",
                AlarmAddress = 0,
                StartAddress = 0,
                Description = "New Description",
                Fb = fb
            };
            return comp;
        }
        //Generates a List of Units from a Components DataGridview content
        public static List<Unit> GenerateUnitListFromComponents(List<string> units)
        {
            List<Unit> unitList = new List<Unit>();
            bool dupe = false;

            foreach(string unittext in units)
            {
                if(unitList.Count == 0) 
                {
                    unitList.Add(new Unit() { Tag = "NewUnit", Text = unittext });
                }
                else
                {
                    foreach(Unit unit in unitList)
                    {
                        if(unit.Text == unittext)
                        {
                            dupe = true;
                            break;
                        }
                    }
                    if (!dupe)
                    {
                        unitList.Add(new Unit() { Tag = "NewUnit", Text = unittext });
                    }
                    dupe = false;
                }
            }

            return unitList;
        }
    }
}
