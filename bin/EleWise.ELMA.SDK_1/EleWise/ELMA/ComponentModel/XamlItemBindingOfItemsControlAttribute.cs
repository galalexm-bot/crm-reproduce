// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.XamlItemBindingOfItemsControlAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// XAML attibute. Indicates the property of some <c>BindingBase</c>-derived type, that
  /// is used to bind some item of <c>ItemsControl</c>-derived type. This annotation will
  /// enable the <c>DataContext</c> type resolve for XAML bindings for such properties.
  /// </summary>
  /// <remarks>
  /// Property should have the tree ancestor of the <c>ItemsControl</c> type or
  /// marked with the <see cref="T:EleWise.ELMA.ComponentModel.XamlItemsControlAttribute" /> attribute.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Property)]
  public sealed class XamlItemBindingOfItemsControlAttribute : Attribute
  {
    private static XamlItemBindingOfItemsControlAttribute f4WA67fCsXwDndjv0ggw;

    public XamlItemBindingOfItemsControlAttribute()
    {
      XamlItemBindingOfItemsControlAttribute.DBJiosfvFKrHqkZwl4QV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void DBJiosfvFKrHqkZwl4QV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool FRoSySfCcbR2sArosaZo() => XamlItemBindingOfItemsControlAttribute.f4WA67fCsXwDndjv0ggw == null;

    internal static XamlItemBindingOfItemsControlAttribute Qfdn3YfCz8J8oGgvRqcR() => XamlItemBindingOfItemsControlAttribute.f4WA67fCsXwDndjv0ggw;
  }
}
