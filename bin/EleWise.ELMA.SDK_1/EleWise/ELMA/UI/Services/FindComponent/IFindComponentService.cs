// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.FindComponent.IFindComponentService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.UI.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.UI.Services.FindComponent
{
  /// <summary>Сервис поиска компонента</summary>
  public interface IFindComponentService
  {
    /// <summary>Найти компонент и все его зависимости</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка компонента</param>
    /// <param name="options">Опции поиска</param>
    /// <returns>Рекурсивная модель компонента</returns>
    RecursiveComponentModel FindComponent(Guid headerUid, FindComponentOptions options);

    /// <summary>
    /// Найти компонент и все его зависимости
    /// Используется для поиска компонентов, являющихся формой объектов, процессов и т.д.
    /// </summary>
    /// <param name="model">Модели поиска компонента для формы объекта</param>
    /// <param name="options">Опции поиска</param>
    /// <returns>Рекурсивная модель компонента</returns>
    RecursiveComponentModel FindComponent(
      ObjectFormFindComponentModel model,
      FindComponentOptions options);

    /// <summary>Получить список дополнительных для дозагрузки модулей</summary>
    /// <returns>Список дополнительных для дозагрузки модулей</returns>
    IEnumerable<ClientComponentModel> GetAdditionalModules();
  }
}
