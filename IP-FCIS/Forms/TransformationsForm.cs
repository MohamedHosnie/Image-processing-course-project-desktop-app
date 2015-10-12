using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_FCIS
{
    public partial class TransformationsForm : Form
    {
        public TransformationsForm()
        {
            InitializeComponent();
        }
        private void ScaleOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (ScaleX.Text != "" && ScaleY.Text != "")
                {
                    float PX = (float)Convert.ToDouble(ScaleX.Text),
                          PY = (float)Convert.ToDouble(ScaleY.Text);
                    MainForm.opened_image.scale(PX, PY);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        private void RotateOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (RotateAngle.Text != "")
                {
                    float PAngle = (float)Convert.ToDouble(RotateAngle.Text);
                    MainForm.opened_image.rotate(PAngle);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ShearOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShearX.Text != "" && ShearY.Text != "")
                {
                    float PX = (float)Convert.ToDouble(ShearX.Text),
                          PY = (float)Convert.ToDouble(ShearY.Text);
                    MainForm.opened_image.shear(PX, PY);
                    this.Close();
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void TransformOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (ScaleX.Text != "" && ScaleY.Text != "" && ShearX.Text != "" && ShearY.Text != "" && RotateAngle.Text != "")
                {
                    float PX = (float)Convert.ToDouble(ScaleX.Text),
                          PY = (float)Convert.ToDouble(ScaleY.Text),
                          SX = (float)Convert.ToDouble(ShearX.Text),
                          SY = (float)Convert.ToDouble(ShearY.Text),
                          PAngle = (float)Convert.ToDouble(RotateAngle.Text);
                    MainForm.opened_image.full_transform(PX, PY, SX, SY, PAngle);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
