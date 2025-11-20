using System;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace To_Do_List
{
    public static class TesteConexao
    {
        public static void Testar()
        {
            try
            {
                using var context = new TodoContext();
                
                // Tenta conectar ao banco de dados
                var podeConectar = context.Database.CanConnect();
                
                string nomeBanco = "TodoListDB";
                var connectionString = ConfigurationManager.ConnectionStrings["TodoConnection"]?.ConnectionString;
                if (!string.IsNullOrEmpty(connectionString))
                {
                    var dbPart = connectionString.Split(';')
                        .FirstOrDefault(s => s.Trim().StartsWith("Database=", StringComparison.OrdinalIgnoreCase));
                    if (dbPart != null)
                    {
                        nomeBanco = dbPart.Split('=')[1].Trim();
                    }
                }
                
                if (podeConectar)
                {
                    MessageBox.Show(
                        "✅ Conexão com o banco de dados estabelecida com sucesso!\n\n" +
                        $"Banco de dados: {nomeBanco}\n" +
                        "A aplicação está pronta para uso.",
                        "Teste de Conexão",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    // Tenta criar o banco se não existir
                    context.Database.EnsureCreated();
                    MessageBox.Show(
                        "✅ Banco de dados criado com sucesso!\n\n" +
                        $"Banco: {nomeBanco}\n" +
                        "A conexão está funcionando corretamente.",
                        "Teste de Conexão",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                var mensagem = $"❌ Erro ao conectar com o banco de dados:\n\n{ex.Message}\n\n";
                
                if (ex.InnerException != null)
                {
                    mensagem += $"Detalhes: {ex.InnerException.Message}\n\n";
                }
                
                mensagem += "Verifique:\n" +
                           "1. SQL Server está instalado e rodando\n" +
                           "2. A porta 1433 está acessível\n" +
                           "3. As credenciais no App.config estão corretas\n" +
                           "4. O SQL Server aceita conexões remotas (se aplicável)";
                
                MessageBox.Show(
                    mensagem,
                    "Erro de Conexão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

