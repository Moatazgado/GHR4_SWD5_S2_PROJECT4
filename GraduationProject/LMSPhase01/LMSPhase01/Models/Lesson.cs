using System;
using System.Collections.Generic;
using System.Text;

namespace LMSPhase01.Models
{
    public class Lesson
    {
        public int Id { get; set; }

        public int ModuleId { get; set; }
        public string Title { get; set; }
        public string VideoUrl { get; set; }
        public int OrderIndex { get; set; }

        // Navigation
        public Module Module { get; set; }
        public List<Progress> Progresses { get; set; } = new List<Progress>();
    }
}
