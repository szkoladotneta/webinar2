using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Webinar2Todo.Application.Interfaces;
using Webinar2Todo.Application.Services;

namespace Webinar2Todo.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ITodoService, TodoService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }

}
