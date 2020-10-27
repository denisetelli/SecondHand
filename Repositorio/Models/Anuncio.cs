using Entidades.Enums;
using System;
using System.Collections.Generic;

namespace Repositorio.Models
{
    public class Anuncio
    {
        public int Id { get; set; }
        public virtual Usuario Anunciante { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public virtual List<Imagem> Imagens { get; set; }
        public decimal Valor { get; set; }
        public string Localidade { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Avaliacao Avaliação { get; set; }
        public EnumStatus Situacao { get; set; }
        public int IdComprador { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataCancelamento { get; set; }
        public DateTime DataBloqueio { get; set; }
        public virtual List<Pergunta> Perguntas { get; set; }
    }
}


