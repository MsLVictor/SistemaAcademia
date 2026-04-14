using SistemaAcademia.DTOs;
using SistemaAcademia.Interface.Repositories;
using SistemaAcademia.Models;
using SistemaAcademia.Repositories;

namespace SistemaAcademia.Services;

public class AutenticacaoService(IUsuarioRepository usuarioRepository)
{
    private readonly IUsuarioRepository _usuarioRepository = usuarioRepository;

    public Usuario UsuarioLogin(LoginDto dto)
    {
        var usuario = _usuarioRepository.BuscarUsuarioPorEmail(dto.Email);

        if (usuario == null)
        {
            System.Console.WriteLine("Usuário não encontrado");
            return null; 
        }

        if (!usuario.ValidarSenha(dto.Senha))
        {
            System.Console.WriteLine("Senha inválida");
            return null; 
        }
        Console.WriteLine($"Bem-vindo(a), {usuario.Nome}! [{usuario.TipoPermissao}]");
            return usuario;
    }
}
