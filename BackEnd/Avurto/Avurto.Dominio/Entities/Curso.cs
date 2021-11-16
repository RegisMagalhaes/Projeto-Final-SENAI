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
    public class Curso : Base
    {
        public Curso(string nomeCurso, string descricao, int preco, int duracao)
        {

            AddNotifications(
               new Contract<Notification>()
                   .Requires()
                   .IsNotEmpty(NomeCurso, "NomeTurma", "O nome da turma não pode ser vazio.")
                   .IsNotEmpty(Descricao, "Descricao", "A descrição não pode ser vazia.")
                   .IsGreaterThan(Preco, 100, "Preco", "O valor precisa ser de no mínimo R$100,00")
                   .IsGreaterThan(Duracao, 15, "Duracao", "O curso precisa durar no mínimo 15 dias")

          );

            if (IsValid)
            {
                NomeCurso = nomeCurso;
                Descricao = descricao;
                Preco = preco;
                Duracao = duracao;
            }
        }

        public string NomeCurso { get; private set; }
        public string Descricao { get; private set; }
        public int Preco { get; private set; }
        public int Duracao { get; private set; }

        //Composições
        public Guid IdTurma { get; private set; }
        public Turma Turma { get; private set; }
        public IReadOnlyCollection<Turma> Turmas { get; private set; }
    }
}
