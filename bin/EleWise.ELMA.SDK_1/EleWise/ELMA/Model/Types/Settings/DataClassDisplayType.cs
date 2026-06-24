// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.DataClassDisplayType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>
  /// Вид отображения значения типа "Структура обмена данными"
  /// </summary>
  [Uid("d0ae05a6-7176-46cc-86df-fcdccedda458")]
  [MetadataType(typeof (EnumMetadata))]
  [ShowInDesigner(false)]
  [ShowInTypeTree(false)]
  [DisplayName("SR.M('Вид отображения значения типа \"Структура обмена данными\"')")]
  [DefaultValueUid("8c69f6ef-9ea7-4ae7-be24-ec4bcde7ae8f")]
  public enum DataClassDisplayType
  {
    /// <summary>Стандартный</summary>
    [Uid("8c69f6ef-9ea7-4ae7-be24-ec4bcde7ae8f"), DisplayName("SR.M('Стандартный')")] Standard,
    /// <summary>Табличный</summary>
    [DisplayName("SR.M('Табличный')"), Uid("e5dc514f-d980-4dd0-9bef-ed7f88934044")] Table,
  }
}
