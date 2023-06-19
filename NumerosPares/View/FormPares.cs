using NumerosPares.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPares.View
{
    public partial class FormPares : Form
    {
        public FormPares()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculoPar calculoPar = new CalculoPar();
            int vlr = Convert.ToInt32(textBox1.Text);
            label2.Text = calculoPar.Calcular(vlr);
        }
    }
}
