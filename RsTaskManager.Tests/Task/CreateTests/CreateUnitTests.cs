using RsTaskManager.Application.UseCases.Task.Create;
using RsTaskManager.Communication.Requests;
using RsTaskManager.Communication.Responses;

namespace RsTaskManager.Tests.Task.CreateTests;

public class CreateUnitTests
{
    [Fact]
    public void ShouldReturnResponseTaskJson()
    {
        // Mocking/Arrange
        var request = new RequestTaskJson()
        {
            Id = 1,
            Name = "Teste unitário",
            Description = "Deve retornar 201",
            Priority = Communication.Enums.TaskPriority.High,
            Deadline = new DateTime(year: 2024, month: 7, day: 15),
            Status = Communication.Enums.TaskStatusCode.InExecution
        };

        // Act
        var useCase = new CreateTaskUseCase();
        var result = useCase.Execute(request);

        // Assert
        Assert.NotNull(result);
        Assert.IsType<ResponseTaskJson>(result);
    }

    [Fact] 
    public void ShouldThrowArgumentNullException()
    {
        var request = new RequestTaskJson()
        {
            Id = 1,
            Name = "",
            Description = "Deve retornar 201",
            Priority = Communication.Enums.TaskPriority.High,
            Deadline = new DateTime(year: 2024, month: 7, day: 15),
            Status = Communication.Enums.TaskStatusCode.InExecution
        };
        var exceptionType = typeof(ArgumentNullException);
        var useCase = new CreateTaskUseCase();

        Assert.Throws(exceptionType, () => {
            useCase.Execute(request);
        });
    }
}
