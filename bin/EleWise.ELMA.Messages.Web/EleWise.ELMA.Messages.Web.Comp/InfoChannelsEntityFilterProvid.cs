using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Messages.Web.Components;

[Component]
public class InfoChannelsEntityFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "E877391A-52C7-450F-8B80-B018AF2816BD";

	public static readonly Guid UID = new Guid("E877391A-52C7-450F-8B80-B018AF2816BD");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		bool flag = false;
		string[] array = data.Split(";".ToCharArray(), 2);
		if (array[0] == "send")
		{
			flag = true;
			array = ((array.Length == 1) ? "" : array[1]).Split(";".ToCharArray());
		}
		if (!(filter is IInformationChannelFilter informationChannelFilter))
		{
			return;
		}
		if (flag)
		{
			filter.PermissionId = PermissionProvider.ChannelEditPermission.Id;
		}
		switch (array[0])
		{
		case "All":
			informationChannelFilter.IsActive = true;
			informationChannelFilter.IsArchive = false;
			break;
		case "General":
			informationChannelFilter.IsActive = true;
			informationChannelFilter.IsArchive = false;
			informationChannelFilter.GroupUid = Guid.Empty;
			break;
		case "Over":
			informationChannelFilter.IsActive = true;
			informationChannelFilter.IsArchive = false;
			informationChannelFilter.NotGroupUid = Guid.Empty;
			break;
		}
		if (array.Length > 1 && !string.IsNullOrEmpty(array[1]))
		{
			informationChannelFilter.WithoutIds = (from id in array[1].Split(",".ToCharArray())
				select Convert.ToInt64(id)).ToList();
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
			if (filter is IInformationChannelFilter result)
			{
				return result;
			}
			return (IEntityFilter)InterfaceActivator.Create(typeof(IInformationChannelFilter));
		}
		catch
		{
		}
		return null;
	}
}
