using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

/// <summary>
/// Comportamientos específicos del aplicativo, que son configurables mediante claves y valores. Cada registro en la tabla &quot;Controlador&quot; contiene una clave que identifica el comportamiento específico del aplicativo que se está configurando, una descripción del mismo y un valor que indica cómo se debe comportar el aplicativo en relación a ese comportamiento.
/// 
/// La tabla &quot;Controlador&quot; es esencial para garantizar la flexibilidad y adaptabilidad del aplicativo, ya que proporciona una forma de configurar y personalizar el comportamiento del sistema sin necesidad de realizar cambios en el código fuente. Además, esta tabla también puede utilizarse para auditar y controlar los cambios en el comportamiento del aplicativo y para garantizar el cumplimiento de las políticas de seguridad establecidas por la organización.
/// </summary>
public partial class Controlador
{
    /// <summary>
    /// identity
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// nombre de la accion a controlar
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// descripcion de la accion a controlar
    /// </summary>
    public string Descripcion { get; set; } = null!;

    /// <summary>
    /// campo booleano para activar o desactivar el controlador
    /// </summary>
    public bool Bandera { get; set; }

    /// <summary>
    /// indica el valor del cero
    /// </summary>
    public string Cero { get; set; } = null!;

    /// <summary>
    /// indica el valor del numero uno
    /// </summary>
    public string Uno { get; set; } = null!;

    public int Correlativo { get; set; }
}
