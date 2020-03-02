using University.Domain.Cqrs.Commands;

namespace University.Domain.Core.Commands
{
    public abstract class CourseCommand : Command
    {
        public string CourseName { get; protected set; }
        public string CourseDescription { get; protected set; }
        public int NumberOfStudents { get; protected set; }
    }
}
