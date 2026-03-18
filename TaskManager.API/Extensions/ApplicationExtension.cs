using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Application.UseCases.Tasks.Create;

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
        }
    }
}