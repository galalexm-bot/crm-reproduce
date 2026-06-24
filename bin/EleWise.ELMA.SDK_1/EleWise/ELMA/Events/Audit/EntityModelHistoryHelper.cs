// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.EntityModelHistoryHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Events.Audit
{
  public static class EntityModelHistoryHelper
  {
    private static EntityModelHistoryHelper U62o6WGUFGeiDgXQe4Ld;

    public static IEntity ToEntity(this IEntityModelHistoryItem self)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (self != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (IEntity) null;
label_3:
      return EntityModelHistoryHelper.yIjVP3GUheK6x24BdQgV((object) ModelHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(EntityModelHistoryHelper.CgeIMhGUoFsfYEgkEvh5((object) self))), EntityModelHistoryHelper.dxYThIGUbHLdFH8S2N8o((object) self)) as IEntity;
    }

    [Obsolete("Метод устарел", true)]
    public static IEnumerable<WebData> ReturnWebData(
      IEnumerable<IEntityModelHistoryItem> entityModelHistoryItems,
      Func<PropertyMetadata, bool> propertyFilter,
      Func<TablePartMetadata, bool> tablePartFilter)
    {
      return EntityModelHistoryHelper.ReturnWebData(entityModelHistoryItems, propertyFilter, (Func<ITablePartMetadata, bool>) (m => tablePartFilter((TablePartMetadata) m)));
    }

    /// <summary>Возвращает веб-данные</summary>
    /// <param name="entityModelHistoryItems">Список элементов истории изменения сущности</param>
    /// <param name="propertyFilter">Фильтр свойств</param>
    /// <param name="tablePartFilter">Фильтр табличных данных</param>
    public static IEnumerable<WebData> ReturnWebData(
      IEnumerable<IEntityModelHistoryItem> entityModelHistoryItems,
      Func<PropertyMetadata, bool> propertyFilter = null,
      Func<ITablePartMetadata, bool> tablePartFilter = null)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<WebData>) new EntityModelHistoryHelper.\u003CReturnWebData\u003Ed__2(-2)
      {
        \u003C\u003E3__entityModelHistoryItems = entityModelHistoryItems,
        \u003C\u003E3__propertyFilter = propertyFilter,
        \u003C\u003E3__tablePartFilter = tablePartFilter
      };
    }

    private static WebData GetEntityWebData(
      IEnumerable<IEntityModelHistoryItem> historyItem,
      Func<PropertyMetadata, bool> propertyFilter = null,
      Func<ITablePartMetadata, bool> tablePartFilter = null)
    {
      IEntityModelHistoryItem modelHistoryItem = historyItem.First<IEntityModelHistoryItem>();
      IEntity entity = ModelHelper.GetEntity(modelHistoryItem.ObjectTypeUid, modelHistoryItem.ObjectUid);
      return entity == null ? (WebData) null : WebData.CreateFromEntity(entity, propertyFilter, tablePartFilter);
    }

    private static WebData GetDeletedWebData(IEnumerable<IEntityModelHistoryItem> historyItem)
    {
      IEntityModelHistoryItem modelHistoryItem = historyItem.First<IEntityModelHistoryItem>();
      return WebData.CreateForDeleted(modelHistoryItem.ObjectTypeUid, modelHistoryItem.ObjectUid, (object) modelHistoryItem.ObjectId);
    }

    internal static Guid CgeIMhGUoFsfYEgkEvh5([In] object obj0) => ((IEntityModelHistoryItem) obj0).ObjectTypeUid;

    internal static Guid dxYThIGUbHLdFH8S2N8o([In] object obj0) => ((IEntityModelHistoryItem) obj0).ObjectUid;

    internal static object yIjVP3GUheK6x24BdQgV([In] object obj0, Guid uid) => ((IEntityManager) obj0).LoadOrNull(uid);

    internal static bool GdGExFGUBwiaaqGuAbqb() => EntityModelHistoryHelper.U62o6WGUFGeiDgXQe4Ld == null;

    internal static EntityModelHistoryHelper MMpC8KGUWYcL4MpG4PvB() => EntityModelHistoryHelper.U62o6WGUFGeiDgXQe4Ld;
  }
}
