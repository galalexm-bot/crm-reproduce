// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.EntityChangesLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>
  /// Абстрактный класс расширения для получения изменений, использует сервис <see cref="T:EleWise.ELMA.Events.Audit.IEntityModelHistoryService" />
  /// </summary>
  [Component(EnableInterceptiors = false)]
  public abstract class EntityChangesLoader : IEntityChangesLoader
  {
    internal static EntityChangesLoader eibS27hGDu5VEsHxL5Fu;

    protected IEntityModelHistoryService EntityModelHistoryService => Locator.GetServiceNotNull<IEntityModelHistoryService>();

    /// <summary>
    /// Поддерживается ли тип сущности данной точкой расширения
    /// </summary>
    /// <param name="typeUid">Идентификатор типа сущности</param>
    /// <returns><c>true</c>, если поддерживается</returns>
    public abstract bool IsTypeSupported(Guid typeUid);

    /// <summary>Получить измененные сущности за период</summary>
    /// <param name="typeUid">Идентификатор типа сущности</param>
    /// <param name="fromDateTime">Начало периода (включительно)</param>
    /// <param name="selectExpression">Запрос на языке EQL</param>
    /// <returns>Коллекция измененных сущностей</returns>
    public virtual IEnumerable<IEntityModelHistoryItem> LoadChanges(
      Guid typeUid,
      DateTime? fromDateTime,
      string selectExpression = null)
    {
      return this.EntityModelHistoryService.Find(typeUid, fromDateTime, selectExpression);
    }

    protected EntityChangesLoader()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool B2WBV3hGtbkWU0ioZpWT() => EntityChangesLoader.eibS27hGDu5VEsHxL5Fu == null;

    internal static EntityChangesLoader UUGoLohGw7i1RGFcPmew() => EntityChangesLoader.eibS27hGDu5VEsHxL5Fu;
  }
}
