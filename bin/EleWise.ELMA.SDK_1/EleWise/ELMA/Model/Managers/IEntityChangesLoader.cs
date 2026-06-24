// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.IEntityChangesLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>
  /// Точка расширения для получения измененных сущностей за период
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IEntityChangesLoader
  {
    /// <summary>
    /// Поддерживается ли тип сущности данной точкой расширения
    /// </summary>
    /// <param name="typeUid">Идентификатор типа сущности</param>
    /// <returns><c>true</c>, если поддерживается</returns>
    bool IsTypeSupported(Guid typeUid);

    /// <summary>Получить измененные сущности за период</summary>
    /// <param name="typeUid">Идентификатор типа сущности</param>
    /// <param name="fromDateTime">Начало периода (включительно)</param>
    /// <param name="selectExpression">Запрос на языке EQL</param>
    /// <returns>Коллекция измененных сущностей</returns>
    IEnumerable<IEntityModelHistoryItem> LoadChanges(
      Guid typeUid,
      DateTime? fromDateTime,
      string selectExpression = null);
  }
}
