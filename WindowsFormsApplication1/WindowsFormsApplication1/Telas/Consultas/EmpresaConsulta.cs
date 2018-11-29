using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Telas.Consultas
{
    public partial class EmpresaConsulta : UserControl
    {
        public EmpresaConsulta()
        {
            InitializeComponent();
        }

        public void CarregarGrid()
        {
            try
            {
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao consultar a empresa: " + ex.Message, "SGE",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgvEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                EmpresaDTO produto = dgvEmpresa.CurrentRow.DataBoundItem as EmpresaDTO;

                // this.Hide();
                // AlterarProduto tela = new AlterarProduto();
                // tela.LoadScreen(produto);

                // tela.Show();

            }

            if (e.ColumnIndex == 8)
            {
                EmpresaDTO empresa = dgvEmpresa.CurrentRow.DataBoundItem as EmpresaDTO;

                DialogResult r = MessageBox.Show("Deseja excluir a empresa?", "SGE",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    EmpresaBusiness business = new EmpresaBusiness();
                    business.Remover(empresa.ID);

                    CarregarGrid();

                }
            }
        }

    }
}