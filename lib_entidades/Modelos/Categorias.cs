using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace lib_entidades.Modelos
{
    public class Categorias
    {
        [Key] public int Id { get; set; }
        public string? Nombre { get; set; }

        [NotMapped] public virtual ICollection<Productos>? _Productos { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nombre))
                return false;
            return true;
        }
    }
}