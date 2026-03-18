using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Communication.Errors;
using TaskManager.Communication.Requests;

namespace TaskManager.Application.UseCases.Tasks.Update
{
    public class UpdateTaskUseCase
    {
        public void Execute(Guid id, UpdateTaskRequestJson request)
        {
            var randomizerNumber = Math.Floor(new Random().NextDouble());
            if (randomizerNumber < 0.5)
            {
                throw new NotFoundException("Tarefa não encontrada.");
            }
        }
    }
}