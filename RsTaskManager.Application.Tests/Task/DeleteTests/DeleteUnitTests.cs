using RsTaskManager.Application.UseCases.Task.Delete;

namespace RsTaskManager.Application.Tests.Task.DeleteTests;

public class DeleteUnitTests
{
    [Fact]
    public void ShouldThrowArgumentNullException()
    {
        int id = 0;
        var exceptionType = typeof(ArgumentNullException);
        var useCase = new DeleteTaskUseCase();

        Assert.Throws(exceptionType, () =>
        {
            useCase.Execute(id);
        });
    }
}
