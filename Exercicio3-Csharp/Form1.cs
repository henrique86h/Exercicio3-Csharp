using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(txtBoxJucelia.Text);
            decimal b = Convert.ToDecimal(txtBoxSophia.Text);
            decimal c = Convert.ToDecimal(txtBoxHenrique.Text);

            decimal media = (a + b + c) / 3;

            txtBoxMedia.Text = media.ToString();
            MessageBox.Show("A média é " + txtBoxMedia.Text);
        }
    }
}
