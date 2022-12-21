using System;
using System.Text.Json;

namespace exercicio_pessoa_fisica_juridica.Models
{
	public interface IPessoa
	{

        string Id { get; set; }
        string Nome { get; set; }
        string Tipo { get; set; }

    }

}

