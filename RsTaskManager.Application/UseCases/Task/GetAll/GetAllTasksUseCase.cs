using RsTaskManager.Communication.Responses;

namespace RsTaskManager.Application.UseCases.Task.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "Test",
                    Deadline = DateTime.Now,
                    Status = Communication.Enums.TaskStatusCode.InExecution
                }
            }
        };
    }
}
