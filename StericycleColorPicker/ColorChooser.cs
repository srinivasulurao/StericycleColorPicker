using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StericycleColorPicker
{
    public partial class ColorChooser : UserControl
    {
        public ColorChooser()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void BackgroundColorChooser_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog BackgroundColorChooser = new ColorDialog();
                
                if (BackgroundColorChooser.ShowDialog() == DialogResult.OK)
                {
                    string bc_choosen = null; 
                    string HexColor = string.Format("0x{0:X8}", BackgroundColorChooser.Color.ToArgb());                
                    bc_choosen = "#" + HexColor.Substring(HexColor.Length - 6, 6);                 
                    BackgroundColor.Text = bc_choosen;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void AssignBackgroundColor(String bc)
        {
            BackgroundColor.Text = bc;
        }

        public void AssignTextColor(String tc)
        {
            TextColor.Text = tc;
        }

        public void AssignRequiredColor(String Rc)
        {
            RequiredColor.Text = Rc;
        }

        private void TextColorChooser_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog TextColorChooser = new ColorDialog();
                if (TextColorChooser.ShowDialog() == DialogResult.OK)
                {
                    string tc_choosen = null;
                    string HexColor = string.Format("0x{0:X8}", TextColorChooser.Color.ToArgb());
                    tc_choosen = "#" + HexColor.Substring(HexColor.Length - 6, 6);
                    TextColor.Text = tc_choosen;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        private void RequiredColorChooser_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog RequiredColorChooser = new ColorDialog();
                if (RequiredColorChooser.ShowDialog() == DialogResult.OK)
                {
                    string rc_choosen = null;
                    string HexColor = string.Format("0x{0:X8}", RequiredColorChooser.Color.ToArgb());
                    rc_choosen = "#" + HexColor.Substring(HexColor.Length - 6, 6);
                    RequiredColor.Text = rc_choosen;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BackgroundColor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
