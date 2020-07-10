using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Webinar2Todo.Domain.Interfaces;
using Webinar2Todo.Infrastructure.Repositories;

namespace Webinar2Todo.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ITodoItemRepository, TodoItemRepository>();
            services.AddTransient<ITodoListRepository, TodoListRepository>();
            return services;
        }
    }
}
