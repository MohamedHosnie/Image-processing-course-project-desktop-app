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
                Program.main_form.set_form_width_height_values(opened_image.get_width(), opened_image.get_height());

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void set_new_image()
        {
            try
            {
                this.pictureBox1.Image = this.opened_image.get_bitmap();
                Program.main_form.set_form_width_height_values(opened_image.get_width(), opened_image.get_height());
                this.Width = opened_image.get_width() + 50;
                this.Height = opened_image.get_height() + 50;

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void transformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.transformation();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void transformation()
        {
            TransformationsForm trans_form = new TransformationsForm();
            trans_form.working_on = this.opened_image;
            trans_form.ShowDialog(this);
            this.opened_image = trans_form.working_on;
            set_new_image();
        }
        public void save()
        {
            SaveForm saveform = new SaveForm();
            saveform.saving_image = this.opened_image;
            saveform.ShowDialog(this);

        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.save();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void gray_scale()
        {
            opened_image.gray_scale();
            set_new_image();
        }
        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.gray_scale();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    }
}
