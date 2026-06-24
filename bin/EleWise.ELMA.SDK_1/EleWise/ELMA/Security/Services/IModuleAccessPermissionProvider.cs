// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IModuleAccessPermissionProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Интерфейс провайдера, определяющего привилегии для доступа к модулям
  /// </summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-810.html">Пример реализации привилегии для доступа к модулю</see>
  /// <see href="http://www.elma-bpm.ru/kb/article-813.html">Пример реализации привилегий</see>
  /// </remarks>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IModuleAccessPermissionProvider
  {
    /// <summary>
    /// Получить словарь из значений "Идентификатор модуля-&gt;Привилегия доступа к модулю"
    /// </summary>
    /// <returns></returns>
    Dictionary<string, Permission> GetModuleAccessPermissions();
  }
}
