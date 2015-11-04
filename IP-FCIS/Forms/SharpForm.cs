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
    public partial class SharpForm : Form
    {
        public TypicalImage img;
        public SharpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBoxResult.Image = img.laplacianFilter().get_bitmap();
        }

        private void SharpForm_Load(object sender, EventArgs e)
        {
            Original.Image = img.get_bitmap();
        }
    }
}
