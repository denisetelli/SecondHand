using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repositorio.Crud.Interfaces;
using Repositorio.Models;

namespace SecondHandProject
{
    [ApiController]
    [Route("avaliacoes")]
    public class AvaliacaoController : ControllerBase
    {
        private ICrudAvaliacao _repositorioAvaliacao;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Avaliacao>>> Get()
        {
            //return await _repositorioAvaliacao.List();
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Avaliacao
            {
                Id = rng.Next(100),
                Avaliador = {
                    Id = 1,
                    Perguntas = {new Pergunta{IdAnuncio =3, DataInclusao= DateTime.Now.AddDays(index), } } ,
                    Nota = 10
                    },
                Nota = 10,
                Comentario = "entrega rápida"
            }).ToArray();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Avaliacao>> GetById(int id)
        {
            var item = await _repositorioAvaliacao.GetObjById(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Avaliacao avaliacao)
        {
            if (id != avaliacao.Id)
            {
                return BadRequest();
            }

            var avaliacaoo = await _repositorioAvaliacao.GetObjById(id);
            _repositorioAvaliacao.Update(avaliacaoo);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Avaliacao>> Create(Avaliacao avaliacao)
        {
            _repositorioAvaliacao.Insert(avaliacao);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var avaliacao = await _repositorioAvaliacao.GetObjById(id);

            if (avaliacao == null)
            {
                return NotFound();
            }

            _repositorioAvaliacao.Delete(avaliacao);
            return NoContent();
        }
    }
}



