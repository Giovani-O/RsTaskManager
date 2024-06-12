using RsTaskManager.Communication.Enums;

namespace RsTaskManager.Communication.Responses;

public class ResponseShortTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Deadline { get; set; }
    public TaskStatusCode Status { get; set; }
}
