// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.Impl.DefaultEntityActionEventAggregator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Events.Audit.Impl
{
  /// <summary>Агрегатор событий по умолчанию</summary>
  /// <remarks>
  /// Срабатывает первым из всех агрегаторов и записывает результаты для всех событий из списка.
  /// </remarks>
  [Component(Order = -1000000)]
  public class DefaultEntityActionEventAggregator : IEntityActionEventAggregator
  {
    internal static DefaultEntityActionEventAggregator DvpMQQGcOoe7TdyLleF0;

    /// <summary>
    /// Аггрегировать события в списке (убрать дублирующие, объединить общие события)
    /// </summary>
    /// <param name="eventList">Текущий список событий в рамках транзакции</param>
    /// <param name="previousResults">Список результатов выполнения предыдущих аггрегаторов</param>
    /// <returns>Результаты выполнения</returns>
    public IEnumerable<ActionEventAggregatorResult> Aggregate(
      IList<EntityActionEventArgs> eventList,
      IEnumerable<ActionEventAggregatorResult> previousResults)
    {
      List<ActionEventAggregatorResult> aggregatorResultList = new List<ActionEventAggregatorResult>(eventList.Count);
      HashSet<string> stringSet = new HashSet<string>();
      foreach (EntityActionEventArgs entityActionEventArgs in (IEnumerable<EntityActionEventArgs>) eventList)
      {
        string eventKey = this.GetEventKey(entityActionEventArgs);
        if (eventKey == null || stringSet.Contains(eventKey))
        {
          aggregatorResultList.Add(new ActionEventAggregatorResult((IEntityActionEventAggregator) this, entityActionEventArgs, false));
        }
        else
        {
          stringSet.Add(eventKey);
          aggregatorResultList.Add(new ActionEventAggregatorResult((IEntityActionEventAggregator) this, entityActionEventArgs, true));
        }
      }
      return (IEnumerable<ActionEventAggregatorResult>) aggregatorResultList;
    }

    /// <summary>
    /// Определяет, является ли данное событие дубликатом ранее обработанных
    /// </summary>
    /// <param name="event">Событие</param>
    /// <param name="results">Текущие обработанные результаты</param>
    /// <returns><c>true</c>, если событие является дублирующим</returns>
    protected virtual bool IsDuplicate(
      EntityActionEventArgs @event,
      IEnumerable<ActionEventAggregatorResult> results)
    {
      return @event == null || results.Any<ActionEventAggregatorResult>((Func<ActionEventAggregatorResult, bool>) (r =>
      {
        int num1 = 5;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 2:
                // ISSUE: reference to a compiler-generated method
                if (DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.YojYmo8VI1xtDdMP2owf((object) r.EventArgs) != null)
                {
                  num2 = 28;
                  continue;
                }
                goto case 23;
              case 3:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!((IIdentified) DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.yPTC6a8VRoXHKGVj3w2g(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL((object) r))).GetId().Equals(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.tbojCR8VirC28ejcAWBf(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.yPTC6a8VRoXHKGVj3w2g((object) @event))))
                  goto case 7;
                else
                  goto label_8;
              case 4:
                // ISSUE: reference to a compiler-generated method
                if (DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL((object) r) == null)
                {
                  num2 = 20;
                  continue;
                }
                goto case 21;
              case 5:
                if (r != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 4 : 3;
                  continue;
                }
                goto label_22;
              case 6:
              case 24:
              case 30:
                goto label_45;
              case 7:
              case 11:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.yPTC6a8VRoXHKGVj3w2g(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL((object) r)) == null)
                {
                  num2 = 29;
                  continue;
                }
                goto label_22;
              case 8:
                // ISSUE: reference to a compiler-generated method
                if (DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.dVSVrU8VSKsdm8950sj1((object) @event) == null)
                {
                  num2 = 13;
                  continue;
                }
                goto case 18;
              case 9:
              case 15:
                goto label_21;
              case 10:
              case 16:
              case 17:
              case 20:
              case 33:
                goto label_22;
              case 12:
              case 13:
              case 19:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.dVSVrU8VSKsdm8950sj1(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL((object) r)) != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 17 : 1;
                  continue;
                }
                goto label_31;
              case 14:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.yPTC6a8VRoXHKGVj3w2g(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL((object) r)) == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 7 : 7;
                  continue;
                }
                goto case 26;
              case 18:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.tbojCR8VirC28ejcAWBf(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.dVSVrU8VSKsdm8950sj1(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL((object) r))).Equals(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.tbojCR8VirC28ejcAWBf(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.dVSVrU8VSKsdm8950sj1((object) @event))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 19 : 4;
                  continue;
                }
                goto case 14;
              case 21:
                // ISSUE: reference to a compiler-generated method
                if (((AuditEventArgs) DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL((object) r)).Object == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 17 : 30;
                  continue;
                }
                goto case 22;
              case 22:
                // ISSUE: reference to a compiler-generated method
                if (DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.Y7U02s8V8YbrJ2TKL2on((object) @event) == null)
                {
                  num2 = 24;
                  continue;
                }
                break;
              case 23:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.YojYmo8VI1xtDdMP2owf(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL((object) r)) != null)
                {
                  num2 = 33;
                  continue;
                }
                goto case 25;
              case 25:
                if (@event.Action == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 23 : 32;
                  continue;
                }
                goto label_22;
              case 26:
                // ISSUE: reference to a compiler-generated method
                if (DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.yPTC6a8VRoXHKGVj3w2g((object) @event) != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 3 : 3;
                  continue;
                }
                goto case 7;
              case 27:
                // ISSUE: reference to a compiler-generated method
                if (DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.Y7U02s8V8YbrJ2TKL2on((object) @event) != null)
                {
                  num2 = 10;
                  continue;
                }
                goto case 1;
              case 28:
                // ISSUE: reference to a compiler-generated method
                if (DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.YojYmo8VI1xtDdMP2owf((object) @event) != null)
                {
                  num2 = 31;
                  continue;
                }
                goto case 23;
              case 29:
                // ISSUE: reference to a compiler-generated method
                if (DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.yPTC6a8VRoXHKGVj3w2g((object) @event) != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 16 : 2;
                  continue;
                }
                goto label_21;
              case 31:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.KOcWXA8VVlRiWKgRsDP6(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.YojYmo8VI1xtDdMP2owf(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL((object) r))) == DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.KOcWXA8VVlRiWKgRsDP6(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.YojYmo8VI1xtDdMP2owf((object) @event))))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 23 : 23;
                  continue;
                }
                goto case 32;
              case 32:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.dVSVrU8VSKsdm8950sj1(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL((object) r)) == null)
                {
                  num2 = 12;
                  continue;
                }
                goto case 8;
              case 34:
                goto label_31;
            }
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.y5RCu58Vuh64yOxafEya(r.EventArgs.Object.Uid, DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.aOkls78VZYvyYRKXcFDl((object) @event.Object)))
              num2 = 2;
            else
              goto label_45;
          }
label_8:
          num1 = 15;
          continue;
label_31:
          if (@event.New == null)
          {
            num1 = 14;
            continue;
          }
          goto label_22;
label_45:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.Y7U02s8V8YbrJ2TKL2on(DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.rI56098Vv7D4SX9wHGaL((object) r)) == null)
            num1 = 27;
          else
            goto label_22;
        }
label_21:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.FPQo438VqfKJnuIJwhb1((object) r.EventArgs) == DefaultEntityActionEventAggregator.\u003C\u003Ec__DisplayClass1_0.FPQo438VqfKJnuIJwhb1((object) @event);
label_22:
        return false;
      }));
    }

    /// <summary>Получить ключ события</summary>
    /// <param name="event">Событие</param>
    /// <returns>Ключ</returns>
    protected string GetEventKey(EntityActionEventArgs @event)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (@event == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) null;
label_5:
      string[] strArray = new string[5];
      Guid guid;
      string empty1;
      if (DefaultEntityActionEventAggregator.cnHIXGGcPm5mxWMRZr8J((object) @event) == null)
      {
        empty1 = string.Empty;
      }
      else
      {
        guid = ((IAuditObject) DefaultEntityActionEventAggregator.cnHIXGGcPm5mxWMRZr8J((object) @event)).Uid;
        empty1 = guid.ToString();
      }
      strArray[0] = empty1;
      string empty2;
      if (@event.Action == null)
      {
        empty2 = string.Empty;
      }
      else
      {
        guid = DefaultEntityActionEventAggregator.jqr5PNGcNktaUBbRiv5K(DefaultEntityActionEventAggregator.OVjFkNGc17LI5AMC7ckd((object) @event));
        empty2 = guid.ToString();
      }
      strArray[1] = empty2;
      strArray[2] = DefaultEntityActionEventAggregator.eQhv7LGc3Xqvakp7DcJp((object) @event) == null || DefaultEntityActionEventAggregator.nQLF7hGcphRfUGlAxVom(DefaultEntityActionEventAggregator.eQhv7LGc3Xqvakp7DcJp((object) @event)) == null ? string.Empty : @event.New.GetId().ToString();
      strArray[3] = DefaultEntityActionEventAggregator.U7SnqRGcaNerPQMDX98P((object) @event) == null || DefaultEntityActionEventAggregator.nQLF7hGcphRfUGlAxVom(DefaultEntityActionEventAggregator.U7SnqRGcaNerPQMDX98P((object) @event)) == null ? string.Empty : DefaultEntityActionEventAggregator.nQLF7hGcphRfUGlAxVom(DefaultEntityActionEventAggregator.U7SnqRGcaNerPQMDX98P((object) @event)).ToString();
      strArray[4] = @event.ActionAuthor != null ? DefaultEntityActionEventAggregator.UAAX8JGcDPBA5ARaWpTL((object) @event).GetHashCode().ToString() : string.Empty;
      return (string) DefaultEntityActionEventAggregator.D71l9hGct537OsFbdjQr((object) strArray);
    }

    public DefaultEntityActionEventAggregator()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object cnHIXGGcPm5mxWMRZr8J([In] object obj0) => (object) ((AuditEventArgs) obj0).Object;

    internal static object OVjFkNGc17LI5AMC7ckd([In] object obj0) => (object) ((AuditEventArgs) obj0).Action;

    internal static Guid jqr5PNGcNktaUBbRiv5K([In] object obj0) => ((IAuditAction) obj0).Uid;

    internal static object eQhv7LGc3Xqvakp7DcJp([In] object obj0) => (object) ((EntityActionEventArgs) obj0).New;

    internal static object nQLF7hGcphRfUGlAxVom([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static object U7SnqRGcaNerPQMDX98P([In] object obj0) => (object) ((EntityActionEventArgs) obj0).Old;

    internal static object UAAX8JGcDPBA5ARaWpTL([In] object obj0) => (object) ((EntityActionEventArgs) obj0).ActionAuthor;

    internal static object D71l9hGct537OsFbdjQr([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static bool BXOy5ZGc2CpEF0CmEENt() => DefaultEntityActionEventAggregator.DvpMQQGcOoe7TdyLleF0 == null;

    internal static DefaultEntityActionEventAggregator RRam1nGce9SooAnMmI8Q() => DefaultEntityActionEventAggregator.DvpMQQGcOoe7TdyLleF0;
  }
}
