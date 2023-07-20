using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

/// <summary>
/// La ubicación lógica de los datos que se han extraído y transformado mediante el proceso ETL. Cada registro en la tabla &quot;Tabla&quot; describe una tabla específica en una base de datos y proporciona información sobre la ubicación física de los datos que se han extraído y transformado.
/// 
/// Cada registro en la tabla &quot;Tabla&quot; contiene información sobre la base de datos y la tabla de origen, así como información sobre la ubicación física de los datos transformados en el sistema de destino. Esta información se utiliza para realizar un seguimiento de los datos a lo largo del proceso ETL y para garantizar que se estén utilizando los datos correctos en el sistema de destino.
/// 
/// La tabla &quot;Tabla&quot; es esencial para el monitoreo y control de calidad del proceso ETL, ya que proporciona una forma de rastrear la ubicación y el origen de los datos transformados en el sistema de destino. Además, esta tabla también puede utilizarse para auditar y controlar el rendimiento del proceso ETL y para garantizar el cumplimiento de las políticas de seguridad y privacidad establecidas por la organización.
/// </summary>
public partial class Tabla
{
    /// <summary>
    /// identity
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// nombre de la tabla
    /// </summary>
    public string Nombre { get; set; } = null!;

    public string NombreId { get; set; } = null!;

    public int ConexionId { get; set; }

    public virtual ICollection<Cabecera> Cabeceras { get; set; } = new List<Cabecera>();

    public virtual Conexion Conexion { get; set; } = null!;
}
