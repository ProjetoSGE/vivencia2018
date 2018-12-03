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
        }

        AlunoDTO alunos;
        public void LoadScrean(AlunoDTO aluno)
        {
            this.alunos = aluno;

            txtNome.Text = aluno.Nome;
            cboCurso.Text = aluno.QualCurso;
            cboAnoEstudou.Text = aluno.AnoDeEstudo;
            dtpDataNasc.Value = Convert.ToDateTime(aluno.Nascimento);
            mskCEP.Text = aluno.Cep;
            txtEndereco.Text = aluno.Endereco;
            txtBairro.Text = aluno.Bairro;
            txtNumero.Text = aluno.Numero;
            txtIdade.Text = aluno.Idade;
            mskRes.Text = aluno.Fixo;
            mskRecado.Text = aluno.Celular;
            rdbSim.Checked = aluno.SeEstuda;
            cboSerie.Text = aluno.Curso;
            cboTurno.Text = aluno.Turno;
            txtPreferencia.Text = aluno.AreaPreferencial;
            txtExperiencia.Text = aluno.ExpProfissional;
            txtRg.Text = aluno.Rg;


        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
                this.alunos.Nome = txtNome.Text;
                this.alunos.Idade = txtIdade.Text;
                this.alunos.AreaPreferencial = txtPreferencia.Text;
                this.alunos.Bairro = txtBairro.Text;
                this.alunos.Celular = mskRecado.Text;
                this.alunos.Fixo = mskRes.Text;
                this.alunos.Cep = mskCEP.Text;
                this.alunos.Endereco = txtEndereco.Text;
                this.alunos.ExpProfissional = txtExperiencia.Text;
                this.alunos.Nascimento = dtpDataNasc.Value.Date;
                this.alunos.Curso = cboCurso.SelectedItem.ToString();
                this.alunos.Turno = cboTurno.SelectedItem.ToString();
                this.alunos.QualCurso = cboSerie.SelectedItem.ToString();
                this.alunos.SeEstuda = rdbSim.Checked;
                this.alunos.Numero = txtNumero.Text;
                this.alunos.AnoDeEstudo = cboAnoEstudou.SelectedItem.ToString();
                this.alunos.Rg = txtRg.Text;

            
        }
    }
}
