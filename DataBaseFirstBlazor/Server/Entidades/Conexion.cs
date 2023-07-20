using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

/// <summary>
/// Conexión a las bases de datos a las que se accede mediante el JDBC (Java Database Connectivity). Contiene un nombre genérico para la conexión, así como detalles específicos de la configuración de la conexión, como la dirección del servidor, el número de puerto, el nombre de la base de datos y las credenciales de autenticación.
/// 
/// La tabla &quot;Conexion&quot; es esencial para garantizar la disponibilidad y fiabilidad de la información almacenada en la base de datos, ya que proporciona una forma de mantener y gestionar las conexiones a los sistemas de gestión de bases de datos relacionales. Además, esta tabla también puede utilizarse para auditar el acceso a las bases de datos y garantizar el cumplimiento de las políticas de seguridad establecidas por la organización.
/// </summary>
public partial class Conexion
{
    /// <summary>
    /// identity
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// nombre de la base de datos
    /// </summary>
    public string Base { get; set; } = null!;

    /// <summary>
    /// nombre para mostrar
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// ip de bdd
    /// </summary>
    public string Ip { get; set; } = null!;

    /// <summary>
    /// puerto que utiliza
    /// </summary>
    public string Puerto { get; set; } = null!;

    /// <summary>
    /// la firma del dte en uso
    /// </summary>
    public string FirmaDte { get; set; } = null!;

    /// <summary>
    /// ultima fecha y hora en la que se actualizo el dte
    /// </summary>
    public DateTime ActualizacionFirmaDte { get; set; }

    /// <summary>
    /// tiempo (en minutos) para actualizar la firma del dte
    /// </summary>
    public int ActualizacionFirma { get; set; }

    /// <summary>
    /// NRC por el guion faltante
    /// </summary>
    public string NrcPdf { get; set; } = null!;

    /// <summary>
    /// direccion de la imagen para que aparezca el logo en el pdf (puede ser local o url)
    /// </summary>
    public string LogoPdf { get; set; } = null!;

    /// <summary>
    /// apartado de contactenos
    /// </summary>
    public string FacebookPdf { get; set; } = null!;

    /// <summary>
    /// apartado de contactenos
    /// </summary>
    public string InstagramPdf { get; set; } = null!;

    /// <summary>
    /// apartado de contactenos
    /// </summary>
    public string CorreoPdf { get; set; } = null!;

    /// <summary>
    /// apartado de contactenos
    /// </summary>
    public string WhatsappPdf { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string CorreoContra { get; set; } = null!;

    public string CorreoTitulo { get; set; } = null!;

    public string CorreoAsunto { get; set; } = null!;

    /// <summary>
    /// en el titulo, asunto y cuerpo del documento, se pueden agregar solamente objetos del json o campos de la cabecera, no arreglos
    /// </summary>
    public string CorreoCuerpo { get; set; } = null!;

    public string CorreoIp { get; set; } = null!;

    public int CorreoPuerto { get; set; }

    public string NombreComercial { get; set; } = null!;

    public bool CorreoSsl { get; set; }

    public virtual ICollection<CabeceraReintentoCore> CabeceraReintentoCores { get; set; } = new List<CabeceraReintentoCore>();

    public virtual ICollection<CabeceraReintentoJson> CabeceraReintentoJsons { get; set; } = new List<CabeceraReintentoJson>();

    public virtual ICollection<Cabecera> Cabeceras { get; set; } = new List<Cabecera>();

    public virtual ICollection<Tabla> Tablas { get; set; } = new List<Tabla>();
}
