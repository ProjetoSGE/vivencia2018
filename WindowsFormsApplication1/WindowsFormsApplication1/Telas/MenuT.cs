using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Telas
{
    public partial class MenuT : Form
    {
        public MenuT()
        {
            InitializeComponent();
        }
        public void OpenScreen(UserControl control)
        {
            if (pnlCentro.Controls.Count == 1)
                pnlCentro.Controls.RemoveAt(0);
            pnlCentro.Controls.Add(control);
        }
        

        private void asdaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmteste frm = new frmteste();
            OpenScreen(frm);
        }
    }
}
