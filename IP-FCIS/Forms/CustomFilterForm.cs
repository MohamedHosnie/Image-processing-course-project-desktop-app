using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP_FCIS.Classes;

namespace IP_FCIS.Forms
{
    public partial class CustomFilterForm : Form
    {
        public TypicalImage img, edited;
        public int width, height;

        Exception DataNotValid = new Exception(@"Entered data is not valid!
                - Filter size must be at least 3x3.
                - The sum of all numbers in the filter should be equal to zero.");
        public CustomFilterForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (filterHeight.Text == "" && filterWidth.Text == "")
                {
                    throw DataNotValid;
                }

                width = Int32.Parse(filterWidth.Text);
                height = Int32.Parse(filterHeight.Text);

                filterGrid.Columns.Clear();
                filterGrid.Rows.Clear();

                for (int j = 0; j < width; j++)
                {
                    DataGridViewColumn col = new DataGridViewTextBoxColumn();
                    col.HeaderText = "" + j;
                    filterGrid.Columns.Add(col);
                }

                for (int i = 0; i < height; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.HeaderCell.Value = "" + i;
                    filterGrid.Rows.Add(row);
                }

                
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void SharpForm_Load(object sender, EventArgs e)
        {
            try
            {
                Original.Image = img.get_bitmap();
                comboBoxpost.SelectedIndex = 0;
                edited = new TypicalImage(img);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void apply_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (height < 3 || width < 3)
                    throw DataNotValid;

                TypicalImage.Postprocessing post;

                switch(comboBoxpost.Text)
                {
                    case "None":
                        post = TypicalImage.Postprocessing.No;
                        break;
                    case "Absolute":
                        post = TypicalImage.Postprocessing.Absolute;
                        break;
                    case "Cut Off":
                        post = TypicalImage.Postprocessing.Cut_off;
                        break;
                    case "Normalization":
                        post = TypicalImage.Postprocessing.Normalization;
                        break;
                    default:
                        post = TypicalImage.Postprocessing.No;
                        break;
                }
                
                float sum = 0;
                float[,] filter = new float[height, width];
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (filterGrid.Rows[i].Cells[j].Value == null)
                        {
                            filterGrid.Rows[i].Cells[j].Value = Convert.ToString(0);
                            filter[i, j] = 0;
                        }
                        else filter[i, j] = (float)Decimal.Parse((String)filterGrid.Rows[i].Cells[j].Value);
                        sum += filter[i, j];
                    }
                }

                if (sum != 0) throw DataNotValid;
                edited = img.custom_filter(filter, width, height, post);
                pictureBoxResult.Image = edited.get_bitmap();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                img = edited;
                this.Close();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
