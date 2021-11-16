using Avurto.Comum.Enum;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avurto.Dominio.Entidades
{
    public class Professor : Usuario
    { 
        public Professor(string turma, string nome, string sobrenome, string email, string senha, EnTipoUsuario tipoUsuario) : base(nome, sobrenome, email, senha, tipoUsuario)
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNotEmpty(turma, "Turma", "O professor precisa estar em uma turma.")
           );

            if (IsValid)
            {
                Turma = turma;
            }

        }

        public string Turma { get; private set; }

    }
}
