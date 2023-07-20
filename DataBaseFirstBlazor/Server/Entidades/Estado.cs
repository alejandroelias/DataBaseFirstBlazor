using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

/// <summary>
/// Respuestas de la API, proporcionando detalles sobre el estado de la conexión, los errores HTTP, los errores internos de la API, entre otros. Cada registro en la tabla estado contiene un código de respuesta que identifica el tipo de respuesta, una descripción amigable para el usuario y detalles técnicos adicionales, como el código de estado HTTP, el mensaje de error y cualquier otra información relevante.
/// 
/// La tabla &quot;estado&quot; es esencial para garantizar la calidad y fiabilidad de las respuestas de la API, ya que proporciona una forma de registrar y analizar los resultados de las solicitudes enviadas a la API. Además, esta tabla también puede utilizarse para auditar y controlar el rendimiento de la API y para garantizar el cumplimiento de las políticas de seguridad y privacidad establecidas por la organización.
/// </summary>
public partial class Estado
{
    /// <summary>
    /// identity
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// codigo de respuesta, generalmente represetado por un numero
    /// </summary>
    public int Estatus { get; set; }

    /// <summary>
    /// descripcion, significado, explicacion de este error que este apareciendo
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// tipo de estado, descripcion mas general de lo que esta pasando inidcando si es respuesta de haciendao simplemente estatus http
    /// </summary>
    public int IdTipoEstado { get; set; }

    public int IdColor { get; set; }

    public virtual ICollection<Cabecera> Cabeceras { get; set; } = new List<Cabecera>();

    public virtual Color IdColorNavigation { get; set; } = null!;

    public virtual TipoEstado IdTipoEstadoNavigation { get; set; } = null!;
}
