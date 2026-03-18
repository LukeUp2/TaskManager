using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Application.UseCases.Tasks.Create;
using TaskManager.Application.UseCases.Tasks.Delete;
using TaskManager.Application.UseCases.Tasks.GetAll;
using TaskManager.Application.UseCases.Tasks.GetById;
using TaskManager.Application.UseCases.Tasks.Update;

namespace TaskManager.API.Extensions
{
    public static class ApplicationExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            AddUseCases(services);
        }

        private static void AddUseCases(IServiceCollection services)
        {
            services.AddScoped<CreateTaskUseCase>();
            services.AddScoped<GetAllTasksUseCase>();
            services.AddScoped<GetTaskByIdUseCase>();
            services.AddScoped<UpdateTaskUseCase>();
            services.AddScoped<DeleteTaskUseCase>();
        }
    }
}