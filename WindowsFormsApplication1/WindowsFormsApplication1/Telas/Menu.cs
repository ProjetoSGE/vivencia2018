using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Telas;
using WindowsFormsApplication1.Telas.Adicionais;
using WindowsFormsApplication1.Telas.Cadastros;
using WindowsFormsApplication1.Telas.Consultas;


namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public void OpenScreen(UserControl control)
        {
            if (pnlCentru.Controls.Count == 1)
                pnlCentru.Controls.RemoveAt(0);
            pnlCentru.Controls.Add(control);
        }

        private void control_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vagaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home frm = new Home();
            OpenScreen(frm);
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunosCadastro frm = new AlunosCadastro();
            OpenScreen(frm);
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpresaCadastro frm = new EmpresaCadastro();
            OpenScreen(frm);
        }

        private void vagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VagasCadastro frm = new VagasCadastro();
            OpenScreen(frm);
        }

        private void alunosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlunosConsulta frm = new AlunosConsulta();
            OpenScreen(frm);
        }

        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Candidato frm = new Candidato();
            OpenScreen(frm);
        }

        private void empresasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmpresaConsulta frm = new EmpresaConsulta();
            OpenScreen(frm);
        }

        private void vagasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VagasConsulta frm = new VagasConsulta();
            OpenScreen(frm);
        }

        private void empresasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EmpresaCadastro tela = new EmpresaCadastro();
            OpenScreen(tela);
        }

        private void vagasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            VagasCadastro tela = new VagasCadastro();
            OpenScreen(tela);
        }

        private void candidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunosCadastro tela = new AlunosCadastro();
            OpenScreen(tela);
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlunosConsulta tela = new AlunosConsulta();
            OpenScreen(tela);
        }

        private void candidatoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Candidato tela = new Candidato();
            OpenScreen(tela);
        }

        private void empreSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpresaConsulta tela = new EmpresaConsulta();
            OpenScreen(tela);
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Home tela = new Home();
            OpenScreen(tela);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja realmente sair?", "SGE",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void pnlCentru_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vagasToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void vagasToolStripMenuItem1_Click_2(object sender, EventArgs e)
        {
            VagasConsulta tela = new VagasConsulta();
            OpenScreen(tela);
        }

        private void empresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            emailempresa tela = new emailempresa();
            OpenScreen(tela);
        }

        private void alunoToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
