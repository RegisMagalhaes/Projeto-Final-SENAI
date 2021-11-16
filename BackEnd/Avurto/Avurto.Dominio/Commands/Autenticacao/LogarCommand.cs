﻿using Avurto.Dominio.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avurto.Dominio.Commands.Autenticacao
{
    public class LogarCommand : Notifiable<Notification>, ICommand
    {
        public LogarCommand()
        {

        }

        public LogarCommand(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public string Email { get; set; }
        public string Senha { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsEmail(Email, "Email", "O formato do email está incorreto.")
                    .IsGreaterThan(Senha, 7, "Senha", "A senha deve ter pelo menos 8 caracteres.")
           );
        }
    }
}
