// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.DropDownListDisplayType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Вид отображения значения типа "Выпадающий список"</summary>
  [Uid("625ae248-fca4-4a41-8b17-a61bb4845844")]
  [MetadataType(typeof (EnumMetadata))]
  [DefaultValueUid("3d8a5f90-4250-423d-98ef-c03e6c9617c0")]
  [DisplayName(typeof (__Resources_DropDownListDisplayType), "DisplayName")]
  public enum DropDownListDisplayType
  {
    /// <summary>Стандартный</summary>
    [Uid("3d8a5f90-4250-423d-98ef-c03e6c9617c0"), DisplayName(typeof (__Resources_DropDownListDisplayType), "P_Standard_DisplayName")] Standard,
    /// <summary>Горизонтальная радиогруппа</summary>
    [Uid("ec09a6ae-ad3d-4df9-b8cb-e37f3512362c"), DisplayName(typeof (__Resources_DropDownListDisplayType), "P_HorizontalGroup_DisplayName")] HorizontalGroup,
    /// <summary>Вертикальная радиогруппа</summary>
    [Uid("edb35ba6-e368-40e1-b5b3-8b8cff38be96"), DisplayName(typeof (__Resources_DropDownListDisplayType), "P_VerticalGroup_DisplayName")] VerticalGroup,
  }
}
