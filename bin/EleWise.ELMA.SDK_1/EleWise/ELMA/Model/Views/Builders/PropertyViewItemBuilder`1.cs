// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.PropertyViewItemBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Views.Builders
{
  public class PropertyViewItemBuilder<TM> : 
    PropertyViewItemBuilder<TM, PropertyViewItem, PropertyViewItemBuilder<TM>>
    where TM : IEntity
  {
    private static object VYv01joD8DHJLdjApEw4;

    public PropertyViewItemBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal PropertyViewItemBuilder(
      Expression<Func<TM, object>> property,
      ViewItemBuilder parentViewItemBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(property, parentViewItemBuilder);
      this.ViewItem.PropertyUid = InterfaceActivator.PropertyUid<TM>(property, true);
    }

    internal static bool PPKilnoDZbX37CJI1RtP() => PropertyViewItemBuilder<TM>.VYv01joD8DHJLdjApEw4 == null;

    internal static object zEm0paoDuqOhr01ss3c0() => PropertyViewItemBuilder<TM>.VYv01joD8DHJLdjApEw4;
  }
}
