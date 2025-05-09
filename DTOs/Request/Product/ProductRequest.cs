using System.ComponentModel.DataAnnotations;

namespace Gestor.Web.DTOs.Request.Product
{
    public class ProductRequest
    {
        [Required(ErrorMessage = "La categoría es obligatoria.")]
        public int IdCategoria { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres.")]
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(1.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 1.")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "El país de fabricación es obligatorio.")]
        public string PaisFabricacion { get; set; } = null!;
    }
}
