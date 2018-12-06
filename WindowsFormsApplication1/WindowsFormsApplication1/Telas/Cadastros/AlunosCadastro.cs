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
using WindowsFormsApplication1.Classes.Classes.Auxiliares;
using WindowsFormsApplication1.Classes.Diferenciais.CEP;
using System.Net;
using Newtonsoft.Json;

namespace WindowsFormsApplication1.Telas.Cadastros
{
    public partial class AlunosCadastro : UserControl
    {
        public AlunosCadastro()
        {
            InitializeComponent();
        }




        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AlunosCadastro_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        
        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoDTO dto = new AlunoDTO();

                if (mskCEP.MaskCompleted)
                {
                    dto.Cep = mskCEP.Text.Trim();

                }
                else
                {
                    throw new ArgumentException("CEP é obrigatório");
                }

                if (mskRecado.MaskCompleted)
                {
                    dto.Celular = mskRecado.Text.Trim();

                }
                else
                {
                    throw new ArgumentException("Celular é obrigatório");
                }

                if (mtkRG.MaskCompleted)
                {
                    dto.Rg = mtkRG.Text.Trim();

                }
                else
                {
                    throw new ArgumentException("RG é obrigatório");
                }


                dto.Nome = txtNome.Text.Trim();
                dto.Curso = cboCurso.Text;
                dto.Idade = numericUpDown1.Text;
                dto.AreaPreferencial = txtPreferencia.Text.Trim();
                dto.Bairro = txtBairro.Text.Trim();
                dto.Fixo = mskRes.Text.Trim();
                dto.Endereco = txtEndereco.Text.Trim();
                dto.ExpProfissional = txtExperiencia.Text.Trim();
                dto.Nascimento = dtpDataNasc.Value;
                dto.QualCurso = cboSerie.Text;
                dto.Turno = cboTurno.Text;
                dto.SeEstuda = rdnSim.Checked;
                dto.Numero = txtNumero.Text.Trim();
                dto.AnoDeEstudo = cboAnoEstudou.Text.Trim();
                dto.email = txtEmail.Text;

                AlunoBussiness business = new AlunoBussiness();
                business.Salvar(dto);

                MessageBox.Show("Aluno cadastrado com sucesso", "SGE");

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
        private CorreioResponde BuscarAPICorreio(string cep)
        {
            // Cria objeto responsável por conversar com uma API
            WebClient rest = new WebClient();
            rest.Encoding = Encoding.UTF8;

            // Chama API do correio, concatenando o cep
            string resposta = rest.DownloadString("https://viacep.com.br/ws/" + cep + "/json");

            // Transforma a resposta do correio em DTO
            CorreioResponde correio = JsonConvert.DeserializeObject<CorreioResponde>(resposta);
            return correio;
        }
        private void rdnSim_CheckedChanged(object sender, EventArgs e)
        {
            cboSerie.Enabled = true;
            cboTurno.Enabled = true;
               
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            cboSerie.Enabled = false;
            cboTurno.Enabled = false;
        }

        private void mskCEP_Validated(object sender, EventArgs e)
        {
            // Lê e formata o CEP do textbox
            string cep = mskCEP.Text.Trim().Replace("-", "");

            // Chama função BuscarAPICorreio
            CorreioResponde correio = BuscarAPICorreio(cep);

            // Altera os valores dos textbox com a resposta do correio
            txtEndereco.Text = correio.Logradouro + correio.Complemento;
            txtBairro.Text = correio.bairro;

        }
    }
}
