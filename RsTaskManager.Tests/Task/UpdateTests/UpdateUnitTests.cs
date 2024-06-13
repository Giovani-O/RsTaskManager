using RsTaskManager.Application.UseCases.Task.Update;
using RsTaskManager.Communication.Requests;

namespace RsTaskManager.Tests.Task.UpdateTests;

public class UpdateUnitTests
{
    [Fact]
    public void ShouldReturnArgumentNullException()
    {
        int invalidId = 0;
        int validId = 1;
        var invalidRequest = new RequestTaskJson
        {
            Id = 1,
            Name = "",
            Description = "Deve lançar uma exceção",
            Priority = Communication.Enums.TaskPriority.High,
            Deadline = new DateTime(year: 2024, month: 7, day: 15),
            Status = Communication.Enums.TaskStatusCode.InExecution
        };
        var validRequest = new RequestTaskJson
        {
            Id = 1,
            Name = "",
            Description = "Deve lançar uma exceção",
            Priority = Communication.Enums.TaskPriority.High,
            Deadline = new DateTime(year: 2024, month: 7, day: 15),
            Status = Communication.Enums.TaskStatusCode.InExecution
        };
        var exceptionType = typeof(ArgumentException);
        var useCase = new UpdateTaskUseCase();

        Assert.Throws(exceptionType, () =>
        {
            useCase.Execute(invalidId, validRequest);
        });
        Assert.Throws(exceptionType, () =>
        {
            useCase.Execute(validId, invalidRequest);
        });
        Assert.Throws(exceptionType, () =>
        {
            useCase.Execute(invalidId, invalidRequest);
        });
    }
}
