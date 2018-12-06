using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes.Classes.Empresa;
using WindowsFormsApplication1.Classes.Classes.Vagas;
using WindowsFormsApplication1.Telas.Alterações;

namespace WindowsFormsApplication1.Telas.Consultas
{
    public partial class VagasConsulta : UserControl
    {
        public VagasConsulta()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            VagasBusiness buss = new VagasBusiness();
            List<VagasView> lista = buss.ListarView();

            dgvVaga.AutoGenerateColumns = false;
            dgvVaga.DataSource = lista;
        }

        void CarregarGrid()
        {
            string vaga = txtVaga.Text.Trim();

            VagasBusiness buss = new VagasBusiness();
            List<VagasView> lista = buss.Consultar(vaga);

            dgvVaga.AutoGenerateColumns = false;
            dgvVaga.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgvVaga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6)
                {
                    VagasDTO funcionario = dgvVaga.CurrentRow.DataBoundItem as VagasDTO;

                    DialogResult r = MessageBox.Show("Deseja excluir a vaga?", "SGE",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        VagasBusiness business = new VagasBusiness();
                        business.Remover(funcionario.Id);

                        CarregarGrid();

                    }
                }
                if (e.ColumnIndex == 5)
                {
                    VagasDTO funcionario = dgvVaga.CurrentRow.DataBoundItem as VagasDTO;

                    DialogResult r = MessageBox.Show("Deseja alterar a vaga?", "SGE",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        VagasDTO dto = dgvVaga.Rows[e.RowIndex].DataBoundItem as VagasDTO;
                        this.Hide();
                        FrmAlterarVagas tela = new FrmAlterarVagas();
                        tela.LoadScrean(dto);
                        tela.Show();


                    }
                }
            }
            catch (Exception)
            {
                /* MessageBox.Show("Não foi possível realizar a ação requisitada.", "SGE",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);*/



            }
        }
    }
}
