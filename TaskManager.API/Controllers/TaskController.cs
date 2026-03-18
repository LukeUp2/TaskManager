using Microsoft.AspNetCore.Mvc;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers
{
    public class TaskController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorResponseJson), StatusCodes.Status400BadRequest)]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id: guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponseJson), StatusCodes.Status404NotFound)]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }

        [HttpPut("{id: guid}")]
        [ProducesResponseType(typeof(ErrorResponseJson), StatusCodes.Status404NotFound)]
        public IActionResult Update(Guid id)
        {
            return Ok();
        }

        [HttpDelete("{id: guid}")]
        [ProducesResponseType(typeof(ErrorResponseJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete(Guid id)
        {
            return Ok();
        }
    }
}