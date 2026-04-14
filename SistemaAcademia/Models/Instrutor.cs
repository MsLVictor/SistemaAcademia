namespace SistemaAcademia.Models;

public class Instrutor : Usuario
{
    public Instrutor(string email, string senha, string nome, string sobrenome)
   : base(email, senha, nome, sobrenome, Enums.TipoPermissaoEnum.Instrutor)
    {

    }

    public override void ExibirMenu()
    {
        Console.WriteLine("=== INSTRUTOR ===");
        Console.WriteLine("1 - Criar treino");
    }
}
