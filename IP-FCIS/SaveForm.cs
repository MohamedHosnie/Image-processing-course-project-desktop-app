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

namespace IP_FCIS
{
    public partial class SaveForm : Form
    {
        public SaveForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                string ppm_type = comboBox1.Text;
                this.Hide();
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "untitled.ppm";
                savefile.Filter = "Image files (*.ppm)  | *.ppm";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    Form1.opened_image.save_ppm(ppm_type, savefile.FileName);
                }

                this.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


        }
    }
}
