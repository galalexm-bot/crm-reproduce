// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Ranges.RelativeDateTimeMeter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Ranges
{
  /// <summary>RelativeDateTimeMeter</summary>
  [MetadataType(typeof (EnumMetadata))]
  [DisplayName(typeof (__Resources_RelativeDateTimeMeter), "DisplayName")]
  [Uid("3cd25495-942b-477f-997a-76067b541325")]
  public enum RelativeDateTimeMeter
  {
    /// <summary>ч</summary>
    [DisplayName(typeof (__Resources_RelativeDateTimeMeter), "P_Hour_DisplayName"), Uid("073bb9e1-4aac-4e8e-aa5a-b80900236ba1")] Hour,
    /// <summary>д</summary>
    [Uid("065e3fb4-b618-4ea7-b1d0-f164003c8a43"), DisplayName(typeof (__Resources_RelativeDateTimeMeter), "P_Day_DisplayName")] Day,
    /// <summary>н</summary>
    [DisplayName(typeof (__Resources_RelativeDateTimeMeter), "P_Week_DisplayName"), Uid("1f7b578e-cab9-4b10-881f-79d2007539ad")] Week,
    /// <summary>м</summary>
    [Uid("d5446538-7ca4-4e40-b242-77913e5846d6"), DisplayName(typeof (__Resources_RelativeDateTimeMeter), "P_Month_DisplayName")] Month,
    /// <summary>г</summary>
    [DisplayName(typeof (__Resources_RelativeDateTimeMeter), "P_Year_DisplayName"), Uid("3adee897-ae0e-4589-8543-b2ef5628e75a")] Year,
  }
}
