using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Communication.Enuns;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetAll
{
    public class GetAllTasksUseCase
    {
        public GetAllTasksResponseJson Execute()
        {
            return new GetAllTasksResponseJson
            {
                Tasks = new List<TaskShortResponseJson>
                {
                    new() {
                        Name = "Refatorar Camada de Service",
                        Description = "Aplicar padrões de clean code e reduzir acoplamento.",
                        Status = StatusEnum.COMPLETED
                    },
                    new() {
                        Name = "Integrar Gateway de Pagamento",
                        Description = "Configurar webhooks e processamento de cartões.",
                        Status = StatusEnum.IN_PROGRESS
                    },
                    new() {
                        Name = "Otimizar Queries SQL",
                        Description = "Analisar execução de queries lentas no dashboard.",
                        Status = StatusEnum.PENDING
                    }
                }
            };
        }
    }
}