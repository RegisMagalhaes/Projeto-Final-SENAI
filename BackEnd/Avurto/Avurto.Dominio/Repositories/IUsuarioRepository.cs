using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avurto.Dominio.Repositories
{
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="usuario">Dados do usuário</param>
        void Adicionar(Usuario usuario);

        /// <summary>
        /// Altera os dados de um usuário existente
        /// </summary>
        /// <param name="usuario">Dados do usuário</param>
        void Alterar(Usuario usuario);

        /// <summary>
        /// Altera a senha de um usuário existente
        /// </summary>
        /// <param name="usuario">Dados do usuário</param>
        void AlterarSenha(Usuario usuario);

        /// <summary>
        /// Busca um usuário pelo email
        /// </summary>
        /// <param name="email">Email do usuário cadastrado</param>
        /// <returns>Um usuário buscado</returns>
        Usuario BuscarPorEmail(string email);

        /// <summary>
        /// Busca um usuário pelo seu ID
        /// </summary>
        /// <param name="id">ID do usuário cadastrado</param>
        /// <returns>Um usuário buscado</returns>
        Usuario BuscarPorId(Guid id);

        /// <summary>
        /// Lista todos os usuários criados
        /// </summary>
        /// <returns>Uma lista de usuários</returns>
        ICollection<Usuario> Listar();
    }
}
