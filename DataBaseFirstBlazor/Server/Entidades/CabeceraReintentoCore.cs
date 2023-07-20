using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

public partial class CabeceraReintentoCore
{
    public int Id { get; set; }

    public DateTime Creacion { get; set; }

    public string Nota { get; set; } = null!;

    public bool Procesado { get; set; }

    public string JsonCabecera { get; set; } = null!;

    public string JsonDetalle { get; set; } = null!;

    public int IdCabecera { get; set; }

    public int IdConexion { get; set; }

    public virtual Conexion IdConexionNavigation { get; set; } = null!;
}
