using RsTaskManager.Communication.Requests;
using RsTaskManager.Communication.Responses;

namespace RsTaskManager.Application.UseCases.Task.Create;

public class CreateTaskUseCase
{
    public ResponseRegisteredTaskJson Execute(RequestTaskJson request)
    {
        // TODO
        return new ResponseRegisteredTaskJson {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            Deadline = request.Deadline,
            Status = request.Status
        };
    }
}
