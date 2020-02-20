using System;
using System.Collections.Generic;
using System.Text;
using University.Application.Interfaces;
using University.Application.ViewModels;
using University.Data.Repository;

namespace University.Application.Services
{
    public class CourseService : ICourseService
    {
        private CourseRepository _courseRepository;
        public CourseService(CourseRepository courseRepository)
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
