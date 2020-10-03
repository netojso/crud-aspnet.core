using System.ComponentModel.DataAnnotations;

namespace aspnet_react.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter até 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter mais que 3 caracteres")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "Este campo pode conter no máximo 1024 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria inválida")]
        public int CategoryId { get; set;}
        public Category Category { get; set; }
    }
}