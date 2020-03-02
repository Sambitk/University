using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using University.Application.Interfaces;
using University.Application.Services;
using University.Bus;
using University.Data.Repository;
using University.Data.UniversityData;
using University.Domain.Core.CommandHandlers;
using University.Domain.Core.Commands;
using University.Domain.Core.Interfaces;
using University.Domain.Cqrs.Bus;

namespace University.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IMediatorHandler, InMemoryBus>();

            serviceCollection.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CreateCourseCommandHandler>();

            serviceCollection.AddScoped<ICourseService, CourseService>();

            serviceCollection.AddScoped<ICourseRepository, CourseRepository>();

            serviceCollection.AddScoped<UniversityDbContext>();
        }
    }
}
