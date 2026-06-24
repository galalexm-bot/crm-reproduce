// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.RestrictionsBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Helpers
{
  public class RestrictionsBuilder<T>
  {
    internal readonly RestrictionList restrictions;
    internal static object yXsT6ehcyTB7eGXqKjNe;

    internal RestrictionsBuilder(RestrictionList restrictions)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.restrictions = restrictions;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Создать новое правило</summary>
    /// <returns></returns>
    public RestrictionBuilderSelectType<T> Rule()
    {
      Restriction restriction = new Restriction();
      this.restrictions.Add(restriction);
      return new RestrictionBuilderSelectType<T>(restriction, this);
    }

    internal static bool tBDEQOhcMj1Sq9OLGg9M() => RestrictionsBuilder<T>.yXsT6ehcyTB7eGXqKjNe == null;

    internal static object PnZvVchcJYh8ZI7Hha7u() => RestrictionsBuilder<T>.yXsT6ehcyTB7eGXqKjNe;
  }
}
