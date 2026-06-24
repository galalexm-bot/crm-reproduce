// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.BaseEntityActionHistoryCollectorRelated
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Events;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Базовый сборщик дополнительных данных для отображения истории по объекту.
  /// </summary>
  public abstract class BaseEntityActionHistoryCollectorRelated : 
    IEntityActionHistoryCollectorRelated
  {
    internal static BaseEntityActionHistoryCollectorRelated bXRXVQGLnL7XrxIPqe04;

    /// <inheritdoc />
    public virtual bool CanUse(long id, Guid actionObject)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (id > 0L)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return !actionObject.Equals(Guid.Empty);
label_3:
      return false;
    }

    /// <inheritdoc />
    public abstract IEnumerable<EntityActionEventArgs> CollectHistory(
      long id,
      Guid actionObject,
      IEnumerable<EntityActionEventArgs> relatedEventList,
      IEnumerable<HistoryCollectorRelatedModel> relatedObjectList);

    /// <inheritdoc />
    public abstract IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(
      long id,
      Guid actionObject);

    protected BaseEntityActionHistoryCollectorRelated()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool I7fTQHGLOdqYPtVJtDuO() => BaseEntityActionHistoryCollectorRelated.bXRXVQGLnL7XrxIPqe04 == null;

    internal static BaseEntityActionHistoryCollectorRelated kyut3VGL2mLNQYLIvqVH() => BaseEntityActionHistoryCollectorRelated.bXRXVQGLnL7XrxIPqe04;
  }
}
