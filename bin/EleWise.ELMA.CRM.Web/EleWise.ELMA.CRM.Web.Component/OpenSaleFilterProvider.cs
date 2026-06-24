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
public class OpenSaleFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "58E430F0-1D40-4A3F-B73E-394C54764C5B";

	public static readonly Guid UID = new Guid("58E430F0-1D40-4A3F-B73E-394C54764C5B");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (filter is ISaleFilter saleFilter)
		{
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
