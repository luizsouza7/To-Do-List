using System;
using System.Linq;
using System.Windows.Forms;
using To_Do_List.Controllers;
using To_Do_List.Services;

namespace To_Do_List
{
    public partial class FrmConsultaDatas : Form
    {
        private readonly BindingSource _bindingSource = new();
        private TarefaController? _controller;

        public FrmConsultaDatas()
        {
            InitializeComponent();
            btnConsultar.Click += BtnConsultar_Click;
            Load += FrmConsultaDatas_Load;
        }

        private void FrmConsultaDatas_Load(object? sender, EventArgs e)
        {
            if (AppData.UsuarioLogado == null)
            {
                MessageBox.Show("Sessão expirada. Faça login novamente.",
                    "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }

            _controller = new TarefaController(AppData.UsuarioLogado.Id);
            dtpInicio.Value = DateTime.Today.AddDays(-7);
            dtpFim.Value = DateTime.Today;
            dgvResultados.DataSource = _bindingSource;
        }

        private void BtnConsultar_Click(object? sender, EventArgs e)
        {
            AtualizarResultados();
        }

        private void AtualizarResultados()
        {
            if (_controller == null)
                return;

            var dados = _controller
                .BuscarPorPeriodo(dtpInicio.Value, dtpFim.Value)
                .Select(t => new
                {
                    t.Titulo,
                    t.Descricao,
                    DataPrevista = t.DataPrevista.HasValue ? t.DataPrevista.Value.ToString("dd/MM/yyyy") : "",
                    t.Prioridade,
                    t.Status
                })
                .ToList();

            _bindingSource.DataSource = dados;

            if (dados.Count == 0)
            {
                MessageBox.Show("Nenhuma tarefa encontrada no período selecionado.",
                    "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmConsultaDatas_Load_1(object sender, EventArgs e)
        {

        }
    }
}
