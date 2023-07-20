using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

/// <summary>
/// parametros clave, valor y su descripcion para diferentes configuraciones en el sistema y para guardados en memoria desde una base de datos
/// </summary>
public partial class Parametro
{
    /// <summary>
    /// identity
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// nombre descriptivo sobre lo que se esta guardando
    /// </summary>
    public string Clave { get; set; } = null!;

    /// <summary>
    /// valor, cantidad de la clave, se utilizara para las diferentes configuraciones en el sistema ETL o CORE
    /// </summary>
    public string Valor { get; set; } = null!;

    /// <summary>
    /// descripcion sobre a lo que se regiere esta clave
    /// </summary>
    public string Descripcion { get; set; } = null!;
}
