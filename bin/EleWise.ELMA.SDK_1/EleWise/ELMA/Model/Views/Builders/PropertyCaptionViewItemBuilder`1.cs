// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.PropertyCaptionViewItemBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Views.Builders
{
  public class PropertyCaptionViewItemBuilder<TM> : 
    PropertyViewItemBuilder<TM, PropertyCaptionViewItem, PropertyCaptionViewItemBuilder<TM>>
    where TM : IEntity
  {
    private static object GP4njqoDi7VZSnGDbfoE;

    public PropertyCaptionViewItemBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal PropertyCaptionViewItemBuilder(
      Expression<Func<TM, object>> property,
      ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(property, parentViewItemBuilder);
    }

    internal static bool IPRJAXoDRdA6otj5Cd5e() => PropertyCaptionViewItemBuilder<TM>.GP4njqoDi7VZSnGDbfoE == null;

    internal static object wulMoEoDqfxoGFMrvSDC() => PropertyCaptionViewItemBuilder<TM>.GP4njqoDi7VZSnGDbfoE;
  }
}
