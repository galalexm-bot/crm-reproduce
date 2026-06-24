// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.PartnerFilterProvider
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using System;
using System.Linq;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component]
  public class PartnerFilterProvider : IEntityFilterProvider
  {
    public static readonly Guid UID = new Guid("7528909e-3651-4829-a8ec-92d1d8513551");

    public Guid ProviderUid => PartnerFilterProvider.UID;

    public void ApplyFilter(IEntityFilter filter, string data)
    {
      if (!(filter is IContractorFilter contractorFilter))
        return;
      contractorFilter.Type = EntityManager<IContractorType>.Instance.Load(ContractorTypeManager.PartnerItemUid);
    }

    public string GetFilterProviderData(
      Type entityType,
      PropertyMetadata propertyMetadata,
      ViewAttributes viewAttributes)
    {
      if (entityType == (Type) null || propertyMetadata == null || propertyMetadata.Name != "Partner")
        return (string) null;
      return MetadataLoader.LoadMetadata(typeof (IContractor)) is EntityMetadata entityMetadata && entityMetadata.Properties.Any<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Uid == propertyMetadata.Uid)) ? "true" : (string) null;
    }

    public IEntityFilter GetFilter(Guid uid, IEntityFilter filter)
    {
      try
      {
        return filter is IContractorFilter ? filter : (IEntityFilter) InterfaceActivator.Create<IContractorFilter>();
      }
      catch
      {
        return (IEntityFilter) null;
      }
    }
  }
}
