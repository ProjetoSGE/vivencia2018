using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes.Classes.Aluno;
using WindowsFormsApplication1.Classes.Auxiliar;

namespace WindowsFormsApplication1.Telas.Adicionais
{
    public partial class AlunoEmail : UserControl
    {
        public AlunoEmail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Enviar(textBox1.Text, conteudo.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlunoDTO alu = comboBox1.SelectedItem as AlunoDTO;

            textBox1.Text = alu.email;
        }
    }
}
