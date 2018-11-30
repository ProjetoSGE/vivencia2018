namespace WindowsFormsApplication1
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vagasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vagasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 22);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(765, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 561);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 561);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(765, 13);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 574);
            this.panel5.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 32);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.consutasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.empresasToolStripMenuItem,
            this.vagasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.empresasToolStripMenuItem.Text = "Empresas";
            this.empresasToolStripMenuItem.Click += new System.EventHandler(this.empresasToolStripMenuItem_Click);
            // 
            // vagasToolStripMenuItem
            // 
            this.vagasToolStripMenuItem.Name = "vagasToolStripMenuItem";
            this.vagasToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.vagasToolStripMenuItem.Text = "Vagas";
            this.vagasToolStripMenuItem.Click += new System.EventHandler(this.vagasToolStripMenuItem_Click);
            // 
            // consutasToolStripMenuItem
            // 
            this.consutasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem1,
            this.candidatosToolStripMenuItem,
            this.empresasToolStripMenuItem1,
            this.vagasToolStripMenuItem1});
            this.consutasToolStripMenuItem.Name = "consutasToolStripMenuItem";
            this.consutasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consutasToolStripMenuItem.Text = "Consultas";
            // 
            // alunosToolStripMenuItem1
            // 
            this.alunosToolStripMenuItem1.Name = "alunosToolStripMenuItem1";
            this.alunosToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.alunosToolStripMenuItem1.Text = "Alunos";
            this.alunosToolStripMenuItem1.Click += new System.EventHandler(this.alunosToolStripMenuItem1_Click);
            // 
            // candidatosToolStripMenuItem
            // 
            this.candidatosToolStripMenuItem.Name = "candidatosToolStripMenuItem";
            this.candidatosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.candidatosToolStripMenuItem.Text = "Candidatos";
            this.candidatosToolStripMenuItem.Click += new System.EventHandler(this.candidatosToolStripMenuItem_Click);
            // 
            // empresasToolStripMenuItem1
            // 
            this.empresasToolStripMenuItem1.Name = "empresasToolStripMenuItem1";
            this.empresasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.empresasToolStripMenuItem1.Text = "Empresas";
            this.empresasToolStripMenuItem1.Click += new System.EventHandler(this.empresasToolStripMenuItem1_Click);
            // 
            // vagasToolStripMenuItem1
            // 
            this.vagasToolStripMenuItem1.Name = "vagasToolStripMenuItem1";
            this.vagasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.vagasToolStripMenuItem1.Text = "Vagas";
            this.vagasToolStripMenuItem1.Click += new System.EventHandler(this.vagasToolStripMenuItem1_Click);
            // 
            // pnlCentro
            // 
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(10, 54);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(755, 507);
            this.pnlCentro.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 574);
            this.Controls.Add(this.pnlCentro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vagasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem candidatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vagasToolStripMenuItem1;
    }
}

