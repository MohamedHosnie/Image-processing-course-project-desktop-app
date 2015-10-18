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
    public partial class GammaForm : Form
    {
        public ImageP current_image;
        public ImageP small_current, edited_current;
        public GammaForm()
        {
            InitializeComponent();
        }
        private void trackGamma_ValueChanged(object sender, EventArgs e)
        {
            decimal value = (decimal)this.trackGamma.Value;
            this.numericGamma.Value = value / (decimal)100;
            edited_current = small_current.change_gamma(Convert.ToDouble(this.numericGamma.Value));
            this.Adjusted.Image = edited_current.get_bitmap();
        }
        private void numericGamma_ValueChanged(object sender, EventArgs e)
        {
            this.trackGamma.Value = Convert.ToInt32(this.numericGamma.Value * 100);
        }
        private void GammaForm_Load(object sender, EventArgs e)
        {
            try
            {
                int width, height;
                small_current = new ImageP(current_image);
                if (small_current.get_width() > 200 || small_current.get_height() > 200)
                {
                    if (small_current.get_width() > small_current.get_height())
                    {
                        width = 200;
                        height = (width * small_current.get_height()) / small_current.get_width();

                    }
                    else
                    {
                        height = 200;
                        width = (height * small_current.get_width()) / small_current.get_height();
                    }

                    small_current.resize(width, height);
                }
                this.Original.Image = this.small_current.get_bitmap();
                this.Adjusted.Image = this.small_current.get_bitmap();

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
                current_image = current_image.change_gamma(Convert.ToDouble(this.numericGamma.Value / 100));
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
