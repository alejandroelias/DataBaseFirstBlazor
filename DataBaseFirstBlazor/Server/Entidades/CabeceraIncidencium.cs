using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

public partial class CabeceraIncidencium
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

    public string? ReceptorNit { get; set; }

    public string? ReceptorNombreComercial { get; set; }

    public string? ResumenIvaPerci1 { get; set; }

    public string? ReceptorBienTitulo { get; set; }

    public bool Error { get; set; }

    public string? EmisorCodigoMh { get; set; }

    public string? EmisorCodigo { get; set; }

    public string? EmisorPuntoVentaMh { get; set; }

    public string? ResumenTotalSujetoRetencion { get; set; }

    public string? ResumenTotalIvaretenido { get; set; }

    public string? ResumenTotalIvaretenidoLetras { get; set; }

    public string? EmisorPuntoVentaContri { get; set; }

    public string? ExtensionCodEmpleado { get; set; }

    public string? IdentificacionMotivoContigencia { get; set; }

    public string? IdentificacionTipoItemExpor { get; set; }

    public string? IdentificacionRecintoFiscal { get; set; }

    public string? IdentificacionRegimen { get; set; }

    public string? ReceptorCodPais { get; set; }

    public string? ReceptorNombrePais { get; set; }

    public string? ReceptorTipoPersona { get; set; }

    public string? ResumenDescuento { get; set; }

    public string? ResumenSeguro { get; set; }

    public string? ResumenFlete { get; set; }

    public string? ResumenDescIncoterms { get; set; }

    public string? ResumenObservaciones { get; set; }

    public string? ResumenTotalCompra { get; set; }

    public string? ResumenDescu { get; set; }

    public string? SujetoExcluidoTipoDocumento { get; set; }

    public string? SujetoExcluidoNumDocumento { get; set; }

    public string? SujetoExcluidoNombre { get; set; }

    public string? SujetoExcluidoCodActividad { get; set; }

    public string? SujetoExcluidoDescActividad { get; set; }

    public string? SujetoExcluidoDireccionDepartamento { get; set; }

    public string? SujetoExcluidoDireccionMunicipio { get; set; }

    public string? SujetoExcluidoDireccionComplemento { get; set; }

    public string? ResumenValorTotal { get; set; }

    public string? DonatarioTipoDocumento { get; set; }

    public string? DonatarioNumDocumento { get; set; }

    public string? DonatarioNombreComercial { get; set; }

    public string? DonatarioCodActividad { get; set; }

    public string? DonatarioNombre { get; set; }

    public string? DonatarioNrc { get; set; }

    public string? EmisorPuntoVenta { get; set; }

    public bool Siguiente { get; set; }

    public int IdJson { get; set; }

    public bool JsonAprobado { get; set; }

    public string? DonatarioTipoEstablecimiento { get; set; }

    public string? DonatarioDireccionDepartamento { get; set; }

    public string? DonatarioDireccionMunicipio { get; set; }

    public string? DonatarioDireccionComplemento { get; set; }

    public string? DonatarioTelefono { get; set; }

    public string? DonatarioCorreo { get; set; }

    public string? DonatarioCodEstableMh { get; set; }

    public string? DonatarioCodEstable { get; set; }

    public string? DonatarioCodPuntoVentaMh { get; set; }

    public string? DonatarioCodPuntoVenta { get; set; }

    public string? DonanteTipoDocumento { get; set; }

    public string? DonanteCodActividad { get; set; }

    public string? DonanteCodDomiciliado { get; set; }

    public string? DonanteCodPais { get; set; }

    public string? DonanteCorreo { get; set; }

    public string? DonanteDescActividad { get; set; }

    public string? DonanteDireccionDepartamento { get; set; }

    public string? DonanteDireccionMunicipio { get; set; }

    public string? DonanteDireccionComplemento { get; set; }

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

    public long? Cc { get; set; }
}
