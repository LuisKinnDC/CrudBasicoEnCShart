using System;
using System.Collections.Generic;

namespace GestorUsuariosCRUD.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string? Telefono { get; set; }

    public string Contrasena { get; set; } = null!;

    public string? Estado { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Role> IdRols { get; set; } = new List<Role>();
}
