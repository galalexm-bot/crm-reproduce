using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class WorkLogActivityFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "36330015-1281-445B-8A04-81C8C4F87428";

	public static readonly Guid UID = new Guid("36330015-1281-445B-8A04-81C8C4F87428");

	public Guid ProviderUid => UID;

	public static List<IWorkLogActivity> AllowWorkLogActivity(Guid? objectUid)
	{
		if (!objectUid.HasValue)
		{
			return new List<IWorkLogActivity>();
		}
		IWorkLogActivityFilter workLogActivityFilter = (IWorkLogActivityFilter)InterfaceActivator.Create(typeof(IWorkLogActivityFilter));
		workLogActivityFilter.EntityTypeUid = objectUid;
		workLogActivityFilter.AllOrEntityTypeUid = true;
		return WorkLogActivityManager.Instance.Find(workLogActivityFilter, FetchOptions.All).ToList();
	}

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (!(filter is IWorkLogActivityFilter workLogActivityFilter))
		{
			return;
		}
		if (string.IsNullOrEmpty(data))
		{
			workLogActivityFilter.Id = 0;
			return;
		}
		Guid? guid = null;
		try
		{
			guid = new Guid(data);
		}
		catch
		{
		}
		if (!guid.HasValue || guid.Value == Guid.Empty)
		{
			workLogActivityFilter.Id = 0;
			return;
		}
		workLogActivityFilter.EntityTypeUid = guid.Value;
		workLogActivityFilter.AllOrEntityTypeUid = true;
	}

	public string GetFilterProviderData(Type entityType, PropertyMetadata propertyMetadata, ViewAttributes viewAttributes)
	{
		return null;
	}

	public IEntityFilter GetFilter(Guid uid, IEntityFilter filter)
	{
		if (filter is IWorkLogActivityFilter result)
		{
			return result;
		}
		try
		{
			return (IEntityFilter)InterfaceActivator.Create(typeof(IWorkLogActivityFilter));
		}
		catch
		{
		}
		return null;
	}
}
