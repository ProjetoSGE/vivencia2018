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
         
        }

        private void CarregarGrid()
        {
            AlunoBussiness business = new AlunoBussiness();
            List<AlunoDTO> lista = business.Consultar(textBox1.Text);

            dgvAluno.AutoGenerateColumns = false;
            dgvAluno.DataSource = lista;
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
