using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class ContactSupportFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "7D6B4B1B-3934-4655-8961-F35CD0241982";

	public static readonly Guid UID = new Guid("7D6B4B1B-3934-4655-8961-F35CD0241982");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (filter is IContractorFilter contractorFilter)
		{
			contractorFilter.IsContactSupportType = true;
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
			if (filter is IContractorFilter result)
			{
				return result;
			}
			return (IEntityFilter)InterfaceActivator.Create(typeof(IContractorFilter));
		}
		catch
		{
		}
		return null;
	}
}
