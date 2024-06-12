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
}
