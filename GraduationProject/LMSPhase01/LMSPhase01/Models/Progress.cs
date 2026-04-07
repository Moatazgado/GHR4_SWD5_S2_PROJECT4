using System;
using System.Collections.Generic;
using System.Text;

namespace LMSPhase01.Models
{
    public class Progress
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int LessonId { get; set; }

        public bool IsCompleted { get; set; }
        public DateTime? CompletedAt { get; set; }

        // Navigation
        public ApplicationUser User { get; set; }
        public Lesson Lesson { get; set; }
    }
}
