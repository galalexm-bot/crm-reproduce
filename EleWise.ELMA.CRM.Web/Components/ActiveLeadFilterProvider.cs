// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.ActiveLeadFilterProvider
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
  public class ActiveLeadFilterProvider : IEntityFilterProvider
  {
    public const string UID_S = "7CEB38DF-E5D7-4B73-A4F5-390F8A6459BD";
    public static readonly Guid UID = new Guid("7CEB38DF-E5D7-4B73-A4F5-390F8A6459BD");

    public Guid ProviderUid => ActiveLeadFilterProvider.UID;

    public void ApplyFilter(IEntityFilter filter, string data)
    {
      if (!(filter is ILeadFilter leadFilter))
        return;
      leadFilter.Active = new bool?(true);
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
        return filter is ILeadFilter leadFilter ? (IEntityFilter) leadFilter : (IEntityFilter) InterfaceActivator.Create(typeof (ILeadFilter));
      }
      catch
      {
      }
      return (IEntityFilter) null;
    }
  }
}
