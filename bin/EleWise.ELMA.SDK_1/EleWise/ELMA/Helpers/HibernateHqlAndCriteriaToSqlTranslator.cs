// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.HibernateHqlAndCriteriaToSqlTranslator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Impl;
using NHibernate.Loader.Criteria;
using NHibernate.Persister.Entity;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  public class HibernateHqlAndCriteriaToSqlTranslator
  {
    internal static HibernateHqlAndCriteriaToSqlTranslator O4kBGNhUJBUJxHip0JJ4;

    /// <summary>Возвращает код SQL для критерии.</summary>
    /// <param name="criteria"></param>
    /// <returns></returns>
    public static string ToSql(ICriteria criteria) => ((NHibernate.Loader.Loader) HibernateHqlAndCriteriaToSqlTranslator.WEqmqXhUlyXFgj2i4RoT((object) criteria)).SqlString.ToString();

    public static CriteriaImpl GetCriteriaImpl(ICriteria criteria)
    {
      int num1 = 4;
      CriteriaImpl criteriaImpl;
      DetachedCriteriaAdapter detachedCriteriaAdapter;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              goto label_8;
            case 3:
              goto label_3;
            case 4:
              criteriaImpl = criteria as CriteriaImpl;
              num2 = 3;
              continue;
            case 5:
              if (detachedCriteriaAdapter == null)
              {
                num2 = 2;
                continue;
              }
              goto label_7;
            case 6:
              detachedCriteriaAdapter = criteria as DetachedCriteriaAdapter;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 5;
              continue;
            default:
              goto label_7;
          }
        }
label_3:
        if (criteriaImpl == null)
          num1 = 6;
        else
          goto label_9;
      }
label_7:
      return HibernateHqlAndCriteriaToSqlTranslator.GetCriteriaImpl((ICriteria) HibernateHqlAndCriteriaToSqlTranslator.vep3oKhUgJkpR9DSjS5K((object) detachedCriteriaAdapter.DetachedCriteria, HibernateHqlAndCriteriaToSqlTranslator.aHIVjhhUrLexZcHQSc3G((object) detachedCriteriaAdapter)));
label_8:
      return (CriteriaImpl) null;
label_9:
      return criteriaImpl;
    }

    public static CriteriaLoader GetLoader(ICriteria criteria)
    {
      int num1 = 3;
      SessionImpl sessionImpl;
      ISessionFactoryImplementor factory;
      string[] strArray;
      CriteriaImpl rootCriteria;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              strArray = (string[]) HibernateHqlAndCriteriaToSqlTranslator.Cps5ZDhUUF2AyqvhnrF4((object) factory, HibernateHqlAndCriteriaToSqlTranslator.uZBQOIhULebEQkh8ZceI((object) rootCriteria));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            case 2:
              sessionImpl = (SessionImpl) HibernateHqlAndCriteriaToSqlTranslator.DhShA8hUjigYlHmC14tQ((object) rootCriteria);
              num2 = 4;
              continue;
            case 3:
              goto label_7;
            case 4:
              factory = (ISessionFactoryImplementor) HibernateHqlAndCriteriaToSqlTranslator.XHWp2ThUY88XaX1RJp4x((object) sessionImpl);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
              continue;
            default:
              goto label_4;
          }
        }
label_7:
        rootCriteria = (CriteriaImpl) HibernateHqlAndCriteriaToSqlTranslator.qX3ukjhU5GjUDpNXYp2Y((object) criteria);
        num1 = 2;
      }
label_4:
      return new CriteriaLoader((IOuterJoinLoadable) HibernateHqlAndCriteriaToSqlTranslator.pccO1shUs0Oma50tid0C((object) factory, (object) strArray[0]), factory, rootCriteria, strArray[0], sessionImpl.EnabledFilters);
    }

    public HibernateHqlAndCriteriaToSqlTranslator()
    {
      HibernateHqlAndCriteriaToSqlTranslator.Umt6oehUcPAik0nyatQo();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object WEqmqXhUlyXFgj2i4RoT([In] object obj0) => (object) HibernateHqlAndCriteriaToSqlTranslator.GetLoader((ICriteria) obj0);

    internal static bool Fthlv5hU9FCM2VGfGBqq() => HibernateHqlAndCriteriaToSqlTranslator.O4kBGNhUJBUJxHip0JJ4 == null;

    internal static HibernateHqlAndCriteriaToSqlTranslator GflHZMhUdgJTAUXTnnMu() => HibernateHqlAndCriteriaToSqlTranslator.O4kBGNhUJBUJxHip0JJ4;

    internal static object aHIVjhhUrLexZcHQSc3G([In] object obj0) => (object) ((DetachedCriteriaAdapter) obj0).Session;

    internal static object vep3oKhUgJkpR9DSjS5K([In] object obj0, [In] object obj1) => (object) ((DetachedCriteria) obj0).GetExecutableCriteria((ISession) obj1);

    internal static object qX3ukjhU5GjUDpNXYp2Y([In] object obj0) => (object) HibernateHqlAndCriteriaToSqlTranslator.GetCriteriaImpl((ICriteria) obj0);

    internal static object DhShA8hUjigYlHmC14tQ([In] object obj0) => (object) ((CriteriaImpl) obj0).Session;

    internal static object XHWp2ThUY88XaX1RJp4x([In] object obj0) => (object) ((SessionImpl) obj0).SessionFactory;

    internal static object uZBQOIhULebEQkh8ZceI([In] object obj0) => (object) ((CriteriaImpl) obj0).EntityOrClassName;

    internal static object Cps5ZDhUUF2AyqvhnrF4([In] object obj0, [In] object obj1) => (object) ((ISessionFactoryImplementor) obj0).GetImplementors((string) obj1);

    internal static object pccO1shUs0Oma50tid0C([In] object obj0, [In] object obj1) => (object) ((ISessionFactoryImplementor) obj0).GetEntityPersister((string) obj1);

    internal static void Umt6oehUcPAik0nyatQo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
