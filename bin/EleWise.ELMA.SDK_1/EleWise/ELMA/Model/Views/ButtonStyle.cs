// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ButtonStyle
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>ButtonStyle</summary>
  /// <remarks>Возможные цвета кнопок переходов</remarks>
  [Description("SR.M('Возможные цвета кнопок переходов ')")]
  [DefaultValueUid("1ab66bd0-81c1-4025-a7d1-926e73bacabf")]
  [Uid("dd959698-9048-457e-9f20-08772dbb154f")]
  [DisplayName("SR.M('ButtonStyle')")]
  [MetadataType(typeof (EnumMetadata))]
  public enum ButtonStyle
  {
    /// <summary>Default</summary>
    /// <remarks>Цвет по умолчанию</remarks>
    [Description("SR.M('Цвет по умолчанию')"), Uid("1ab66bd0-81c1-4025-a7d1-926e73bacabf"), DisplayName("SR.M('Default')")] Default,
    /// <summary>Blue</summary>
    /// <remarks>Синий</remarks>
    [Description("SR.M('Синий')"), DisplayName("SR.M('Blue')"), Uid("40e99bfc-de47-4b22-9f1c-0cb8d1f4ff78")] Blue,
    /// <summary>Green</summary>
    [DisplayName("SR.M('Green')"), Uid("1fb69293-9026-4a40-8101-f9eb7392af18")] Green,
    /// <summary>Yellow</summary>
    [DisplayName("SR.M('Yellow')"), Uid("8f309546-9101-4d89-b6bb-67178081e1ba")] Yellow,
    /// <summary>Red</summary>
    [DisplayName("SR.M('Red')"), Uid("7d30b957-1e03-4d6c-9618-2b65092665a4")] Red,
    /// <summary>metroGray</summary>
    [DisplayName("SR.M('metroGray')"), Uid("2f06869e-4d3d-4e44-80b3-6a5b71f0809b")] MetroGray,
    /// <summary>Simple</summary>
    [DisplayName("SR.M('Simple')"), Uid("bb14e0ea-1090-4dfa-bbbd-1d7dc7bb8843")] Simple,
    /// <summary>Главный</summary>
    [DisplayName("SR.M('Главный')"), Uid("8c96b261-e207-415c-95ef-7e1b725262ee")] Main,
  }
}
