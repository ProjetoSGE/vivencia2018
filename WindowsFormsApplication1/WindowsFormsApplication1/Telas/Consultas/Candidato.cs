using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes.Classes.Candidato;
using WindowsFormsApplication1.Telas.Alterações;

namespace WindowsFormsApplication1.Telas.Consultas
{
    public partial class Candidato : UserControl
    {
        public Candidato()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            CandidatoBusiness buss = new CandidatoBusiness();
            List<CandidatoView> lista = buss.List();

            dgvAluno.AutoGenerateColumns = false;
            dgvAluno.DataSource = lista;
        }

        void CarregarGrid()
        {
            string name, status;
            name = txtNome.Text;
            status = (string)cboStatus.SelectedItem;

            if (status == "Todos")
            {
                status = "";
            }

            CandidatoBusiness buss = new CandidatoBusiness();
            List<CandidatoView> lista = buss.Search(name, status);

            dgvAluno.DataSource = lista;
        }

        private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CandidatoView dto = dgvAluno.Rows[e.RowIndex].DataBoundItem as CandidatoView;

            if (e.ColumnIndex == 5)
            {
                frmAlterarCandidato tela = new frmAlterarCandidato();
                tela.LoadScreen(dto);
                tela.ShowDialog();

                CarregarGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
