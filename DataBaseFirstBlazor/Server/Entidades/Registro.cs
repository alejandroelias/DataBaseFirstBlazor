using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

/// <summary>
/// Distintos eventos que pueden surgir en la aplicación, como el inicio o la detención de ciertos procesos. Cada registro en la tabla &quot;Evento&quot; contiene información detallada sobre el evento, incluyendo su tipo, el momento en que ocurrió, la duración del evento, el estado de la aplicación antes y después del evento, entre otros detalles relevantes.
/// 
/// La tabla &quot;Evento&quot; es esencial para el monitoreo y análisis del comportamiento de la aplicación, ya que proporciona una forma de registrar y analizar los eventos clave que ocurren en el sistema. Además, esta tabla también puede utilizarse para auditar y controlar el rendimiento de la aplicación y para garantizar el cumplimiento de las políticas de seguridad y privacidad establecidas por la organización.
/// </summary>
public partial class Registro
{
    /// <summary>
    /// Identity
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nombre para el tipo de registro
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Una descripcion sobre a lo que se referira
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// Una descripcion mucho mas detallada y explicativa
    /// </summary>
    public string? Nota { get; set; }

    public int IdColor { get; set; }

    public virtual ICollection<DetalleRegistro> DetalleRegistros { get; set; } = new List<DetalleRegistro>();

    public virtual Color IdColorNavigation { get; set; } = null!;
}
