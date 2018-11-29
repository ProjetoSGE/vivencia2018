using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            try
            {

               tb_empresas dto = new tb_empresas();
                dto.nm_empresa = txtNome.Text.Trim();
                dto.ds_email = txtEmail.Text.Trim();
                dto.ds_cep = mktCep.Text.Trim();
                dto.ds_bairro = txtBairro.Text.Trim();
                dto.ds_endereco = txtEndereco.Text.Trim();
                dto.nr_telefone = mktTelefone.Text.Trim();
                dto.ds_pontoReferencia= txtPontoRef.Text.Trim();

                VivenciaEntities db = new VivenciaEntities();
                db.tb_empresas.Add(dto);

                db.SaveChanges();

                MessageBox.Show("Empresa cadastrada com sucesso", "SGE");

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SGE",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
