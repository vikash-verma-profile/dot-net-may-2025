namespace MiddleWareSamples.Models
{

    public class ApiResponse
    {
        public bool Success { get; set; } = true;
        public object Data { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}