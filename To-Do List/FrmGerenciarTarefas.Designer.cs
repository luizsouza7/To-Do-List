namespace To_Do_List
{
    partial class FrmGerenciarTarefas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            dgvTarefas = new DataGridView();
            btnNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 20);
            label1.Name = "label1";
            label1.Size = new Size(300, 41);
            label1.TabIndex = 0;
            label1.Text = "Gerenciar Tarefas";
            // 
            // dgvTarefas
            // 
            dgvTarefas.AllowUserToAddRows = false;
            dgvTarefas.AllowUserToDeleteRows = false;
            dgvTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTarefas.Location = new Point(12, 80);
            dgvTarefas.MultiSelect = false;
            dgvTarefas.Name = "dgvTarefas";
            dgvTarefas.ReadOnly = true;
            dgvTarefas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTarefas.Size = new Size(776, 280);
            dgvTarefas.TabIndex = 1;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(12, 380);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(120, 40);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "Nova Tarefa";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(150, 380);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(288, 380);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(120, 40);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(668, 380);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 40);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // FrmGerenciarTarefas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(dgvTarefas);
            Controls.Add(label1);
            Name = "FrmGerenciarTarefas";
            Text = "Gerenciar Tarefas";
            ((System.ComponentModel.ISupportInitialize)dgvTarefas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvTarefas;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnVoltar;
    }
}

