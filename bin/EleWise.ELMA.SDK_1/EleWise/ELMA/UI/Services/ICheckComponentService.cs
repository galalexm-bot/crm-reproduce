// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.ICheckComponentService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UI.Services
{
  /// <summary>Сервис проверки компонента</summary>
  public interface ICheckComponentService
  {
    /// <summary>Проверить компонент на возможность публикации</summary>
    /// <param name="componentMetadata">Метаданные компонента</param>
    /// <returns>Результат проверки компонента</returns>
    ValidationResult Validate(ComponentMetadata componentMetadata);
  }
}
