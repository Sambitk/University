using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Core.Models;

namespace University.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
