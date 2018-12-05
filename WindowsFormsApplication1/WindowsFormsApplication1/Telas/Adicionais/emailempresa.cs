using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes.Auxiliar;
using WindowsFormsApplication1.Classes.Classes.Empresa;

namespace WindowsFormsApplication1.Telas.Adicionais
{
    public partial class emailempresa : UserControl
    {
        public emailempresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Email email = new Email();
            email.Enviar(txEmail.Text, conteudo.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmpresaDTO em = comboBox1.SelectedItem as EmpresaDTO;
            textBox1.Text = em.Email;
        }
    }
}
