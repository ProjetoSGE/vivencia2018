using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes.Classes.Candidato;
using WindowsFormsApplication1.Classes.Classes.Aluno;
using WindowsFormsApplication1.Classes.Classes.Empresa;

namespace WindowsFormsApplication1.Telas.Cadastros
{
    public partial class CadastrarCandidato : Form
    {
        public CadastrarCandidato()
        {
            InitializeComponent();
        }

        void CarregarCombos()
        {
            AlunoBussiness bus = new AlunoBussiness();
            List<AlunoDTO> lista = bus.Listar();

            cboAluno.DisplayMember = nameof(AlunoDTO.Nome);
            cboAluno.ValueMember = nameof(AlunoDTO.Id);
            cboAluno.DataSource = lista;

            AlunoBussiness buss = new AlunoBussiness();
            List<AlunoDTO> listaa = bus.Listar();

            cboAluno.DisplayMember = nameof(AlunoDTO.QualCurso);
            cboAluno.ValueMember = nameof(AlunoDTO.Id);
            cboAluno.DataSource = listaa;

            VagasBusiness busss = new VagasBusiness();
            List<VagasDTO> listaaa = busss.Listar();

            cboAluno.DisplayMember = nameof(VagasDTO.NomeArea);
            cboAluno.ValueMember = nameof(VagasDTO.Id);
            cboAluno.DataSource = listaaa;
        }

        private void btnCadatrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            CandidatoDTO dto = new CandidatoDTO();
            AlunoDTO dto1 = cboAluno.SelectedItem as AlunoDTO;
            VagasDTO dto2 = cboVaga.SelectedItem as VagasDTO;

            dto.IdAluno = dto1.Id;
            dto.IdVaga = dto2.Id;
            dto.Status = null;
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
