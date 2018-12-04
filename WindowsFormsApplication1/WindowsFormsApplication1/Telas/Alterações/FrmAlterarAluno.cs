using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes.Classes.Aluno;

namespace WindowsFormsApplication1.Telas.Alterações
{
    public partial class FrmAlterarAluno : Form
    {
        public FrmAlterarAluno()
        {
            InitializeComponent();
            //CarregarCombos();
        }

       /* void CarregarCombos()
        {
            AlunoBussiness business = new AlunoBussiness();
            List<AlunoDTO> lista = business.Listar();

            cboCurso.ValueMember = nameof(AlunoDTO.Id);
            cboCurso.DisplayMember = nameof(AlunoDTO.Curso);
            cboCurso.DataSource = lista;

            cboSerie.ValueMember = nameof(AlunoDTO.Id);
            cboSerie.DisplayMember = nameof(AlunoDTO.QualCurso);
            cboSerie.DataSource = lista;

            cboTurno.ValueMember = nameof(AlunoDTO.Id);
            cboTurno.DisplayMember = nameof(AlunoDTO.Turno);
            cboTurno.DataSource = lista;


        }*/


        AlunoDTO alunos;
        public void LoadScrean(AlunoDTO aluno)
        {
            this.alunos = aluno;

            txtNome.Text = aluno.Nome;
            cboAnoEstudou.Text = aluno.AnoDeEstudo;
            dtpDataNasc.Value = Convert.ToDateTime(aluno.Nascimento);
            mskCEP.Text = aluno.Cep;
            txtEndereco.Text = aluno.Endereco;
            txtBairro.Text = aluno.Bairro;
            txtNumero.Text = aluno.Numero;
            numericUpDown1.Value = aluno.Idade;
            mskRes.Text = aluno.Fixo;
            mskRecado.Text = aluno.Celular;
            rdbSim.Checked = aluno.SeEstuda;
            txtPreferencia.Text = aluno.AreaPreferencial;
            txtExperiencia.Text = aluno.ExpProfissional;
            mtkRG.Text = aluno.Rg;


        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskCEP.MaskCompleted)
                {
                    alunos.Cep = mskCEP.Text.Trim();

                }
                else
                {
                    throw new ArgumentException("CEP é obrigatório");
                }

                if (mskRecado.MaskCompleted)
                {
                    alunos.Celular = mskRecado.Text.Trim();

                }
                else
                {
                    throw new ArgumentException("Celular é obrigatório");
                }

                if (mtkRG.MaskCompleted)
                {
                    alunos.Rg = mtkRG.Text.Trim();

                }
                else
                {
                    throw new ArgumentException("RG é obrigatório");
                }



                this.alunos.Nome = txtNome.Text;
                this.alunos.Curso = cboCurso.Text;
                this.alunos.Idade = Convert.ToInt32(numericUpDown1.Value);
                this.alunos.AreaPreferencial = txtPreferencia.Text.Trim();
                this.alunos.Bairro = txtBairro.Text.Trim();
                this.alunos.Fixo = mskRes.Text.Trim();
                this.alunos.Endereco = txtEndereco.Text.Trim();
                this.alunos.ExpProfissional = txtExperiencia.Text.Trim();
                this.alunos.Nascimento = dtpDataNasc.Value.Date;
                this.alunos.QualCurso = cboSerie.Text;
                this.alunos.Turno = cboTurno.Text;
                this.alunos.SeEstuda = rdbSim.Checked;
                this.alunos.Numero = txtNumero.Text.Trim();
                this.alunos.AnoDeEstudo = cboAnoEstudou.Text.Trim();


                AlunoBussiness buss = new AlunoBussiness();
                buss.Alterar(alunos);


                MessageBox.Show("Aluno alterado com sucesso.", "SGE",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            cboSerie.Enabled = true;
            cboTurno.Enabled = true;
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            cboSerie.Enabled = false;
            cboTurno.Enabled = false;
        }
    }
}
