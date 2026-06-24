// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.PropertyDescriptionViewItemBuilder`1
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
  public class PropertyDescriptionViewItemBuilder<TM> : 
    PropertyViewItemBuilder<TM, PropertyDescriptionViewItem, PropertyDescriptionViewItemBuilder<TM>>
    where TM : IEntity
  {
    internal static object Cp4yexoDKPh8OgHXT2o3;

    public PropertyDescriptionViewItemBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal PropertyDescriptionViewItemBuilder(
      Expression<Func<TM, object>> property,
      ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(property, parentViewItemBuilder);
    }

    internal static bool ftNTRkoDXZh601XhCY9c() => PropertyDescriptionViewItemBuilder<TM>.Cp4yexoDKPh8OgHXT2o3 == null;

    internal static object wFlAeUoDTY6iXRlZ3hhf() => PropertyDescriptionViewItemBuilder<TM>.Cp4yexoDKPh8OgHXT2o3;
  }
}
