using Microsoft.AspNetCore.Mvc;
using Repositorio.Crud.Interfaces;
using Repositorio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SecondHandProject.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/secondhand")]
    [ApiController]
    public class SecondHandController : ControllerBase
    {
        private ICrudAnuncio _repositorioAnuncio;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Anuncio>>> GetTodoItems()
        {
            return await _repositorioAnuncio.List();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Anuncio>> GetTodoItem(int id)
        {
            var item = await _repositorioAnuncio.GetObjById(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTodoItem(int id, Anuncio todoItemDTO)
        {
            if (id != todoItemDTO.Id)
            {
                return BadRequest();
            }

            var todoItem = await _repositorioAnuncio.GetObjById(id);
            _repositorioAnuncio.Update(todoItem);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Anuncio>> CreateTodoItem(Anuncio todoItemDTO)
        {
            _repositorioAnuncio.Insert(todoItemDTO);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(int id)
        {
            var todoItem = await _repositorioAnuncio.GetObjById(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            _repositorioAnuncio.Delete(todoItem);
            return NoContent();
        }
    }
}
