using SistemaAcademia.DTOs;
using SistemaAcademia.Interface.Repositories;
using SistemaAcademia.Models;

namespace SistemaAcademia.Services;

public class UsuarioService(IUsuarioRepository usuarioRepository)
{

    private readonly IUsuarioRepository _usuarioRepository = usuarioRepository;

    public void CriarUsuario(UsuarioDto dto)
    {
        var usuario = _usuarioRepository.BuscarUsuarioPorEmail(dto.Email);

        if(usuario == null)
        
        _usuarioRepository.AdicionarUsuario(usuario);
    }

}
