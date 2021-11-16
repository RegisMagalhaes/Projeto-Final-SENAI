using Avurto.Comum;
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
    public class Aluno : Base
    {

        public DateTime DataNascimento { get; set; }
        public string Turma { get; set; }
        public string RG { get; set; }
        public int CPF { get; set; }

        public Aluno(DateTime dataNascimento, string turma, string rG, int cPF)
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsGreaterThan(dataNascimento, DateTime.MinValue.AddYears(10), "DataNascimento")
                    .IsNotEmpty(turma, "Turma", "O aluno precisa estar em uma turma")
                    .AreEquals(rG, 9, "RG", "O RG precisa ter 9 dígitos.")
                    .AreEquals(cPF, 11, "RG", "O CPF precisa ter 11 dígitos.")
           );

            if(IsValid)
            {
                DataNascimento = dataNascimento;
                Turma = turma;
                RG = rG;
                CPF = cPF;
            }

        }

        //Composições
        public Guid IdUsuario { get; set; }
        public Usuario usuario { get; set; }


    }
}
