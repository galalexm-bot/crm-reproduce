// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.PreviewSettingsOption
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Опция отображения предпросмотра</summary>
  [DisplayName(typeof (__Resources_PreviewSettingsOption), "DisplayName")]
  [MetadataType(typeof (EnumMetadata))]
  [Uid("fc1585a0-66b9-46ea-857c-16ba2e44723c")]
  public enum PreviewSettingsOption
  {
    /// <summary>Скрывать окно выбора</summary>
    [DisplayName(typeof (__Resources_PreviewSettingsOption), "P_HideSelector_DisplayName"), Uid("74da11a3-792b-4175-b733-420678830728")] HideSelector,
  }
}
