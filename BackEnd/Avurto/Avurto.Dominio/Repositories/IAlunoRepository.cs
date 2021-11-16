using Avurto.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avurto.Dominio.Repositories
{
    public interface IAlunoRepository
    {
        void Create(Guid id, Aluno aluno);
        void Update(Aluno aluno);
    }
}
