using System;
using System.Text.Json;

namespace exercicio_pessoa_fisica_juridica.Models
{
    public class PessoaFisica : IPessoa

    {
        string _Id = Guid.NewGuid().ToString();
        string _Tipo = "F";

        public string Id {
            get { return _Id; }
            set { this.Id = _Id; }
        }
        public string Nome { get ; set ; }
        public string Tipo {
            get { return _Tipo; }
            set { this.Tipo = _Tipo; } }
        public int CPF { get; set; }
    }

}

