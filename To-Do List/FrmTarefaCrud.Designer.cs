namespace To_Do_List
{
    partial class FrmTarefaCrud
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTitulo = new TextBox();
            textBox1 = new TextBox();
            cmbPrioridade = new ComboBox();
            cmbStatus = new ComboBox();
            dtpDataPrevista = new DateTimePicker();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 9);
            label1.Name = "label1";
            label1.Size = new Size(490, 41);
            label1.TabIndex = 0;
            label1.Text = "Cadastro / Edição de Tarefas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 100);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 1;
            label2.Text = "Título";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 137);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 2;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(478, 100);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 3;
            label4.Text = "Prioridade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(496, 139);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 4;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(457, 187);
            label6.Name = "label6";
            label6.Size = new Size(111, 21);
            label6.TabIndex = 5;
            label6.Text = "Data Prevista";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(127, 98);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(289, 23);
            txtTitulo.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 139);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 131);
            textBox1.TabIndex = 7;
            // 
            // cmbPrioridade
            // 
            cmbPrioridade.FormattingEnabled = true;
            cmbPrioridade.Location = new Point(590, 98);
            cmbPrioridade.Name = "cmbPrioridade";
            cmbPrioridade.Size = new Size(121, 23);
            cmbPrioridade.TabIndex = 8;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(590, 141);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 9;
            // 
            // dtpDataPrevista
            // 
            dtpDataPrevista.Location = new Point(590, 187);
            dtpDataPrevista.Name = "dtpDataPrevista";
            dtpDataPrevista.Size = new Size(200, 23);
            dtpDataPrevista.TabIndex = 10;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(253, 326);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(131, 45);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(435, 326);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 45);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmTarefaCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(dtpDataPrevista);
            Controls.Add(cmbStatus);
            Controls.Add(cmbPrioridade);
            Controls.Add(textBox1);
            Controls.Add(txtTitulo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmTarefaCrud";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTitulo;
        private TextBox textBox1;
        private ComboBox cmbPrioridade;
        private ComboBox cmbStatus;
        private DateTimePicker dtpDataPrevista;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}