// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IDependenciesExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Dependencies;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Точка расширения работы с зависимостями</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IDependenciesExtension
  {
    /// <summary>
    /// Получение контейнеров зависимостей по идентификатору объекта
    /// </summary>
    /// <param name="uid">Идентификатор объекта</param>
    IEnumerable<IDependencyContainer> GetDependencyContainers(Guid uid);
  }
}
