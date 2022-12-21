using System.Text;
using System.Text.Json;
using exercicio_pessoa_fisica_juridica.Models;

namespace Exercicio;


class Exercicio

{
    public static void Main(string[] args)
    {
        using StreamWriter file = new("/Users/sung/Projects/exercicio-pessoa-fisica-juridica/exercicio-pessoa-fisica-juridica/CadastroJson.json", append: true);
        var path = "/Users/sung/Projects/exercicio-pessoa-fisica-juridica/exercicio-pessoa-fisica-juridica/CadastroJson.json";
        string conteudo = File.ReadAllText(path, Encoding.UTF8);

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Registro Pessoa Física");
            Console.WriteLine("2. Registro Pessoa Jurídica");
            Console.WriteLine("3. Ver tabela de pessoas cadastradas.");
            Console.WriteLine("4. Exit");

            Console.Write("Escolha a opção desejada: ");
            int selecao = int.Parse(Console.ReadLine());

            switch (selecao)
            {
                case 1:

                    Console.WriteLine("1. Nome");
                    string nomeFisico = Console.ReadLine();
                    Console.WriteLine("2. Documento");
                    int documento = int.Parse(Console.ReadLine());

                    PessoaFisica pessoaFisica = new PessoaFisica() { Nome = nomeFisico, CPF = documento};
                    pessoaFisica.Serializador(pessoaFisica, file);
                    Console.Clear();

                    break;

                case 2:

                    Console.WriteLine("1. Nome");
                    string nomeFornecedor = Console.ReadLine();
                    Console.WriteLine("2. CNPJ");
                    int cnpj = int.Parse(Console.ReadLine());

                    PessoaJuridica pessoaJuridica = new PessoaJuridica() { Nome = nomeFornecedor, CNPJ = cnpj};
                    pessoaJuridica.Serializador(pessoaJuridica, file);
                    Console.Clear();

                    break;
                case 3:
                    Console.WriteLine("Para ver os cadastros atuais é necessário encerrar e rodar a aplicação.");
                    Console.WriteLine(conteudo);
                    break;
                case 4:
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        }
    }
}


