using RsTaskManager.Application.UseCases.Task.GetAll;
using RsTaskManager.Communication.Responses;

namespace RsTaskManager.Application.Tests.Task.GetAllTests;

public class GetAllUnitTests
{
    [Fact]
    public void ShouldReturnResponseAllTasksJson()
    {
        var useCase = new GetAllTasksUseCase();

        var result = useCase.Execute();

        Assert.NotNull(result);
        Assert.IsType<ResponseAllTasksJson>(result);
        Assert.NotNull(result.Tasks);
    }
}
