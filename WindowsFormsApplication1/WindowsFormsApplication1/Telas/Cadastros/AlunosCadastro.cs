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
            CarregarImagem();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            AlunoDTO dto = new AlunoDTO();
            dto.Nome = txtNome.Text; 
           // dto.NomeCurso = txtCurso.Text;
            dto.Idade = Convert.ToInt32(txtIdade.Text);
           // dto.Nascimento = Convert.ToDateTime(mskNascimento.Text);
            dto.Numero = Convert.ToInt32(txtN.Text);
           // dto.QualCurso = txtQualCurso.Text;
           // dto.SeEstuda = cboEstuda.Text;
            // turno faltando
           // dto.AnoDeEstudo = txtAno.Text;
            dto.AreaPreferencial = txtExperiencia.Text;
            dto.Bairro = txtBairro.Text;
            dto.Celular = mskRecado.Text;
            dto.Endereco = txtEndereco.Text;
            dto.Fixo = mskRes.Text;
            dto.CEP = mskCEP.Text;
            dto.ExpProfissional = txtExperiencia.Text;

            AlunoBussiness bussiness = new AlunoBussiness();
            bussiness.Salvar(dto);

            MessageBox.Show("Aluno salvo com sucesso");


        }

        private void label12_Click(object sender, EventArgs e)
        {
         
        }
        void CarregarImagem()
        {
            var aux = new Auxiliares();
            panel1.BackgroundImage = aux.BotaoFechar;
            
        }
    }
}
