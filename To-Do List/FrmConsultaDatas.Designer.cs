
namespace To_Do_List
{
    partial class FrmConsultaDatas
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

            label3 = new Label();
            dtpInicio = new DateTimePicker();
            dtpFim = new DateTimePicker();
            label2 = new Label();
            btnConsultar = new Button();
            dgvResultados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 149);
            label1.Name = "label1";
            label1.Size = new Size(34, 21);
            label1.TabIndex = 0;
            label1.Text = "De:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(191, 28);
            label3.Name = "label3";
            label3.Size = new Size(433, 41);
            label3.TabIndex = 5;
            label3.Text = "Tarefas por Data Prevista";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(290, 147);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(200, 23);
            dtpInicio.TabIndex = 6;
            // 
            // dtpFim
            // 
            dtpFim.Location = new Point(290, 195);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(200, 23);
            dtpFim.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(244, 195);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 7;
            label2.Text = "Até:";
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(326, 258);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(113, 41);
            btnConsultar.TabIndex = 9;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.AllowUserToResizeRows = false;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(-4, 315);
            dgvResultados.MultiSelect = false;
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.Size = new Size(806, 135);
            dgvResultados.TabIndex = 10;
            // 
            // FrmConsultaDatas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResultados);
            Controls.Add(btnConsultar);
            Controls.Add(dtpFim);
            Controls.Add(label2);
            Controls.Add(dtpInicio);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FrmConsultaDatas";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label3;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFim;
        private Label label2;
        private Button btnConsultar;
        private DataGridView dgvResultados;
    }
}