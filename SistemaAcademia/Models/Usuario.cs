using SistemaAcademia.Enums;

namespace SistemaAcademia.Models;

public abstract class Usuario
{
    public Usuario(string email, string senha, string nome, string sobrenome, TipoPermissaoEnum tipoPermissao)
    {
        Id = ++_contadorId;
        Email = email;
        _senha = senha;
        Nome = nome;
        Sobrenome = sobrenome;
        TipoPermissao = tipoPermissao;
    }
    private static int _contadorId = 0;
    public int Id { get; }
    public string Email { get; }
    private string _senha { get; set; }
    public string Nome { get; }
    public string Sobrenome { get; }
    public TipoPermissaoEnum TipoPermissao { get; private set; }

    public bool ValidarSenha(string senha) =>  _senha == senha;
    
    public abstract void ExibirMenu();
}
