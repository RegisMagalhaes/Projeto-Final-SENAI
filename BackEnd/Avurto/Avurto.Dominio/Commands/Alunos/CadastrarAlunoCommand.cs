using Avurto.Dominio.Commands.Contracts;
using Avurto.Dominio.Entidades;
using Flunt.Notifications;
using System;


namespace Avurto.Dominio.Commands.Alunos
{
    public class CadastrarAlunoCommand : Notifiable<Notification>, ICommand
    {
        public CadastrarAlunoCommand()
        {

        }

        public CadastrarAlunoCommand(Guid id, Aluno aluno)
        {
            Id = id;
            Aluno = aluno;
        }

        public Guid Id { get; set; }
        public Aluno Aluno { get; set; }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
