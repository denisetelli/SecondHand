using Entidades.Enums;
using System;
using System.Collections.Generic;

namespace Entidades.ViewModels
{
    public class AnuncioDto
    {
        public int Id { get; set; }
        public  UsuarioDto Anunciante { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public  List<ImagemDto> Imagens { get; set; }
        public decimal Valor { get; set; }
        public string Localidade { get; set; }
        public  CategoriaDto Categoria { get; set; }
        public  AvaliacaoDto Avaliação { get; set; }
        public EnumStatus Situacao { get; set; }
        public  UsuarioDto Comprador { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataVenda { get; set; }
        public DateTime DataCancelamento { get; set; }
        public DateTime DataBloqueio { get; set; }

    }

}


