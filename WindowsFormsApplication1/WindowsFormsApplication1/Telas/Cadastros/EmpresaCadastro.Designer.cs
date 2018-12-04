namespace WindowsFormsApplication1
{
    partial class EmpresaCadastro
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtkCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mktTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mktRegistroEstadual = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomeFantasi = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPontoRef = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.mktCep = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(789, 182);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(17, 20);
            this.maskedTextBox2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cadastrar Empresa";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.mtkCNPJ);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.mktTelefone);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mktRegistroEstadual);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtNomeFantasi);
            this.groupBox2.Controls.Add(this.txtRazaoSocial);
            this.groupBox2.Location = new System.Drawing.Point(111, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 203);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(135, 171);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // mtkCNPJ
            // 
            this.mtkCNPJ.Location = new System.Drawing.Point(136, 19);
            this.mtkCNPJ.Mask = "99.999.999/9999-99";
            this.mtkCNPJ.Name = "mtkCNPJ";
            this.mtkCNPJ.Size = new System.Drawing.Size(122, 20);
            this.mtkCNPJ.TabIndex = 1;
            this.mtkCNPJ.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefone:";
            // 
            // mktTelefone
            // 
            this.mktTelefone.Location = new System.Drawing.Point(135, 145);
            this.mktTelefone.Mask = "0000-0000";
            this.mktTelefone.Name = "mktTelefone";
            this.mktTelefone.Size = new System.Drawing.Size(59, 20);
            this.mktTelefone.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail:";
            // 
            // mktRegistroEstadual
            // 
            this.mktRegistroEstadual.Location = new System.Drawing.Point(136, 112);
            this.mktRegistroEstadual.Mask = "00000";
            this.mktRegistroEstadual.Name = "mktRegistroEstadual";
            this.mktRegistroEstadual.Size = new System.Drawing.Size(42, 20);
            this.mktRegistroEstadual.TabIndex = 4;
            this.mktRegistroEstadual.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "Codigo Estadual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razão Social:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(80, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "CNPJ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nome Fantasia:";
            // 
            // txtNomeFantasi
            // 
            this.txtNomeFantasi.Location = new System.Drawing.Point(136, 49);
            this.txtNomeFantasi.MaxLength = 150;
            this.txtNomeFantasi.Name = "txtNomeFantasi";
            this.txtNomeFantasi.Size = new System.Drawing.Size(122, 20);
            this.txtNomeFantasi.TabIndex = 2;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(136, 82);
            this.txtRazaoSocial.MaxLength = 300;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(122, 20);
            this.txtRazaoSocial.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.txtPontoRef);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.mktCep);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(409, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 203);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // txtPontoRef
            // 
            this.txtPontoRef.Location = new System.Drawing.Point(14, 125);
            this.txtPontoRef.MaxLength = 100;
            this.txtPontoRef.Multiline = true;
            this.txtPontoRef.Name = "txtPontoRef";
            this.txtPontoRef.Size = new System.Drawing.Size(216, 63);
            this.txtPontoRef.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 21);
            this.label8.TabIndex = 37;
            this.label8.Text = "Ponto de referencia: ";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(93, 47);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(137, 20);
            this.txtBairro.TabIndex = 8;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(30, 45);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(59, 21);
            this.lblBairro.TabIndex = 24;
            this.lblBairro.Text = "Bairro: ";
            // 
            // mktCep
            // 
            this.mktCep.Location = new System.Drawing.Point(93, 22);
            this.mktCep.Mask = "00000-000";
            this.mktCep.Name = "mktCep";
            this.mktCep.Size = new System.Drawing.Size(59, 20);
            this.mktCep.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "CEP:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(93, 75);
            this.txtEndereco.MaxLength = 150;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(137, 20);
            this.txtEndereco.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Endereço:";
            // 
            // btnsalvar
            // 
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_save_261;
            this.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalvar.Location = new System.Drawing.Point(556, 341);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(89, 45);
            this.btnsalvar.TabIndex = 11;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // EmpresaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maskedTextBox2);
            this.Name = "EmpresaCadastro";
            this.Size = new System.Drawing.Size(747, 521);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtkCNPJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mktTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mktRegistroEstadual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomeFantasi;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPontoRef;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.MaskedTextBox mktCep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsalvar;
    }
}
