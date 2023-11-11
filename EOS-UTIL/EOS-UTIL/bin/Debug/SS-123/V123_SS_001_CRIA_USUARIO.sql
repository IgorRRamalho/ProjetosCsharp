using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Solicitar informações ao usuário
        Console.Write("Número do chamado: ");
        string numeroChamado = Console.ReadLine().ToUpper();

        Console.Write("Sigla: ");
        string sigla = Console.ReadLine().ToUpper();

        Console.Write("O que o script faz: ");
        string descricaoScript = Console.ReadLine().ToUpper();

        Console.Write("Versão do script: ");
        string versaoScript = Console.ReadLine().ToUpper();

        // Criar o nome da pasta e do arquivo
        string nomePasta = $"{sigla}-{numeroChamado}";
        string nomeArquivoSql = $"V{numeroChamado}_{sigla}_{versaoScript}_{descricaoScript}.sql";

        try
        {
            // Criar a pasta
            string caminhoPasta = Path.Combine(Directory.GetCurrentDirectory(), nomePasta);
            Directory.CreateDirectory(caminhoPasta);

            // Solicitar conteúdo para o arquivo SQL
            Console.WriteLine("Digite o conteúdo para o arquivo SQL (pressione Ctrl+Z e Enter para finalizar):");
            string conteudoSql = Console.In.ReadToEnd();

            // Criar o arquivo SQL dentro da pasta
            string caminhoArquivoSql = Path.Combine(caminhoPasta, nomeArquivoSql);
            File.WriteAllText(caminhoArquivoSql, conteudoSql);

            Console.WriteLine("Pasta e arquivo SQL criados com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }

        Console.ReadLine(); // Aguardar entrada do usuário antes de fechar o programa
    }
}











