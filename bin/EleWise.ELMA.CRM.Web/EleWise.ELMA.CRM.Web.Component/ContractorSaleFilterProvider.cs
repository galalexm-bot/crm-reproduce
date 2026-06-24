using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class ContractorSaleFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "3FA40BD9-8202-4B61-A9CA-C8A7231AD35B";

	public static readonly Guid UID = new Guid("3FA40BD9-8202-4B61-A9CA-C8A7231AD35B");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (!string.IsNullOrEmpty(data) && filter is ISaleFilter saleFilter)
		{
			saleFilter.Contractors.Add(ContractorManager.Instance.LoadOrNull(int.Parse(data)));
			saleFilter.Closed = false;
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
			if (filter is ISaleFilter result)
			{
				return result;
			}
			return (IEntityFilter)InterfaceActivator.Create(typeof(ISaleFilter));
		}
		catch
		{
		}
		return null;
	}
}
