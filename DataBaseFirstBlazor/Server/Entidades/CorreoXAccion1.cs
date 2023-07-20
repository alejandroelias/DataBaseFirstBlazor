using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

public partial class CorreoXAccion1
{
    public string Correo { get; set; } = null!;

    public int Accion { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Nombre { get; set; }
}
