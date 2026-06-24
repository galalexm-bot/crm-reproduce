// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.IWebDesignerCheckModulesService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UI.Services
{
  /// <summary>Сервис для проверки Дизайнера ELMA</summary>
  public interface IWebDesignerCheckModulesService
  {
    /// <summary>Проверить корректность установки Дизайнера ELMA</summary>
    /// <returns>Результат проверки</returns>
    CheckDesignerModuleResult[] CheckWebDesigner();

    /// <summary>Очистить кеш</summary>
    void ClearCache();
  }
}
