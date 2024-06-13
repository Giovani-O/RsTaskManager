using RsTaskManager.Communication.Responses;

namespace RsTaskManager.Application.UseCases.Task.GetById;

public class GetByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        if (id <= 0)
            throw new ArgumentNullException(nameof(id));

        return new ResponseTaskJson
        {
            Id = id,
            Name = "Tarefa 1",
            Description = "Lorem Ipsum Dolor Sit Amet",
            Priority = Communication.Enums.TaskPriority.Medium,
            Deadline = new DateTime(year: 2024, month: 6, day: 14),
            Status = Communication.Enums.TaskStatusCode.StandBy
        };
    }
}
