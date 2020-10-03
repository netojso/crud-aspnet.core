using System.ComponentModel.DataAnnotations;

namespace aspnet_react.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter até 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter mais que 3 caracteres")]
        public string Title { get; set; }
    }
}