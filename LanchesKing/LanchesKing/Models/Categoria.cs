﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesKing.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        
        [Required(ErrorMessage ="Informe o nome da categoria")]
        [StringLength(100,ErrorMessage ="O tamanho maximo e 100 carcteres")]
        [Display(Name ="Nome")]
        public string CategoriaNome { get; set; }

        [Required(ErrorMessage = "Informe o descricao da categoria")]
        [StringLength(200, ErrorMessage = "O tamanho maximo e 200 carcteres")]
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
