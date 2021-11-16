using Avurto.Dominio.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avurto.Dominio.Commands.Alunos
{
    class AtualizarAlunoCommand : Notifiable<Notification>, ICommand
    {
        public AtualizarAlunoCommand()
        {
                
        }

        public AtualizarAlunoCommand(string turma)
        {
            Turma = turma;
        }

        public string Turma { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNotEmpty(Turma, "Turma", "O aluno precisa estar em uma turma")
           );
        }
    }
}
