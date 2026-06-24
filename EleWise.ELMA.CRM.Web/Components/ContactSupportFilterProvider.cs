// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.ContactSupportFilterProvider
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
  public class ContactSupportFilterProvider : IEntityFilterProvider
  {
    public const string UID_S = "7D6B4B1B-3934-4655-8961-F35CD0241982";
    public static readonly Guid UID = new Guid("7D6B4B1B-3934-4655-8961-F35CD0241982");

    public Guid ProviderUid => ContactSupportFilterProvider.UID;

    public void ApplyFilter(IEntityFilter filter, string data)
    {
      if (!(filter is IContractorFilter contractorFilter))
        return;
      contractorFilter.IsContactSupportType = new bool?(true);
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
        return filter is IContractorFilter contractorFilter ? (IEntityFilter) contractorFilter : (IEntityFilter) InterfaceActivator.Create(typeof (IContractorFilter));
      }
      catch
      {
      }
      return (IEntityFilter) null;
    }
  }
}
