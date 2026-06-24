// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Comparers.NHComparer`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Types.Comparers
{
  /// <summary>
  /// Сравниватель для маппинга NHibernate для свойств - сортированных списоков сущностей
  /// </summary>
  /// <typeparam name="TEntity">Тип сущности, содержащей свойство с сортировкой</typeparam>
  /// <typeparam name="TSource">Тип элемента списка свойства с сортировкой</typeparam>
  public sealed class NHComparer<TEntity, TSource> : IComparer, IComparer<TSource>, IComparerInternal
  {
    private static readonly IDictionary<Type, ConcurrentDictionary<string, IComparer>> Comparers;
    private IComparer comparerInternal;
    internal static object XcRWXPoUC0BV0FdoEqY2;

    /// <summary>ctor</summary>
    public NHComparer()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    int IComparer.Compare(object x, object y) => this.comparerInternal.Compare(x, y);

    int IComparer<TSource>.Compare(TSource x, TSource y) => this.comparerInternal.Compare((object) x, (object) y);

    void IComparerInternal.SetRole(string role)
    {
      int num1 = 3;
      string role1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_6;
          case 1:
            IDictionary<Type, ConcurrentDictionary<string, IComparer>> comparers = NHComparer<TEntity, TSource>.Comparers;
            Type key = typeof (TEntity);
            // ISSUE: reference to a compiler-generated field
            Func<Type, ConcurrentDictionary<string, IComparer>> func = NHComparer<TEntity, TSource>.\u003C\u003Ec.\u003C\u003E9__5_0;
            Func<Type, ConcurrentDictionary<string, IComparer>> valueFactory;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              NHComparer<TEntity, TSource>.\u003C\u003Ec.\u003C\u003E9__5_0 = valueFactory = (Func<Type, ConcurrentDictionary<string, IComparer>>) (t => new ConcurrentDictionary<string, IComparer>());
            }
            else
              goto label_9;
label_8:
            this.comparerInternal = comparers.GetOrAdd<Type, ConcurrentDictionary<string, IComparer>>(key, valueFactory).GetOrAdd(role1, (Func<string, IComparer>) (r =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_2;
                }
              }
label_2:
              EntityMetadata entityMetadata = (EntityMetadata) MetadataLoader.LoadMetadata(typeof (TEntity));
              string propertyName = role1.Substring(role1.LastIndexOf('.') + 1);
              return entityMetadata.Properties.First<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Name == propertyName)).CreateComparer();
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
label_9:
            valueFactory = func;
            goto label_8;
          case 2:
            role1 = role;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
            continue;
          case 3:
            num1 = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_6:
      return;
label_2:;
    }

    static NHComparer()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            NHComparer<TEntity, TSource>.Comparers = PublishCacheContext.CreateCache<Type, ConcurrentDictionary<string, IComparer>>((Action<IDictionary<Type, ConcurrentDictionary<string, IComparer>>, Type, Guid>) ((c, t, g) => c.Remove(t)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool R83RkYoUvY02B2DJt9rK() => NHComparer<TEntity, TSource>.XcRWXPoUC0BV0FdoEqY2 == null;

    internal static object nAl2eFoU8GDaDId1jB3w() => NHComparer<TEntity, TSource>.XcRWXPoUC0BV0FdoEqY2;
  }
}
