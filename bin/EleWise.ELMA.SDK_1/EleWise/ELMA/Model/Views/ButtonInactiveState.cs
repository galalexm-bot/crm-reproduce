// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ButtonInactiveState
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>ButtonInactiveState</summary>
  /// <remarks>
  /// Состояние кнопки в неактивном режиме родительской формы (readonly)
  /// </remarks>
  [MetadataType(typeof (EnumMetadata))]
  [DefaultValueUid("016f4741-aed7-4560-8b54-418b8b43bae5")]
  [Description(typeof (__Resources_ButtonInactiveState), "Description")]
  [DisplayName(typeof (__Resources_ButtonInactiveState), "DisplayName")]
  [Uid("9341073b-746c-4804-8f60-c3449773b64d")]
  public enum ButtonInactiveState
  {
    /// <summary>Активна</summary>
    [Uid("016f4741-aed7-4560-8b54-418b8b43bae5"), DisplayName(typeof (__Resources_ButtonInactiveState), "P_Active_DisplayName")] Active,
    /// <summary>Не активна</summary>
    [Uid("14f0811d-080c-4e56-91dc-0861435a14af"), DisplayName(typeof (__Resources_ButtonInactiveState), "P_Inactive_DisplayName")] Inactive,
    /// <summary>Скрыта</summary>
    [DisplayName(typeof (__Resources_ButtonInactiveState), "P_Hide_DisplayName"), Uid("7adf95af-bd2a-4cdf-beca-71750a201d56")] Hide,
  }
}
