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
using WindowsFormsApplication1.Classes.Classes.Vagas;
using WindowsFormsApplication1.Classes.Classes.Candidato;

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
            List<VagasView> vagas = buss.ListarView();

            cboVaga.ValueMember = nameof(VagasView.Id);
            cboVaga.DisplayMember = nameof(VagasView.NomeVaga);
            cboVaga.DataSource = vagas;
        }

        private void cboAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlunoDTO dto = cboAluno.SelectedItem as AlunoDTO;

            txtCurso.Text = dto.Curso;
            txtAno.Text = dto.AnoDeEstudo;
            txtRG.Text = dto.Rg;
            txtNasci.Text = dto.Nascimento.ToString();
            txtAreaPreferencial.Text = dto.AreaPreferencial;
        }

        private void cboVaga_SelectedIndexChanged(object sender, EventArgs e)
        {
            VagasView dto = cboVaga.SelectedItem as VagasView;

            txtAreaVaga.Text = dto.NomeVaga;
            txtEmpresa.Text = dto.Empresa;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CandidatoDTO dto = new CandidatoDTO();
            AlunoDTO aluno = cboAluno.SelectedItem as AlunoDTO;
            VagasDTO vagas = cboVaga.SelectedItem as VagasDTO;

            dto.IdAluno = aluno.Id;
            dto.IdVaga = vagas.Id;
            dto.Status = "Em Espera";

            CandidatoBusiness buss = new CandidatoBusiness();
            buss.Save(dto);

            MessageBox.Show("Candidato cadastrado com sucesso!");
        }
    }
}
