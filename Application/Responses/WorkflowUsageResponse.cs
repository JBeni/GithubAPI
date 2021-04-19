namespace Application.Responses
{
    public class WorkflowUsageResponse
    {
        public Billable Billable { get; set; }
    }

    public class Billable
    {
        public UBUNTU Ubuntu { get; set; }
        public MACOS Macos { get; set; }
        public WINDOWS Windows { get; set; }
    }

    public class UsageModel {  public int Total_ms { get; set; } }
    public class UBUNTU : UsageModel { }
    public class MACOS : UsageModel { }
    public class WINDOWS : UsageModel { }
}
