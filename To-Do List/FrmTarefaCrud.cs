using System;
using System.Linq;
using System.Windows.Forms;
using To_Do_List.Models;
using To_Do_List.Services;

namespace To_Do_List
{
    public partial class FrmTarefaCrud : Form
    {
        private readonly Tarefa _tarefa;
        private static readonly string[] Prioridades = { "Alta", "Média", "Baixa" };
        private static readonly string[] Statuses = { "Pendente", "Em Progresso", "Concluída" };

        public FrmTarefaCrud(Tarefa? tarefa = null)
        {
            InitializeComponent();
            _tarefa = tarefa ?? new Tarefa();
            Load += FrmTarefaCrud_Load;
            btnSalvar.Click += BtnSalvar_Click;
            btnCancelar.Click += (_, _) => Close();
        }

        private void FrmTarefaCrud_Load(object? sender, EventArgs e)
        {
            cmbPrioridade.Items.Clear();
            cmbPrioridade.Items.AddRange(Prioridades.Cast<object>().ToArray());

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(Statuses.Cast<object>().ToArray());

            txtTitulo.Text = _tarefa.Titulo;
            textBox1.Text = _tarefa.Descricao;
            dtpDataPrevista.Value = _tarefa.DataPrevista == default
                ? DateTime.Today
                : _tarefa.DataPrevista;

            if (!string.IsNullOrWhiteSpace(_tarefa.Prioridade))
            {
                cmbPrioridade.SelectedItem = _tarefa.Prioridade;
            }

            if (!string.IsNullOrWhiteSpace(_tarefa.Status))
            {
                cmbStatus.SelectedItem = _tarefa.Status;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            var titulo = txtTitulo.Text.Trim();
            var descricao = textBox1.Text.Trim();
            var prioridade = cmbPrioridade.SelectedItem?.ToString() ?? string.Empty;
            var status = cmbStatus.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(titulo))
            {
                MessageBox.Show("Informe um título para a tarefa.", "Tarefa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(prioridade))
            {
                MessageBox.Show("Selecione a prioridade.", "Tarefa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Selecione o status.", "Tarefa",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _tarefa.Titulo = titulo;
            _tarefa.Descricao = descricao;
            _tarefa.Prioridade = prioridade;
            _tarefa.Status = status;
            _tarefa.DataPrevista = dtpDataPrevista.Value.Date;

            AppData.SalvarTarefa(_tarefa);
            MessageBox.Show("Tarefa salva com sucesso.", "Tarefa",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
