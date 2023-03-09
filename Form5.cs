using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                Class1.Acertou();
            }
            else
            {
                Class1.Errou();
            }

            resultado resultado = new resultado();
            resultado.Show();
            this.Hide();
        }
    }
}
