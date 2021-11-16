using Avurto.Comum.Handlers.Contracts;
using Avurto.Dominio.Commands.Autenticacao;
using Avurto.Dominio.Commands.Contracts;
using Avurto.Dominio.Repositories;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avurto.Dominio.Handlers.Autenticacao
{
    public class LogarHandle : Notifiable<Notification>, IHandler<LogarCommand>
    {
        private readonly IUsuarioRepository _repository;

        public LogarHandle(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(LogarCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
