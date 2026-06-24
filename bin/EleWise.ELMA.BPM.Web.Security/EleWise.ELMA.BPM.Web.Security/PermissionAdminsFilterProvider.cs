using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.ExtensionPoints;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Components.FilterProviders;

[Component]
internal class PermissionAdminsFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "5E956FE7-F236-4AC2-A295-191D3E200A96";

	public static readonly Guid UID = new Guid("5E956FE7-F236-4AC2-A295-191D3E200A96");

	public IEnumerable<IEntityPermissionAccessRequestProvider> EntityPermissionAccessRequestProviders { get; set; }

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (filter is IUserFilter userFilter)
		{
			string[] array = data.Split(';');
			if (array.Length < 2)
			{
				throw new FormatException(SR.T("Данные фильтрации должны быть заполнены в виде \"Уникальный идентификатор типа сущности;Идентификатор сущности\""));
			}
			if (!Guid.TryParse(array[0], out var entityTypeUid))
			{
				throw new InvalidCastException(SR.T("Невозможно определить уникальный идентификатор типа сущности - {0}", data));
			}
			if (!long.TryParse(array[1], out var result))
			{
				throw new InvalidCastException(SR.T("Невозможно определить идентификатор сущности - {0}", data));
			}
			IEntityPermissionAccessRequestProvider entityPermissionAccessRequestProvider = EntityPermissionAccessRequestProviders.FirstOrDefault((IEntityPermissionAccessRequestProvider p) => p.CanUse(entityTypeUid));
			if (entityPermissionAccessRequestProvider == null)
			{
				throw new InvalidOperationException(SR.T("Невозможно определить запрашиваемые права доступа"));
			}
			userFilter.UserIds = (from u in entityPermissionAccessRequestProvider.GetAdmins(entityTypeUid, result)
				select u.Id).ToList();
		}
	}

	public string GetFilterProviderData(Type entityType, PropertyMetadata propertyMetadata, ViewAttributes viewAttributes)
	{
		return null;
	}

	public IEntityFilter GetFilter(Guid uid, IEntityFilter filter)
	{
		if (filter is IUserFilter result)
		{
			return result;
		}
		return (IEntityFilter)InterfaceActivator.Create(typeof(IUserFilter));
	}
}
