// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Components.Dependency.IDependencyFinder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.UI.Components.Dependency.Models;
using System.Collections.Generic;

namespace EleWise.ELMA.UI.Components.Dependency
{
  /// <summary>Точка расширения по поиску зависимостей в системе</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IDependencyFinder
  {
    /// <summary>Получить список зависимостей</summary>
    /// <param name="dependencyRequests">Список запросов на зависимости</param>
    /// <returns>Список зависимостей</returns>
    IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> GetDependencies(
      IEnumerable<IDependencyRequest> dependencyRequests);
  }
}
