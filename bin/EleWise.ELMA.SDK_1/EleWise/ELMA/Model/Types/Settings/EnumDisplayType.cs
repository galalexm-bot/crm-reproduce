// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.EnumDisplayType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Вид отображения значения типа "Перечисление"</summary>
  [DisplayName(typeof (__Resources_EnumDisplayType), "DisplayName")]
  [Uid("ace00fad-4f16-4032-b361-e4e23bd4bd5b")]
  [MetadataType(typeof (EnumMetadata))]
  public enum EnumDisplayType
  {
    /// <summary>Стандартный</summary>
    [Uid("be081635-e111-4471-b66c-523e086971a8"), DisplayName(typeof (__Resources_EnumDisplayType), "P_Standard_DisplayName")] Standard,
    /// <summary>Горизонтальная радиогруппа</summary>
    [Uid("7ac2f816-6f9c-45bc-af09-37861879c13b"), DisplayName(typeof (__Resources_EnumDisplayType), "P_HorizontalGroup_DisplayName")] HorizontalGroup,
    /// <summary>Вертикальная радиогруппа</summary>
    [Uid("b1a3832f-fe70-432a-8ad8-a04563475499"), DisplayName(typeof (__Resources_EnumDisplayType), "P_VerticalGroup_DisplayName")] VerticalGroup,
    /// <summary>Переключатель</summary>
    [Uid("e5a50137-51cc-4523-84dd-46162ec738e4"), DisplayName(typeof (__Resources_EnumDisplayType), "P_Switch_DisplayName")] Switch,
  }
}
