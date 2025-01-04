using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Ventas
    {
        [Key] public int Id { get; set; }
        public DateTime Fecha_venta { get; set; }
        public int Factura { get; set; }
        public decimal Valor { get; set; }

        [ForeignKey("Factura")] public Facturas? _Factura { get; set; }

    }
}