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
    public class RecuperarSenhaCommand : Notifiable<Notification>, ICommand
    {
        public RecuperarSenhaCommand()
        {

        }

        public RecuperarSenhaCommand(string email)
        {
            Email = email;
        }

        public string Email { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsEmail(Email, "Email", "O formato do email está incorreto.")
           );
        }
    }
}
