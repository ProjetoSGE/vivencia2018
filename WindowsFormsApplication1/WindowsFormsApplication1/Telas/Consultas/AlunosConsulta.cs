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
using WindowsFormsApplication1.Telas.Cadastros;

namespace WindowsFormsApplication1.Telas.Consultas
{
    public partial class AlunosConsulta : UserControl
    {
        public AlunosConsulta()
        {
            InitializeComponent();
            AutoCarregar();
        }
        void AutoCarregar()
        {
            AlunoBussiness buss = new AlunoBussiness();
            List<AlunoDTO> lista = buss.Listar();

            dgvAluno.AutoGenerateColumns = false;
            dgvAluno.DataSource = lista;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CarregarGrid();
           
        }

        private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                AlunoDTO aluno = dgvAluno.Rows[e.RowIndex].DataBoundItem as AlunoDTO;


                AlunosCadastro tela = new AlunosCadastro();
                tela.LoadScreen(aluno);
                tela.ShowDialog();
                this.Hide();

            }

            if (e.ColumnIndex == 5)
            {
                AlunoDTO produtoss = dgvAluno.CurrentRow.DataBoundItem as AlunoDTO;

                DialogResult r = MessageBox.Show("Deseja excluir o aluno ?", "Realce Sua Beleza",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    AlunoBussiness business = new AlunoBussiness();
                    business.Remover(produtoss.ID);

                    CarregarGrid();
                }
            }
        }

        private void CarregarGrid()
        {
            AlunoBussiness business = new AlunoBussiness();
            List<AlunoDTO> lista = business.Consultar(textBox1.Text);

            dgvAluno.AutoGenerateColumns = false;
            dgvAluno.DataSource = lista;
        }
    }
}
