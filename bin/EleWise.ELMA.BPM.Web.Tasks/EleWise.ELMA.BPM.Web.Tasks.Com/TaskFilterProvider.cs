using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class TaskFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "DAD33A67-F591-4227-9DC8-8BD2C98A3543";

	public static readonly Guid UID = new Guid("DAD33A67-F591-4227-9DC8-8BD2C98A3543");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (!string.IsNullOrEmpty(data) && filter is ITaskBaseFilter taskBaseFilter)
		{
			taskBaseFilter.NotShowInLists = bool.Parse(data);
			taskBaseFilter.Query = "NOT ChildTasks is EMPTY";
		}
	}

	public string GetFilterProviderData(Type entityType, PropertyMetadata propertyMetadata, ViewAttributes viewAttributes)
	{
		if (entityType == InterfaceActivator.TypeOf<ITaskBaseFilter>() && propertyMetadata.Uid == InterfaceActivator.PropertyUid((ITaskBaseFilter p) => p.ParentTask))
		{
			return "False";
		}
		return null;
	}

	public IEntityFilter GetFilter(Guid uid, IEntityFilter filter)
	{
		try
		{
			if (filter is ITaskBaseFilter result)
			{
				return result;
			}
			return (IEntityFilter)InterfaceActivator.Create(typeof(ITaskBaseFilter));
		}
		catch
		{
		}
		return null;
	}
}
