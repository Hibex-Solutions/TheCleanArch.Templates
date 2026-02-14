namespace TheCleanArch.Templates.UnitTest;

public class MockingSampleTest
{
    /// <summary>
    /// Use a biblioteca de mocking "Moq" para criar objetos simulados (mocks)
    /// de dependências em seus testes unitários.
    /// </summary>
    [Test]
    public async Task ConstructorInjectionAllowsProvidingMockedDependency()
    {
        var mockService = new Mock<IMyService>();
        var target = new MyTarget(mockService.Object);

        await Assert.That(target).IsNotNull();
    }

    /// <summary>
    /// Use os métodos "Verify" do Moq para verificar se os métodos das
    /// dependências foram chamados corretamente durante a execução do teste.
    /// </summary>
    [Test]
    public async Task VerifyDependencyMethodCalled()
    {
        var mockService = new Mock<IMyService>();
        var target = new MyTarget(mockService.Object);

        target.Execute();

        mockService.Verify(s => s.DoWork(), Times.Once);
        await Task.CompletedTask;
    }

    /// <summary>
    /// Você também pode verificar se um método foi chamado com parâmetros
    /// específicos usando o Moq.
    /// </summary>
    [Test]
    public async Task VerifyDependencyMethodCalledWithSpecificParameter()
    {
        var mockService = new Mock<IMyService>();
        var target = new MyTarget(mockService.Object);

        target.ExecuteWithParam("expected");

        mockService.Verify(s => s.DoWorkWithParam("expected"), Times.Once);
        await Task.CompletedTask;
    }

    /// <summary>
    /// Use o método "Setup" do Moq para configurar o comportamento de um método
    /// simulado e retornar um valor específico quando for chamado.
    /// </summary>
    [Test]
    public async Task VerifyMethodReturnsSpecificValue()
    {
        var mockService = new Mock<IMyService>();
        mockService.Setup(s => s.GetValue()).Returns(42);

        var target = new MyTarget(mockService.Object);

        var result = target.Compute();

        await Assert.That(result).IsEqualTo(43);
    }
}

public interface IMyService
{
    void DoWork();
    void DoWorkWithParam(string value);
    int GetValue();
}

public class MyTarget
{
    private readonly IMyService _service;

    public MyTarget(IMyService service) => _service = service;

    public void Execute() => _service.DoWork();

    public void ExecuteWithParam(string value) => _service.DoWorkWithParam(value);

    public int Compute() => _service.GetValue() + 1;
}
