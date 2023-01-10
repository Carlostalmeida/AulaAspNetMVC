using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesKing.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2} carcteres")]
        [Display(Name = "Nome do Lanche")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descricao do lanche deve ser informada")]
        [MinLength(20, ErrorMessage = "Descricao deve ter no minimo {1} Caracteres")]
        [MaxLength(200, ErrorMessage = "Descricao pode exceder {1} Caracteres")]
        [Display(Name = "Descricao do Lanche")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descricao detalhada do lanche deve ser informada")]
        [MinLength(20, ErrorMessage = "Descricao detalhada deve ter no minimo {1} Caracteres")]
        [MaxLength(200, ErrorMessage = "Descricao detalhada pode exceder {1} Caracteres")]
        [Display(Name = "Descricao Detalhada do Lanche")]
        public string NDescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preco do lanche")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "O preco deve estar entre 1 e 999,99")]
        [Display(Name = "Preco")]
        public decimal Preco { get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} carcteres")]
        [Display(Name = "Caminho Imagem Normal")]
        public string ImagemUrl { get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} carcteres")]
        [Display(Name = "Caminho Imagem Miniatura")]
        public string ImagemThumbnailUrl { get; set; }

        
        [Display(Name = "Preferido?")]
        public bool IslanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }


        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }


    }
}
