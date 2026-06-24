// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.FormViewItemTransformationBuilder`1
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
  public class FormViewItemTransformationBuilder<TM> where TM : IEntity
  {
    internal readonly FormViewItem formViewItem;
    internal readonly FormViewItemTransformation transformations;
    private static object GBD2knoD1UINdDoc2KkA;

    internal FormViewItemTransformationBuilder(
      FormViewItem formViewItem,
      FormViewItemTransformation transformations)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.formViewItem = formViewItem;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
            continue;
          default:
            this.transformations = transformations;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public FormViewItemTransformationBuilder<TM> If(
      bool condition,
      Action<FormViewItemTransformationBuilder<TM>> builder)
    {
      if (condition && builder != null)
        builder(this);
      return this;
    }

    public ViewItemTransformationBuilder<TM> ForItem(Guid itemUid) => new ViewItemTransformationBuilder<TM>(this, itemUid);

    public ViewItemTransformationBuilder<TM, PropertyViewItem> ForPropertyItem(
      Expression<Func<TM, object>> expr)
    {
      return new ViewItemTransformationBuilder<TM, PropertyViewItem>(this, InterfaceActivator.PropertyUid<TM>(expr, true));
    }

    public ViewItemTransformationBuilder<TM, TItem> ForItem<TItem>(Guid itemUid) where TItem : ViewItem => new ViewItemTransformationBuilder<TM, TItem>(this, itemUid);

    public ViewItemTransformationBuilder<TM, TItem> ForItem<TItem>(Expression<Func<TM, object>> expr) where TItem : ViewItem => new ViewItemTransformationBuilder<TM, TItem>(this, InterfaceActivator.PropertyUid<TM>(expr, true));

    internal static bool NhVmf6oDN8W6JwZIOYVW() => FormViewItemTransformationBuilder<TM>.GBD2knoD1UINdDoc2KkA == null;

    internal static object t0POkNoD3XGySfxSJMKc() => FormViewItemTransformationBuilder<TM>.GBD2knoD1UINdDoc2KkA;
  }
}
