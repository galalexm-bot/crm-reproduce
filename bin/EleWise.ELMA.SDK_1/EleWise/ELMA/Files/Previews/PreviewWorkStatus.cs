// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.PreviewWorkStatus
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Статус формирования превью</summary>
  [MetadataType(typeof (EnumMetadata))]
  [DisplayName(typeof (__Resources_PreviewWorkStatus), "DisplayName")]
  [Uid("09b07ae0-7c5a-4124-bbd7-df6e15766a15")]
  public enum PreviewWorkStatus
  {
    /// <summary>Идет формирование</summary>
    [DisplayName(typeof (__Resources_PreviewWorkStatus), "P_InProgress_DisplayName"), Uid("9ff5eb89-e5fa-467d-8234-904333008476")] InProgress,
    /// <summary>Завершено</summary>
    [DisplayName(typeof (__Resources_PreviewWorkStatus), "P_Completed_DisplayName"), Uid("7a541cf8-69ad-493f-a8ac-f7d1859a62b6")] Completed,
    /// <summary>Ошибка при формировании</summary>
    [Uid("1d021981-c999-41e6-8682-a0322b9a649b"), DisplayName(typeof (__Resources_PreviewWorkStatus), "P_Fail_DisplayName")] Fail,
    /// <summary>Нет</summary>
    [DisplayName(typeof (__Resources_PreviewWorkStatus), "P_None_DisplayName"), Uid("42d731bc-aa60-45bb-bde3-34fa96948ba2")] None,
  }
}
