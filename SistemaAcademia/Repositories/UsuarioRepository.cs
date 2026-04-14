using SistemaAcademia.Interface.Repositories;
using SistemaAcademia.Models;

namespace SistemaAcademia.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly List<Usuario> _usuarios = [];
    public void AdicionarUsuario(Usuario usuario) => _usuarios.Add(usuario);
    
    public Usuario BuscarUsuarioPorEmail(string email) => _usuarios.FirstOrDefault(u => u.Email == email);
    
    public List<Usuario> Listar() => _usuarios;
    
}
