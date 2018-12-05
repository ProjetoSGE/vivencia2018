using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes.Classes.Empresa;

namespace WindowsFormsApplication1.Telas.Alterações
{
    public partial class FrmAlterarVagas : Form
    {
        public FrmAlterarVagas()
        {
            InitializeComponent();
        }

        VagasDTO vagas;
        public void LoadScrean(VagasDTO vaga)
        {
            this.vagas = vaga;
            EmpresaDTO empresa = cboEmpresa.SelectedItem as EmpresaDTO;

            txtNome.Text = vagas.NomeVaga;
            txtArea.Text = vagas.NomeArea;
            nudQtd.Value = vagas.QuantidadeDeVaga;
            dtInicioEstagio.Value = vagas.DataDeInicio;
            cboSexo.SelectedItem = vagas.Sexo;
            empresa.Id = vagas.IdEmpresa;

            dtInicioEstagio.Value = vagas.DataDeInicio;
            mtkInicio.Text = vagas.HorarioEntrada;
            mtkFim.Text = vagas.HorarioSaida;
            mtkIntervalo.Text = vagas.Intervalo;

            chkSeguroVida.Checked = vagas.SeguroDeVida;
            chkAuxilioTrasporte.Checked = vagas.AuxTransporte;
            chkRecessoRemuneracao.Checked = vagas.RecRemunerado;
            chkValeRef.Checked = vagas.ValeRefeicao;
            chkCestaBasica.Checked = vagas.CestaBasica;
            chkRefeitorioLocal.Checked = vagas.ReLocal;
            chkAssisMedica.Checked = vagas.AssisMedica;
            chkPacoteOffice.Checked = vagas.InfoOffice;
            chkAutoCad.Checked = vagas.InfoAutoCAD;
            chkCorelDraw.Checked = vagas.InfoCorel;
            chkPhotoshop.Checked = vagas.InfoPhotoShop;
            chkProgramacao.Checked = vagas.InfoProgramacao;
            txtOutros.Text = vagas.Outros;
            txtTarefa.Text = vagas.Tarefas;
            txtCompetecias.Text = vagas.CompPessoal;
            txtObs.Text = vagas.Observacao;

                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EmpresaDTO empresa = cboEmpresa.SelectedItem as EmpresaDTO;

                this.vagas.NomeVaga = txtNome.Text.Trim();
                this.vagas.NomeArea = txtArea.Text.Trim();
                this.vagas.QuantidadeDeVaga = (int)nudQtd.Value;
                this.vagas.DataDeInicio = dtInicioEstagio.Value;
                this.vagas.Sexo = (string)cboSexo.SelectedItem;
                this.vagas.IdEmpresa = empresa.Id;

                DateTime inicio = Convert.ToDateTime(mtkInicio.Text);
                TimeSpan inicioHora = inicio.TimeOfDay;
                this.vagas.HorarioEntrada = Convert.ToString(inicioHora);

                DateTime fim = Convert.ToDateTime(mtkFim.Text);
                TimeSpan fimHora = fim.TimeOfDay;
                this.vagas.HorarioSaida = Convert.ToString(fimHora);

                DateTime intervalo = Convert.ToDateTime(mtkIntervalo.Text);
                TimeSpan intervaloHora = intervalo.TimeOfDay;
                this.vagas.Intervalo = Convert.ToString(intervaloHora);

                this.vagas.SeguroDeVida = chkSeguroVida.Checked;
                this.vagas.AuxTransporte = chkAuxilioTrasporte.Checked;
                this.vagas.RecRemunerado = chkRecessoRemuneracao.Checked;
                this.vagas.ValeRefeicao = chkValeRef.Checked;
                this.vagas.CestaBasica = chkCestaBasica.Checked;
                this.vagas.ReLocal = chkRefeitorioLocal.Checked;
                this.vagas.AssisMedica = chkAssisMedica.Checked;
                this.vagas.NivelIngles = cboNvlIngles.Text;
                this.vagas.InfoOffice = chkPacoteOffice.Checked;
                this.vagas.InfoAutoCAD = chkAutoCad.Checked;
                this.vagas.InfoCorel = chkCorelDraw.Checked;
                this.vagas.InfoPhotoShop = chkPhotoshop.Checked;
                this.vagas.InfoProgramacao = chkProgramacao.Checked;
                this.vagas.Outros = txtOutros.Text.Trim();
                this.vagas.Observacao = txtObs.Text.Trim();
                this.vagas.CompPessoal = txtCompetecias.Text.Trim();
                this.vagas.Tarefas = txtTarefa.Text.Trim();

                VagasBusiness buss = new VagasBusiness();
                buss.Salvar(vagas);

                MessageBox.Show("Vaga alterada com sucesso!", "SGE");

                this.Hide();
                Menu tela = new Menu();
                tela.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGE",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
    }
}
