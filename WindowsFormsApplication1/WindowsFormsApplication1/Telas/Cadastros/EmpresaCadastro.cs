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
            /*try
            {
                EmpresaDTO dto = new EmpresaDTO();
                dto.Empresa = txtNome.Text.Trim();
                dto.Email = txtEmail.Text.Trim();
                dto.CEP = mktCep.Text.Trim();
                dto.Bairro = txtBairro.Text.Trim();
                dto.Endereço = txtEndereco.Text.Trim();
                dto.Telefone = mktTelefone.Text.Trim();
                dto.PontoDeReferencia = txtPontoRef.Text.Trim();

                EmpresaBusiness business = new EmpresaBusiness();
                business.Salvar(dto);

                MessageBox.Show("Empresa cadastrada com sucesso", "SGE");

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SGE",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/





        }
    }
}
