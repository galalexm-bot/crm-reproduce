// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.AspMvcViewAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// ASP.NET MVC attribute. If applied to a parameter, indicates that the parameter
  /// is an MVC view. If applied to a method, the MVC view name is calculated implicitly
  /// from the context. Use this attribute for custom wrappers similar to
  /// <c>System.Web.Mvc.Controller.View(Object)</c>.
  /// </summary>
  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
  public sealed class AspMvcViewAttribute : Attribute
  {
    private static AspMvcViewAttribute eFr35dfCE0F6Hm5tJgSF;

    public AspMvcViewAttribute()
    {
      AspMvcViewAttribute.rARsMqfCC4b6MnmMXVxw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void rARsMqfCC4b6MnmMXVxw() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ucNk1wfCfc5y1S5wSpvA() => AspMvcViewAttribute.eFr35dfCE0F6Hm5tJgSF == null;

    internal static AspMvcViewAttribute tp9tkDfCQPqIdkerQ4O3() => AspMvcViewAttribute.eFr35dfCE0F6Hm5tJgSF;
  }
}
