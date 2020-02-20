using System;
using System.Collections.Generic;
using System.Text;
using University.Application.ViewModels;

namespace University.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
