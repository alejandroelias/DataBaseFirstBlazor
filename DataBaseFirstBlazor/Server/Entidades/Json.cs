using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

/// <summary>
/// tabla pibote para saber que json usare dependiendo de la parametrizacion en la tabla parametro
/// </summary>
public partial class Json
{
    /// <summary>
    /// identity
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// relacionado con version
    /// </summary>
    public int Version { get; set; }

    /// <summary>
    /// relacionado con tipo de documento
    /// </summary>
    public int IdTipoDocumento { get; set; }

    /// <summary>
    /// con este campo se indicara que version de json para cada tipo de factura esta activo. CUIDADO con tener dos JSON de facturas activos ya que el aplicativo ordenara de forma ascendente los registros de esta tabla y podria ser que no se actualice la version que se esta tratando de tomar en cuenta.
    /// </summary>
    public bool Activo { get; set; }

    /// <summary>
    /// ruta exacta del archivo
    /// </summary>
    public string Ruta { get; set; } = null!;

    /// <summary>
    /// arreglos de objetos [{}]
    /// </summary>
    public string ArregloObjeto { get; set; } = null!;

    /// <summary>
    /// arreglos normales []
    /// </summary>
    public string Arreglo { get; set; } = null!;

    public bool ErrorJson { get; set; }

    /// <summary>
    /// escribiras el path del json que deseas que se elimine
    /// por ejemplo 
    /// 
    /// resumen.pagos hara que la propiedad pagos dentro del objeto resumen se remueva del json
    /// 
    /// resumen[n].pagos es diferente
    /// se hace referencia a un arreglo que puede tener esa propiedad pagos dentro de algun objeto en el, esto, eliminaria (de todos los objetos dentro de resumen) la propiedad pagos
    /// </summary>
    public string EliminarExcedente { get; set; } = null!;

    public virtual ICollection<Cabecera> Cabeceras { get; set; } = new List<Cabecera>();

    public virtual TipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;

    public virtual ICollection<PdfSeccion> PdfSeccions { get; set; } = new List<PdfSeccion>();
}
