using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

/// <summary>
/// Representacion de distintas consultas que se pueden programar para distintas horas, distintos dias o una fecha en especifico
/// </summary>
public partial class Automatizacion
{
    /// <summary>
    /// identity
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// fecha de lanzamiento
    /// </summary>
    public DateTime? FechaLanzamiento { get; set; }

    /// <summary>
    /// hora y minuto de lanzamiento, no puede ser nulo porque siempre se necesita un momento determinado en el que la accion se ejecute
    /// </summary>
    public TimeSpan TiempoLanzamiento { get; set; }

    /// <summary>
    /// si se repetira diariamente, todos los dias, no se ha consentido en la programacion si puede ser nulo, es un booleano, es true o es false
    /// </summary>
    public bool Diario { get; set; }

    /// <summary>
    /// que dias se repetiran ? 
    /// Lunes: lu
    /// Martes: ma
    /// Miercoles: mi
    /// Jueves: ju
    /// Viernes: vi
    /// Sabado: sa
    /// Domingo: do
    /// estos dias deben estar entre ;; cada uno
    /// ;;lu;;mi;;vi;;     
    /// Si se escribiese mal no se tomara en cuenta, debe ir capitalizada justo como se ve en la descripcion y sin espacios entre los puntos y comas y los dias
    /// </summary>
    public string Dia { get; set; } = null!;

    /// <summary>
    /// script sql que se ejecutara en ese momento
    /// </summary>
    public string? Consulta { get; set; }

    /// <summary>
    /// fecha y hora del ultimo lanzamiento de este registro en esta tabla
    /// </summary>
    public DateTime? UltimoLanzamiento { get; set; }

    /// <summary>
    /// cantara progresivamente cuantas veces se ha lanzado la automatizacion,no puede ser nulo porque al momento de hacer la suma no se tiene consentido que pueda ser nulo
    /// </summary>
    public int Lanzamiento { get; set; }

    /// <summary>
    /// conteo de errores, no puede ser nulo porque al momento de hacer la suma no se tiene en cuenta que sea nulo
    /// </summary>
    public int Error { get; set; }

    /// <summary>
    /// hora y fecha del ultimo error
    /// </summary>
    public DateTime? UltimoError { get; set; }

    /// <summary>
    /// si esta activo el etl lo agarrara, sino, no
    /// </summary>
    public bool Activo { get; set; }

    /// <summary>
    /// descripcion detallada sobre lo que hace el procedimiento almacenado, se representara en la descripcion de los registros acerca de las acciones que se han realizado
    /// </summary>
    public string Descripcion { get; set; } = null!;
}
