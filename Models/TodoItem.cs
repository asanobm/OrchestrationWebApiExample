namespace OrchestrationWebApiExample.Models
{

    /// <summary>
    /// Todo Item model.
    /// </summary>
    public class TodoItem
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Secret { get; set; }
        public bool IsComplete { get; set; }
    }
}