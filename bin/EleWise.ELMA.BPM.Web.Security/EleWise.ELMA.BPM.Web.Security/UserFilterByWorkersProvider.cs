using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[Component]
public class UserFilterByWorkersProvider : IEntityFilterProvider
{
	public const string UID_S = "{57D54F8C-B152-4717-9C5B-E8D3486081C6}";

	public static readonly Guid UID = new Guid("{57D54F8C-B152-4717-9C5B-E8D3486081C6}");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (filter == null || string.IsNullOrEmpty(data))
		{
			return;
		}
		List<string> list = data.Split(new string[1] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();
		if (list.Count == 0)
		{
			return;
		}
		if (filter is IUserFilter)
		{
			IUserFilter fl2 = (IUserFilter)filter;
			if (fl2.Workers == null)
			{
				fl2.Workers = new List<Worker>();
			}
			list.ForEach(delegate(string w)
			{
				fl2.Workers.Add((Worker)ClassSerializationHelper.DeserializeObjectByJson(typeof(Worker), w));
			});
		}
		if (filter is IUserGroupFilter)
		{
			IUserGroupFilter fl = (IUserGroupFilter)filter;
			if (fl.Workers == null)
			{
				fl.Workers = new List<Worker>();
			}
			list.ForEach(delegate(string w)
			{
				fl.Workers.Add((Worker)ClassSerializationHelper.DeserializeObjectByJson(typeof(Worker), w));
			});
		}
	}

	public string GetFilterProviderData(Type entityType, PropertyMetadata propertyMetadata, ViewAttributes viewAttributes)
	{
		return null;
	}

	public IEntityFilter GetFilter(Guid uid, IEntityFilter filter)
	{
		return null;
	}
}
