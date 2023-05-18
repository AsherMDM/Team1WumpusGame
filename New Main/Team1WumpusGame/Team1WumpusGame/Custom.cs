using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom
{
    public static class Methods
    {
        public static void Clear(Control c)
        {
            foreach (Control ob in c.Controls)
            {
                if (ob is TextBox)
                {
                    TextBox tb = ob as TextBox;
                    tb.Clear();
                }
                else if (ob is CheckBox)
                {
                    CheckBox cb = ob as CheckBox;
                    cb.Checked = false;
                }
                else if (ob is RadioButton)
                {
                    RadioButton rb = ob as RadioButton;
                    rb.Checked = false;
                }

                if (ob.Controls.Count > 0)
                {
                    Clear(ob);
                }
            }
        }
        public static void Exit(Form form)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                form.Close();
            }
        }
        public static string Radio(Control cont)
        {
            try
            {
                return cont.Controls.OfType<RadioButton>().Single(rad => rad.Checked == true).Text;
            }
            catch
            {
                return null;
            }
        }
    }
}