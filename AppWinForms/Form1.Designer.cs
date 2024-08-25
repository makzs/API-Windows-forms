namespace AppWinForms
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
            this.panelCampos = new System.Windows.Forms.Panel();
            this.tableLayoutPanelCampos = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelCampos.SuspendLayout();
            this.tableLayoutPanelCampos.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.tableLayoutPanelCampos);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCampos.Location = new System.Drawing.Point(0, 0);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(784, 170);
            this.panelCampos.TabIndex = 0;
            // 
            // tableLayoutPanelCampos
            // 
            this.tableLayoutPanelCampos.ColumnCount = 2;
            this.tableLayoutPanelCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.37245F));
            this.tableLayoutPanelCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.62755F));
            this.tableLayoutPanelCampos.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelCampos.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelCampos.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanelCampos.Controls.Add(this.txtNomeCompleto, 1, 0);
            this.tableLayoutPanelCampos.Controls.Add(this.txtTelefone, 1, 1);
            this.tableLayoutPanelCampos.Controls.Add(this.txtDocumento, 1, 2);
            this.tableLayoutPanelCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCampos.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCampos.Name = "tableLayoutPanelCampos";
            this.tableLayoutPanelCampos.RowCount = 3;
            this.tableLayoutPanelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.5F));
            this.tableLayoutPanelCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanelCampos.Size = new System.Drawing.Size(784, 170);
            this.tableLayoutPanelCampos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Documento:";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNomeCompleto.Location = new System.Drawing.Point(100, 3);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(681, 20);
            this.txtNomeCompleto.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTelefone.Location = new System.Drawing.Point(100, 58);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(681, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDocumento.Location = new System.Drawing.Point(100, 119);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(681, 20);
            this.txtDocumento.TabIndex = 5;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnDeletar);
            this.panelButton.Controls.Add(this.btnAtualizar);
            this.panelButton.Controls.Add(this.btnLimpar);
            this.panelButton.Controls.Add(this.btnAdicionar);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 170);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(784, 49);
            this.panelButton.TabIndex = 1;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(441, 6);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(245, 6);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(588, 6);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(98, 6);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Add";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dataGridView1);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelData.Location = new System.Drawing.Point(0, 225);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(784, 236);
            this.panelData.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(784, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelCampos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCampos.ResumeLayout(false);
            this.tableLayoutPanelCampos.ResumeLayout(false);
            this.tableLayoutPanelCampos.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCampos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeletar;
    }
}

