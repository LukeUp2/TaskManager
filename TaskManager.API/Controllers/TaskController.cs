using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Tasks.Create;
using TaskManager.Application.UseCases.Tasks.Delete;
using TaskManager.Application.UseCases.Tasks.GetAll;
using TaskManager.Application.UseCases.Tasks.GetById;
using TaskManager.Application.UseCases.Tasks.Update;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers
{
    public class TaskController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ErrorResponseJson), StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody] CreateTaskRequestJson request, [FromServices] CreateTaskUseCase useCase)
        {
            var result = useCase.Execute(request);

            return Created("", result);
        }

        [HttpGet]
        [ProducesResponseType(typeof(GetAllTasksResponseJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll([FromServices] GetAllTasksUseCase useCase)
        {
            var result = useCase.Execute();
            if (result.Tasks.Count > 0)
            {
                return Ok(result);
            }
            return NoContent();
        }

        [HttpGet("{id: guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponseJson), StatusCodes.Status404NotFound)]
        public IActionResult GetById(Guid id, [FromServices] GetTaskByIdUseCase useCase)
        {
            var result = useCase.Execute(id);
            return Ok(result);
        }

        [HttpPut("{id: guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorResponseJson), StatusCodes.Status404NotFound)]
        public IActionResult Update(Guid id, [FromBody] UpdateTaskRequestJson request, [FromServices] UpdateTaskUseCase useCase)
        {
            useCase.Execute(id, request);
            return NoContent();
        }

        [HttpDelete("{id: guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorResponseJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete(Guid id, [FromServices] DeleteTaskUseCase useCase)
        {
            useCase.Execute(id);
            return NoContent();
        }
    }
}