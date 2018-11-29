using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        VivenciaEntities db = new VivenciaEntities();

        void AutoCarregar()
        {
           
            var get_data = from c in db.tb_alunos select c;
             
           
            dgvAluno.AutoGenerateColumns = false;
            dgvAluno.DataSource = get_data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CarregarGrid();
           
        }
        public void OpenScreen(UserControl control)
        {
            if (pnlCentro.Controls.Count == 1)
                pnlCentro.Controls.RemoveAt(0);
            pnlCentro.Controls.Add(control);
        }
        private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                tb_alunos aluno = dgvAluno.Rows[e.RowIndex].DataBoundItem as tb_alunos;


                AlunosCadastro tela = new AlunosCadastro();
                tela.LoadScreen(aluno);
                tela.ShowDialog();
                this.Hide();

            }

            if (e.ColumnIndex == 5)
            {
                tb_alunos produtoss = dgvAluno.CurrentRow.DataBoundItem as tb_alunos;

                DialogResult r = MessageBox.Show("Deseja excluir o aluno ?", "Realce Sua Beleza",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                   


                    db.tb_alunos.Remove(produtoss);
                    db.SaveChanges();



                    CarregarGrid();
                }
            }
        }

        private void CarregarGrid()
        {
            var get_data = from c in db.tb_alunos select c;


            dgvAluno.AutoGenerateColumns = false;
            dgvAluno.DataSource = get_data;

           
        }
    }
}
