using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.BPM.Web.Calendar.Export.Components;

[Component]
public class SharedScheduleFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "04EF8DD1-34BD-4A20-B2BE-DC66C35D5303";

	public static readonly Guid UID = new Guid("04EF8DD1-34BD-4A20-B2BE-DC66C35D5303");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (filter is IScheduleFilter scheduleFilter)
		{
			scheduleFilter.Shared = true;
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
			if (filter is IScheduleFilter result)
			{
				return result;
			}
			return (IEntityFilter)InterfaceActivator.Create(typeof(IScheduleFilter));
		}
		catch
		{
		}
		return null;
	}
}
