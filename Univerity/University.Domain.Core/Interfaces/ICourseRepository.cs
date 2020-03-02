using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Core.Models;

namespace University.Domain.Core.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        void Add(Course course);
    }
}
