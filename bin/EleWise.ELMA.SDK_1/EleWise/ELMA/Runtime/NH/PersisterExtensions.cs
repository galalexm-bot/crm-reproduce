// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.PersisterExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  public static class PersisterExtensions
  {
    private static PersisterExtensions DP160VW6G6p2qVkHkRJk;

    public static RT Get<ET, RT>(
      this IEntityPersister persister,
      object[] state,
      Expression<Func<ET, RT>> expression)
    {
      if (state == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841521802));
      if (expression == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70040796));
      if (!(expression.Body is MemberExpression body))
        throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218619162));
      string name = body.Member.Name;
      return persister.Get<RT>(state, name);
    }

    public static RT Get<RT>(this IEntityPersister persister, object[] state, string memberName)
    {
      int index = Array.IndexOf<string>(persister.PropertyNames, memberName);
      return index >= 0 ? (RT) state[index] : throw new InvalidOperationException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654174425) + memberName);
    }

    public static void Set<ET, RT>(
      this IEntityPersister persister,
      object[] state,
      ET entity,
      Expression<Func<ET, RT>> expression)
    {
      if (state == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583605298));
      if (expression == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234302956));
      RT rt = expression.Compile()(entity);
      string memberName = LinqUtils.NameOf<ET, RT>(expression);
      persister.Set(state, memberName, (object) rt);
    }

    public static void Set<ET, RT>(
      this IEntityPersister persister,
      object[] state,
      Expression<Func<ET, RT>> expression,
      RT value)
    {
      if (state == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1787009678));
      string memberName = expression != null ? LinqUtils.NameOf<ET, RT>(expression) : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304607817));
      persister.Set(state, memberName, (object) value);
    }

    public static void Set(
      this IEntityPersister persister,
      object[] state,
      string memberName,
      object value)
    {
      int num = 1;
      int index;
      while (true)
      {
        switch (num)
        {
          case 1:
            index = Array.IndexOf<string>((string[]) PersisterExtensions.sjXmyaW6QgP4kdPP0Mtj((object) persister), memberName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_6;
          default:
            if (index < 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 3 : 3;
              continue;
            }
            state[index] = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:
      return;
label_6:
      throw new InvalidOperationException((string) PersisterExtensions.yTXHtaW6CQK1fgjBr207(-2138160520 ^ -2138283528) + memberName);
    }

    internal static object sjXmyaW6QgP4kdPP0Mtj([In] object obj0) => (object) ((IEntityPersister) obj0).PropertyNames;

    internal static object yTXHtaW6CQK1fgjBr207(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool JoHZjEW6EaVevqeHDCoD() => PersisterExtensions.DP160VW6G6p2qVkHkRJk == null;

    internal static PersisterExtensions hWJieiW6fBpHEpguiX6x() => PersisterExtensions.DP160VW6G6p2qVkHkRJk;
  }
}
