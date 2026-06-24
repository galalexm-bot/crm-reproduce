using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class PartnerFilterProvider : IEntityFilterProvider
{
	public static readonly Guid UID = new Guid("7528909e-3651-4829-a8ec-92d1d8513551");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (filter is IContractorFilter contractorFilter)
		{
			contractorFilter.Type = EntityManager<IContractorType>.Instance.Load(ContractorTypeManager.PartnerItemUid);
		}
	}

	public string GetFilterProviderData(Type entityType, PropertyMetadata propertyMetadata, ViewAttributes viewAttributes)
	{
		if (entityType == null || propertyMetadata == null || propertyMetadata.Name != "Partner")
		{
			return null;
		}
		if (MetadataLoader.LoadMetadata(typeof(IContractor)) is EntityMetadata entityMetadata && entityMetadata.Properties.Any((PropertyMetadata p) => p.Uid == propertyMetadata.Uid))
		{
			return "true";
		}
		return null;
	}

	public IEntityFilter GetFilter(Guid uid, IEntityFilter filter)
	{
		try
		{
			if (filter is IContractorFilter)
			{
				return filter;
			}
			return InterfaceActivator.Create<IContractorFilter>();
		}
		catch
		{
			return null;
		}
	}
}
