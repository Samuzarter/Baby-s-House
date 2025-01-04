using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace lib_entidades.Modelos
{
    public class Productos
    {
        [Key] public int Id { get; set; }
        public string? Codigo_barra { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int Stock { get; set; }
        public decimal Precio_compra { get; set; }
        public decimal Precio_venta { get; set; }
        public decimal Iva { get; set; }
        public int Categoria { get; set; }
        public int Proveedor { get; set; }

        [ForeignKey("Categoria")] public Categorias? _Categoria { get; set; }
        [ForeignKey("Proveedor")] public Proveedores? _Proveedor { get; set; }

        public decimal CalcularPrecioVenta()
        {
            if (Precio_venta > 0 && Stock > 0)
            {
                Precio_venta = Precio_venta * (1 + Iva);
                return Precio_venta;
            }
            else
            {
                throw new Exception("Precio ingresado o cantidad de Stock incorrectos");
            }
        }
        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nombre) ||
                string.IsNullOrEmpty(Descripcion) ||
                Stock <= 0 ||
                Precio_venta <= (decimal)0.009 ||
                Iva <= (decimal)0.009)
                return false;
            return true;
        }
    }
}