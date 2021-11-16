using Avurto.Dominio.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avurto.Dominio.Commands.Cursos
{
    public class AtualizarCursoCommand : Notifiable<Notification>, ICommand
    {
        public AtualizarCursoCommand()
        {

        }

        public AtualizarCursoCommand(Guid id, string nomeCurso, string descricao, int preco, int duracao)
        {
            Id = id;
            NomeCurso = nomeCurso;
            Descricao = descricao;
            Preco = preco;
            Duracao = duracao;
        }

        public Guid Id { get; set; }
        public string NomeCurso { get; private set; }
        public string Descricao { get; private set; }
        public int Preco { get; private set; }
        public int Duracao { get; private set; }


        public void Validate()
        {
            AddNotifications(
               new Contract<Notification>()
                   .Requires()
                   .IsNotEmpty(NomeCurso, "NomeTurma", "O nome da turma não pode ser vazio.")
                   .IsNotEmpty(Descricao, "Descricao", "A descrição não pode ser vazia.")
                   .IsGreaterThan(Preco, 100, "Preco", "O valor precisa ser de no mínimo R$100,00")
                   .IsGreaterThan(Duracao, 15, "Duracao", "O curso precisa durar no mínimo 15 dias")
           );
        }
    }
}
