// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IAuditObjectProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Интерфейс провайдера, выдающего информацию о типах объектов
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IAuditObjectProvider
  {
    /// <summary>Получить список объектов</summary>
    /// <returns>Список объектов</returns>
    IEnumerable<IAuditObject> GetObjects();

    /// <summary>Получить объект по уникальному идентификатору</summary>
    /// <param name="uid">Уникальный идентификатор объекта</param>
    /// <returns>ОБъект. Если не найден - null</returns>
    IAuditObject GetObject(Guid uid);
  }
}
