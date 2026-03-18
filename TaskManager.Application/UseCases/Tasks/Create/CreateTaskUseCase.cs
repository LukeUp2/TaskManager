using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Communication.Errors;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.Create
{
    public class CreateTaskUseCase
    {
        public TaskShortResponseJson Execute(CreateTaskRequestJson request)
        {
            if (request.Name.Length > 100)
                throw new ErrorOnValidationException("O nome da tarefa deve conter no máximo 100 caracteres.");
            if (request.Name.Length < 3)
                throw new ErrorOnValidationException("O nome da tarefa deve conter no mínimo 3 caracteres.");
            if (request.DueDate.ToUniversalTime() < DateTime.UtcNow)
                throw new ErrorOnValidationException("A data de vencimento da tarefa deve ser no futuro.");

            return new TaskShortResponseJson
            {
                Name = request.Name,
                Description = request.Description ?? string.Empty,
                Status = request.Status

            };
        }
    }
}