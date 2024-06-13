namespace RsTaskManager.Application.UseCases.Task.Delete;

public class DeleteTaskUseCase
{
    public void Execute(int id)
    {
        if (id <= 0)
            throw new ArgumentNullException(nameof(id));
    }
}
