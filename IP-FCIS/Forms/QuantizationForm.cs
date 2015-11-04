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
    public partial class QuantizationForm : Form
    {
        public TypicalImage img;
        private List<int> Masks;
        public QuantizationForm()
        {
            InitializeComponent();
            Masks = new List<int>();
            Masks.Add(128);
            Masks.Add(192);
            Masks.Add(224);
            Masks.Add(240);
            Masks.Add(248);
            Masks.Add(252);
            Masks.Add(254);
            Masks.Add(255);
        }

        private void reduceButton_Click(object sender, EventArgs e)
        {
            int number = int.Parse(reduceText.Text);
            number = (int)Math.Log(number, 2);
            if (number > 8 || number < 1)
                MessageBox.Show("Can't Reduce to that Value");
            else
            {
                img.quantization(Masks[number - 1]);
                this.Close();
            }

        }

        private void QuantizationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
