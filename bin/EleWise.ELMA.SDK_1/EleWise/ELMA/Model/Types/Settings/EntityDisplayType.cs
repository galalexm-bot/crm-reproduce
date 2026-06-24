// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.EntityDisplayType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Вид отображения значения типа "Сущность"</summary>
  [DefaultValueUid("57e25a65-8a49-4760-95af-922286a8351c")]
  [DisplayName(typeof (__Resources_EntityDisplayType), "DisplayName")]
  [Uid("b1401619-1df9-4d97-a2d8-c426abc127cc")]
  [MetadataType(typeof (EnumMetadata))]
  public enum EntityDisplayType
  {
    /// <summary>Стандартный</summary>
    [DisplayName(typeof (__Resources_EntityDisplayType), "P_Standard_DisplayName"), Uid("57e25a65-8a49-4760-95af-922286a8351c")] Standard,
    /// <summary>Горизонтальная группа</summary>
    [Uid("bafc1f65-4278-4751-b465-d62807f88cf1"), DisplayName(typeof (__Resources_EntityDisplayType), "P_HorizontalGroup_DisplayName")] HorizontalGroup,
    /// <summary>Вертикальная группа</summary>
    [DisplayName(typeof (__Resources_EntityDisplayType), "P_VerticalGroup_DisplayName"), Uid("80dfca25-5bad-48c9-b6e0-4dbf180d3212")] VerticalGroup,
  }
}
