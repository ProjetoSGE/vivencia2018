namespace WindowsFormsApplication1.Telas.Cadastros
{
    partial class VagasCadastro
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtInicioEstagio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.mkbInicio = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mkbFim = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mkbIntervalo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOutros = new System.Windows.Forms.TextBox();
            this.chkAutoCad = new System.Windows.Forms.CheckBox();
            this.chkPhotoshop = new System.Windows.Forms.CheckBox();
            this.chkProgramacao = new System.Windows.Forms.CheckBox();
            this.chkPacoteOffice = new System.Windows.Forms.CheckBox();
            this.chkCorelDraw = new System.Windows.Forms.CheckBox();
            this.chkOutros = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAssisMedica = new System.Windows.Forms.CheckBox();
            this.chkAuxilioTrasporte = new System.Windows.Forms.CheckBox();
            this.chkRecessoRemuneracao = new System.Windows.Forms.CheckBox();
            this.chkValeRef = new System.Windows.Forms.CheckBox();
            this.chkSeguroVida = new System.Windows.Forms.CheckBox();
            this.chkRefeitorioLocal = new System.Windows.Forms.CheckBox();
            this.chkCestaBasica = new System.Windows.Forms.CheckBox();
            this.txtCompetecias = new System.Windows.Forms.TextBox();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cboNvlIngles = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtNome);
            this.groupBox4.Controls.Add(this.cboEmpresa);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cboSexo);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.nudQtd);
            this.groupBox4.Controls.Add(this.txtArea);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(28, 266);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(675, 81);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vagas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(88, 20);
            this.txtNome.MaxLength = 150;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 25);
            this.txtNome.TabIndex = 22;
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(88, 49);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(121, 25);
            this.cboEmpresa.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Empresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Sexo:";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Ambos "});
            this.cboSexo.Location = new System.Drawing.Point(314, 51);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(91, 25);
            this.cboSexo.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Àrea:";
            // 
            // nudQtd
            // 
            this.nudQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudQtd.Location = new System.Drawing.Point(314, 23);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(91, 25);
            this.nudQtd.TabIndex = 24;
            // 
            // txtArea
            // 
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArea.Location = new System.Drawing.Point(530, 20);
            this.txtArea.MaxLength = 100;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 25);
            this.txtArea.TabIndex = 26;
            // 
            // btnsalvar
            // 
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_save_261;
            this.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalvar.Location = new System.Drawing.Point(615, 3);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(89, 47);
            this.btnsalvar.TabIndex = 31;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtInicioEstagio);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.mkbInicio);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.mkbFim);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.mkbIntervalo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(28, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(676, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estágio";
            // 
            // dtInicioEstagio
            // 
            this.dtInicioEstagio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicioEstagio.Location = new System.Drawing.Point(111, 19);
            this.dtInicioEstagio.Name = "dtInicioEstagio";
            this.dtInicioEstagio.Size = new System.Drawing.Size(100, 25);
            this.dtInicioEstagio.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Inicio Estágio:";
            // 
            // mkbInicio
            // 
            this.mkbInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkbInicio.Location = new System.Drawing.Point(111, 60);
            this.mkbInicio.Mask = "00:00";
            this.mkbInicio.Name = "mkbInicio";
            this.mkbInicio.Size = new System.Drawing.Size(41, 25);
            this.mkbInicio.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Horário Inicio:";
            // 
            // mkbFim
            // 
            this.mkbFim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkbFim.Location = new System.Drawing.Point(204, 60);
            this.mkbFim.Mask = "00:00";
            this.mkbFim.Name = "mkbFim";
            this.mkbFim.Size = new System.Drawing.Size(37, 25);
            this.mkbFim.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(158, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 21);
            this.label16.TabIndex = 56;
            this.label16.Text = "Fim:";
            // 
            // mkbIntervalo
            // 
            this.mkbIntervalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkbIntervalo.Location = new System.Drawing.Point(323, 61);
            this.mkbIntervalo.Mask = "00:00";
            this.mkbIntervalo.Name = "mkbIntervalo";
            this.mkbIntervalo.Size = new System.Drawing.Size(38, 25);
            this.mkbIntervalo.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(247, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 29;
            this.label9.Text = "Intervalo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutros);
            this.groupBox2.Controls.Add(this.chkAutoCad);
            this.groupBox2.Controls.Add(this.chkPhotoshop);
            this.groupBox2.Controls.Add(this.chkProgramacao);
            this.groupBox2.Controls.Add(this.chkPacoteOffice);
            this.groupBox2.Controls.Add(this.chkCorelDraw);
            this.groupBox2.Controls.Add(this.chkOutros);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 139);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conhecimentos De Informática";
            // 
            // txtOutros
            // 
            this.txtOutros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutros.Location = new System.Drawing.Point(134, 93);
            this.txtOutros.MaxLength = 150;
            this.txtOutros.Multiline = true;
            this.txtOutros.Name = "txtOutros";
            this.txtOutros.Size = new System.Drawing.Size(151, 40);
            this.txtOutros.TabIndex = 12;
            this.txtOutros.Visible = false;
            // 
            // chkAutoCad
            // 
            this.chkAutoCad.AutoSize = true;
            this.chkAutoCad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoCad.Location = new System.Drawing.Point(8, 29);
            this.chkAutoCad.Name = "chkAutoCad";
            this.chkAutoCad.Size = new System.Drawing.Size(93, 25);
            this.chkAutoCad.TabIndex = 7;
            this.chkAutoCad.Text = "AutoCAD";
            this.chkAutoCad.UseVisualStyleBackColor = true;
            // 
            // chkPhotoshop
            // 
            this.chkPhotoshop.AutoSize = true;
            this.chkPhotoshop.BackColor = System.Drawing.Color.Transparent;
            this.chkPhotoshop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPhotoshop.Location = new System.Drawing.Point(8, 60);
            this.chkPhotoshop.Name = "chkPhotoshop";
            this.chkPhotoshop.Size = new System.Drawing.Size(106, 25);
            this.chkPhotoshop.TabIndex = 8;
            this.chkPhotoshop.Text = "PhotoShop";
            this.chkPhotoshop.UseVisualStyleBackColor = false;
            // 
            // chkProgramacao
            // 
            this.chkProgramacao.AutoSize = true;
            this.chkProgramacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProgramacao.Location = new System.Drawing.Point(8, 91);
            this.chkProgramacao.Name = "chkProgramacao";
            this.chkProgramacao.Size = new System.Drawing.Size(122, 25);
            this.chkProgramacao.TabIndex = 9;
            this.chkProgramacao.Text = "Programação";
            this.chkProgramacao.UseVisualStyleBackColor = true;
            // 
            // chkPacoteOffice
            // 
            this.chkPacoteOffice.AutoSize = true;
            this.chkPacoteOffice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPacoteOffice.Location = new System.Drawing.Point(134, 29);
            this.chkPacoteOffice.Name = "chkPacoteOffice";
            this.chkPacoteOffice.Size = new System.Drawing.Size(117, 25);
            this.chkPacoteOffice.TabIndex = 10;
            this.chkPacoteOffice.Text = "Pacote office";
            this.chkPacoteOffice.UseVisualStyleBackColor = true;
            // 
            // chkCorelDraw
            // 
            this.chkCorelDraw.AutoSize = true;
            this.chkCorelDraw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCorelDraw.Location = new System.Drawing.Point(134, 60);
            this.chkCorelDraw.Name = "chkCorelDraw";
            this.chkCorelDraw.Size = new System.Drawing.Size(103, 25);
            this.chkCorelDraw.TabIndex = 11;
            this.chkCorelDraw.Text = "CorelDraw";
            this.chkCorelDraw.UseVisualStyleBackColor = true;
            // 
            // chkOutros
            // 
            this.chkOutros.AutoSize = true;
            this.chkOutros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOutros.Location = new System.Drawing.Point(134, 91);
            this.chkOutros.Name = "chkOutros";
            this.chkOutros.Size = new System.Drawing.Size(77, 25);
            this.chkOutros.TabIndex = 41;
            this.chkOutros.Text = "Outros";
            this.chkOutros.UseVisualStyleBackColor = true;
            this.chkOutros.CheckedChanged += new System.EventHandler(this.chkOutros_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAssisMedica);
            this.groupBox1.Controls.Add(this.chkAuxilioTrasporte);
            this.groupBox1.Controls.Add(this.chkRecessoRemuneracao);
            this.groupBox1.Controls.Add(this.chkValeRef);
            this.groupBox1.Controls.Add(this.chkSeguroVida);
            this.groupBox1.Controls.Add(this.chkRefeitorioLocal);
            this.groupBox1.Controls.Add(this.chkCestaBasica);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(359, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 139);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Benefícios";
            // 
            // chkAssisMedica
            // 
            this.chkAssisMedica.AutoSize = true;
            this.chkAssisMedica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAssisMedica.Location = new System.Drawing.Point(6, 108);
            this.chkAssisMedica.Name = "chkAssisMedica";
            this.chkAssisMedica.Size = new System.Drawing.Size(159, 25);
            this.chkAssisMedica.TabIndex = 17;
            this.chkAssisMedica.Text = "Assistência Médica";
            this.chkAssisMedica.UseVisualStyleBackColor = true;
            // 
            // chkAuxilioTrasporte
            // 
            this.chkAuxilioTrasporte.AutoSize = true;
            this.chkAuxilioTrasporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAuxilioTrasporte.Location = new System.Drawing.Point(6, 19);
            this.chkAuxilioTrasporte.Name = "chkAuxilioTrasporte";
            this.chkAuxilioTrasporte.Size = new System.Drawing.Size(152, 25);
            this.chkAuxilioTrasporte.TabIndex = 14;
            this.chkAuxilioTrasporte.Text = "Auxilio transporte";
            this.chkAuxilioTrasporte.UseVisualStyleBackColor = true;
            // 
            // chkRecessoRemuneracao
            // 
            this.chkRecessoRemuneracao.AutoSize = true;
            this.chkRecessoRemuneracao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRecessoRemuneracao.Location = new System.Drawing.Point(6, 50);
            this.chkRecessoRemuneracao.Name = "chkRecessoRemuneracao";
            this.chkRecessoRemuneracao.Size = new System.Drawing.Size(179, 25);
            this.chkRecessoRemuneracao.TabIndex = 15;
            this.chkRecessoRemuneracao.Text = "Recesso Remunerado";
            this.chkRecessoRemuneracao.UseVisualStyleBackColor = true;
            // 
            // chkValeRef
            // 
            this.chkValeRef.AutoSize = true;
            this.chkValeRef.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkValeRef.Location = new System.Drawing.Point(6, 81);
            this.chkValeRef.Name = "chkValeRef";
            this.chkValeRef.Size = new System.Drawing.Size(122, 25);
            this.chkValeRef.TabIndex = 16;
            this.chkValeRef.Text = "Vale Refeição";
            this.chkValeRef.UseVisualStyleBackColor = true;
            // 
            // chkSeguroVida
            // 
            this.chkSeguroVida.AutoSize = true;
            this.chkSeguroVida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeguroVida.Location = new System.Drawing.Point(185, 19);
            this.chkSeguroVida.Name = "chkSeguroVida";
            this.chkSeguroVida.Size = new System.Drawing.Size(135, 25);
            this.chkSeguroVida.TabIndex = 18;
            this.chkSeguroVida.Text = "Seguro de Vida";
            this.chkSeguroVida.UseVisualStyleBackColor = true;
            // 
            // chkRefeitorioLocal
            // 
            this.chkRefeitorioLocal.AutoSize = true;
            this.chkRefeitorioLocal.BackColor = System.Drawing.Color.Transparent;
            this.chkRefeitorioLocal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRefeitorioLocal.Location = new System.Drawing.Point(185, 82);
            this.chkRefeitorioLocal.Name = "chkRefeitorioLocal";
            this.chkRefeitorioLocal.Size = new System.Drawing.Size(159, 25);
            this.chkRefeitorioLocal.TabIndex = 20;
            this.chkRefeitorioLocal.Text = "Refeitório no Local";
            this.chkRefeitorioLocal.UseVisualStyleBackColor = false;
            // 
            // chkCestaBasica
            // 
            this.chkCestaBasica.AutoSize = true;
            this.chkCestaBasica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCestaBasica.Location = new System.Drawing.Point(185, 50);
            this.chkCestaBasica.Name = "chkCestaBasica";
            this.chkCestaBasica.Size = new System.Drawing.Size(114, 25);
            this.chkCestaBasica.TabIndex = 19;
            this.chkCestaBasica.Text = "Cesta Básica";
            this.chkCestaBasica.UseVisualStyleBackColor = true;
            // 
            // txtCompetecias
            // 
            this.txtCompetecias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompetecias.Location = new System.Drawing.Point(120, 350);
            this.txtCompetecias.MaxLength = 200;
            this.txtCompetecias.Name = "txtCompetecias";
            this.txtCompetecias.Size = new System.Drawing.Size(226, 20);
            this.txtCompetecias.TabIndex = 27;
            // 
            // txtTarefa
            // 
            this.txtTarefa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTarefa.Location = new System.Drawing.Point(475, 350);
            this.txtTarefa.MaxLength = 200;
            this.txtTarefa.Multiline = true;
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(226, 47);
            this.txtTarefa.TabIndex = 29;
            // 
            // txtObs
            // 
            this.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObs.Location = new System.Drawing.Point(120, 376);
            this.txtObs.MaxLength = 250;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(226, 47);
            this.txtObs.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 21);
            this.label11.TabIndex = 85;
            this.label11.Text = "Tarefas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(361, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 21);
            this.label8.TabIndex = 83;
            this.label8.Text = "Competências";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 21);
            this.label10.TabIndex = 84;
            this.label10.Text = "Observações ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnsalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 64);
            this.panel1.TabIndex = 95;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(418, 403);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 21);
            this.label12.TabIndex = 96;
            this.label12.Text = "Inglês";
            // 
            // cboNvlIngles
            // 
            this.cboNvlIngles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNvlIngles.FormattingEnabled = true;
            this.cboNvlIngles.Items.AddRange(new object[] {
            "Básico",
            "Intermediário",
            "Avançado",
            "Indiferente"});
            this.cboNvlIngles.Location = new System.Drawing.Point(475, 403);
            this.cboNvlIngles.Name = "cboNvlIngles";
            this.cboNvlIngles.Size = new System.Drawing.Size(121, 21);
            this.cboNvlIngles.TabIndex = 30;
            // 
            // VagasCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cboNvlIngles);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCompetecias);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Name = "VagasCadastro";
            this.Size = new System.Drawing.Size(757, 509);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtInicioEstagio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mkbInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mkbFim;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox mkbIntervalo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAutoCad;
        private System.Windows.Forms.CheckBox chkPhotoshop;
        private System.Windows.Forms.CheckBox chkProgramacao;
        private System.Windows.Forms.CheckBox chkPacoteOffice;
        private System.Windows.Forms.CheckBox chkCorelDraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAuxilioTrasporte;
        private System.Windows.Forms.CheckBox chkRecessoRemuneracao;
        private System.Windows.Forms.CheckBox chkValeRef;
        private System.Windows.Forms.CheckBox chkSeguroVida;
        private System.Windows.Forms.CheckBox chkRefeitorioLocal;
        private System.Windows.Forms.CheckBox chkCestaBasica;
        private System.Windows.Forms.TextBox txtCompetecias;
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOutros;
        private System.Windows.Forms.CheckBox chkOutros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkAssisMedica;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboNvlIngles;
    }
}
