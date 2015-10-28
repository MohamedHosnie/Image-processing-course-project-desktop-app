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
        public ImageP img;
        public SmoothForm()
        {
            InitializeComponent();
          
        }

        private void SmoothForm_Load(object sender, EventArgs e)
        {
            Original.Image = img.get_bitmap();
        }

        private void dropListOperation_SelectedIndexChanged(object sender, EventArgs e)
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

        private void meanSmooth_Click(object sender, EventArgs e)
        {
            pictureBoxResult.Image = img.meanFilter(
                int.Parse(meanWidth.Text),
                int.Parse(meanHeight.Text),
                int.Parse(meanOrigix.Text),
                int.Parse(meanOriginy.Text)
            ).get_bitmap();
       
        }

        private void guassianButton_Click(object sender, EventArgs e)
        {
            if (gaussianSize.Text == "")
                pictureBoxResult.Image = img.gaussianFilter2(int.Parse(sigma.Text)).get_bitmap();
            else
                pictureBoxResult.Image = img.gaussianFilter1(int.Parse(sigma.Text),int.Parse(gaussianSize.Text)).get_bitmap();
        }
    }
}
