using SistemaAcademia.Models;

namespace SistemaAcademia.Interface.Repositories;

    public interface IUsuarioRepository
    {
        void AdicionarUsuario(Usuario usuario);
        Usuario BuscarUsuarioPorEmail(string email);
        List<Usuario> Listar();
    }
