using Avurto.Comum.Enum;
using Avurto.Dominio.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace Avurto.Dominio.Commands.Usuarios
{
    public class CriarContaCommand : Notifiable<Notification>, ICommand
    {
        public CriarContaCommand()
        {

        }

        public CriarContaCommand(string nome, string sobrenome, string email, string senha, EnTipoUsuario tipoUsuario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Senha = senha;
            TipoUsuario = tipoUsuario;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public EnTipoUsuario TipoUsuario { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNotEmpty(Nome, "Nome", "Nome não pode ser vazio.")
                    .IsNotEmpty(Sobrenome, "Sobrenome", "Sobrenome não pode ser vazio.")
                    .IsEmail(Email, "Email", "O formato do email está incorreto.")
                    .IsGreaterThan(Senha, 7, "Senha", "A senha deve ter pelo menos 8 caracteres.")
           );

        }
    }
}
