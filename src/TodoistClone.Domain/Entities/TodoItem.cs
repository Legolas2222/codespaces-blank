using TodoistClone.Domain.Primitives;

namespace TodoistClone.Domain.Entities
{
    public class TodoItem(string Title, string Description, bool Done) : Entity
    {
        public string Title { get; private set; } = Title;
        public string Description { get; private set; } = Description;
        public bool Done { get; private set; } = Done;

        public void Update(string? NewTitle = null, string? NewDescription = null)
        {
            base.Update();
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