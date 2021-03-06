﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes.Classes.Empresa;
using WindowsFormsApplication1.Telas.Alterações;
using WindowsFormsApplication1.Telas.Adicionais;

namespace WindowsFormsApplication1.Telas.Consultas
{
    public partial class EmpresaConsulta : UserControl
    {
        public void OpenScreen(UserControl control)
        {
            /*if (pnl.Controls.Count == 1)
                pnlCentru.Controls.RemoveAt(0);
            pnlCentru.Controls.Add(control);*/
        }
        public EmpresaConsulta()
        {
            InitializeComponent();
            AutoCarregar();
        }

        void AutoCarregar()
        {
            EmpresaBusiness buss = new EmpresaBusiness();
            List<EmpresaDTO> lista = buss.Listar();

            dgvEmpresa.AutoGenerateColumns = false;
            dgvEmpresa.DataSource = lista;
        }

        public void CarregarGrid()
        {
            try
            {

                string nome = textBox1.Text.Trim();

                EmpresaBusiness business = new EmpresaBusiness();
                List<EmpresaDTO> dto = business.Consultar(nome);

                dgvEmpresa.AutoGenerateColumns = false;
                dgvEmpresa.DataSource = dto;

           }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao consultar a empresa: " + ex.Message, "SGE",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgvEmpresa_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == 7)
            {
                EmpresaDTO produto = dgvEmpresa.CurrentRow.DataBoundItem as EmpresaDTO;

                this.Hide();
                FrmAlterarEmpresa tela = new FrmAlterarEmpresa();
                tela.LoadScreen(produto);

                tela.Show();

            }

            if (e.ColumnIndex == 8)
            {
                EmpresaDTO empresa = dgvEmpresa.CurrentRow.DataBoundItem as EmpresaDTO;

                DialogResult r = MessageBox.Show("Deseja excluir a empresa?", "SGE",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    EmpresaBusiness business = new EmpresaBusiness();
                    business.Remover(empresa.Id);

                    CarregarGrid();

                }
            }
        }
        

    }
}