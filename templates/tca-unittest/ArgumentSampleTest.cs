namespace TheCleanArch.Templates.UnitTest;

public class ArgumentSampleTest
{
    /// <summary>
    /// Sempre valide os parâmetros de entrada em seus métodos de teste usando a
    /// classe "ArgumentNullException" ou outras classes de exceção apropriadas.
    /// </summary>
    /// <returns></returns>
    [Test]
    public async Task ArgumentIsRequired()
    {
        var exception = Assert.Throws<ArgumentNullException>(
            () => Test(null!)
        );

        await Assert.That(exception!.ParamName).IsEqualTo("parameterName");
    }

    private void Test(object parameterName)
    {
        ArgumentNullException.ThrowIfNull(parameterName);
    }
}
