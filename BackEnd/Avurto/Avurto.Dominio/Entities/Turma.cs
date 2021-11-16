using Avurto.Comum;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avurto.Dominio.Entidades
{
    public class Turma : Base
    {
        public Turma(string nomeTurma, int capacidade)
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNotEmpty(nomeTurma, "NomeTurma", "O nome da turma não pode ser vazio")
                    .IsGreaterThan(capacidade, 19, "Capacidade", "A capacidade deve ser de pelo menos 20 pessoas.")
           );

            if (IsValid)
            {
                NomeTurma = nomeTurma;
                Capacidade = capacidade;
            }
            
        }

        public string NomeTurma { get; private set; }
        public int Capacidade { get; private set; }

        //Composições
        public Guid IdAluno { get; private set; }
        public virtual Aluno Aluno { get; private set; }
        public IReadOnlyCollection<Aluno> Alunos { get { return _alunos; } }

        //Para alterar os alunos, vamos precisar de uma lista de apoio
        private List<Aluno> _alunos { get; set; }


        public Guid IdProfessor { get; private set; }
        public virtual Professor Professor { get; private set; }
        public IReadOnlyCollection<Professor> Professors { get; private set; }
    }
}
