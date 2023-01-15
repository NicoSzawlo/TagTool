using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagTool.Models;

namespace TagTool.ViewModels
{
    public class LibraryViewModel
    {
        public static void loadLibraryFbListView(List<FunctionBlock> fbs, ListView lv)
        {
            lv.Clear();
            foreach (FunctionBlock functionBlock in fbs)
            {
                ListViewItem item = new ListViewItem(functionBlock.Name);
                lv.Items.Add(item);
            }
        }

        public static void loadFb(FunctionBlock fb, TextBox txtName, TextBox txtSize, TextBox txtDescription, DataGridView dgvAlarms, DataGridView dgvParameters)
        {
            txtName.Text = fb.Name;
            txtSize.Text = fb.Size.ToString();
            txtDescription.Text = fb.Description;
        }
        
        public static int selectedFb(List<FunctionBlock> fbs,ListView.SelectedIndexCollection lv) 
        {
            int selectedId = 0;
            foreach(int index in lv)
            {
                selectedId= index;
            }
            return selectedId;
        }

        
    }
}
