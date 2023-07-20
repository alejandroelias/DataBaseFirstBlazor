using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

/// <summary>
/// el correo que se le enviara individualmente a cada usuario por accion realizada
/// </summary>
public partial class CorreoXAccion
{
    public int Id { get; set; }

    public int IdCorreo { get; set; }

    public int IdAccion { get; set; }

    public bool Activado { get; set; }

    public virtual Accion IdAccionNavigation { get; set; } = null!;

    public virtual Correo IdCorreoNavigation { get; set; } = null!;
}
