// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.ProductGroupFilterProvider
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using System;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class ProductGroupFilterProvider : IEntityFilterProvider
  {
    public const string UID_S = "DFD9CCA1-A7E1-4DDA-A11E-3E66948E8B69";
    public static readonly Guid UID = new Guid("DFD9CCA1-A7E1-4DDA-A11E-3E66948E8B69");

    public Guid ProviderUid => ProductGroupFilterProvider.UID;

    public void ApplyFilter(IEntityFilter filter, string data)
    {
      if (!(filter is IProductFilter productFilter))
        return;
      productFilter.IsGroup = new bool?(bool.Parse(data));
    }

    public string GetFilterProviderData(
      Type entityType,
      PropertyMetadata propertyMetadata,
      ViewAttributes viewAttributes)
    {
      return (string) null;
    }

    public IEntityFilter GetFilter(Guid uid, IEntityFilter filter)
    {
      try
      {
        return filter is IProductFilter productFilter ? (IEntityFilter) productFilter : (IEntityFilter) InterfaceActivator.Create(typeof (IProductFilter));
      }
      catch
      {
      }
      return (IEntityFilter) null;
    }
  }
}
