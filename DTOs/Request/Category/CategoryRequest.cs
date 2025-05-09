using System.ComponentModel.DataAnnotations;

namespace Gestor.Web.DTOs.Request.Category
{
    public class AddCategoryRequest
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres.")]
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; } = null!;
    }
}
