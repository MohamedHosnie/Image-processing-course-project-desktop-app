using IP_FCIS.Classes;
using IP_FCIS.Forms;
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
    public partial class TransformationsForm : Form
    {
        public TypicalImage working_on;
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
                    this.working_on.scale(PX, PY, (TypicalImage.Interpolation)comboInterpolation.SelectedIndex);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        private void ResizeOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (RWidth.Text != "" && RHeight.Text != "")
                {
                    float PW = (float)Convert.ToDouble(RWidth.Text),
                          PH = (float)Convert.ToDouble(RHeight.Text);
                    this.working_on.resize(PW, PH, (TypicalImage.Interpolation)comboInterpolation.SelectedIndex);
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
                    this.working_on.rotate(PAngle, (TypicalImage.Interpolation)comboInterpolation.SelectedIndex);
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

                    this.working_on.shear(PX, PY, (TypicalImage.Interpolation)comboInterpolation.SelectedIndex);
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
                    this.working_on.full_transform(PX, PY, SX, SY, PAngle, (TypicalImage.Interpolation)comboInterpolation.SelectedIndex);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TransformationsForm_Load(object sender, EventArgs e)
        {
            try
            {
                comboInterpolation.SelectedIndex = 1;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
