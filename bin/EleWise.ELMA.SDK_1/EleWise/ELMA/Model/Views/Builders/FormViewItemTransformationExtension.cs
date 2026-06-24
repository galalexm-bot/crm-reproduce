// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Builders.FormViewItemTransformationExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using System;

namespace EleWise.ELMA.Model.Views.Builders
{
  public static class FormViewItemTransformationExtension
  {
    public static FormViewItem Transformate(
      this FormViewItem formViewItem,
      Action<FormViewItemTransformationBuilder<IEntity>> builder)
    {
      if (builder == null)
        return formViewItem;
      FormViewItemTransformation itemTransformation = new FormViewItemTransformation();
      builder(new FormViewItemTransformationBuilder<IEntity>(formViewItem, itemTransformation));
      return formViewItem.Transformate((ViewItemTransformation) itemTransformation);
    }

    public static FormViewItem Transformate<TM>(
      this FormViewItem formViewItem,
      Action<FormViewItemTransformationBuilder<TM>> builder)
      where TM : IEntity
    {
      if (builder == null)
        return formViewItem;
      FormViewItemTransformation itemTransformation = new FormViewItemTransformation();
      builder(new FormViewItemTransformationBuilder<TM>(formViewItem, itemTransformation));
      return formViewItem.Transformate((ViewItemTransformation) itemTransformation);
    }
  }
}
