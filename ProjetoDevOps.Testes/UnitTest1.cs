using Xunit;

namespace ProjetoDevOps.Testes;

public class UnitTest1
{
    [Fact]
    public void TestarSomaSimples()
    {
        // Organizar
        int a = 2;
        int b = 3;
        
        // Agir
        int resultado = a + b;
        
        // Afirmar
        Assert.Equal(5, resultado);
    }
}