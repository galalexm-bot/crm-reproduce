// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.BoolDisplayType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Вид отображения значения типа "Да/нет"</summary>
  [DisplayName(typeof (__Resources_BoolDisplayType), "DisplayName")]
  [DefaultValueUid("40a000a9-2016-42f4-842f-83a60048ee61")]
  [MetadataType(typeof (EnumMetadata))]
  [Uid("3f73cd2d-c2c7-4b74-8b52-d81a08c286e9")]
  public enum BoolDisplayType
  {
    /// <summary>Радиогруппа</summary>
    [DisplayName(typeof (__Resources_BoolDisplayType), "P_RadioButtons_DisplayName"), Uid("40a000a9-2016-42f4-842f-83a60048ee61")] RadioButtons,
    /// <summary>Флажок</summary>
    [DisplayName(typeof (__Resources_BoolDisplayType), "P_Checkbox_DisplayName"), Uid("583c1e2c-2849-4a9e-940e-d437e8040082")] Checkbox,
    /// <summary>Переключатель</summary>
    [Uid("E756C297-E2D7-40B0-A09D-D2ADBB308EE6"), DisplayName(typeof (__Resources_BoolDisplayType), "P_Switch_DisplayName")] Switch,
  }
}
