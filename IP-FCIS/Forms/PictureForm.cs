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
    public partial class PictureForm : Form, IP_FCIS.Forms.MainForm.ICommon
    {

        public ImageP opened_image;
        public PictureForm()
        {
            InitializeComponent();
        }
        private void PictureForm_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = opened_image.get_bitmap();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void ChildForm_Activeted(object sender, EventArgs e)
        {
            try
            {
                MainForm.opened_image = this.opened_image;
                Program.main_form.set_form_width_height_values(opened_image.get_width(), opened_image.get_height());

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void set_new_image()
        {
            try
            {
                this.opened_image = MainForm.opened_image;
                this.pictureBox1.Image = this.opened_image.get_bitmap();
                Program.main_form.set_form_width_height_values(opened_image.get_width(), opened_image.get_height());
                this.Width = opened_image.get_width() + 50;
                this.Height = opened_image.get_height() + 50;

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
