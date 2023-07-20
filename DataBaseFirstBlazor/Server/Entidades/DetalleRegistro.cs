using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

/// <summary>
/// Está relacionada con la tabla anterior &quot;Registro&quot; y se utiliza para registrar la fecha de creación de cada registro en la tabla &quot;Registro&quot; y el evento que se utilizó en ese momento. Cada registro en la tabla &quot;Linea_Registro&quot; contiene una clave foránea que hace referencia al registro correspondiente en la tabla &quot;Registro&quot;, así como la fecha y hora en que se creó ese registro.
/// 
/// La tabla &quot;Linea_Registro&quot; es esencial para el seguimiento y análisis del comportamiento de la aplicación, ya que proporciona una forma de rastrear la creación de cada registro en la tabla &quot;Registro&quot; y el evento asociado que se utilizó en ese momento. Además, esta tabla también puede utilizarse para auditar y controlar el rendimiento de la aplicación y para garantizar el cumplimiento de las políticas de seguridad y privacidad establecidas por la organización.
/// </summary>
public partial class DetalleRegistro
{
    /// <summary>
    /// identity
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// fecha y hora de creacion
    /// </summary>
    public DateTime Creacion { get; set; }

    /// <summary>
    /// referencia con el tipo de registro que se ha creado
    /// </summary>
    public int IdRegistro { get; set; }

    /// <summary>
    /// referencia con el posible error que este registro pueda tener
    /// </summary>
    public int? IdErrorAplicacion { get; set; }

    public string? Descripcion { get; set; }

    public virtual Cabecera? Cabecera { get; set; }

    public virtual ErrorAplicacion? IdErrorAplicacionNavigation { get; set; }

    public virtual Registro IdRegistroNavigation { get; set; } = null!;
}
