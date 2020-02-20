using System;
using System.Collections.Generic;
using System.Text;
using University.Data.UniversityData;
using University.Domain.Core.Interfaces;
using University.Domain.Core.Models;

namespace University.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDbContext _universityDbContext;
        public CourseRepository(UniversityDbContext context)
        {
            _universityDbContext = context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _universityDbContext.Courses;
        }
    }
}
