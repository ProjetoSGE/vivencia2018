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

namespace WindowsFormsApplication1.Telas.Alterações
{
    public partial class frmAlterarCandidato : Form
    {
        public frmAlterarCandidato()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        CandidatoView dto;
        public void LoadScreen(CandidatoView dto)
        {
            this.dto = dto;
            txtCandidato.Text = dto.Aluno;
            txtVaga.Text = dto.Vaga;
            cboStatus.Text = dto.Status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CandidatoBusiness buss = new CandidatoBusiness();
            CandidatoView candidato = new CandidatoView();

            candidato.Id = this.dto.Id;
            candidato.Aluno = txtCandidato.Text;
            candidato.Vaga = txtVaga.Text;
            candidato.Status = cboStatus.Text;

            buss.Update(candidato);

            this.Close();
        }
    }
}
