using Avurto.Comum.Handlers.Contracts;
using Avurto.Dominio.Commands;
using Avurto.Dominio.Commands.Alunos;
using Avurto.Dominio.Commands.Contracts;
using Avurto.Dominio.Entidades;
using Avurto.Dominio.Repositories;
using Flunt.Notifications;
using System;

namespace Avurto.Dominio.Handlers.Alunos
{

    public class AlunoHandler : Notifiable<Notification>, IHandler<CadastrarAlunoCommand>
    {
        private readonly IAlunoRepository _repository;

        public AlunoHandler(IAlunoRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CadastrarAlunoCommand command)
        {
            throw new NotImplementedException();
        }

       public ICommandResult Handle(CadastrarAlunoCommand command)
       {
            // Fail fast validation
            command.Validate();
            if (!command.IsValid)
            {
                return new GenericCommandResult(false, "Ops, deu ruim", command.Notifications);
           }

            var aluno = new Aluno(command.Id, command.Aluno);

            _repository.Update(aluno);
        }   
    }
}
