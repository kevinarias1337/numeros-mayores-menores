using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numeromayor.Visible = false;
            numero1txt.Focus();
        }

        private void Btncontinuar_Click(object sender, EventArgs e)
        {
            int numero1txt2 = int.Parse(numero1txt.Text);
            int numero2txt2 = int.Parse(numero2txt.Text);

            if (numero1txt2 < numero2txt2)
            {
                numeromayor.Text = numero2txt2.ToString();
            }

            if (numero2txt2 < numero1txt2)
            {
                numeromayor.Text = numero1txt2.ToString();
            }
            
            if (numero2txt2==numero1txt2)
            {
                MessageBox.Show("Los números son iguales.");

            }

            numero1txt.Text = "";
            numero2txt.Text = "";
            numero1txt.Focus();
            numeromayor.Visible = true;
        }
    }
}
