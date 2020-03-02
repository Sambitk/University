using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using University.Domain.Core.Commands;
using University.Domain.Core.Interfaces;
using University.Domain.Core.Models;

namespace University.Domain.Core.CommandHandlers
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository _courseRepository;
        public CreateCourseCommandHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course()
            {
                CourseName = request.CourseName,
                CourseDescription = request.CourseDescription,
                NumberOfStudents = request.NumberOfStudents
            };
            _courseRepository.Add(course);
            return Task.FromResult(true);
        }
    }
}
