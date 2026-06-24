// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.Services.IExportCheckingService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Export.Models;

namespace EleWise.ELMA.Deploy.Export.Services
{
  /// <summary>Сервис проверки выгружаемой конфигурации</summary>
  public interface IExportCheckingService
  {
    /// <summary>Проверить</summary>
    /// <param name="context">Контекст проверки</param>
    /// <returns>Результат проверки</returns>
    IExportCheckingResult Check(IExportCheckingContext context);
  }
}
