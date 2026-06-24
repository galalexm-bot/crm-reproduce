// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.AspMvcActionSelectorAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// ASP.NET MVC attribute. When applied to a parameter of an attribute,
  /// indicates that this parameter is an MVC action name.
  /// </summary>
  /// <example><code>
  /// [ActionName("Foo")]
  /// public ActionResult Login(string returnUrl) {
  ///   ViewBag.ReturnUrl = Url.Action("Foo"); // OK
  ///   return RedirectToAction("Bar"); // Error: Cannot resolve action
  /// }
  /// </code></example>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
  public sealed class AspMvcActionSelectorAttribute : Attribute
  {
    internal static AspMvcActionSelectorAttribute Edu1IHfCvJlROqV5ARAa;

    public AspMvcActionSelectorAttribute()
    {
      AspMvcActionSelectorAttribute.G6iF3TfCu6bRyxIm0XbJ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void G6iF3TfCu6bRyxIm0XbJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool mIA6o9fC84BMV91guCA6() => AspMvcActionSelectorAttribute.Edu1IHfCvJlROqV5ARAa == null;

    internal static AspMvcActionSelectorAttribute A6c3LCfCZIkaSex5JTHy() => AspMvcActionSelectorAttribute.Edu1IHfCvJlROqV5ARAa;
  }
}
