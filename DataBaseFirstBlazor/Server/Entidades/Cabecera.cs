using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

public partial class Cabecera
{
    public long Id { get; set; }

    public string Uuid { get; set; } = null!;

    public string? Eslavon { get; set; }

    public string Cadena { get; set; } = null!;

    public string Integridad { get; set; } = null!;

    public int IdTabla { get; set; }

    public int IdConexion { get; set; }

    public int IdEstado { get; set; }

    public int IdDetalleRegistro { get; set; }

    public int IdTransaccion { get; set; }

    public DateTime Creacion { get; set; }

    public int IdentificacionVersion { get; set; }

    public string? IdentificacionAmbiente { get; set; }

    public string? IdentificacionTipoDte { get; set; }

    public string IdentificacionNumeroControl { get; set; } = null!;

    public string? IdentificacionCodigoGeneracion { get; set; }

    public string? IdentificacionTipoModelo { get; set; }

    public string? IdentificacionTipoOperacion { get; set; }

    public string? IdentificacionTipoContingencia { get; set; }

    public string? IdentificacionMotivoContin { get; set; }

    public string? IdentificacionFecEmi { get; set; }

    public string? IdentificacionHorEmi { get; set; }

    public string? IdentificacionTipoMoneda { get; set; }

    public string? EmisorNit { get; set; }

    public string? EmisorNrc { get; set; }

    public string? EmisorNombre { get; set; }

    public string? EmisorCodActividad { get; set; }

    public string? EmisorDescActividad { get; set; }

    public string? EmisorNombreComercial { get; set; }

    public string? EmisorTipoEstablecimiento { get; set; }

    public string? EmisorDireccionDepartamento { get; set; }

    public string? EmisorDireccionMunicipio { get; set; }

    public string? EmisorDireccionComplemento { get; set; }

    public string? EmisorTelefono { get; set; }

    public string? EmisorCorreo { get; set; }

    public string? EmisorCodEstableMh { get; set; }

    public string? EmisorCodEstable { get; set; }

    public string? EmisorCodPuntoVentaMh { get; set; }

    public string? EmisorCodPuntoVenta { get; set; }

    public string? ReceptorTipoDocumento { get; set; }

    public string? ReceptorNumDocumento { get; set; }

    public string? ReceptorNrc { get; set; }

    public string? ReceptorNombre { get; set; }

    public string? ReceptorCodActividad { get; set; }

    public string? ReceptorDescActividad { get; set; }

    public string? ReceptorDireccionDepartamento { get; set; }

    public string? ReceptorDireccionMunicipio { get; set; }

    public string? ReceptorDireccionComplemento { get; set; }

    public string? ReceptorTelefono { get; set; }

    public string? ReceptorCorreo { get; set; }

    public string? VentaTerceroNit { get; set; }

    public string? VentaTerceroNombre { get; set; }

    public string? ResumenTotalNoSuj { get; set; }

    public string? ResumenTotalExenta { get; set; }

    public string? ResumenTotalGravada { get; set; }

    public string? ResumenSubTotalVentas { get; set; }

    public string? ResumenDescuNoSuj { get; set; }

    public string? ResumenDescuExenta { get; set; }

    public string? ResumenDescuGravada { get; set; }

    public string? ResumenPorcentajeDescuento { get; set; }

    public string? ResumenTotalDescu { get; set; }

    public string? ResumenSubTotal { get; set; }

    public string? ResumenIvaRete1 { get; set; }

    public string? ResumenReteRenta { get; set; }

    public string? ResumenMontoTotalOperacion { get; set; }

    public string? ResumenTotalNoGravado { get; set; }

    public string? ResumenTotalPagar { get; set; }

    public string? ResumenTotalLetras { get; set; }

    public string? ResumenTotalIva { get; set; }

    public string? ResumenSaldoFavor { get; set; }

    public string? ResumenCondicionOperacion { get; set; }

    public string? ResumenPagosCodigo { get; set; }

    public string? ResumenPagosMontoPago { get; set; }

    public string? ResumenPagosReferencia { get; set; }

    public string? ResumenPagosPlazo { get; set; }

    public string? ResumenPagosPeriodo { get; set; }

    public string? ResumenNumPagoElectronico { get; set; }

    public string? ExtensionNombEntrega { get; set; }

    public string? ExtensionDocuEntrega { get; set; }

    public string? ExtensionNombRecibe { get; set; }

    public string? ExtensionDocuRecibe { get; set; }

    public string? ExtensionObservaciones { get; set; }

    public string? ExtensionPlacaVehiculo { get; set; }

    /// <summary>
    /// Comprobante de Crédito Fiscal Electrónica
    /// </summary>
    public string? ReceptorNit { get; set; }

    /// <summary>
    /// Comprobante de Crédito Fiscal Electrónica
    /// </summary>
    public string? ReceptorNombreComercial { get; set; }

    /// <summary>
    /// Comprobante de Crédito Fiscal Electrónica, Nota de Crédito Electrónica,Nota de Débito Electrónica
    /// </summary>
    public string? ResumenIvaPerci1 { get; set; }

    /// <summary>
    /// Nota de Remisión Electrónica
    /// </summary>
    public string? ReceptorBienTitulo { get; set; }

    /// <summary>
    /// si el documento tiene algun error
    /// </summary>
    public bool Error { get; set; }

    /// <summary>
    /// Comprobante de Retención Electrónica
    /// </summary>
    public string? EmisorCodigoMh { get; set; }

    /// <summary>
    /// Comprobante de Retención Electrónica
    /// </summary>
    public string? EmisorCodigo { get; set; }

    /// <summary>
    /// Comprobante de Retención Electrónica
    /// </summary>
    public string? EmisorPuntoVentaMh { get; set; }

    /// <summary>
    /// Comprobante de Retención Electrónica
    /// </summary>
    public string? ResumenTotalSujetoRetencion { get; set; }

    /// <summary>
    /// Comprobante de Retención Electrónica
    /// </summary>
    public string? ResumenTotalIvaretenido { get; set; }

    /// <summary>
    /// Comprobante de Retención Electrónica
    /// </summary>
    public string? ResumenTotalIvaretenidoLetras { get; set; }

    /// <summary>
    /// Comprobante de Retención Electrónica
    /// </summary>
    public string? EmisorPuntoVentaContri { get; set; }

    /// <summary>
    /// Documento Contable de Liquidación Electrónica
    /// </summary>
    public string? ExtensionCodEmpleado { get; set; }

    /// <summary>
    /// Factura de Exportación Electrónica
    /// </summary>
    public string? IdentificacionMotivoContigencia { get; set; }

    /// <summary>
    /// Factura de Exportación Electrónica
    /// </summary>
    public string? IdentificacionTipoItemExpor { get; set; }

    /// <summary>
    /// Factura de Exportación Electrónica
    /// </summary>
    public string? IdentificacionRecintoFiscal { get; set; }

    /// <summary>
    /// Factura de Exportación Electrónica
    /// </summary>
    public string? IdentificacionRegimen { get; set; }

    /// <summary>
    /// Factura de Exportación Electrónica
    /// </summary>
    public string? ReceptorCodPais { get; set; }

    /// <summary>
    /// Factura de Exportación Electrónica
    /// </summary>
    public string? ReceptorNombrePais { get; set; }

    /// <summary>
    /// Factura de Exportación Electrónica
    /// </summary>
    public string? ReceptorTipoPersona { get; set; }

    /// <summary>
    /// Factura de Exportación Electrónica
    /// </summary>
    public string? ResumenDescuento { get; set; }

    /// <summary>
    /// Factura de Exportación Electrónica
    /// </summary>
    public string? ResumenSeguro { get; set; }

    public string? ResumenFlete { get; set; }

    public string? ResumenDescIncoterms { get; set; }

    public string? ResumenObservaciones { get; set; }

    /// <summary>
    /// Factura de Sujeto Excluido Electrónica
    /// </summary>
    public string? ResumenTotalCompra { get; set; }

    /// <summary>
    /// Factura de Sujeto Excluido Electrónica
    /// </summary>
    public string? ResumenDescu { get; set; }

    /// <summary>
    /// Factura de Sujeto Excluido Electrónica
    /// </summary>
    public string? SujetoExcluidoTipoDocumento { get; set; }

    /// <summary>
    /// Factura de Sujeto Excluido Electrónica
    /// </summary>
    public string? SujetoExcluidoNumDocumento { get; set; }

    /// <summary>
    /// Factura de Sujeto Excluido Electrónica
    /// </summary>
    public string? SujetoExcluidoNombre { get; set; }

    /// <summary>
    /// Factura de Sujeto Excluido Electrónica
    /// </summary>
    public string? SujetoExcluidoCodActividad { get; set; }

    /// <summary>
    /// Factura de Sujeto Excluido Electrónica
    /// </summary>
    public string? SujetoExcluidoDescActividad { get; set; }

    /// <summary>
    /// Factura de Sujeto Excluido Electrónica
    /// </summary>
    public string? SujetoExcluidoDireccionDepartamento { get; set; }

    /// <summary>
    /// Factura de Sujeto Excluido Electrónica
    /// </summary>
    public string? SujetoExcluidoDireccionMunicipio { get; set; }

    /// <summary>
    /// Factura de Sujeto Excluido Electrónica
    /// </summary>
    public string? SujetoExcluidoDireccionComplemento { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? ResumenValorTotal { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioTipoDocumento { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioNumDocumento { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioNombreComercial { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioCodActividad { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioNombre { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioNrc { get; set; }

    /// <summary>
    /// Comprobante de Retención Electrónica
    /// </summary>
    public string? EmisorPuntoVenta { get; set; }

    /// <summary>
    /// si el documento tiene otro delante de el
    /// </summary>
    public bool Siguiente { get; set; }

    public int IdJson { get; set; }

    public bool JsonAprobado { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioTipoEstablecimiento { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioDireccionDepartamento { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioDireccionMunicipio { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioDireccionComplemento { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioTelefono { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioCorreo { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioCodEstableMh { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioCodEstable { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioCodPuntoVentaMh { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonatarioCodPuntoVenta { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonanteTipoDocumento { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonanteCodActividad { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonanteCodDomiciliado { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonanteCodPais { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonanteCorreo { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonanteDescActividad { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonanteDireccionDepartamento { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonanteDireccionMunicipio { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonanteDireccionComplemento { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? DonanteTelefono { get; set; }

    public string? ResumenTributosCodigo { get; set; }

    public string? ResumenTributosDescripcion { get; set; }

    public string? ResumenTributosValor { get; set; }

    public bool EtlCompleto { get; set; }

    public string FechaDte { get; set; } = null!;

    public bool? ErrorMh { get; set; }

    public bool? AceptadoMh { get; set; }

    public bool? Pdf { get; set; }

    public DateTime? PdfFechaHora { get; set; }

    public string? SujetoExcluidoTelefono { get; set; }

    public string? SujetoExcluidoCorreo { get; set; }

    public int? IdAccion { get; set; }

    public bool? Papelera { get; set; }

    public string? DescripcionSucedido { get; set; }

    public virtual Cabecera? CabeceraNavigation { get; set; }

    public virtual Accion? IdAccionNavigation { get; set; }

    public virtual Conexion IdConexionNavigation { get; set; } = null!;

    public virtual DetalleRegistro IdDetalleRegistroNavigation { get; set; } = null!;

    public virtual Estado IdEstadoNavigation { get; set; } = null!;

    public virtual Json IdJsonNavigation { get; set; } = null!;

    public virtual Tabla IdTablaNavigation { get; set; } = null!;

    public virtual ICollection<Cabecera> InverseCabeceraNavigation { get; set; } = new List<Cabecera>();
}
