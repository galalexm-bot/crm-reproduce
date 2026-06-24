// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.IComponentManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>Базовый интерфейс менеджера компонентов</summary>
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IComponentManager
  {
    /// <summary>
    /// Возвращает компоненты, реализующие интерфейс-расширение
    /// </summary>
    /// <typeparam name="T">Тип интерфейса расширения</typeparam>
    /// <returns>Список компонентов</returns>
    IEnumerable<T> GetExtensionPoints<T>();

    /// <summary>
    /// Возвращает типы компонентов, реализующих интерфейс-расширение
    /// </summary>
    /// <param name="type">Тип интерфейса расширения</param>
    /// <returns>Список компонентов</returns>
    IEnumerable<Type> GetExtensionPointTypes(Type type);

    /// <summary>
    /// Возвращает типы компонентов, реализующих интерфейс-расширение
    /// </summary>
    /// <typeparam name="T">Тип интерфейса расширения</typeparam>
    /// <returns>Список компонентов</returns>
    IEnumerable<Type> GetExtensionPointTypes<T>();

    /// <summary>
    /// Возвращает типы компонентов, реализующих интерфейс-расширение
    /// </summary>
    /// <param name="type">Тип интерфейса расширения</param>
    /// <returns>Список компонентов</returns>
    Type[] GetExtensionPointTypesArray(Type type);
  }
}
