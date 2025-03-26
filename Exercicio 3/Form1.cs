using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumInteiro.Text);
            double numero2 = Convert.ToDouble(txtNumReal.Text);
            double resultado = numero1 * numero2;

            MessageBox.Show($"A multiplicação de {numero1} x {numero2} = {resultado}", MessageBoxButtons.OK.ToString());
        }
    }
}
