using Avurto.Dominio.Commands.Contracts;
using Avurto.Dominio.Entidades;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avurto.Dominio.Commands.Turmas
{
    class AdicionarTurmaCommand : Notifiable<Notification>, ICommand
    {
        public AdicionarTurmaCommand()
        {

        }

        public AdicionarTurmaCommand(string nomeTurma, int capacidade, Guid idAluno, Aluno aluno)
        {
            NomeTurma = nomeTurma;
            Capacidade = capacidade;
            IdAluno = idAluno;
            Aluno = aluno;
        }

        public string NomeTurma { get; set; }
        public int Capacidade { get; set; }
        public Guid IdAluno { get; set; }
        public Aluno Aluno { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNotEmpty(NomeTurma, "NomeTurma", "O nome da turma não pode ser vazio")
                    .IsGreaterThan(Capacidade, 19, "Capacidade", "A capacidade deve ser de pelo menos 20.")
           );
        }
    }
}
