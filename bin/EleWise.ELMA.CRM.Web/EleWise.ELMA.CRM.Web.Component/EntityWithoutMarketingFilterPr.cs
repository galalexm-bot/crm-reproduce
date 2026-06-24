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
public class EntityWithoutMarketingFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "{69E761BC-F58D-49FE-AFFF-ED0E5C4AC0F8}";

	public static readonly Guid UID = new Guid("{69E761BC-F58D-49FE-AFFF-ED0E5C4AC0F8}");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (data == InterfaceActivator.UID<IMarketingGroup>().ToString())
		{
			filter.Query = "MarketingGroup is null";
		}
		else if (data == InterfaceActivator.UID<IMarketingActivity>().ToString())
		{
			filter.Query = "MarketingActivity is null";
		}
		else if (data == InterfaceActivator.UID<IMarketingEffect>().ToString())
		{
			filter.Query = "MarketingEffect is null";
		}
	}

	public string GetFilterProviderData(Type entityType, PropertyMetadata propertyMetadata, ViewAttributes viewAttributes)
	{
		return null;
	}

	public IEntityFilter GetFilter(Guid uid, IEntityFilter filter)
	{
		return filter;
	}
}
