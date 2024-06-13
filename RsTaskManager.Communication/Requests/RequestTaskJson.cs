using RsTaskManager.Communication.Enums;

namespace RsTaskManager.Communication.Requests;

public class RequestTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
    public DateTime Deadline { get; set; }
    public TaskStatusCode Status { get; set; }

    public bool IsValid()
    {
        var validationErrors = new List<string>();

        ValidateProperty(Id > 0, "Id inválido", validationErrors);
        ValidateProperty(Name != string.Empty, "Nome inválido", validationErrors);
        ValidateProperty(Description != string.Empty, "Descrição inválida", validationErrors);
        ValidateProperty(Enum.IsDefined(typeof(TaskPriority), Priority), "Prioridade inválida", validationErrors);
        ValidateProperty(Enum.IsDefined(typeof(TaskStatusCode), Status), "Status inválido", validationErrors);
        ValidateProperty(Deadline > DateTime.Now, "A data deve ser no futuro", validationErrors);

        if (validationErrors.Count > 0)
            return false;
        else return true;
    }

    private void ValidateProperty(bool condition, string errorMessage, List<string> errorsList)
    {
        if (!condition)
            errorsList.Add(errorMessage);
    }
}
