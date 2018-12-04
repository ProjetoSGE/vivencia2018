using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes.Classes.Empresa;

namespace WindowsFormsApplication1
{
    public partial class EmpresaCadastro : UserControl
    {
        public EmpresaCadastro()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
      

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpresaDTO empresa = new EmpresaDTO();

                if (mktCep.MaskCompleted)
                {
                    empresa.Cep = mktCep.Text.Trim();

                }
                else
                {
                    throw new ArgumentException("CEP é obrigatório");
                }

                if (mktTelefone.MaskCompleted)
                {
                    empresa.Telefone = mktTelefone.Text.Trim();

                }
                else
                {
                    throw new ArgumentException("Telefone é obrigatório");
                }



                empresa.Cnpj = mtkCNPJ.Text.Trim();
                empresa.Nome = txtNomeFantasi.Text.Trim();
                empresa.RazãoSocial = txtRazaoSocial.Text.Trim();
                empresa.CodEstadual = mktRegistroEstadual.Text.Trim();
                empresa.Email = txtEmail.Text.Trim();
                empresa.Bairro = txtBairro.Text.Trim();
                empresa.Endereço = txtEndereco.Text.Trim();
                empresa.PontoDeReferencia = txtPontoRef.Text.Trim();

                EmpresaBusiness business = new EmpresaBusiness();
                business.Salvar(empresa);

                MessageBox.Show("Empresa cadastrada com sucesso", "SGE");

                this.Hide();
                Menu tela = new Menu();
                tela.Show();

            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SGE",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
