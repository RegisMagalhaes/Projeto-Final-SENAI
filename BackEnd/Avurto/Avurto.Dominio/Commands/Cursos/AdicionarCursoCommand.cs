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
    public class AdicionarCursoCommand : Notifiable<Notification>, ICommand
    {
        public AdicionarCursoCommand()
        {

        }

        public AdicionarCursoCommand(string nomeCurso, string descricao, int preco, int duracao)
        {
            NomeCurso = nomeCurso;
            Descricao = descricao;
            Preco = preco;
            Duracao = duracao;
        }

        public string NomeCurso { get; set; }
        public string Descricao { get; set; }
        public int Preco { get; set; }
        public int Duracao { get; set; }


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
