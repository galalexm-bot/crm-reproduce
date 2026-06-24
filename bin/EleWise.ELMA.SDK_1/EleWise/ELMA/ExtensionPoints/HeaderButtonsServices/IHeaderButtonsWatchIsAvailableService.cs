// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.HeaderButtonsServices.IHeaderButtonsWatchIsAvailableService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using System;

namespace EleWise.ELMA.ExtensionPoints.HeaderButtonsServices
{
  /// <summary>
  /// Сервис проверки поддержки объектом наблюдателей в кнопках заголовка страницы
  /// </summary>
  public interface IHeaderButtonsWatchIsAvailableService
  {
    /// <summary>Поддерживает ли объект кнопку наблюдения</summary>
    /// <param name="typeUid"></param>
    /// <param name="entityId"></param>
    /// <returns></returns>
    bool IsAvailable(Guid typeUid, object entityId);

    /// <summary>Поддерживает ли объект кнопку наблюдения</summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    bool IsAvailable(IEntity entity);
  }
}
