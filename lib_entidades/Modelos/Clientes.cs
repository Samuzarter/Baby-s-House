using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace lib_entidades.Modelos
{
    public class Clientes
    {
        [Key] public int Id { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Telefono { get; set; }

        [NotMapped] public virtual ICollection<Facturas>? _Facturas { get; set; }
        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nombre) ||
                string.IsNullOrEmpty(Apellidos) ||
                string.IsNullOrEmpty(Cedula) ||
                string.IsNullOrEmpty(Telefono)
                )
                return false;
            return true;
        }
    }
}