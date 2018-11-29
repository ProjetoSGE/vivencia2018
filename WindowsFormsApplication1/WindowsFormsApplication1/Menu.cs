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
            if (pnlCentro.Controls.Count == 1)
                pnlCentro.Controls.RemoveAt(0);
            pnlCentro.Controls.Add(control);
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

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
    }
}
