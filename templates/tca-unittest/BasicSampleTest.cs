namespace TheCleanArch.Templates.UnitTest;

public class BasitSampleTest
{
    /// <summary>
    /// Não use sublinhados para separar os nomes dos métodos de teste.
    /// Use a convenção de nomenclatura PascalCase.
    /// </summary>
    /// <remarks>
    /// Por exemplo, em vez de "Add_WithTwoNumbers_ReturnsSum", use "AddWithTwoNumbersReturnsSum".
    /// </remarks>
    [Test]
    [Arguments(DisplayName = "Add with two numbers returns sum")]
    public async Task AddWithTwoNumbersReturnsSum()
    {
        var result = Add(2, 3);

        await Assert.That(result).IsEqualTo(5);
    }
    private int Add(int a, int b)
    {
        return a + b;
    }
}
