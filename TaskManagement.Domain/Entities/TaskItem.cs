using TaskManagement.Domain.Enums;

namespace TaskManagement.Domain.Entities
{
    public class TaskItem : BaseEntity
    {
        public string Title { get; private set; } = "";
        public string? Description { get; private set; } = "";
        public Guid UserId { get; private set; }
        public TaskItemStatus Status { get; private set; } = TaskItemStatus.Pending;
        public DateTime? DueDate { get; private set; }
        private TaskItem() { }
        protected TaskItem(Guid id, string title, string? description, Guid userId, TaskItemStatus status, DateTime? dueDate, DateTime createdAt, DateTime? updatedAt)
        {
            Id = id;
            Title = title;
            Description = description;
            UserId = userId;
            Status = status;
            DueDate = dueDate;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public static TaskItem Create(string title, string? description, Guid userId, DateTime? dueDate)
        {
            return new TaskItem(
                   Guid.NewGuid(), title, description, userId, TaskItemStatus.Pending, dueDate, DateTime.UtcNow, null);
        }

        public void Update(string title, string? description, TaskItemStatus status, DateTime? dueDate)
        {
            Title = title;
            Description = description;
            Status = status;
            DueDate = dueDate;
            SetUpdatedAt();
        }
    }
}