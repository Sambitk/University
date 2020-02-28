using System;
using System.Collections.Generic;
using System.Text;
using University.Application.Interfaces;
using University.Application.ViewModels;
using University.Data.Repository;
using University.Domain.Core.Interfaces;

namespace University.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
