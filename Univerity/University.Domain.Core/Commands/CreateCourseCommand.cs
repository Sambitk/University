using System;
using System.Collections.Generic;
using System.Text;

namespace University.Domain.Core.Commands
{
    public class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand(string courseName, string courseDescription, int numberOfStudents)
        {
            CourseName = courseName;
            CourseDescription = courseDescription;
            NumberOfStudents = numberOfStudents;
        }
    }
}
