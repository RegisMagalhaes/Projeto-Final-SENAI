using Avurto.Comum;
using Avurto.Comum.Enum;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avurto.Dominio
{
    public class Usuario : Base
    {

        public Usuario(string nome, string sobrenome, string email, string senha, EnTipoUsuario tipoUsuario)
        {

            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNotEmpty(nome, "Nome", "Nome não pode ser vazio.")
                    .IsNotEmpty(sobrenome, "Sobrenome", "Sobrenome não pode ser vazio.")
                    .IsEmail(email, "Email", "O formato do email está incorreto.")
                    .IsGreaterThan(senha, 7, "Senha", "A senha deve ter pelo menos 8 caracteres.")
           );

            if(IsValid)
            {
                Nome = nome;
                Sobrenome = sobrenome;
                Email = email;
                Senha = senha;
                TipoUsuario = tipoUsuario;
            }

        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public EnTipoUsuario TipoUsuario { get; private set; }
    }
}
