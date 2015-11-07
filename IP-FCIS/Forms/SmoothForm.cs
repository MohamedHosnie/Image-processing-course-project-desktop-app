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
    public partial class SmoothForm : Form
    {
        public TypicalImage img;
        public TypicalImage bluredimg;
        public SmoothForm()
        {
            InitializeComponent();
          
        }
        private void SmoothForm_Load(object sender, EventArgs e)
        {
            try
            {
                Original.Image = img.get_bitmap();
                dropListOperation.SelectedIndex = 0;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void dropListOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dropListOperation.Text == "Mean Filter")
                {
                    if (gaussianPanel.Visible == true)
                        gaussianPanel.Hide();

                    MeanPanel.Show();
               
                }
                else if (dropListOperation.Text == "Gaussian Filter ")
                {
                    if (MeanPanel.Visible == true)
                        MeanPanel.Hide();

                    gaussianPanel.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void meanSmooth_Click(object sender, EventArgs e)
        {
            try
            {
                bluredimg = img.meanFilter(
                    int.Parse(meanWidth.Text),
                    int.Parse(meanHeight.Text),
                    int.Parse(meanOrigix.Text),
                    int.Parse(meanOriginy.Text)
                );

                pictureBoxResult.Image = bluredimg.get_bitmap();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }
        private void guassianButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (gaussianSize.Text == "")
                {
                    bluredimg = img.gaussianFilter2(int.Parse(sigma.Text));
                    pictureBoxResult.Image = bluredimg.get_bitmap();
                }
                else
                {
                    bluredimg =img.gaussianFilter1(int.Parse(sigma.Text), int.Parse(gaussianSize.Text));
                    pictureBoxResult.Image = bluredimg.get_bitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                img = bluredimg;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
