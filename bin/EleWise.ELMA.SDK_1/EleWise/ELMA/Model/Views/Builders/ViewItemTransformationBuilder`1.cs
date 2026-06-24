// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.ViewItemTransformationBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Transformations;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Views.Builders
{
  public class ViewItemTransformationBuilder<TM> where TM : IEntity
  {
    protected readonly FormViewItemTransformationBuilder<TM> builder;
    protected readonly Guid itemUid;

    internal ViewItemTransformationBuilder(
      FormViewItemTransformationBuilder<TM> builder,
      Guid itemUid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.builder = builder;
      this.itemUid = itemUid;
    }

    public FormViewItemTransformationBuilder<TM> Add(
      ViewItem item,
      Guid? afterItem = null,
      Guid? beforeItem = null)
    {
      this.builder.transformations.Items.Add((ViewItemTransformation) ViewItemTransformation.Add(this.itemUid, item, afterItem, beforeItem));
      return this.builder;
    }

    public FormViewItemTransformationBuilder<TM> Add(
      ViewItem item,
      Guid? afterItem,
      Expression<Func<TM, object>> beforePropertyExpr)
    {
      return this.Add(item, afterItem, new Guid?(InterfaceActivator.PropertyUid<TM>(beforePropertyExpr, true)));
    }

    public FormViewItemTransformationBuilder<TM> Add(
      ViewItem item,
      Expression<Func<TM, object>> afterPropertyExpr,
      Guid? beforeItem = null)
    {
      return this.Add(item, new Guid?(InterfaceActivator.PropertyUid<TM>(afterPropertyExpr, true)), beforeItem);
    }

    public FormViewItemTransformationBuilder<TM> Add(
      ViewItem item,
      Expression<Func<TM, object>> afterPropertyExpr,
      Expression<Func<TM, object>> beforePropertyExpr)
    {
      return this.Add(item, new Guid?(InterfaceActivator.PropertyUid<TM>(afterPropertyExpr, true)), new Guid?(InterfaceActivator.PropertyUid<TM>(beforePropertyExpr, true)));
    }

    public FormViewItemTransformationBuilder<TM> Add<TB>(
      Action<TB> builder,
      Guid? afterItem = null,
      Guid? beforeItem = null)
      where TB : ViewItemBuilder, new()
    {
      if (builder != null)
      {
        TB b = new TB();
        builder(b);
        if (b.viewItem is RootViewItem viewItem1)
        {
          foreach (ViewItem viewItem in (EventedList<ViewItem>) viewItem1.Items)
          {
            this.builder.transformations.Items.Add((ViewItemTransformation) ViewItemTransformation.Add(this.itemUid, viewItem, afterItem, beforeItem));
            afterItem = new Guid?(viewItem.Uid);
          }
        }
      }
      return this.builder;
    }

    public FormViewItemTransformationBuilder<TM> Add<TB>(
      Action<TB> builder,
      Guid? afterItem,
      Expression<Func<TM, object>> beforePropertyExpr)
      where TB : ViewItemBuilder, new()
    {
      return this.Add<TB>(builder, afterItem, new Guid?(InterfaceActivator.PropertyUid<TM>(beforePropertyExpr, true)));
    }

    public FormViewItemTransformationBuilder<TM> Add<TB>(
      Action<TB> builder,
      Expression<Func<TM, object>> afterPropertyExpr,
      Guid? beforeItem = null)
      where TB : ViewItemBuilder, new()
    {
      return this.Add<TB>(builder, new Guid?(InterfaceActivator.PropertyUid<TM>(afterPropertyExpr, true)), beforeItem);
    }

    public FormViewItemTransformationBuilder<TM> Add<TB>(
      Action<TB> builder,
      Expression<Func<TM, object>> afterPropertyExpr,
      Expression<Func<TM, object>> beforePropertyExpr)
      where TB : ViewItemBuilder, new()
    {
      return this.Add<TB>(builder, new Guid?(InterfaceActivator.PropertyUid<TM>(afterPropertyExpr, true)), new Guid?(InterfaceActivator.PropertyUid<TM>(beforePropertyExpr, true)));
    }

    public FormViewItemTransformationBuilder<TM> Move(
      Guid toItemUid,
      Guid? afterItem = null,
      Guid? beforeItem = null)
    {
      this.builder.transformations.Items.Add((ViewItemTransformation) ViewItemTransformation.Move(toItemUid, this.itemUid, afterItem, beforeItem));
      return this.builder;
    }

    public FormViewItemTransformationBuilder<TM> Move(
      Guid toItemUid,
      Guid? afterItem,
      Expression<Func<TM, object>> beforePropertyExpr)
    {
      return this.Move(toItemUid, afterItem, new Guid?(InterfaceActivator.PropertyUid<TM>(beforePropertyExpr, true)));
    }

    public FormViewItemTransformationBuilder<TM> Move(
      Guid toItemUid,
      Expression<Func<TM, object>> afterPropertyExpr,
      Guid? beforeItem = null)
    {
      return this.Move(toItemUid, new Guid?(InterfaceActivator.PropertyUid<TM>(afterPropertyExpr, true)), beforeItem);
    }

    public FormViewItemTransformationBuilder<TM> Move(
      Guid toItemUid,
      Expression<Func<TM, object>> afterPropertyExpr,
      Expression<Func<TM, object>> beforePropertyExpr)
    {
      return this.Move(toItemUid, new Guid?(InterfaceActivator.PropertyUid<TM>(afterPropertyExpr, true)), new Guid?(InterfaceActivator.PropertyUid<TM>(beforePropertyExpr, true)));
    }

    public FormViewItemTransformationBuilder<TM> Hide()
    {
      this.builder.transformations.Items.Add((ViewItemTransformation) ViewItemTransformation.Hide(this.itemUid));
      return this.builder;
    }

    public FormViewItemTransformationBuilder<TM> SetPropertyValue(string propertyName, object value)
    {
      this.builder.transformations.Items.Add((ViewItemTransformation) ViewItemTransformation.SetPropertyValue(this.itemUid, propertyName, value));
      return this.builder;
    }
  }
}
