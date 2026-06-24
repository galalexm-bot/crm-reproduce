// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.HeaderButtonsServices.IHeaderButtonsPaperPinIsAvailableService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using System;

namespace EleWise.ELMA.ExtensionPoints.HeaderButtonsServices
{
  /// <summary>
  /// Сервис проверки поддержки объектом булавки в кнопках заголовка страницы
  /// </summary>
  public interface IHeaderButtonsPaperPinIsAvailableService
  {
    /// <summary>Поддерживает ли объект булавку</summary>
    /// <param name="typeUid"></param>
    /// <param name="entityId"></param>
    /// <returns></returns>
    bool IsAvailable(Guid typeUid, object entityId);

    /// <summary>Поддерживает ли объект булавку</summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    bool IsAvailable(IEntity entity);
  }
}
