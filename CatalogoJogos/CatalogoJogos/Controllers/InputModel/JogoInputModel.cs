﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace CatalogoJogos.Controllers.InputModel
{
    public class JogoInputModel
    {

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome do jogo" +
            " deve ter entre 3 e 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "o nome da produtora deve ter" +
            " entre 3 e 100 caracteres")]
        public string Produtora { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage ="O preço deve estar entre 1 e 1000 reais")]
        public double Preco { get; set; }
    }
}
