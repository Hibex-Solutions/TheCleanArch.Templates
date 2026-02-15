namespace TheCleanArch.Templates.UnitTest.Samples;

[Skip("Esses testes são apenas para fins de demonstração e por isso estão sendo ignorados.")]
public class MethodDataSourceSampleTest
{
    /// <summary>
    /// Obtenha os dados de teste de um método separado usando a propriedade
    /// "MethodDataSource" e um método estático como origem dos dados.
    /// </summary>
    [Test]
    [MethodDataSource(typeof(MethodDataSourceSampleTest), nameof(StaticTestData))]
    public async Task AddWithTwoNumbersReturnsSumByStaticData(int value1, int value2, int expectedResult)
    {
        var result = Add(value1, value2);

        await Assert.That(result).IsEqualTo(expectedResult);
    }

    /// <summary>
    /// Você também pode usar a propriedade "MethodDataSource" para obter os
    /// dados de teste de um método na instância do teste.
    /// </summary>
    [Test]
    [InstanceMethodDataSource(nameof(InstanceTestData))]
    public async Task AddWithTwoNumbersReturnsSumByInstanceData(int value1, int value2, int expectedResult)
    {
        var result = Add(value1, value2);

        await Assert.That(result).IsEqualTo(expectedResult);
    }

    private int Add(int a, int b)
    {
        return a + b;
    }

    private IEnumerable<(int, int, int)> InstanceTestData => [
        (12, 30, 42),
        (10, 20, 30)
    ];

    public static IEnumerable<Func<(int, int, int)>> StaticTestData()
    {
        yield return () => (6, 2, 8);
        yield return () => (7, 1, 8);
        yield return () => (3, 7, 10);
    }
}
