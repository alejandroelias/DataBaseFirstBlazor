using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

public partial class Detalle
{
    public long Id { get; set; }

    public DateTime Creacion { get; set; }

    public string Uuid { get; set; } = null!;

    public string? DocumentoRelacionadoTipoDocumento { get; set; }

    public string? DocumentoRelacionadoTipoGeneracion { get; set; }

    public string? DocumentoRelacionadoNumeroDocumento { get; set; }

    public string? DocumentoRelacionadoFechaEmision { get; set; }

    public string? OtrosDocumentosCodDocAsociado { get; set; }

    public string? OtrosDocumentosDescDocumento { get; set; }

    public string? OtrosDocumentosDetalleDocumento { get; set; }

    public string? OtrosDocumentosMedicoNombre { get; set; }

    public string? OtrosDocumentosMedicoNit { get; set; }

    public string? OtrosDocumentosMedicoDocIdentificacion { get; set; }

    public string? OtrosDocumentosMedicoTipoServicio { get; set; }

    public string? CuerpoDocumentoNumItem { get; set; }

    public string? CuerpoDocumentoTipoItem { get; set; }

    public string? CuerpoDocumentoNumeroDocumento { get; set; }

    public string? CuerpoDocumentoCantidad { get; set; }

    public string? CuerpoDocumentoCodigo { get; set; }

    public string? CuerpoDocumentoCodTributo { get; set; }

    public string? CuerpoDocumentoUniMedida { get; set; }

    public string? CuerpoDocumentoDescripcion { get; set; }

    /// <summary>
    /// Comprobante de Crédito Fiscal Electrónica
    /// </summary>
    public string? CuerpoDocumentoPrecioUni { get; set; }

    public string? CuerpoDocumentoMontoDescu { get; set; }

    public string? CuerpoDocumentoVentaNoSuj { get; set; }

    public string? CuerpoDocumentoVentaExenta { get; set; }

    public string? CuerpoDocumentoVentaGravada { get; set; }

    public string? CuerpoDocumentoTributos { get; set; }

    public string? CuerpoDocumentoPsv { get; set; }

    public string? CuerpoDocumentoNoGravado { get; set; }

    public string? CuerpoDocumentoIvaItem { get; set; }

    public string? ApendiceCampo { get; set; }

    public string? ApendiceEtiqueta { get; set; }

    public string? ApendiceValor { get; set; }

    /// <summary>
    /// Comprobante de Retención Electrónica
    /// </summary>
    public string? CuerpoDocumentoCodigoRetencionMh { get; set; }

    /// <summary>
    /// Comprobante de Retención Electrónica
    /// </summary>
    public string? CuerpoDocumentoIvaRetenido { get; set; }

    /// <summary>
    /// Factura de Exportación Electrónica
    /// </summary>
    public string? OtrosDocumentosPlacaTrans { get; set; }

    /// <summary>
    /// Factura de Exportación Electrónica
    /// </summary>
    public string? OtrosDocumentosModoTransp { get; set; }

    /// <summary>
    /// Factura de Exportación Electrónica
    /// </summary>
    public string? OtrosDocumentosNumConductor { get; set; }

    /// <summary>
    /// Factura de Exportación Electrónica
    /// </summary>
    public string? OtrosDocumentosNombreConductor { get; set; }

    /// <summary>
    /// Factura de Sujeto Excluido Electrónica
    /// </summary>
    public string? CuerpoDocumentoCompra { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? CuerpoDocumentoTipoDonacion { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? CuerpoDocumentoDepreciacion { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? CuerpoDocumentoValorUni { get; set; }

    /// <summary>
    /// Comprobante de Donación Electrónica
    /// </summary>
    public string? CuerpoDocumentoValor { get; set; }

    public string? CuerpoDocumentoTipoDte { get; set; }

    public string? CuerpoDocumentoTipoDoc { get; set; }

    public string? CuerpoDocumentoNumDocumento { get; set; }

    public string? CuerpoDocumentoFechaEmision { get; set; }

    public string? CuerpoDocumentoMontoSujetoGrav { get; set; }
}
