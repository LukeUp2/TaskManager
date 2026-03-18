using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Communication.Errors;

namespace TaskManager.Application.UseCases.Tasks.Delete
{
    public class DeleteTaskUseCase
    {
        public void Execute(Guid id)
        {
            //Delete task
            var randomizerNumber = Math.Floor(new Random().NextDouble());
            if (randomizerNumber < 0.5)
            {
                throw new NotFoundException("Tarefa não encontrada.");
            }
        }
    }
}