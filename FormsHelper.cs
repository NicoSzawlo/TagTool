using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TagTool
{
    public class FormsHelper
    {
        public static Button NavBtnSelect(Button btn)
        {
            btn.Size = new System.Drawing.Size(148, 84);
            btn.BackColor = Color.LightGray;
            return btn;
        }

        public static Button NavBtnDeselect(Button btn)
        {
            btn.Size = new System.Drawing.Size(148, 78);
            btn.BackColor = Color.DarkGray;
            return btn;
        }

        public static string CallFileDialog()
        {
            string filepath;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            filepath = ofd.FileName;
            return filepath;
        }

        public static string CallSaveFileDialog()
        {
            string filepath = "";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "json files (*.json)|*.json";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filepath = sfd.FileName;
            }
            return filepath;
        }
    }
}
