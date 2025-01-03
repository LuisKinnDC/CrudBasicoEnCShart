using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestorUsuariosCRUD.Models;

public partial class Role
{
    public int IdRol { get; set; }

    [Required(ErrorMessage = "El nombre del rol es obligatorio.")]
    [StringLength(50, ErrorMessage = "El nombre del rol no puede exceder los 50 caracteres.")]
    public string NombreRol { get; set; } = null!;

    public virtual ICollection<Usuario> IdUsuarios { get; set; } = new List<Usuario>();
}
