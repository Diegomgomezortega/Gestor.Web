namespace Gestor.Web.DTOs.Response.Product
{
    public class GetProductResponse
    {
        public int id { get; set; }
        public string nombre { get; set; } = null!;
        public string? descripcion { get; set; } = "";
        public string categoria { get; set; } = null!;
        public int idCategoria { get; set; }
        public decimal precio { get; set; }
        public string paisFabricacion { get; set; } = null!;
    }
}
