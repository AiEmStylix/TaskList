using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.Model
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsCompleted { get; set; }
        public TimeSpan Timer { get; set; }

        public TaskStatus TaskStatus { get; set; }
        public TaskCategory TaskCategory { get; set; }
        public TaskImportance TaskImportance { get; set; }

    }

    public enum TaskStatus
    {
        /// <summary>
        /// The task is still is progress
        /// </summary>
        InProgress,
        /// <summary>
        /// The task has been completed
        /// </summary>
        Complete,
        /// <summary>
        /// The task is not even started
        /// </summary>
        NotStarted,
        /// <summary>
        /// The task is late
        /// </summary>
        Late,
        /// <summary>
        /// The task has been archived
        /// </summary>
        Archived,
        /// <summary>
        /// The task has been deleted
        /// </summary>
        Deleted
    }

    public enum TaskCategory
    {
        Education,
        Work,
        Finance,
        Shopping
    }

    public enum TaskImportance
    {
        Low,
        Medium, 
        High,
        Critical
    }
}
