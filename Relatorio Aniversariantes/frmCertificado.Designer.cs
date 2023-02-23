namespace Relatorio_Certtificado
{
    partial class RelatorioCertificados
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvCertificados = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxAtribuido = new System.Windows.Forms.CheckBox();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.checkBoxDuracao = new System.Windows.Forms.CheckBox();
            this.checkBoxDataFechamento = new System.Windows.Forms.CheckBox();
            this.checkBoxDataAbertura = new System.Windows.Forms.CheckBox();
            this.checkBoxTipoAtendimento = new System.Windows.Forms.CheckBox();
            this.checkBoxSolicitante = new System.Windows.Forms.CheckBox();
            this.checkBoxIdAtendimento = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxOrdenar = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttoncarregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelHoras = new System.Windows.Forms.Label();
            this.labelQuantidadeAtendimentos = new System.Windows.Forms.Label();
            this.quantidadeCertificados = new System.Windows.Forms.TextBox();
            this.timerHoras = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificados)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "RELATÓRIO CERTIFICADOS";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 31);
            this.panel1.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "Status:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.White;
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(20, 73);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(143, 22);
            this.comboBoxStatus.TabIndex = 38;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 300);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvCertificados);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvCertificados
            // 
            this.dgvCertificados.AllowUserToAddRows = false;
            this.dgvCertificados.AllowUserToDeleteRows = false;
            this.dgvCertificados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCertificados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCertificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCertificados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCertificados.Location = new System.Drawing.Point(3, 3);
            this.dgvCertificados.MultiSelect = false;
            this.dgvCertificados.Name = "dgvCertificados";
            this.dgvCertificados.ReadOnly = true;
            this.dgvCertificados.RowHeadersWidth = 51;
            this.dgvCertificados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCertificados.Size = new System.Drawing.Size(880, 268);
            this.dgvCertificados.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Opções de emissão";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(244, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Ordernar por:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Colounas relatório:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBoxAtribuido);
            this.panel2.Controls.Add(this.checkBoxStatus);
            this.panel2.Controls.Add(this.checkBoxDuracao);
            this.panel2.Controls.Add(this.checkBoxDataFechamento);
            this.panel2.Controls.Add(this.checkBoxDataAbertura);
            this.panel2.Controls.Add(this.checkBoxTipoAtendimento);
            this.panel2.Controls.Add(this.checkBoxSolicitante);
            this.panel2.Controls.Add(this.checkBoxIdAtendimento);
            this.panel2.Location = new System.Drawing.Point(15, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 170);
            this.panel2.TabIndex = 28;
            // 
            // checkBoxAtribuido
            // 
            this.checkBoxAtribuido.AutoSize = true;
            this.checkBoxAtribuido.Location = new System.Drawing.Point(6, 140);
            this.checkBoxAtribuido.Name = "checkBoxAtribuido";
            this.checkBoxAtribuido.Size = new System.Drawing.Size(69, 17);
            this.checkBoxAtribuido.TabIndex = 36;
            this.checkBoxAtribuido.Text = "Atribuído";
            this.checkBoxAtribuido.UseVisualStyleBackColor = true;
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(6, 122);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(56, 17);
            this.checkBoxStatus.TabIndex = 35;
            this.checkBoxStatus.Text = "Status";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // checkBoxDuracao
            // 
            this.checkBoxDuracao.AutoSize = true;
            this.checkBoxDuracao.Location = new System.Drawing.Point(6, 104);
            this.checkBoxDuracao.Name = "checkBoxDuracao";
            this.checkBoxDuracao.Size = new System.Drawing.Size(67, 17);
            this.checkBoxDuracao.TabIndex = 34;
            this.checkBoxDuracao.Text = "Duração";
            this.checkBoxDuracao.UseVisualStyleBackColor = true;
            // 
            // checkBoxDataFechamento
            // 
            this.checkBoxDataFechamento.AutoSize = true;
            this.checkBoxDataFechamento.Location = new System.Drawing.Point(6, 86);
            this.checkBoxDataFechamento.Name = "checkBoxDataFechamento";
            this.checkBoxDataFechamento.Size = new System.Drawing.Size(123, 17);
            this.checkBoxDataFechamento.TabIndex = 33;
            this.checkBoxDataFechamento.Text = "Data de fechamento";
            this.checkBoxDataFechamento.UseVisualStyleBackColor = true;
            // 
            // checkBoxDataAbertura
            // 
            this.checkBoxDataAbertura.AutoSize = true;
            this.checkBoxDataAbertura.Location = new System.Drawing.Point(6, 68);
            this.checkBoxDataAbertura.Name = "checkBoxDataAbertura";
            this.checkBoxDataAbertura.Size = new System.Drawing.Size(106, 17);
            this.checkBoxDataAbertura.TabIndex = 32;
            this.checkBoxDataAbertura.Text = "Data de abertura";
            this.checkBoxDataAbertura.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoAtendimento
            // 
            this.checkBoxTipoAtendimento.AutoSize = true;
            this.checkBoxTipoAtendimento.Location = new System.Drawing.Point(6, 50);
            this.checkBoxTipoAtendimento.Name = "checkBoxTipoAtendimento";
            this.checkBoxTipoAtendimento.Size = new System.Drawing.Size(108, 17);
            this.checkBoxTipoAtendimento.TabIndex = 31;
            this.checkBoxTipoAtendimento.Text = "Tipo atendimento";
            this.checkBoxTipoAtendimento.UseVisualStyleBackColor = true;
            // 
            // checkBoxSolicitante
            // 
            this.checkBoxSolicitante.AutoSize = true;
            this.checkBoxSolicitante.Location = new System.Drawing.Point(6, 32);
            this.checkBoxSolicitante.Name = "checkBoxSolicitante";
            this.checkBoxSolicitante.Size = new System.Drawing.Size(75, 17);
            this.checkBoxSolicitante.TabIndex = 30;
            this.checkBoxSolicitante.Text = "Solicitante";
            this.checkBoxSolicitante.UseVisualStyleBackColor = true;
            // 
            // checkBoxIdAtendimento
            // 
            this.checkBoxIdAtendimento.AutoSize = true;
            this.checkBoxIdAtendimento.Location = new System.Drawing.Point(6, 14);
            this.checkBoxIdAtendimento.Name = "checkBoxIdAtendimento";
            this.checkBoxIdAtendimento.Size = new System.Drawing.Size(96, 17);
            this.checkBoxIdAtendimento.TabIndex = 29;
            this.checkBoxIdAtendimento.Text = "Id atendimento";
            this.checkBoxIdAtendimento.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBoxOrdenar);
            this.panel3.Location = new System.Drawing.Point(252, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 50);
            this.panel3.TabIndex = 37;
            // 
            // comboBoxOrdenar
            // 
            this.comboBoxOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdenar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrdenar.FormattingEnabled = true;
            this.comboBoxOrdenar.Items.AddRange(new object[] {
            "Id",
            "Tipo",
            "Solicitante",
            "Data de abertura",
            "Data de fechamento",
            "Duracao",
            "Status",
            "Atribuído"});
            this.comboBoxOrdenar.Location = new System.Drawing.Point(13, 14);
            this.comboBoxOrdenar.Name = "comboBoxOrdenar";
            this.comboBoxOrdenar.Size = new System.Drawing.Size(170, 22);
            this.comboBoxOrdenar.TabIndex = 27;
            // 
            // buttoncarregar
            // 
            this.buttoncarregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttoncarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncarregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncarregar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncarregar.ForeColor = System.Drawing.Color.White;
            this.buttoncarregar.Location = new System.Drawing.Point(522, 71);
            this.buttoncarregar.Margin = new System.Windows.Forms.Padding(2);
            this.buttoncarregar.Name = "buttoncarregar";
            this.buttoncarregar.Size = new System.Drawing.Size(93, 24);
            this.buttoncarregar.TabIndex = 42;
            this.buttoncarregar.Text = "CARREGAR";
            this.buttoncarregar.UseVisualStyleBackColor = false;
            this.buttoncarregar.Click += new System.EventHandler(this.buttoncarregar_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Departamento de desenvolvimento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelHoras
            // 
            this.labelHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHoras.AutoSize = true;
            this.labelHoras.BackColor = System.Drawing.Color.Transparent;
            this.labelHoras.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoras.Location = new System.Drawing.Point(29, 420);
            this.labelHoras.Name = "labelHoras";
            this.labelHoras.Size = new System.Drawing.Size(51, 17);
            this.labelHoras.TabIndex = 46;
            this.labelHoras.Text = "15:57:57";
            this.labelHoras.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelQuantidadeAtendimentos
            // 
            this.labelQuantidadeAtendimentos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelQuantidadeAtendimentos.AutoSize = true;
            this.labelQuantidadeAtendimentos.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantidadeAtendimentos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidadeAtendimentos.Location = new System.Drawing.Point(400, 418);
            this.labelQuantidadeAtendimentos.Name = "labelQuantidadeAtendimentos";
            this.labelQuantidadeAtendimentos.Size = new System.Drawing.Size(184, 19);
            this.labelQuantidadeAtendimentos.TabIndex = 45;
            this.labelQuantidadeAtendimentos.Text = "Quantidade de Certificados:";
            // 
            // quantidadeCertificados
            // 
            this.quantidadeCertificados.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.quantidadeCertificados.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeCertificados.Location = new System.Drawing.Point(588, 418);
            this.quantidadeCertificados.Margin = new System.Windows.Forms.Padding(2);
            this.quantidadeCertificados.Name = "quantidadeCertificados";
            this.quantidadeCertificados.ReadOnly = true;
            this.quantidadeCertificados.Size = new System.Drawing.Size(46, 24);
            this.quantidadeCertificados.TabIndex = 44;
            // 
            // timerHoras
            // 
            this.timerHoras.Enabled = true;
            this.timerHoras.Tick += new System.EventHandler(this.timerHoras_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "Mês:";
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.BackColor = System.Drawing.Color.White;
            this.comboBoxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMes.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Items.AddRange(new object[] {
            "<Todos>",
            "JANEIRO",
            "FEVEREIRO",
            "MARÇO",
            "ABRIL",
            "MAIO",
            "JUNHO",
            "JULHO",
            "AGOSTO",
            "SETEMBRO",
            "OUTUBRO",
            "NOVEMBRO",
            "DEZEMBRO"});
            this.comboBoxMes.Location = new System.Drawing.Point(181, 73);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(139, 22);
            this.comboBoxMes.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tipo:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.BackColor = System.Drawing.Color.White;
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Location = new System.Drawing.Point(342, 73);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(129, 22);
            this.comboBoxTipo.TabIndex = 51;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.ForestGreen;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(723, 414);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(84, 27);
            this.btnExcel.TabIndex = 53;
            this.btnExcel.Text = "Emitir Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F);
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Location = new System.Drawing.Point(813, 414);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(84, 27);
            this.btnPDF.TabIndex = 54;
            this.btnPDF.Text = "Emitir PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // RelatorioCertificados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 446);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelHoras);
            this.Controls.Add(this.labelQuantidadeAtendimentos);
            this.Controls.Add(this.quantidadeCertificados);
            this.Controls.Add(this.buttoncarregar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "RelatorioCertificados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CERTIFICADOS";
            this.Load += new System.EventHandler(this.RelatorioCertificados_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificados)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvCertificados;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxAtribuido;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.CheckBox checkBoxDuracao;
        private System.Windows.Forms.CheckBox checkBoxDataFechamento;
        private System.Windows.Forms.CheckBox checkBoxDataAbertura;
        private System.Windows.Forms.CheckBox checkBoxTipoAtendimento;
        private System.Windows.Forms.CheckBox checkBoxSolicitante;
        private System.Windows.Forms.CheckBox checkBoxIdAtendimento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxOrdenar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttoncarregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelHoras;
        private System.Windows.Forms.Label labelQuantidadeAtendimentos;
        private System.Windows.Forms.TextBox quantidadeCertificados;
        private System.Windows.Forms.Timer timerHoras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPDF;
    }
}

