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
using WindowsFormsApplication1.Classes.Classes.Empresa;

namespace WindowsFormsApplication1.Telas.Cadastros
{
    public partial class frmCadastrarCandidato : UserControl
    {
        public frmCadastrarCandidato()
        {
            InitializeComponent();
            CarregarCombos();
        }

        void CarregarCombos()
        {
            AlunoBussiness db = new AlunoBussiness();
            List<AlunoDTO> lista = db.Listar();

            cboAluno.ValueMember = nameof(AlunoDTO.Id);
            cboAluno.DisplayMember = nameof(AlunoDTO.Nome);
            cboAluno.DataSource = lista;

            VagasBusiness buss = new VagasBusiness();
            List<VagasDTO> vagas = buss.Listar();

            cboVaga.ValueMember = nameof(VagasDTO.Id);
            cboVaga.DisplayMember = nameof(VagasDTO.NomeVaga);
            cboVaga.DataSource = vagas;
        }
    }
}
