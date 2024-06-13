using RsTaskManager.Application.UseCases.Task.GetById;
using RsTaskManager.Communication.Responses;

namespace RsTaskManager.Application.Testes.Task.GetByIdTests;

public class GetByIdUnitTests
{
    [Fact]
    public void ShouldReturnResponseTaskJson()
    {
        int id = 1;
        var useCase = new GetByIdUseCase();

        var result = useCase.Execute(id);

        Assert.NotNull(result);
        Assert.Equal(id, result.Id);
        Assert.IsType<ResponseTaskJson>(result);
    }

    [Fact]
    public void ShouldThrowArgumentNullException()
    {
        int id = 0;
        var useCase = new GetByIdUseCase();
        var exceptionType = typeof(ArgumentNullException);

        Assert.Throws(exceptionType, () =>
        {
            useCase.Execute(id);
        });
    }
}
