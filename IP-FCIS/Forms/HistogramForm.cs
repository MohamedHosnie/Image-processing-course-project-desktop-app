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
    public partial class HistogramForm : Form
    {
        public int[][] current_histogram_data;
        public HistogramForm()
        {
            InitializeComponent();
            this.radioGray.Checked = true;
        }
        private void HistogramForm_Load(object sender, EventArgs e)
        {
            //this.draw_histogram();
        }
        private void HistogramForm_Close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Program.main_form.histogram_form = null;

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void RadioButton_CheckedChange(object sender, EventArgs e)
        {
            try
            {
                RadioButton rb = sender as RadioButton;
                if (rb != null && current_histogram_data != null)
                {
                    if (rb.Checked)
                    {
                        draw_histogram();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void draw_histogram()
        {
            Color drawing_color = Color.Black;
            int color_index = 0;
            Bitmap hist_bitmap = new Bitmap(256, 150);
            if(this.radioGray.Checked)
            {
                drawing_color = Color.Black;
                color_index = 3;

            } else if(this.radioRed.Checked)
            {
                drawing_color = Color.Red;
                color_index = 0;

            } else if(this.radioGreen.Checked)
            {
                drawing_color = Color.Green;
                color_index = 1;

            } else if(this.radioBlue.Checked)
            {
                drawing_color = Color.Blue;
                color_index = 2;

            } else
            {
                return;
            }

            int max_value = current_histogram_data[color_index].Max();
            for(int x = 0; x < 256; x ++)
            {
                double curr_value = current_histogram_data[color_index][x];
                curr_value = (curr_value / max_value) * 150;
                curr_value = 150 - curr_value;
                for(int y = 0; y < 150; y++)
                {
                    if (y < curr_value) hist_bitmap.SetPixel(x, y, Color.White);
                    else hist_bitmap.SetPixel(x, y, drawing_color);
                }
            }

            this.picHistogram.Image = hist_bitmap;

        }
        

    }
}
