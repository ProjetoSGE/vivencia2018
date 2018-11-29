using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            VivenciaEntities db = new VivenciaEntities();

            tb_alunos dto = new tb_alunos();
            dto.nm_aluno = txtNome.Text; 
            dto.nm_curso = txtCurso.Text;
            dto.ds_idade = Convert.ToInt32(txtIdade.Text);
            dto.dt_nascimento = Convert.ToDateTime(mskNascimento.Text);
            dto.Numero = Convert.ToInt32(txtN.Text);
            dto.QualCurso = txtQualCurso.Text;
            dto.SeEstuda = cboEstuda.Text;
            // turno faltando
            dto.AnoDeEstudo = txtAno.Text;
            dto.AreaPreferencial = txtExperiencia.Text;
            dto.Bairro = txtBairro.Text;
            dto.Celular = mskRecado.Text;
            dto.Endereco = txtEndereco.Text;
            dto.Fixo = mskRes.Text;
            dto.CEP = mskCEP.Text;
            dto.ExpProfissional = txtExperiencia.Text;

            db.tb_alunos.Add(dto);
            db.SaveChanges();

            MessageBox.Show("Aluno salvo com sucesso");


        }
    }
}
