using SistemaAcademia.Enums;

namespace SistemaAcademia.Models;

public class Cliente : Usuario
{
  public Cliente(string email, string senha, string nome, string sobrenome, TipoPlanoEnum tipoPlano)
        : base(email, senha, nome, sobrenome, TipoPermissaoEnum.Cliente)
    {
        TipoPlano = tipoPlano;
    }

    public TipoPlanoEnum TipoPlano { get; private set; }
    public override void ExibirMenu()
    {
        Console.WriteLine("=== CLIENTE ===");
        Console.WriteLine("1 - Ver plano");
    }
}
