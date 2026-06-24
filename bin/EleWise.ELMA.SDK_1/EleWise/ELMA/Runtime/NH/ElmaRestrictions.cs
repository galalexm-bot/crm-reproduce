// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.ElmaRestrictions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// Класс с дополнительными статическими методами для создания объектов <see cref="T:NHibernate.Criterion.ICriterion" />
  /// </summary>
  public class ElmaRestrictions
  {
    private static IRuntimeApplication runtimeApplication;
    internal static ElmaRestrictions lv00dAW3Mg4sPZx6QYtJ;

    private static bool CaseSensitivity => SR.GetSetting<bool>((string) ElmaRestrictions.rV87EBW3d3VPdmxKLyEZ(~541731958 ^ -541602887), true);

    private static string LikeValue(object value)
    {
      int num = 1;
      IRuntimeApplication runtimeApplication1;
      while (true)
      {
        switch (num)
        {
          case 1:
            runtimeApplication1 = ElmaRestrictions.runtimeApplication;
            if (runtimeApplication1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_5:
      IRuntimeApplication runtimeApplication2;
      ElmaRestrictions.runtimeApplication = runtimeApplication2 = Locator.GetServiceNotNull<IRuntimeApplication>();
label_6:
      Dialect dialect = ((ITransformationProvider) ElmaRestrictions.WFAg6yW3ltt7uiVFfN5f((object) runtimeApplication2)).Dialect;
      object obj1 = value;
      object obj2 = obj1 == null ? (object) string.Empty : obj1;
      return (string) ElmaRestrictions.ME3XCPW3rFcZYEdhM7r0((object) dialect, obj2);
label_2:
      runtimeApplication2 = runtimeApplication1;
      goto label_6;
    }

    private static string LikeValue(object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_2;
        }
      }
label_2:
      string str = (string) null;
      goto label_6;
label_5:
      str = value.ToString();
label_6:
      return ElmaRestrictions.LikeValue((object) str);
    }

    /// <summary>
    /// Применить ограничение "like" к свойству в зависимости от настроек чувствительности к регистру в БД
    /// </summary>
    /// <param name="propertyName">Название свойства в классе.</param>
    /// <param name="value">Значение для свойства.</param>
    public static AbstractCriterion InsensitiveLike(string propertyName, object value)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (ElmaRestrictions.MD9CJkW3gAfpS27aDfd0())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (AbstractCriterion) ElmaRestrictions.S7XiR0W3jaSHGmqti5rL((object) propertyName, ElmaRestrictions.oWBkVxW35JIFYshYi2KY(value));
label_3:
      return (AbstractCriterion) ElmaRestrictions.C3vgHZW3YW2w2899YOM7((object) propertyName, ElmaRestrictions.oWBkVxW35JIFYshYi2KY(value));
    }

    /// <summary>
    /// Применить ограничение "like" к проекции в зависимости от настроек чувствительности к регистру в БД
    /// </summary>
    /// <param name="projection"><see cref="T:NHibernate.Criterion.IProjection" />.</param>
    /// <param name="value">Значение для свойства.</param>
    public static AbstractCriterion InsensitiveLike(IProjection projection, object value)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (ElmaRestrictions.MD9CJkW3gAfpS27aDfd0())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (AbstractCriterion) ElmaRestrictions.gGkZQbW3LqigyYH95hcH((object) projection, ElmaRestrictions.oWBkVxW35JIFYshYi2KY(value));
label_5:
      return (AbstractCriterion) ElmaRestrictions.hYXSKgW3UWKUgI03rsZ6((object) projection, ElmaRestrictions.oWBkVxW35JIFYshYi2KY(value));
    }

    /// <summary>
    /// Применить ограничение "like" к проекции в зависимости от настроек чувствительности к регистру в БД
    /// </summary>
    /// <param name="projection"><see cref="T:NHibernate.Criterion.IProjection" />.</param>
    /// <param name="value">Значение для свойства.</param>
    /// <param name="matchMode"><see cref="T:NHibernate.Criterion.MatchMode" />.</param>
    public static AbstractCriterion InsensitiveLike(
      IProjection projection,
      string value,
      MatchMode matchMode)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ElmaRestrictions.CaseSensitivity)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return (AbstractCriterion) ElmaRestrictions.TCr3T1W3cl0FPrJt9HZT((object) projection, ElmaRestrictions.iHSn2rW3s7VFsxc20sKS((object) value), (object) matchMode);
label_5:
      return (AbstractCriterion) ElmaRestrictions.obgHv2W3zNQWe3ZA1U1e((object) projection, ElmaRestrictions.iHSn2rW3s7VFsxc20sKS((object) value), (object) matchMode);
    }

    /// <summary>
    /// Применить ограничение "like" к свойству в зависимости от настроек чувствительности к регистру в БД
    /// </summary>
    /// <param name="propertyName">Название свойства в классе.</param>
    /// <param name="value">Значение для свойства.</param>
    /// <param name="matchMode"><see cref="T:NHibernate.Criterion.MatchMode" />.</param>
    public static AbstractCriterion InsensitiveLike(
      string propertyName,
      string value,
      MatchMode matchMode)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (ElmaRestrictions.MD9CJkW3gAfpS27aDfd0())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (AbstractCriterion) ElmaRestrictions.T1UT0oWpFgLousgIMwOL((object) propertyName, ElmaRestrictions.iHSn2rW3s7VFsxc20sKS((object) value), (object) matchMode);
label_5:
      return (AbstractCriterion) ElmaRestrictions.Y9HBJYWpBQlSQMCkQfDZ((object) propertyName, (object) ElmaRestrictions.LikeValue((object) value), (object) matchMode);
    }

    /// <summary>Применить ограничение "like" к свойству</summary>
    /// <param name="propertyName">Название свойства в классе.</param>
    /// <param name="value">Значение для свойства.</param>
    public static AbstractCriterion Like(string propertyName, object value) => (AbstractCriterion) ElmaRestrictions.S7XiR0W3jaSHGmqti5rL((object) propertyName, (object) ElmaRestrictions.LikeValue(value));

    /// <summary>Применить ограничение "like" к проекции</summary>
    /// <param name="projection"><see cref="T:NHibernate.Criterion.IProjection" />.</param>
    /// <param name="value">Значение для свойства.</param>
    public static AbstractCriterion Like(IProjection projection, object value) => (AbstractCriterion) ElmaRestrictions.gGkZQbW3LqigyYH95hcH((object) projection, (object) ElmaRestrictions.LikeValue(value));

    /// <summary>Применить ограничение "like" к проекции</summary>
    /// <param name="projection"><see cref="T:NHibernate.Criterion.IProjection" />.</param>
    /// <param name="value">Значение для свойства.</param>
    /// <param name="matchMode"><see cref="T:NHibernate.Criterion.MatchMode" />.</param>
    public static AbstractCriterion Like(IProjection projection, string value, MatchMode matchMode) => (AbstractCriterion) ElmaRestrictions.TCr3T1W3cl0FPrJt9HZT((object) projection, ElmaRestrictions.iHSn2rW3s7VFsxc20sKS((object) value), (object) matchMode);

    /// <summary>Применить ограничение "like" к свойству</summary>
    /// <param name="propertyName">Название свойства в классе.</param>
    /// <param name="value">Значение для свойства.</param>
    /// <param name="matchMode"><see cref="T:NHibernate.Criterion.MatchMode" />.</param>
    public static AbstractCriterion Like(string propertyName, string value, MatchMode matchMode) => (AbstractCriterion) Restrictions.Like(propertyName, ElmaRestrictions.LikeValue((object) value), matchMode);

    public ElmaRestrictions()
    {
      ElmaRestrictions.WRwQm9WpWR2coHMELqIl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object rV87EBW3d3VPdmxKLyEZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool nHlKIIW3JoNoktd9R7jv() => ElmaRestrictions.lv00dAW3Mg4sPZx6QYtJ == null;

    internal static ElmaRestrictions DNsGRiW39M9eofghWPf3() => ElmaRestrictions.lv00dAW3Mg4sPZx6QYtJ;

    internal static object WFAg6yW3ltt7uiVFfN5f([In] object obj0) => (object) ((IRuntimeApplication) obj0).TransformationProvider;

    internal static object ME3XCPW3rFcZYEdhM7r0([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).LikeValue((string) obj1);

    internal static bool MD9CJkW3gAfpS27aDfd0() => ElmaRestrictions.CaseSensitivity;

    internal static object oWBkVxW35JIFYshYi2KY([In] object obj0) => (object) ElmaRestrictions.LikeValue(obj0);

    internal static object S7XiR0W3jaSHGmqti5rL([In] object obj0, [In] object obj1) => (object) Restrictions.Like((string) obj0, obj1);

    internal static object C3vgHZW3YW2w2899YOM7([In] object obj0, [In] object obj1) => (object) Restrictions.InsensitiveLike((string) obj0, obj1);

    internal static object gGkZQbW3LqigyYH95hcH([In] object obj0, [In] object obj1) => (object) Restrictions.Like((IProjection) obj0, obj1);

    internal static object hYXSKgW3UWKUgI03rsZ6([In] object obj0, [In] object obj1) => (object) Restrictions.InsensitiveLike((IProjection) obj0, obj1);

    internal static object iHSn2rW3s7VFsxc20sKS([In] object obj0) => (object) ElmaRestrictions.LikeValue(obj0);

    internal static object TCr3T1W3cl0FPrJt9HZT([In] object obj0, [In] object obj1, [In] object obj2) => (object) Restrictions.Like((IProjection) obj0, (string) obj1, (MatchMode) obj2);

    internal static object obgHv2W3zNQWe3ZA1U1e([In] object obj0, [In] object obj1, [In] object obj2) => (object) Restrictions.InsensitiveLike((IProjection) obj0, (string) obj1, (MatchMode) obj2);

    internal static object T1UT0oWpFgLousgIMwOL([In] object obj0, [In] object obj1, [In] object obj2) => (object) Restrictions.Like((string) obj0, (string) obj1, (MatchMode) obj2);

    internal static object Y9HBJYWpBQlSQMCkQfDZ([In] object obj0, [In] object obj1, [In] object obj2) => (object) Restrictions.InsensitiveLike((string) obj0, (string) obj1, (MatchMode) obj2);

    internal static void WRwQm9WpWR2coHMELqIl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
