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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioCertificados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Name = "panel1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.White;
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxStatus, "comboBoxStatus");
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Name = "comboBoxStatus";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvCertificados);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvCertificados
            // 
            this.dgvCertificados.AllowUserToAddRows = false;
            this.dgvCertificados.AllowUserToDeleteRows = false;
            this.dgvCertificados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCertificados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCertificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCertificados.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgvCertificados, "dgvCertificados");
            this.dgvCertificados.GridColor = System.Drawing.Color.DimGray;
            this.dgvCertificados.MultiSelect = false;
            this.dgvCertificados.Name = "dgvCertificados";
            this.dgvCertificados.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCertificados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCertificados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvCertificados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCertificados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvCertificados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCertificados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel3);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
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
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // checkBoxAtribuido
            // 
            resources.ApplyResources(this.checkBoxAtribuido, "checkBoxAtribuido");
            this.checkBoxAtribuido.Name = "checkBoxAtribuido";
            this.checkBoxAtribuido.UseVisualStyleBackColor = true;
            // 
            // checkBoxStatus
            // 
            resources.ApplyResources(this.checkBoxStatus, "checkBoxStatus");
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // checkBoxDuracao
            // 
            resources.ApplyResources(this.checkBoxDuracao, "checkBoxDuracao");
            this.checkBoxDuracao.Name = "checkBoxDuracao";
            this.checkBoxDuracao.UseVisualStyleBackColor = true;
            // 
            // checkBoxDataFechamento
            // 
            resources.ApplyResources(this.checkBoxDataFechamento, "checkBoxDataFechamento");
            this.checkBoxDataFechamento.Name = "checkBoxDataFechamento";
            this.checkBoxDataFechamento.UseVisualStyleBackColor = true;
            // 
            // checkBoxDataAbertura
            // 
            resources.ApplyResources(this.checkBoxDataAbertura, "checkBoxDataAbertura");
            this.checkBoxDataAbertura.Name = "checkBoxDataAbertura";
            this.checkBoxDataAbertura.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoAtendimento
            // 
            resources.ApplyResources(this.checkBoxTipoAtendimento, "checkBoxTipoAtendimento");
            this.checkBoxTipoAtendimento.Name = "checkBoxTipoAtendimento";
            this.checkBoxTipoAtendimento.UseVisualStyleBackColor = true;
            // 
            // checkBoxSolicitante
            // 
            resources.ApplyResources(this.checkBoxSolicitante, "checkBoxSolicitante");
            this.checkBoxSolicitante.Name = "checkBoxSolicitante";
            this.checkBoxSolicitante.UseVisualStyleBackColor = true;
            // 
            // checkBoxIdAtendimento
            // 
            resources.ApplyResources(this.checkBoxIdAtendimento, "checkBoxIdAtendimento");
            this.checkBoxIdAtendimento.Name = "checkBoxIdAtendimento";
            this.checkBoxIdAtendimento.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBoxOrdenar);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // comboBoxOrdenar
            // 
            this.comboBoxOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxOrdenar, "comboBoxOrdenar");
            this.comboBoxOrdenar.FormattingEnabled = true;
            this.comboBoxOrdenar.Items.AddRange(new object[] {
            resources.GetString("comboBoxOrdenar.Items"),
            resources.GetString("comboBoxOrdenar.Items1"),
            resources.GetString("comboBoxOrdenar.Items2"),
            resources.GetString("comboBoxOrdenar.Items3"),
            resources.GetString("comboBoxOrdenar.Items4"),
            resources.GetString("comboBoxOrdenar.Items5"),
            resources.GetString("comboBoxOrdenar.Items6"),
            resources.GetString("comboBoxOrdenar.Items7")});
            this.comboBoxOrdenar.Name = "comboBoxOrdenar";
            // 
            // buttoncarregar
            // 
            this.buttoncarregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttoncarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttoncarregar, "buttoncarregar");
            this.buttoncarregar.ForeColor = System.Drawing.Color.White;
            this.buttoncarregar.Name = "buttoncarregar";
            this.buttoncarregar.UseVisualStyleBackColor = false;
            this.buttoncarregar.Click += new System.EventHandler(this.buttoncarregar_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Name = "label7";
            // 
            // labelHoras
            // 
            resources.ApplyResources(this.labelHoras, "labelHoras");
            this.labelHoras.BackColor = System.Drawing.Color.Transparent;
            this.labelHoras.Name = "labelHoras";
            // 
            // labelQuantidadeAtendimentos
            // 
            resources.ApplyResources(this.labelQuantidadeAtendimentos, "labelQuantidadeAtendimentos");
            this.labelQuantidadeAtendimentos.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantidadeAtendimentos.Name = "labelQuantidadeAtendimentos";
            // 
            // quantidadeCertificados
            // 
            resources.ApplyResources(this.quantidadeCertificados, "quantidadeCertificados");
            this.quantidadeCertificados.Name = "quantidadeCertificados";
            this.quantidadeCertificados.ReadOnly = true;
            // 
            // timerHoras
            // 
            this.timerHoras.Enabled = true;
            this.timerHoras.Tick += new System.EventHandler(this.timerHoras_Tick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.BackColor = System.Drawing.Color.White;
            this.comboBoxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxMes, "comboBoxMes");
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Items.AddRange(new object[] {
            resources.GetString("comboBoxMes.Items"),
            resources.GetString("comboBoxMes.Items1"),
            resources.GetString("comboBoxMes.Items2"),
            resources.GetString("comboBoxMes.Items3"),
            resources.GetString("comboBoxMes.Items4"),
            resources.GetString("comboBoxMes.Items5"),
            resources.GetString("comboBoxMes.Items6"),
            resources.GetString("comboBoxMes.Items7"),
            resources.GetString("comboBoxMes.Items8"),
            resources.GetString("comboBoxMes.Items9"),
            resources.GetString("comboBoxMes.Items10"),
            resources.GetString("comboBoxMes.Items11"),
            resources.GetString("comboBoxMes.Items12")});
            this.comboBoxMes.Name = "comboBoxMes";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.BackColor = System.Drawing.Color.White;
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxTipo, "comboBoxTipo");
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Name = "comboBoxTipo";
            // 
            // RelatorioCertificados
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}

