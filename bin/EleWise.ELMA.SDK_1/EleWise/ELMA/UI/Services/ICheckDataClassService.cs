// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.ICheckDataClassService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UI.Services
{
  /// <summary>Сервис проверки метаданных датакласса</summary>
  public interface ICheckDataClassService
  {
    /// <summary>Проверить метаданные датакласса</summary>
    /// <param name="dataClassMetadata">Метаданные датакласса</param>
    /// <returns>Результат проверки</returns>
    ValidationResult Validate(DataClassMetadata dataClassMetadata);
  }
}
