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
    }
}
