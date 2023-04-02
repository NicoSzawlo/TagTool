using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Services;

namespace TagTool.Models
{
    public class Unit
    {
        public int Id { get; set; } 
        public string Tag { get; set; }
        public string Text { get; set; }

        //Generates a raw list of units from the datagridview
        public static List<Unit> GenerateRawUnitList(DataGridViewRowCollection rows)
        {
            List<Unit> unitList = new List<Unit>();
            bool dupe = false;
            //Go through rows of datagridview
            foreach (DataGridViewRow row in rows)
            {
                //when unitlist empty add first entry
                if (unitList.Count == 0)
                {
                    unitList.Add(new Unit()
                    {
                        Tag = "NewUnit",
                        Text = row.Cells["Unit/Group"].Value.ToString(),
                        Id = Unit.GetNextUnitId(unitList)
                    });
                }
                //else go through unitlist
                else
                {
                    foreach (Unit unit in unitList)
                    {
                        //mark dupe when the text is the same
                        if (unit.Text == row.Cells["Unit/Group"].Value.ToString())
                        {
                            dupe = true;
                            break;
                        }
                    }
                    //If not dupe, add to unitlist
                    if (!dupe)
                    {
                        unitList.Add(new Unit()
                        {
                            Tag = "NewUnit",
                            Text = row.Cells["Unit/Group"].Value.ToString()
                        });
                    }
                    dupe = false;
                }
            }
            return unitList;
        }
        //Check UnitList and update entries based on Textproperty form newUnitList
        public static List<Unit> UpdateUnitList(List<Unit> unitList, List<Unit> newUnitList)
        {
            bool dupe = false;
            //Go through newUnitList
            foreach (Unit unit in newUnitList)
            {
                //Go through unitlist
                foreach (Unit unit2 in unitList)
                {
                    //Mark dupe when text is the same
                    if (unit.Text == unit2.Text)
                    {
                        dupe = true;
                        break;
                    }
                }
                //If not dupe, add to unitlist
                if (!dupe)
                {
                    unit.Id = Unit.GetNextUnitId(unitList);
                    unitList.Add(unit);
                }
                dupe = false;
            }
            return unitList;
        }
        //Check UnitList and delete entries based on Textproperty from newUnitList
        public static List<Unit> DeleteUnitEntries(List<Unit> unitList, List<Unit> newUnitList)
        {
            bool dupe = false;
            //Go through unitlist and check if unit is still in newUnitList else, delete it from list
            for (int i = 0; i < unitList.Count; i++)
            {
                foreach (Unit unit in newUnitList)
                {
                    if (unit.Text == unitList[i].Text)
                    {
                        dupe = true;
                        break;
                    }
                }
                if (!dupe)
                {
                    unitList.RemoveAt(i);
                }
                dupe = false;
            }
            return unitList;
        }
        //Function to update unitlist with new unitlist where id is the same
        public static List<Unit> UpdateUnitListWithId(List<Unit> unitList, DataGridViewRowCollection rows)
        {
            List<Unit> newUnitList = ConvertDgvUnitsToUnitList(rows);

            foreach (Unit unit in newUnitList)
            {
                foreach (Unit unit2 in unitList)
                {
                    if (unit.Id == unit2.Id)
                    {
                        unit2.Text = unit.Text;
                        unit2.Tag = unit.Tag;
                    }
                }
            }
            return unitList;
        }        

        //Function to get unit list from datagridview rows containing an ID, Text and Tag
        private static List<Unit> ConvertDgvUnitsToUnitList(DataGridViewRowCollection rows)
        {
            List<Unit> unitList = new List<Unit>();
            foreach (DataGridViewRow row in rows)
            {
                if (row.Cells["ID"].Value != null)
                {
                    unitList.Add(new Unit()
                    {
                        Id = Convert.ToInt32(row.Cells["ID"].Value),
                        Text = row.Cells["Full Text"].Value.ToString(),
                        Tag = row.Cells["Tag"].Value.ToString()
                    });
                }
            }
            return unitList;
        }
        //Function to get next unit id from list and return 1 if list is empty
        private static int GetNextUnitId(List<Unit> units)
        {
            if (units.Count == 0)
            {
                return 1;
            }
            else
            {
                return units.Max(u => u.Id) + 1;
            }
        }
        
    }
}
