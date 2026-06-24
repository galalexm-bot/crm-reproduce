// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.ConvertedDetachedCriteria
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Impl;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  public class ConvertedDetachedCriteria : DetachedCriteria
  {
    private static ConvertedDetachedCriteria uLPbIeWDGH1E6NMDq1wY;

    public ConvertedDetachedCriteria(ICriteria criteria)
    {
      ConvertedDetachedCriteria.lsGGBTWDQaylkrEn2enb();
      // ISSUE: explicit constructor call
      base.\u002Ector((CriteriaImpl) criteria, criteria);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            ConvertedDetachedCriteria.gZ2A5nWDCOangUykZFbA((object) (CriteriaImpl) criteria, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    internal static void lsGGBTWDQaylkrEn2enb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void gZ2A5nWDCOangUykZFbA([In] object obj0, [In] object obj1) => ((CriteriaImpl) obj0).Session = (ISessionImplementor) obj1;

    internal static bool emh5khWDEqW9e1ilrVtP() => ConvertedDetachedCriteria.uLPbIeWDGH1E6NMDq1wY == null;

    internal static ConvertedDetachedCriteria yk9kOxWDfJW5NxxTbS9N() => ConvertedDetachedCriteria.uLPbIeWDGH1E6NMDq1wY;
  }
}
