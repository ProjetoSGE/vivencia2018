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

namespace WindowsFormsApplication1.Telas.Cadastros
{
    public partial class AlunosCadastro : UserControl
    {
        public AlunosCadastro()
        {
            InitializeComponent();
        }




        private void btnsalvar_Click(object sender, EventArgs e)
        {

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

            /*try
            {*/
                AlunoDTO dto = new AlunoDTO();

                dto.Nome = txtNome.Text;
                dto.Idade = txtIdade.Text;
                dto.AreaPreferencial = txtPreferencia.Text;
                dto.Bairro = txtBairro.Text;
                dto.Celular = mskRecado.Text;
                dto.Fixo = mskRes.Text;
                dto.Cep = mskCEP.Text;
                dto.Endereco = txtEndereco.Text;
                dto.ExpProfissional = txtExperiencia.Text;
                dto.Nascimento = dtpDataNasc.Value.Date;
                dto.Curso = cboCurso.SelectedItem.ToString();
                dto.Turno = cboTurno.SelectedItem.ToString();
                dto.QualCurso = cboSerie.SelectedItem.ToString();
                dto.SeEstuda = rdnSim.Checked;
                dto.Numero = txtNumero.Text;
                dto.AnoDeEstudo = cboAnoEstudou.SelectedItem.ToString();
                dto.Rg = txtRG.Text;

                AlunoBussiness business = new AlunoBussiness();
                business.Salvar(dto);

            /*}
            catch (Exception)
            {

                throw new ArgumentException("Preencha todos os campos utilizando apenas informações válidas ");
                
            }*/
            







        }
    }
}
