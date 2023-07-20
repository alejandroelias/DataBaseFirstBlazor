using System;
using System.Collections.Generic;

namespace DataBaseFirstBlazor.Server.Entidades;

public partial class Pdf
{
    public int Id { get; set; }

    public int Correlativo { get; set; }

    public string Clave { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public int IdPdfSeccion { get; set; }

    /// <summary>
    /// c: centro(o sin formato), i: izquierda, d: derecha, (para que el registro no aparezca simulando una desactivacion, puede colocar cualquier otra letra) j: justificado (a la izquierda) sin fields del 50% entre derecha e izquierda
    /// 
    /// si la orientacion se genera en un objeto, es:
    /// |--------------------|
    /// |              c                  |
    /// | i                             d |
    /// |      j                           |
    /// |--------------------|
    /// no alinea el texto en los objetos como en las tablas
    /// </summary>
    public string Posicion { get; set; } = null!;

    public bool ClaveNegrita { get; set; }

    public bool ValorNegrita { get; set; }

    public string TextoAgregadoAntes { get; set; } = null!;

    public string TextoAgregadoDespues { get; set; } = null!;

    /// <summary>
    /// separar las palabras por dos puntos y comas
    /// </summary>
    public string TextoAOmitir { get; set; } = null!;

    /// <summary>
    /// separar el reemplazar asi: si tenemos tomate ajo y cebolla como cadena de texto y queremos reemplazar cebolla por lechuga: cebolla::lechuga;;cebolla::lechuga
    /// </summary>
    public string TextoAReemplazar { get; set; } = null!;

    public int IdTipado { get; set; }

    public int Decimales { get; set; }

    public int IdCapitalizaicon { get; set; }

    public string? OrientacionTexto { get; set; }

    public virtual Capitalizacion IdCapitalizaiconNavigation { get; set; } = null!;

    public virtual PdfSeccion IdPdfSeccionNavigation { get; set; } = null!;

    public virtual Tipado IdTipadoNavigation { get; set; } = null!;
}
