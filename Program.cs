using System.Text;
using System.Text.Json;

namespace Exercicio;


class Exercicio

{
    public static void Main(string[] args)
    {
        using StreamWriter file = new("/Users/sung/Projects/exercicio-pessoa-fisica-juridica/exercicio-pessoa-fisica-juridica/CadastroJson.json", append: true);

        int id = 0;
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Registro Pessoa Física");
            Console.WriteLine("2. Registro Pessoa Jurídica");
            Console.WriteLine("3. Ver tabela de pessoas cadastradas.");
            Console.WriteLine("4. Exit");

            Console.Write("Escolha a opção desejada: ");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:

                    Console.WriteLine("1. Nome");
                    string nomeFisico = Console.ReadLine();
                    Console.WriteLine("2. Documento");
                    int documento = int.Parse(Console.ReadLine());

                    PessoaFisica pessoaFisica = new PessoaFisica();
                    pessoaFisica.Id = id++;
                    pessoaFisica.Nome = nomeFisico;
                    pessoaFisica.CPF = documento;
                    pessoaFisica.Tipo = "F";

                    string jsonFisica = JsonSerializer.Serialize(pessoaFisica);

                    file.WriteLine(jsonFisica);

                    break;

                case 2:

                    Console.WriteLine("1. Nome");
                    string nomeFornecedor = Console.ReadLine();
                    Console.WriteLine("2. CNPJ");
                    int cnpj = int.Parse(Console.ReadLine());

                    PessoaJuridica pessoaJuridica = new PessoaJuridica();
                    pessoaJuridica.Id = id++;
                    pessoaJuridica.Nome = nomeFornecedor;
                    pessoaJuridica.CNPJ = cnpj;
                    pessoaJuridica.Tipo = "J";

                    string jsonJuridica = JsonSerializer.Serialize(pessoaJuridica);

                    file.WriteLine(jsonJuridica);

                    break;
                case 3:
                    var path = "/Users/sung/Projects/exercicio-pessoa-fisica-juridica/exercicio-pessoa-fisica-juridica/CadastroJson.json";
                    string conteudo = File.ReadAllText(path, Encoding.UTF8);
                    Console.WriteLine(conteudo);
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        }
    }

    public class PessoaFisica : Pessoa
    {

        public int CPF { get; set; }
        
    }

    public class PessoaJuridica : Pessoa
    {

        public int CNPJ { get; set; }

    }

    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }

    }

}


