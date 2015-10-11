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
            if (ScaleX.Text != "" && ScaleY.Text != "")
            {
                float PX = (float)Convert.ToDouble(ScaleX.Text),
                      PY = (float)Convert.ToDecimal(ScaleY.Text);
                MainForm.opened_image.scale(PX, PY);
                this.Close();
            }
            

        }

    }
}
