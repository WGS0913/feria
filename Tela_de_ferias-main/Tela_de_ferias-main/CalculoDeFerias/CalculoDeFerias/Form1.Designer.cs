namespace CalculoDeFerias
{
    partial class Form1
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
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.dataTabela = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTerminoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusVencidoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabelaFeriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feriasDataSet = new CalculoDeFerias.FeriasDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeTermino = new System.Windows.Forms.DateTimePicker();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalarioHora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalarioHora = new System.Windows.Forms.TextBox();
            this.btnLimapr = new System.Windows.Forms.Button();
            this.radio13 = new System.Windows.Forms.RadioButton();
            this.radioAbono = new System.Windows.Forms.RadioButton();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.radioBtnVencido = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnExculir = new System.Windows.Forms.Button();
            this.dataSet1 = new CalculoDeFerias.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaFeriasTableAdapter = new CalculoDeFerias.FeriasDataSetTableAdapters.TabelaFeriasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFeriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feriasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionario.Location = new System.Drawing.Point(98, 33);
            this.txtFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(175, 20);
            this.txtFuncionario.TabIndex = 107;
            // 
            // dataTabela
            // 
            this.dataTabela.AllowUserToOrderColumns = true;
            this.dataTabela.AutoGenerateColumns = false;
            this.dataTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeFuncionarioDataGridViewTextBoxColumn,
            this.dataInicioDataGridViewTextBoxColumn,
            this.dataTerminoDataGridViewTextBoxColumn,
            this.statusVencidoDataGridViewCheckBoxColumn});
            this.dataTabela.DataSource = this.tabelaFeriasBindingSource;
            this.dataTabela.Location = new System.Drawing.Point(471, 33);
            this.dataTabela.Name = "dataTabela";
            this.dataTabela.Size = new System.Drawing.Size(559, 169);
            this.dataTabela.TabIndex = 113;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeFuncionarioDataGridViewTextBoxColumn
            // 
            this.nomeFuncionarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "NomeFuncionario";
            this.nomeFuncionarioDataGridViewTextBoxColumn.HeaderText = "NomeFuncionario";
            this.nomeFuncionarioDataGridViewTextBoxColumn.Name = "nomeFuncionarioDataGridViewTextBoxColumn";
            // 
            // dataInicioDataGridViewTextBoxColumn
            // 
            this.dataInicioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataInicioDataGridViewTextBoxColumn.DataPropertyName = "DataInicio";
            this.dataInicioDataGridViewTextBoxColumn.HeaderText = "DataInicio";
            this.dataInicioDataGridViewTextBoxColumn.Name = "dataInicioDataGridViewTextBoxColumn";
            // 
            // dataTerminoDataGridViewTextBoxColumn
            // 
            this.dataTerminoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataTerminoDataGridViewTextBoxColumn.DataPropertyName = "DataTermino";
            this.dataTerminoDataGridViewTextBoxColumn.HeaderText = "DataTermino";
            this.dataTerminoDataGridViewTextBoxColumn.Name = "dataTerminoDataGridViewTextBoxColumn";
            // 
            // statusVencidoDataGridViewCheckBoxColumn
            // 
            this.statusVencidoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusVencidoDataGridViewCheckBoxColumn.DataPropertyName = "StatusVencido";
            this.statusVencidoDataGridViewCheckBoxColumn.HeaderText = "StatusVencido";
            this.statusVencidoDataGridViewCheckBoxColumn.Name = "statusVencidoDataGridViewCheckBoxColumn";
            // 
            // tabelaFeriasBindingSource
            // 
            this.tabelaFeriasBindingSource.DataMember = "TabelaFerias";
            this.tabelaFeriasBindingSource.DataSource = this.feriasDataSet;
            // 
            // feriasDataSet
            // 
            this.feriasDataSet.DataSetName = "FeriasDataSet";
            this.feriasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(11, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 106;
            this.label3.Text = "Data do Inicio:";
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGravar.Location = new System.Drawing.Point(746, 222);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(73, 34);
            this.btnGravar.TabIndex = 109;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(4, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 96;
            this.label6.Text = "Funcionário";
            // 
            // dateTimeTermino
            // 
            this.dateTimeTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTermino.Location = new System.Drawing.Point(165, 300);
            this.dateTimeTermino.Name = "dateTimeTermino";
            this.dateTimeTermino.Size = new System.Drawing.Size(264, 20);
            this.dateTimeTermino.TabIndex = 105;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(584, 222);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(69, 34);
            this.btnCalcular.TabIndex = 108;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalarioHora
            // 
            this.lblSalarioHora.AutoSize = true;
            this.lblSalarioHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalarioHora.Location = new System.Drawing.Point(4, 72);
            this.lblSalarioHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalarioHora.Name = "lblSalarioHora";
            this.lblSalarioHora.Size = new System.Drawing.Size(66, 18);
            this.lblSalarioHora.TabIndex = 97;
            this.lblSalarioHora.Text = "Salario ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 111;
            this.label4.Text = "Data do Retorno:";
            // 
            // txtSalarioHora
            // 
            this.txtSalarioHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarioHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioHora.Location = new System.Drawing.Point(96, 70);
            this.txtSalarioHora.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalarioHora.Name = "txtSalarioHora";
            this.txtSalarioHora.Size = new System.Drawing.Size(175, 20);
            this.txtSalarioHora.TabIndex = 95;
            // 
            // btnLimapr
            // 
            this.btnLimapr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimapr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimapr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimapr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimapr.Location = new System.Drawing.Point(658, 222);
            this.btnLimapr.Name = "btnLimapr";
            this.btnLimapr.Size = new System.Drawing.Size(82, 34);
            this.btnLimapr.TabIndex = 110;
            this.btnLimapr.Text = "Limpar";
            this.btnLimapr.UseVisualStyleBackColor = false;
            this.btnLimapr.Click += new System.EventHandler(this.btnLimapr_Click);
            // 
            // radio13
            // 
            this.radio13.AutoSize = true;
            this.radio13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radio13.Location = new System.Drawing.Point(152, 166);
            this.radio13.Name = "radio13";
            this.radio13.Size = new System.Drawing.Size(170, 19);
            this.radio13.TabIndex = 98;
            this.radio13.TabStop = true;
            this.radio13.Text = "Adiantar o 13 salário ?";
            this.radio13.UseVisualStyleBackColor = true;
            // 
            // radioAbono
            // 
            this.radioAbono.AutoSize = true;
            this.radioAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAbono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioAbono.Location = new System.Drawing.Point(7, 166);
            this.radioAbono.Name = "radioAbono";
            this.radioAbono.Size = new System.Drawing.Size(142, 19);
            this.radioAbono.TabIndex = 100;
            this.radioAbono.TabStop = true;
            this.radioAbono.Text = "Abono Pecuniário ";
            this.radioAbono.UseVisualStyleBackColor = true;
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeInicio.Location = new System.Drawing.Point(166, 236);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(264, 20);
            this.dateTimeInicio.TabIndex = 105;
            // 
            // radioBtnVencido
            // 
            this.radioBtnVencido.AutoSize = true;
            this.radioBtnVencido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnVencido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioBtnVencido.Location = new System.Drawing.Point(347, 167);
            this.radioBtnVencido.Name = "radioBtnVencido";
            this.radioBtnVencido.Size = new System.Drawing.Size(76, 19);
            this.radioBtnVencido.TabIndex = 114;
            this.radioBtnVencido.TabStop = true;
            this.radioBtnVencido.Text = "Vencido";
            this.radioBtnVencido.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultado.Location = new System.Drawing.Point(8, 361);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(78, 16);
            this.lblResultado.TabIndex = 111;
            this.lblResultado.Text = "Resultado";
            // 
            // btnExculir
            // 
            this.btnExculir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExculir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExculir.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExculir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExculir.Location = new System.Drawing.Point(825, 222);
            this.btnExculir.Name = "btnExculir";
            this.btnExculir.Size = new System.Drawing.Size(79, 34);
            this.btnExculir.TabIndex = 112;
            this.btnExculir.Text = "Excluir";
            this.btnExculir.UseVisualStyleBackColor = false;
            this.btnExculir.Click += new System.EventHandler(this.btnExculir_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // tabelaFeriasTableAdapter
            // 
            this.tabelaFeriasTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1042, 481);
            this.Controls.Add(this.radioBtnVencido);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.dataTabela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.dateTimeTermino);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSalarioHora);
            this.Controls.Add(this.btnExculir);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalarioHora);
            this.Controls.Add(this.btnLimapr);
            this.Controls.Add(this.radio13);
            this.Controls.Add(this.radioAbono);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFeriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feriasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.DataGridView dataTabela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeTermino;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalarioHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalarioHora;
        private System.Windows.Forms.Button btnLimapr;
        private System.Windows.Forms.RadioButton radio13;
        private System.Windows.Forms.RadioButton radioAbono;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.RadioButton radioBtnVencido;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnExculir;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private FeriasDataSet feriasDataSet;
        private System.Windows.Forms.BindingSource tabelaFeriasBindingSource;
        private FeriasDataSetTableAdapters.TabelaFeriasTableAdapter tabelaFeriasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTerminoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusVencidoDataGridViewCheckBoxColumn;
    }
}

