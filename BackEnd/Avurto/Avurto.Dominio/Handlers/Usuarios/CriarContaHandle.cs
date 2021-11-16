using Avurto.Comum.Handlers.Contracts;
using Avurto.Dominio.Commands;
using Avurto.Dominio.Commands.Contracts;
using Avurto.Dominio.Commands.Usuarios;
using Avurto.Dominio.Repositories;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Avurto.Dominio.Handlers.Usuarios
{
    public class CriarContaHandle : Notifiable<Notification>, IHandler<CriarContaCommand>
    {
        private readonly IUsuarioRepository _repository;

        public CriarContaHandle(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CriarContaCommand command)
        {
            // Validar o comando
            command.Validate();

            if (!command.IsValid)
            {
                return new GenericCommandResult(
                        false,
                        "Informe corretamente os dados",
                        command.Notifications
                    );
            }

            // Verificar se o email existe
            var usuarioExiste = _repository.BuscarPorEmail(command.Email);
            if (usuarioExiste != null)
                return new GenericCommandResult(false, "Email já cadastrado", "Informe outro email");

            // Criptografar minha senha

            // Salvar no banco
            Usuario u1 = new Usuario(command.Nome, command.Sobrenome, command.Email, command.Senha, command.TipoUsuario);
            if (!u1.IsValid)
                return new GenericCommandResult(false, "Dados de usuário inválidos", u1.Notifications);

            _repository.Adicionar(u1);

            // Enviar um email de boas vindas
            string to = command.Email;
            string from = "domanbruno@gmail.com";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Avurto Treinamentos";
            message.Body = @"Obrigado por ter se cadastrado no nosso site! Aproveite e veja nossos cursos!";
            SmtpClient client = new SmtpClient();
            // Credentials are necessary if the server requires the client
            // to authenticate before it will send email on the client's behalf.
            client.UseDefaultCredentials = true;

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }

            return new GenericCommandResult(true, "Usuario Criado", "Token");
        }
    }
}
