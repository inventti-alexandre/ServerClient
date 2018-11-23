namespace ClienteRest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridFornecedores = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gbFornecedores = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfAlterar = new System.Windows.Forms.Button();
            this.btnCancAlterar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedores)).BeginInit();
            this.gbFornecedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridFornecedores
            // 
            this.dataGridFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFornecedores.Location = new System.Drawing.Point(13, 13);
            this.dataGridFornecedores.MultiSelect = false;
            this.dataGridFornecedores.Name = "dataGridFornecedores";
            this.dataGridFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFornecedores.Size = new System.Drawing.Size(460, 425);
            this.dataGridFornecedores.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(17, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(291, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(17, 131);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(291, 20);
            this.txtCidade.TabIndex = 2;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(17, 208);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(291, 20);
            this.txtEstado.TabIndex = 3;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(17, 253);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(291, 23);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(17, 282);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(291, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // gbFornecedores
            // 
            this.gbFornecedores.Controls.Add(this.txtId);
            this.gbFornecedores.Controls.Add(this.btnCancAlterar);
            this.gbFornecedores.Controls.Add(this.btnConfAlterar);
            this.gbFornecedores.Controls.Add(this.btnAlterar);
            this.gbFornecedores.Controls.Add(this.label3);
            this.gbFornecedores.Controls.Add(this.label2);
            this.gbFornecedores.Controls.Add(this.label1);
            this.gbFornecedores.Controls.Add(this.txtNome);
            this.gbFornecedores.Controls.Add(this.btnExcluir);
            this.gbFornecedores.Controls.Add(this.txtCidade);
            this.gbFornecedores.Controls.Add(this.btnGravar);
            this.gbFornecedores.Controls.Add(this.txtEstado);
            this.gbFornecedores.Location = new System.Drawing.Point(486, 13);
            this.gbFornecedores.Name = "gbFornecedores";
            this.gbFornecedores.Size = new System.Drawing.Size(323, 426);
            this.gbFornecedores.TabIndex = 6;
            this.gbFornecedores.TabStop = false;
            this.gbFornecedores.Text = "Crud Fornecedor";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(17, 311);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(291, 23);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // btnConfAlterar
            // 
            this.btnConfAlterar.Location = new System.Drawing.Point(17, 340);
            this.btnConfAlterar.Name = "btnConfAlterar";
            this.btnConfAlterar.Size = new System.Drawing.Size(291, 23);
            this.btnConfAlterar.TabIndex = 10;
            this.btnConfAlterar.Text = "Confirmar Alteração";
            this.btnConfAlterar.UseVisualStyleBackColor = true;
            this.btnConfAlterar.Click += new System.EventHandler(this.btnConfAlterar_Click);
            // 
            // btnCancAlterar
            // 
            this.btnCancAlterar.Location = new System.Drawing.Point(17, 370);
            this.btnCancAlterar.Name = "btnCancAlterar";
            this.btnCancAlterar.Size = new System.Drawing.Size(291, 23);
            this.btnCancAlterar.TabIndex = 11;
            this.btnCancAlterar.Text = "Cancelar Alteração";
            this.btnCancAlterar.UseVisualStyleBackColor = true;
            this.btnCancAlterar.Click += new System.EventHandler(this.btnCancAlterar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(17, 400);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(291, 20);
            this.txtId.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.gbFornecedores);
            this.Controls.Add(this.dataGridFornecedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente alimentado por um ServerRest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedores)).EndInit();
            this.gbFornecedores.ResumeLayout(false);
            this.gbFornecedores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFornecedores;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gbFornecedores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancAlterar;
        private System.Windows.Forms.Button btnConfAlterar;
        private System.Windows.Forms.TextBox txtId;
    }
}

