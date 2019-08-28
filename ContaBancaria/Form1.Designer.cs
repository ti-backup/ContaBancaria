namespace ContaBancaria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.nudSaldo = new System.Windows.Forms.NumericUpDown();
            this.btnCriar = new System.Windows.Forms.Button();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.btnCreditar = new System.Windows.Forms.Button();
            this.btnDebitar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvContas);
            this.groupBox1.Controls.Add(this.btnCriar);
            this.groupBox1.Controls.Add(this.nudSaldo);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo (R$):";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(75, 20);
            this.txtNome.TabIndex = 2;
            // 
            // nudSaldo
            // 
            this.nudSaldo.DecimalPlaces = 2;
            this.nudSaldo.Location = new System.Drawing.Point(72, 45);
            this.nudSaldo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSaldo.Name = "nudSaldo";
            this.nudSaldo.Size = new System.Drawing.Size(75, 20);
            this.nudSaldo.TabIndex = 3;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(153, 19);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(41, 46);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.AllowUserToDeleteRows = false;
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Location = new System.Drawing.Point(6, 71);
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.ReadOnly = true;
            this.dgvContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContas.Size = new System.Drawing.Size(188, 121);
            this.dgvContas.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDebitar);
            this.groupBox2.Controls.Add(this.btnCreditar);
            this.groupBox2.Controls.Add(this.nudValor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valor (R$):";
            // 
            // nudValor
            // 
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.Location = new System.Drawing.Point(69, 19);
            this.nudValor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(93, 20);
            this.nudValor.TabIndex = 1;
            // 
            // btnCreditar
            // 
            this.btnCreditar.Location = new System.Drawing.Point(6, 45);
            this.btnCreditar.Name = "btnCreditar";
            this.btnCreditar.Size = new System.Drawing.Size(75, 23);
            this.btnCreditar.TabIndex = 2;
            this.btnCreditar.Text = "Creditar";
            this.btnCreditar.UseVisualStyleBackColor = true;
            this.btnCreditar.Click += new System.EventHandler(this.btnCreditar_Click);
            // 
            // btnDebitar
            // 
            this.btnDebitar.Location = new System.Drawing.Point(87, 45);
            this.btnDebitar.Name = "btnDebitar";
            this.btnDebitar.Size = new System.Drawing.Size(75, 23);
            this.btnDebitar.TabIndex = 3;
            this.btnDebitar.Text = "Debitar";
            this.btnDebitar.UseVisualStyleBackColor = true;
            this.btnDebitar.Click += new System.EventHandler(this.btnDebitar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 225);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gerenciamento de Contas Bancárias";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.NumericUpDown nudSaldo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDebitar;
        private System.Windows.Forms.Button btnCreditar;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.Label label3;
    }
}

