namespace To_Do_List
{
    partial class FrmConsultaTarefas
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
            label3 = new Label();
            label1 = new Label();
            txtFiltroTitulo = new TextBox();
            cmbFiltroStatus = new ComboBox();
            cmbFiltroPrior = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            btnFiltrar = new Button();
            dgvResultados2 = new DataGridView();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResultados2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(234, 26);
            label3.Name = "label3";
            label3.Size = new Size(307, 41);
            label3.TabIndex = 5;
            label3.Text = "Consultar Tarefas";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 131);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 6;
            label1.Text = "O Título Contém:";
            // 
            // txtFiltroTitulo
            // 
            txtFiltroTitulo.Location = new Point(265, 131);
            txtFiltroTitulo.Name = "txtFiltroTitulo";
            txtFiltroTitulo.Size = new Size(261, 23);
            txtFiltroTitulo.TabIndex = 7;
            // 
            // cmbFiltroStatus
            // 
            cmbFiltroStatus.FormattingEnabled = true;
            cmbFiltroStatus.Location = new Point(265, 223);
            cmbFiltroStatus.Name = "cmbFiltroStatus";
            cmbFiltroStatus.Size = new Size(121, 23);
            cmbFiltroStatus.TabIndex = 13;
            // 
            // cmbFiltroPrior
            // 
            cmbFiltroPrior.FormattingEnabled = true;
            cmbFiltroPrior.Location = new Point(265, 180);
            cmbFiltroPrior.Name = "cmbFiltroPrior";
            cmbFiltroPrior.Size = new Size(121, 23);
            cmbFiltroPrior.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(202, 221);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 11;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(169, 182);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 10;
            label4.Text = "Prioridade";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.Location = new Point(265, 270);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(101, 45);
            btnFiltrar.TabIndex = 14;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // dgvResultados2
            // 
            dgvResultados2.AllowUserToAddRows = false;
            dgvResultados2.AllowUserToDeleteRows = false;
            dgvResultados2.AllowUserToResizeRows = false;
            dgvResultados2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados2.Location = new Point(-6, 321);
            dgvResultados2.MultiSelect = false;
            dgvResultados2.Name = "dgvResultados2";
            dgvResultados2.ReadOnly = true;
            dgvResultados2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultados2.Size = new Size(806, 135);
            dgvResultados2.TabIndex = 15;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(402, 270);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(101, 45);
            btnVoltar.TabIndex = 17;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaTarefas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(dgvResultados2);
            Controls.Add(btnFiltrar);
            Controls.Add(cmbFiltroStatus);
            Controls.Add(cmbFiltroPrior);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtFiltroTitulo);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "FrmConsultaTarefas";
            Text = "FrmConsultaTarefas";
            ((System.ComponentModel.ISupportInitialize)dgvResultados2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private TextBox txtFiltroTitulo;
        private ComboBox cmbFiltroStatus;
        private ComboBox cmbFiltroPrior;
        private Label label5;
        private Label label4;
        private Button btnFiltrar;
        private DataGridView dgvResultados2;
        private Button btnVoltar;
    }
}