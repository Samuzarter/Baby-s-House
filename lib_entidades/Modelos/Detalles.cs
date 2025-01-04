using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Detalles
    {
        [Key] public int Id { get; set; }
        public int Factura { get; set; }
        public int Producto { get; set; }
        public int Cantidad { get; set; }

        [ForeignKey("Factura")] public Facturas? _Factura { get; set; }
        [ForeignKey("Producto")] public Productos? _Producto { get; set; }

    }
}