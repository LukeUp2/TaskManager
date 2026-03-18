using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Communication.Errors;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetById
{
    public class GetTaskByIdUseCase
    {
        public TaskResponseJson Execute(Guid id)
        {
            var randomizerNumber = Math.Floor(new Random().NextDouble());
            if (randomizerNumber < 0.5)
            {
                throw new NotFoundException("Tarefa não encontrada.");
            }
            var response = new TaskResponseJson
            {
                Id = id,
                Name = "Tarefa de exemplo",
                Description = "Descrição da tarefa de exemplo",
                Status = Communication.Enuns.StatusEnum.COMPLETED
            };
            return response;
        }
    }
}