// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.PropertyCalculateType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Тип вычисления значения свойства</summary>
  [ShowInDesigner(false)]
  [MetadataType(typeof (EnumMetadata))]
  [Uid("{EFE13E18-65B4-4ABE-8D27-53C94571DE75}")]
  [ShowInTypeTree(false)]
  public enum PropertyCalculateType
  {
    /// <summary>Нет</summary>
    [DisplayName(typeof (__Resources_PropertyCalculateType), "P_None_DisplayName")] None = 0,
    /// <summary>Сценарий на C#</summary>
    [DisplayName(typeof (__Resources_PropertyCalculateType), "P_CSScript_DisplayName")] CSScript = 10, // 0x0000000A
    /// <summary>SQL выражение</summary>
    [DisplayName(typeof (__Resources_PropertyCalculateType), "P_SQLFormula_DisplayName")] SQLFormula = 20, // 0x00000014
  }
}
