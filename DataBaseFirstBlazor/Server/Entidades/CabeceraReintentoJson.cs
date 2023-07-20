using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

public partial class CabeceraReintentoJson
{
    public int Id { get; set; }

    public DateTime Creacion { get; set; }

    public string Nota { get; set; } = null!;

    public bool Procesado { get; set; }

    public string JsonCorreccion { get; set; } = null!;

    public int IdCabecera { get; set; }

    public int IdConexion { get; set; }

    public string Uuid { get; set; } = null!;

    public virtual Conexion IdConexionNavigation { get; set; } = null!;
}
