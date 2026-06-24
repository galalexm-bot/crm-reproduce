// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.ViewItemTransformationBuilder`2
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
  public class ViewItemTransformationBuilder<TM, TItem> : ViewItemTransformationBuilder<TM>
    where TM : IEntity
    where TItem : ViewItem
  {
    internal ViewItemTransformationBuilder(
      FormViewItemTransformationBuilder<TM> builder,
      Guid itemUid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(builder, itemUid);
    }

    public FormViewItemTransformationBuilder<TM> SetPropertyValue<T>(
      Expression<Func<TItem, T>> property,
      T value)
    {
      this.builder.transformations.Items.Add((ViewItemTransformation) ViewItemTransformation<TItem>.SetPropertyValue<T>(this.itemUid, property, value));
      return this.builder;
    }
  }
}
