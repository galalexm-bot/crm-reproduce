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
public class ActiveLeadFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "7CEB38DF-E5D7-4B73-A4F5-390F8A6459BD";

	public static readonly Guid UID = new Guid("7CEB38DF-E5D7-4B73-A4F5-390F8A6459BD");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (filter is ILeadFilter leadFilter)
		{
			leadFilter.Active = true;
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
			if (filter is ILeadFilter result)
			{
				return result;
			}
			return (IEntityFilter)InterfaceActivator.Create(typeof(ILeadFilter));
		}
		catch
		{
		}
		return null;
	}
}
