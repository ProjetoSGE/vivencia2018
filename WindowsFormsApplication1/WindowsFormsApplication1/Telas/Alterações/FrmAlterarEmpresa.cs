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
            try
            {
                EmpresaDTO empresa = new EmpresaDTO();
                empresa.Id = this.empresa.Id;
                empresa.Cnpj = mtkCNPJ.Text.Trim();
                empresa.Nome = txtNomeFantasi.Text.Trim();
                empresa.RazãoSocial = txtRazaoSocial.Text.Trim();
                empresa.CodEstadual = Convert.ToInt32(mktRegistroEstadual.Text.Trim());
                empresa.Telefone = mktTelefone.Text.Trim();
                empresa.Email = txtEmail.Text.Trim();
                empresa.Cep = mktCep.Text.Trim();
                empresa.Bairro = txtBairro.Text.Trim();
                empresa.Endereço = txtEndereco.Text.Trim();
                empresa.PontoDeReferencia = txtPontoRef.Text.Trim();

                EmpresaBusiness business = new EmpresaBusiness();
                business.Alterar(empresa);

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
