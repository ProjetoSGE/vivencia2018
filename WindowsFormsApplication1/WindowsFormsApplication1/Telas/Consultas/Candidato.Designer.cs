﻿namespace WindowsFormsApplication1.Telas.Consultas
{
    partial class Candidato
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCandidato = new System.Windows.Forms.DataGridView();
            this.pnVoltar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnFechar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMinimizar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pesquisar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidato)).BeginInit();
            this.pnVoltar.SuspendLayout();
            this.pnFechar.SuspendLayout();
            this.pnMinimizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCandidato
            // 
            this.dgvCandidato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidato.Location = new System.Drawing.Point(32, 83);
            this.dgvCandidato.Name = "dgvCandidato";
            this.dgvCandidato.Size = new System.Drawing.Size(696, 408);
            this.dgvCandidato.TabIndex = 4;
            // 
            // pnVoltar
            // 
            this.pnVoltar.Controls.Add(this.flowLayoutPanel1);
            this.pnVoltar.Location = new System.Drawing.Point(0, 0);
            this.pnVoltar.Name = "pnVoltar";
            this.pnVoltar.Size = new System.Drawing.Size(23, 23);
            this.pnVoltar.TabIndex = 44;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnFechar
            // 
            this.pnFechar.Controls.Add(this.flowLayoutPanel2);
            this.pnFechar.Location = new System.Drawing.Point(732, 0);
            this.pnFechar.Name = "pnFechar";
            this.pnFechar.Size = new System.Drawing.Size(23, 23);
            this.pnFechar.TabIndex = 45;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(32, 13);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // pnMinimizar
            // 
            this.pnMinimizar.Controls.Add(this.flowLayoutPanel3);
            this.pnMinimizar.Location = new System.Drawing.Point(709, 0);
            this.pnMinimizar.Name = "pnMinimizar";
            this.pnMinimizar.Size = new System.Drawing.Size(23, 23);
            this.pnMinimizar.TabIndex = 46;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(32, 13);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(646, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 38);
            this.button1.TabIndex = 48;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(553, 20);
            this.textBox1.TabIndex = 47;
            // 
            // Pesquisar
            // 
            this.Pesquisar.AutoSize = true;
            this.Pesquisar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisar.Location = new System.Drawing.Point(28, 41);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(56, 21);
            this.Pesquisar.TabIndex = 49;
            this.Pesquisar.Text = "Nome:";
            // 
            // Candidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnMinimizar);
            this.Controls.Add(this.pnFechar);
            this.Controls.Add(this.pnVoltar);
            this.Controls.Add(this.dgvCandidato);
            this.Name = "Candidato";
            this.Size = new System.Drawing.Size(755, 507);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidato)).EndInit();
            this.pnVoltar.ResumeLayout(false);
            this.pnFechar.ResumeLayout(false);
            this.pnMinimizar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCandidato;
        private System.Windows.Forms.Panel pnVoltar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnFechar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel pnMinimizar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Pesquisar;
    }
}
