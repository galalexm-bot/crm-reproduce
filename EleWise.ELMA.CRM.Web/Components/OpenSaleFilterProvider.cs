// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.OpenSaleFilterProvider
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
  public class OpenSaleFilterProvider : IEntityFilterProvider
  {
    public const string UID_S = "58E430F0-1D40-4A3F-B73E-394C54764C5B";
    public static readonly Guid UID = new Guid("58E430F0-1D40-4A3F-B73E-394C54764C5B");

    public Guid ProviderUid => OpenSaleFilterProvider.UID;

    public void ApplyFilter(IEntityFilter filter, string data)
    {
      if (!(filter is ISaleFilter saleFilter))
        return;
      saleFilter.Closed = new bool?(false);
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
        return filter is ISaleFilter saleFilter ? (IEntityFilter) saleFilter : (IEntityFilter) InterfaceActivator.Create(typeof (ISaleFilter));
      }
      catch
      {
      }
      return (IEntityFilter) null;
    }
  }
}
