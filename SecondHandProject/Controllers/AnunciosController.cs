using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repositorio.Crud.Interfaces;
using Repositorio.Models;

namespace SecondHandProject
{
    [ApiController]
    [Route("anuncios")]
    public class AnunciosController : ControllerBase
    {
        private ICrudAnuncio _repositorioAnuncio;

        //private readonly ILogger<AnunciosController> _logger;

        //public AnunciosController(ILogger<AnunciosController> logger)
        //{
        //    _logger = logger;
        //}

        // GET: api/Anuncios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Anuncio>>> Get()
        {
            // return await _repositorioAnuncio.List();
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Anuncio
            {
                Id = rng.Next(100),
                Titulo = "TV",
                Anunciante = new Usuario { Id = 0, Login = "denise" },
                Categoria = new Categoria
                {
                    Id = 0,
                    Nome = "Eletronicos",
                    IdadeMinima = 18,
                },
                Descricao = "TV 42 polegadas LED Full HD",
                Valor = 2000,
                DataInclusao = DateTime.Now.AddDays(index),
            })
            .ToArray();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Anuncio>> GetById(int id)
        {
            var item = await _repositorioAnuncio.GetObjById(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Anuncio anuncio)
        {
            if (id != anuncio.Id)
            {
                return BadRequest();
            }

            var anuncioo = await _repositorioAnuncio.GetObjById(id);
            _repositorioAnuncio.Update(anuncioo);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Anuncio>> Create(Anuncio anuncio)
        {
            _repositorioAnuncio.Insert(anuncio);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var anuncio = await _repositorioAnuncio.GetObjById(id);

            if (anuncio == null)
            {
                return NotFound();
            }

            _repositorioAnuncio.Delete(anuncio);
            return NoContent();
        }
    }
}



