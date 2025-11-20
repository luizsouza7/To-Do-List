using System;
using System.Linq;
using System.Windows.Forms;
using To_Do_List.Controllers;
using To_Do_List.Services;

namespace To_Do_List
{
    public partial class FrmConsultaTarefas : Form
    {
        private readonly BindingSource _bindingSource = new();
        private TarefaController? _controller;

        public FrmConsultaTarefas()
        {
            InitializeComponent();
            btnFiltrar.Click += BtnFiltrar_Click;
            btnVoltar.Click += (_, _) => Close();
            Load += FrmConsultaTarefas_Load;
        }

        private void FrmConsultaTarefas_Load(object? sender, EventArgs e)
        {
            if (AppData.UsuarioLogado == null)
            {
                MessageBox.Show("Sessão expirada. Faça login novamente.",
                    "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }

            _controller = new TarefaController(AppData.UsuarioLogado.Id);
            dgvResultados2.DataSource = _bindingSource;

            cmbFiltroPrior.Items.Clear();
            cmbFiltroPrior.Items.Add("Todas");
            cmbFiltroPrior.Items.AddRange(new[] { "Alta", "Média", "Baixa" });
            cmbFiltroPrior.SelectedIndex = 0;

            cmbFiltroStatus.Items.Clear();
            cmbFiltroStatus.Items.Add("Todos");
            cmbFiltroStatus.Items.AddRange(new[] { "Pendente", "Em Progresso", "Concluída" });
            cmbFiltroStatus.SelectedIndex = 0;

            AtualizarResultados();
        }

        private void BtnFiltrar_Click(object? sender, EventArgs e)
        {
            AtualizarResultados();
        }

        private void AtualizarResultados()
        {
            if (_controller == null || AppData.UsuarioLogado == null)
                return;

            var filtroTitulo = txtFiltroTitulo.Text.Trim();
            var filtroPrioridade = cmbFiltroPrior.SelectedItem?.ToString() ?? "Todas";
            var filtroStatus = cmbFiltroStatus.SelectedItem?.ToString() ?? "Todos";

            var tarefas = _controller.Buscar(filtroTitulo);

            if (filtroPrioridade != "Todas")
            {
                tarefas = tarefas.Where(t => t.Prioridade == filtroPrioridade).ToList();
            }

            if (filtroStatus != "Todos")
            {
                tarefas = tarefas.Where(t => t.Status == filtroStatus).ToList();
            }

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

            if (dados.Count == 0)
            {
                MessageBox.Show("Nenhuma tarefa encontrada com os filtros selecionados.",
                    "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
