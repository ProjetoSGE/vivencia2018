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
            string vaga = txtVaga.Text;

            VagasBusiness buss = new VagasBusiness();
            List<VagasView> lista = buss.Consultar(vaga);

            dgvVaga.AutoGenerateColumns = false;
            dgvVaga.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
