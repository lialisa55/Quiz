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
    public partial class resultado : Form
    {
        public resultado()
        {
            InitializeComponent();
        }

        private void resultado_Load(object sender, EventArgs e)
        {
            // Aqui está a instancia de output ao final do quiz. Mostrando todos seus erros e acertos.
            richTextBox1.Text = "Acertos: " + Class1.MostrarAcertos() + "\n\nErros: " + Class1.MostrarErro();
        }
    }
}
