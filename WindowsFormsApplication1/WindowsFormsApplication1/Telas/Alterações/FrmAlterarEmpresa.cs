using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes.Classes.Empresa;

namespace WindowsFormsApplication1.Telas.Alterações
{
    public partial class FrmAlterarEmpresa : Form
    {
        public FrmAlterarEmpresa()
        {
            InitializeComponent();
        }

        EmpresaDTO empresa;
        public void LoadScreen(EmpresaDTO dto)
        {
            this.empresa = dto;
            mtkCNPJ.Text = dto.Cnpj;
            txtNomeFantasi.Text = dto.Nome;
            txtRazaoSocial.Text = dto.RazãoSocial;
            mktRegistroEstadual.Text = Convert.ToString(dto.CodEstadual);
            mktTelefone.Text = dto.Telefone;
            txtEmail.Text = dto.Email;
            mktCep.Text = dto.Cep;
            txtBairro.Text = dto.Bairro;
            txtEndereco.Text = dto.Endereço;
            txtPontoRef.Text = dto.PontoDeReferencia;

        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
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

                empresa.Id = this.empresa.Id;
                empresa.Cnpj = mtkCNPJ.Text.Trim();
                empresa.Nome = txtNomeFantasi.Text.Trim();
                empresa.RazãoSocial = txtRazaoSocial.Text.Trim();
                empresa.CodEstadual = mktRegistroEstadual.Text.Trim();
                empresa.Email = txtEmail.Text.Trim();
                empresa.Bairro = txtBairro.Text.Trim();
                empresa.Endereço = txtEndereco.Text.Trim();
                empresa.PontoDeReferencia = txtPontoRef.Text.Trim();

                EmpresaBusiness business = new EmpresaBusiness();
                business.Alterar(empresa);

                MessageBox.Show("Empresa alterada com sucesso", "SGE");

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
