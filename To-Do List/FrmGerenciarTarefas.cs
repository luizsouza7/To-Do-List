using System;
using System.Linq;
using System.Windows.Forms;
using To_Do_List.Controllers;
using To_Do_List.Models;
using To_Do_List.Services;

namespace To_Do_List
{
    public partial class FrmGerenciarTarefas : Form
    {
        private readonly BindingSource _bindingSource = new();
        private TarefaController? _controller;

        public FrmGerenciarTarefas()
        {
            InitializeComponent();
            btnNovo.Click += BtnNovo_Click;
            btnEditar.Click += BtnEditar_Click;
            btnExcluir.Click += BtnExcluir_Click;
            btnVoltar.Click += (_, _) => Close();
            Load += FrmGerenciarTarefas_Load;
        }

        private void FrmGerenciarTarefas_Load(object? sender, EventArgs e)
        {
            if (AppData.UsuarioLogado == null)
            {
                MessageBox.Show("Sessão expirada. Faça login novamente.",
                    "Gerenciar Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }

            _controller = new TarefaController(AppData.UsuarioLogado.Id);
            dgvTarefas.DataSource = _bindingSource;
            dgvTarefas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTarefas.MultiSelect = false;
            dgvTarefas.ReadOnly = true;

            CarregarTarefas();
        }

        private void CarregarTarefas()
        {
            if (_controller == null)
                return;

            var tarefas = _controller.ListarTodas();
            var dados = tarefas.Select(t => new
            {
                t.Id,
                t.Titulo,
                t.Descricao,
                DataPrevista = t.DataPrevista.HasValue ? t.DataPrevista.Value.ToString("dd/MM/yyyy") : "",
                t.Prioridade,
                t.Status
            }).ToList();

            _bindingSource.DataSource = dados;
        }

        private void BtnNovo_Click(object? sender, EventArgs e)
        {
            using var form = new FrmTarefaCrud();
            if (form.ShowDialog() == DialogResult.OK)
            {
                CarregarTarefas();
            }
        }

        private void BtnEditar_Click(object? sender, EventArgs e)
        {
            if (dgvTarefas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma tarefa para editar.",
                    "Gerenciar Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = (Guid)dgvTarefas.SelectedRows[0].Cells["Id"].Value;
            var tarefa = _controller?.ObterPorId(id);

            if (tarefa == null)
            {
                MessageBox.Show("Tarefa não encontrada.",
                    "Gerenciar Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var form = new FrmTarefaCrud(tarefa);
            if (form.ShowDialog() == DialogResult.OK)
            {
                CarregarTarefas();
            }
        }

        private void BtnExcluir_Click(object? sender, EventArgs e)
        {
            if (dgvTarefas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma tarefa para excluir.",
                    "Gerenciar Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = (Guid)dgvTarefas.SelectedRows[0].Cells["Id"].Value;
            var titulo = dgvTarefas.SelectedRows[0].Cells["Titulo"].Value?.ToString() ?? "";

            var resultado = MessageBox.Show(
                $"Deseja realmente excluir a tarefa '{titulo}'?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            string mensagem = string.Empty; // Inicialização da variável

            if (resultado == DialogResult.Yes)
            {
                if (_controller?.Excluir(id, out mensagem) == true)
                {
                    MessageBox.Show(mensagem, "Gerenciar Tarefas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTarefas();
                }
                else
                {
                    MessageBox.Show(mensagem, "Gerenciar Tarefas",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

