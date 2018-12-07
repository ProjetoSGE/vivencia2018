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
using Catiotro_s.PlugIn;

namespace WindowsFormsApplication1.Telas.Adicionais
{
    public partial class emailempresa : UserControl
    {
        public emailempresa()
        {
            InitializeComponent();
            CarregarCombos();
        }

        void CarregarCombos()
        {
            EmpresaBusiness buss = new EmpresaBusiness();
            List<EmpresaDTO> lista = buss.Listar();

            cboEmpresa.ValueMember = nameof(EmpresaDTO.Id);
            cboEmpresa.DisplayMember = nameof(EmpresaDTO.Nome);
            cboEmpresa.DataSource = lista;
        }

        EmailPlugin Email = new EmailPlugin();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtPara.Text;
                email = email.Trim();

                Email.Para = txtPara.Text;
                Email.Assunto = "SGE";
                Email.Mensagem = txtMsg.Text;

                Email.Enviar();

                MessageBox.Show("Email enviado.", "SGE"); 
            }
            catch (Exception)
            {
               
               MessageBox.Show("Não foi possível enviar o email. \nVerifique se o destinatário está correto.", "SGE");
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmpresaDTO em = cboEmpresa.SelectedItem as EmpresaDTO;
            txtPara.Text = em.Email;
        }
    }
}
