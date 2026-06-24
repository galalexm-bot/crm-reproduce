// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.CloneHelperBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq;

namespace EleWise.ELMA.Helpers
{
  public class CloneHelperBuilder
  {
    private static CloneHelperBuilder eObpUehc6ZBKAJwmVHui;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="cloneObject">Клонируемый объект</param>
    /// <returns></returns>
    public static CloneHelperBuilder<T> Create<T>(T cloneObject) where T : class
    {
      CloneHelperBuilder<T> cloneHelperBuilder = new CloneHelperBuilder<T>(cloneObject);
      foreach (IEntityCopyRuleProvider copyRuleProvider in ComponentManager.Current.GetExtensionPoints<IEntityCopyRuleProvider>().Where<IEntityCopyRuleProvider>((Func<IEntityCopyRuleProvider, bool>) (p => p.CheckType((object) (T) cloneObject))))
        cloneHelperBuilder.Restrictions(new Action<RestrictionsBuilder<T>>(copyRuleProvider.InitRules<T>));
      return cloneHelperBuilder;
    }

    public CloneHelperBuilder()
    {
      CloneHelperBuilder.gWBl7Ahc76OAZFdGWjl3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void gWBl7Ahc76OAZFdGWjl3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool dHxEhBhcHA3Wlhi7tUW1() => CloneHelperBuilder.eObpUehc6ZBKAJwmVHui == null;

    internal static CloneHelperBuilder YN7yEWhcAE7kraQIFFUL() => CloneHelperBuilder.eObpUehc6ZBKAJwmVHui;
  }
}
