using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Components;

[Component]
public class UserSubordinateFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "6082234D-C7C3-4D49-85B3-C76E7B610DE5";

	public static readonly Guid UID = new Guid("6082234D-C7C3-4D49-85B3-C76E7B610DE5");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (!string.IsNullOrEmpty(data) && filter is IUserFilter userFilter)
		{
			userFilter.ShowOnlySubordinateAndSelf = bool.Parse(data);
			if (userFilter.ShowOnlySubordinateAndSelf && !string.IsNullOrEmpty(userFilter.SearchString) && !UserManager.Instance.Exists(userFilter))
			{
				userFilter.ShowOnlySubordinateAndSelf = false;
			}
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
			if (filter is IUserFilter result)
			{
				return result;
			}
			return (IEntityFilter)InterfaceActivator.Create(typeof(IUserFilter));
		}
		catch
		{
		}
		return null;
	}
}
