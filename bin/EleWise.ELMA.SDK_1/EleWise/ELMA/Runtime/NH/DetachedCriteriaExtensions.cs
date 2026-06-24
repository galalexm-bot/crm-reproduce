// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.DetachedCriteriaExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Runtime.NH
{
  public static class DetachedCriteriaExtensions
  {
    private static DetachedCriteriaExtensions grSHAQWpaQMlKveRF7fv;

    public static ICriteria Adapt(this DetachedCriteria criteria, ISession session)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (criteria == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (ICriteria) null;
label_5:
      return (ICriteria) new DetachedCriteriaAdapter(criteria, session);
    }

    internal static bool YSaF3BWpDlfZqmcO6AZe() => DetachedCriteriaExtensions.grSHAQWpaQMlKveRF7fv == null;

    internal static DetachedCriteriaExtensions uNRMZ1Wpt29bfIbM5KBX() => DetachedCriteriaExtensions.grSHAQWpaQMlKveRF7fv;
  }
}
