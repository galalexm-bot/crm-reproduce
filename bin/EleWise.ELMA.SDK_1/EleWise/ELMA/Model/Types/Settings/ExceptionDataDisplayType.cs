// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.ExceptionDataDisplayType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>ExceptionDataDisplayType</summary>
  [MetadataType(typeof (EnumMetadata))]
  [Uid("94ec0966-a965-41e2-9f66-e459666e5c32")]
  [DisplayName(typeof (__Resources_ExceptionDataDisplayType), "DisplayName")]
  public enum ExceptionDataDisplayType
  {
    /// <summary>Упрощенный</summary>
    /// <remarks>
    /// Упрощенный режим отображения ошибки (только строка ошибки)
    /// </remarks>
    [DisplayName(typeof (__Resources_ExceptionDataDisplayType), "P_simple_DisplayName"), Uid("acbe09a0-f8fc-4c1e-9f98-13671e5d2777"), Description(typeof (__Resources_ExceptionDataDisplayType), "P_simple_Description")] simple,
    /// <summary>Полный</summary>
    /// <remarks>Полный режим отображения ошибки</remarks>
    [DisplayName(typeof (__Resources_ExceptionDataDisplayType), "P_complex_DisplayName"), Description(typeof (__Resources_ExceptionDataDisplayType), "P_complex_Description"), Uid("40d72baa-e376-4c74-af6f-02eb023cd0b4")] complex,
  }
}
