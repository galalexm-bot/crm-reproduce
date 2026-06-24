using System;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
public class FilterFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "BC0E8ABA-9ADA-40A4-B443-5F9BFA8243E0";

	public static readonly Guid UID = new Guid("BC0E8ABA-9ADA-40A4-B443-5F9BFA8243E0");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (filter is IFilterFilter filterFilter)
		{
			filterFilter.ObjectsType = new ReferenceOnEntityType
			{
				TypeUid = new Guid(data)
			};
			filterFilter.GetUserFilters = true;
		}
	}

	public void ApplyFilter(IEntityFilter filter, string data, Guid? code)
	{
		if (filter is IFilterFilter filterFilter)
		{
			filterFilter.ObjectsType = new ReferenceOnEntityType
			{
				TypeUid = new Guid(data)
			};
			filterFilter.Code = code;
			filterFilter.GetUserFilters = true;
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
			if (filter is IFilterFilter result)
			{
				return result;
			}
			return (IEntityFilter)InterfaceActivator.Create(typeof(IFilterFilter));
		}
		catch
		{
		}
		return null;
	}
}
