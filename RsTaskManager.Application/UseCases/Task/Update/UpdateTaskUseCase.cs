using RsTaskManager.Communication.Requests;

namespace RsTaskManager.Application.UseCases.Task.Update;

public class UpdateTaskUseCase
{
    public void Execute(int id, RequestTaskJson request)
    {
        if (id < 0) 
            throw new ArgumentOutOfRangeException(nameof(id));

        if (request.IsValid())
        {
            // Do something...
        }
        else 
            throw new ArgumentException(nameof(request));
    }
}
