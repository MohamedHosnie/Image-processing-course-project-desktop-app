using IP_FCIS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_FCIS.Forms
{
    public partial class InfoForm : Form
    {
        public TypicalImage image;
        public InfoForm()
        {
            InitializeComponent();
        }
        private void InfoForm_Load(object sender, EventArgs e)
        {

        }
        public void refreshData()
        {
            try
            {
                labelID.Text = this.image.id.ToString();
                labelName.Text = this.image.get_file_name().ToString();
                labelFormat.Text = this.image.get_extension().ToString();
                labelWidth.Text = this.image.get_width().ToString();
                labelHeight.Text = this.image.get_height().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void infoForm_Close(object sender, System.EventArgs e)
        {
            try
            {
                Program.mainForm.info_form = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
