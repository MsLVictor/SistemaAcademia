namespace SistemaAcademia.Models;

public class Recepcionista : Usuario
{
     public Recepcionista(string email, string senha, string nome, string sobrenome)
        : base(email, senha, nome, sobrenome, Enums.TipoPermissaoEnum.Recepcionista)
    {
        
    }

    public override void ExibirMenu()
    {
        Console.WriteLine("=== RECEPCIONISTA ===");
        Console.WriteLine("1 - Cadastrar Cliente");
    }
}
