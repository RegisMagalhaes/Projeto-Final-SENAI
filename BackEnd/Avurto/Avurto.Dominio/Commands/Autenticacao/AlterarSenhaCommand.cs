using Avurto.Dominio.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avurto.Dominio.Commands.Autenticacao
{
    class AlterarSenhaCommand : Notifiable<Notification>, ICommand
    {
        public AlterarSenhaCommand()
        {

        }

        public AlterarSenhaCommand(string senha)
        {
            Senha = senha;
        }

        public string Senha { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsGreaterThan(Senha, 7, "Senha", "A senha deve ter pelo menos 8 caracteres.")
           );
        }
    }
}
