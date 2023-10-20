using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class Formatos : BaseEntity
{
    [Required]
    public string NombreFormatos { get; set; }
    public ICollection<ModuloNotificaciones> ModuloNoficaciones { get; set; }

}
