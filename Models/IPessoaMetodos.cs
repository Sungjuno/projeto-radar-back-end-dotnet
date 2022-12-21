using System;
using System.Text.Json;

namespace exercicio_pessoa_fisica_juridica.Models
{
	public partial interface IPessoa
	{

        void Serializador(Object pessoa, StreamWriter file);

    }

}

