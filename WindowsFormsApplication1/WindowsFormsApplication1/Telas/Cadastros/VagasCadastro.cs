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

namespace WindowsFormsApplication1.Telas.Cadastros
{
    public partial class VagasCadastro : UserControl
    {
        public VagasCadastro()
        {
            InitializeComponent();
            CarregarCombos();
        }

        void CarregarCombos()
        {
            EmpresaDTO dto = new EmpresaDTO();
            
            EmpresaBusiness buss = new EmpresaBusiness();
            List<EmpresaDTO> lista = buss.Listar();

            cboEmpresa.ValueMember = nameof(EmpresaDTO.Id);
            cboEmpresa.DisplayMember = nameof(EmpresaDTO.Nome);
            cboEmpresa.DataSource = lista;

        }

        private void chkOutros_CheckedChanged(object sender, EventArgs e)
        {
            chkOutros.Visible = false;
            txtOutros.Visible = true;
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            VagasDTO dto = new VagasDTO();
            EmpresaDTO empresa = cboEmpresa.SelectedItem as EmpresaDTO;

            dto.NomeVaga = txtNome.Text;
            dto.NomeArea = txtArea.Text;
            dto.QuantidadeDeVaga = (int)nudQtd.Value;
            dto.DataDeInicio = dtInicioEstagio.Value;
            dto.Sexo = (string)cboSexo.SelectedItem;
            dto.IdEmpresa = empresa.Id;

            DateTime inicio = Convert.ToDateTime(mkbInicio.Text);
            TimeSpan inicioHora = inicio.TimeOfDay;
            dto.HorarioEntrada = Convert.ToString(inicioHora);

            DateTime fim = Convert.ToDateTime(mkbFim.Text);
            TimeSpan fimHora = inicio.TimeOfDay;
            dto.HorarioSaida = Convert.ToString(fimHora);

            DateTime intervalo = Convert.ToDateTime(mkbIntervalo.Text);
            TimeSpan intervaloHora = inicio.TimeOfDay;
            dto.Intervalo = Convert.ToString(intervaloHora);

            dto.SeguroDeVida = chkSeguroVida.Checked;
            dto.AuxTransporte = chkAuxilioTrasporte.Checked;
            dto.RecRemunerado = chkRecessoRemuneracao.Checked;
            dto.ValeRefeicao = chkValeRef.Checked;
            dto.CestaBasica = chkCestaBasica.Checked;
            dto.ReLocal = chkRefeitorioLocal.Checked;
            dto.AssisMedica = chkAssisMedica.Checked;
            dto.NivelIngles = cboNvlIngles.Text;
            dto.InfoOffice = chkPacoteOffice.Checked;
            dto.InfoAutoCAD = chkAutoCad.Checked;
            dto.InfoCorel = chkCorelDraw.Checked;
            dto.InfoPhotoShop = chkPhotoshop.Checked;
            dto.InfoProgramacao = chkProgramacao.Checked;
            dto.Outros = txtOutros.Text;
            dto.Observacao = txtObs.Text;
            dto.CompPessoal = txtCompetecias.Text;
            dto.Tarefas = txtTarefa.Text;

            VagasBusiness buss = new VagasBusiness();
            buss.Salvar(dto);

            MessageBox.Show("Vaga salva com sucesso!");
        }
    }
}
