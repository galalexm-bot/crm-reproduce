using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class SaleTypeFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "F75DB40E-48B0-4F19-943E-E2A90D96B986";

	public static readonly Guid UID = new Guid("F75DB40E-48B0-4F19-943E-E2A90D96B986");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (filter is ISaleTypeFilter saleTypeFilter)
		{
			saleTypeFilter.SaleFunnel = EntityManager<ISaleFunnel>.Instance.LoadOrNull(new Guid(data));
		}
	}

	public string GetFilterProviderData(Type entityType, PropertyMetadata propertyMetadata, ViewAttributes viewAttributes)
	{
		return null;
	}

	public IEntityFilter GetFilter(Guid uid, IEntityFilter filter)
	{
		try
		{
			if (filter is ISaleTypeFilter result)
			{
				return result;
			}
			return (IEntityFilter)InterfaceActivator.Create(typeof(ISaleTypeFilter));
		}
		catch
		{
		}
		return null;
	}
}
