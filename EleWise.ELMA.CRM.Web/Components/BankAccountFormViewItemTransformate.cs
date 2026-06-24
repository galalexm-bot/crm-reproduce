// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.BankAccountFormViewItemTransformate
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  internal class BankAccountFormViewItemTransformate : IFormViewItemTransformate
  {
    public FormViewItem Transformate(FormViewItem formViewItem, object model)
    {
      if (!(model is BankAccountModel bankAccountModel) || bankAccountModel.Entity == null || bankAccountModel.Entity.BankDetails == null || bankAccountModel.ViewType != ViewType.Display)
        return formViewItem;
      Guid bdUid = InterfaceActivator.PropertyUid<IBankAccount>((Expression<Func<IBankAccount, object>>) (p => p.BankDetails));
      FormViewItem form = ((ClassMetadata) MetadataLoader.LoadMetadata(EntityHelper.GetType((object) bankAccountModel.Entity.BankDetails), loadImplementation: false)).DefaultForms.GetForm(ViewType.Display);
      if (form == null)
        return formViewItem;
      List<Guid> bdDisplayFormItemUids = form.GetAllItems().OfType<PropertyViewItem>().Select<PropertyViewItem, Guid>((Func<PropertyViewItem, Guid>) (o => o.PropertyUid)).ToList<Guid>();
      return formViewItem.Transformate<IBankAccount>((Action<FormViewItemTransformationBuilder<IBankAccount>>) (t => formViewItem.GetAllItems().OfType<PropertyViewItem>().Where<PropertyViewItem>((Func<PropertyViewItem, bool>) (i => i.PropertyUid == bdUid)).Each<PropertyViewItem>((Action<PropertyViewItem>) (p =>
      {
        List<Guid> list = p.Items.OfType<PropertyViewItem>().Where<PropertyViewItem>((Func<PropertyViewItem, bool>) (i => !i.Hide)).Select<PropertyViewItem, Guid>((Func<PropertyViewItem, Guid>) (o => o.PropertyUid)).ToList<Guid>();
        if (!list.Any<Guid>())
          return;
        foreach (Guid guid in bdDisplayFormItemUids)
        {
          if (!list.Contains(guid))
          {
            ViewItemTransformationBuilder<IBankAccount, PropertyViewItem> transformationBuilder = t.ForItem<PropertyViewItem>(p.Uid);
            PropertyViewItem propertyViewItem = new PropertyViewItem();
            propertyViewItem.Uid = guid;
            propertyViewItem.PropertyUid = guid;
            Guid? afterItem = new Guid?();
            Guid? beforeItem = new Guid?();
            transformationBuilder.Add((ViewItem) propertyViewItem, afterItem, beforeItem);
          }
        }
      }))));
    }
  }
}
