using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Facturas
    {
        [Key] public int Id { get; set; }
        public int Cliente { get; set; }
        public DateTime Fecha_compra { get; set; }
        public decimal Valor { get; set; }

        [ForeignKey("Cliente")] public Clientes? _Cliente{ get; set; }

        [NotMapped] public virtual ICollection<Detalles>? _Detalles { get; set; }
//        [NotMapped] public virtual ICollection<Facturas>? _Facturas { get; set; }
    }
}