using System;
using System.Collections.Generic;
using System.Text;

namespace University.Domain.Core.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int NumberOfStudents { get; set; }

    }
}
