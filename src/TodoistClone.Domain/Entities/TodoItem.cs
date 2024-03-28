namespace TodoistClone.Domain.Entities
{
    public class TodoItem
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Title { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public bool Done { get; private set; } = false;


        public TodoItem(string Title, string Description, bool Done)
        {
            this.Id = Guid.NewGuid();
            this.Title = Title;
            this.Description = Description;
            this.Done = Done;
        }

        public void Update(string NewTitle, string NewDescription, bool NewCompletionStatus) {
            this.Title = NewTitle;
            this.Description = NewDescription;
            this.Done = NewCompletionStatus;
        }
    }
}