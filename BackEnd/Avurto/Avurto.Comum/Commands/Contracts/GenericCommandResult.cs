﻿using Avurto.Dominio.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avurto.Dominio.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult()
        {

        }

        public GenericCommandResult(bool sucesso, string mensagem, object data)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Data = data;
        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public Object Data { get; set; }
    }
}
