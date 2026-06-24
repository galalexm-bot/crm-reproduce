// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.IEntityManagerExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Расширения IEntityManager</summary>
  public static class IEntityManagerExtensions
  {
    internal static IEntityManagerExtensions XkGxIohQGX9TGDpQo0rs;

    /// <summary>Найти по условию одну запись или вернуть null</summary>
    public static T Get<T>(this IEntityManager<T> manager, Expression<Func<T, bool>> predicate) where T : class, IEntity => manager.Find(predicate, FetchOptions.First).SingleOrDefault<T>();

    /// <summary>Найти по фильтру одну запись или вернуть null</summary>
    public static T Get<T>(this IEntityManager<T> manager, IEntityFilter filter) where T : IEntity => manager.Find(filter, FetchOptions.First).SingleOrDefault<T>();

    /// <summary>Узнать о наличии объектов</summary>
    /// <param name="manager">Менеджер</param>
    public static bool Exists(this IEntityManager manager)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (manager is IEntityExistsManager entityExistsManager)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return entityExistsManager.Exists();
label_3:
      return IEntityManagerExtensions.YhorkthQQx28bQYfOsYA((object) manager) > 0L;
    }

    /// <summary>Узнать о наличии объектов, удовлетворяющих фильтру</summary>
    /// <param name="manager">Менеджер</param>
    /// <param name="filter">Фильтр</param>
    public static bool Exists(this IEntityManager manager, IEntityFilter filter)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (manager is IEntityExistsManager entityExistsManager)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return IEntityManagerExtensions.bvu97bhQCdpFZN7HVLUh((object) entityExistsManager, (object) filter);
label_3:
      return manager.Count(filter) > 0L;
    }

    internal static long YhorkthQQx28bQYfOsYA([In] object obj0) => ((IEntityManager) obj0).Count();

    internal static bool m5cym9hQEYC30iuOl7wn() => IEntityManagerExtensions.XkGxIohQGX9TGDpQo0rs == null;

    internal static IEntityManagerExtensions hrFE4JhQfvDEfq4DbMq8() => IEntityManagerExtensions.XkGxIohQGX9TGDpQo0rs;

    internal static bool bvu97bhQCdpFZN7HVLUh([In] object obj0, [In] object obj1) => ((IEntityExistsManager) obj0).Exists((IEntityFilter) obj1);
  }
}
