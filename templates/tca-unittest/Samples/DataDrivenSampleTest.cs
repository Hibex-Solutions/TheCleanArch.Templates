namespace TheCleanArch.Templates.UnitTest.Samples;

[Skip("Esses testes são apenas para fins de demonstração e por isso estão sendo ignorados.")]
public class DataDrivenSampleTest
{
    /// <summary>
    /// Para múltiplos casos de teste, use testes orientados a dados
    /// (data-driven tests) em vez de criar métodos de teste separados
    /// para cada caso.
    /// </summary>
    [Test]
    [Arguments(1, 1, 2)]
    [Arguments(1, 2, 3)]
    [Arguments(2, 2, 4)]
    [Arguments(4, 3, 7)]
    [Arguments(5, 5, 10)]
    public async Task AddWithTwoNumbersReturnsSumByDataDriven(int value1, int value2, int expectedResult)
    {
        var result = Add(value1, value2);

        await Assert.That(result).IsEqualTo(expectedResult);
    }

    private int Add(int a, int b)
    {
        return a + b;
    }
}
