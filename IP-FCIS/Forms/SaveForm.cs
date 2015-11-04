using IP_FCIS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_FCIS.Forms
{
    public partial class SaveForm : Form
    {
        public TypicalImage saving_image;
        public string fileName;
        public SaveForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ppm_type = comboBox1.Text;
                if(ppm_type != "")
                {
                    this.saving_image.save_ppm(ppm_type, fileName);
                    this.Close();
                }
                else
                {
                    this.Hide();
                    MessageBox.Show("No imgae to save or no type is selected.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

    }
}
