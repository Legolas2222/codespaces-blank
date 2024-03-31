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

        public void Update(string? NewTitle = null, string? NewDescription = null)
        {

            if (NewTitle is not null)
            {
                this.Title = NewTitle;
            }
            if (NewDescription is not null)
            {
                this.Description = NewDescription;
            }
        }

        public void SetCompletionStatus(bool newStatus)
        {
            this.Done = newStatus;
        }
        public void CompleteTask()
        {
            this.Done = true;
        }
    }
}