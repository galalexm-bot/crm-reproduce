// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IAuditManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>Менеджер аудита</summary>
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IAuditManager
  {
    /// <summary>Получить список объектов</summary>
    /// <returns>Список объектов</returns>
    IEnumerable<IAuditObject> GetObjects();

    /// <summary>Получить объект по уникальному идентификатору</summary>
    /// <param name="uid">Уникальный идентификатор объекта</param>
    /// <returns>ОБъект. Если не найден - null</returns>
    IAuditObject GetObject(Guid uid);

    /// <summary>Получить список действий объекта</summary>
    /// <param name="obj">Объект</param>
    /// <returns>Список действий объекта</returns>
    IEnumerable<IAuditAction> GetActions(IAuditObject obj);

    /// <summary>
    /// Получить действие объекта по уникальному идентификатору
    /// </summary>
    /// <param name="obj">Объект</param>
    /// <param name="uid">Уникальный идентификатор объекта</param>
    /// <returns>Действие. Если не найдено - null</returns>
    IAuditAction GetAction(IAuditObject obj, Guid uid);

    /// <summary>
    /// Получить действие объекта по уникальному идентификатору
    /// </summary>
    /// <param name="uid">Уникальный идентификатор</param>
    /// <returns>Действие. Если не найдено - null</returns>
    IAuditAction GetAction(Guid uid);
  }
}
