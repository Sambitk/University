using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using University.Application.Interfaces;
using University.Application.Services;
using University.Data.Repository;
using University.Domain.Core.Interfaces;

namespace University.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICourseService, CourseService>();

            serviceCollection.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
