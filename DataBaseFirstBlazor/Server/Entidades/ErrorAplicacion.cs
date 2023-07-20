using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

/// <summary>
/// Almacenar información detallada sobre los errores que se producen en la aplicación. Cuando ocurre un error, se crea un nuevo registro en la tabla &quot;Error_Aplicacion&quot; que contiene información sobre la fecha y hora del error, la descripción del error y cualquier otra información relevante que pueda ayudar a identificar la causa del problema.
/// 
/// La tabla &quot;Error_Aplicacion&quot; es esencial para el monitoreo y resolución de problemas en la aplicación, ya que proporciona una forma de registrar y analizar los errores que se producen en el sistema. Además, esta tabla también puede utilizarse para auditar y controlar el rendimiento de la aplicación y para garantizar el cumplimiento de las políticas de seguridad y privacidad establecidas por la organización.
/// </summary>
public partial class ErrorAplicacion
{
    /// <summary>
    /// identity
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// hora y fecha de creacion
    /// </summary>
    public DateTime Creacion { get; set; }

    /// <summary>
    /// descripcion de la excepcion desde el backend
    /// </summary>
    public string Valor { get; set; } = null!;

    /// <summary>
    /// codigo de error de acuerdo a c#
    /// </summary>
    public string Codigo { get; set; } = null!;

    public string? Voz { get; set; }

    public virtual ICollection<DetalleRegistro> DetalleRegistros { get; set; } = new List<DetalleRegistro>();
}
