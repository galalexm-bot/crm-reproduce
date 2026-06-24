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
public class ProductGroupFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "DFD9CCA1-A7E1-4DDA-A11E-3E66948E8B69";

	public static readonly Guid UID = new Guid("DFD9CCA1-A7E1-4DDA-A11E-3E66948E8B69");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (filter is IProductFilter productFilter)
		{
			productFilter.IsGroup = bool.Parse(data);
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
			if (filter is IProductFilter result)
			{
				return result;
			}
			return (IEntityFilter)InterfaceActivator.Create(typeof(IProductFilter));
		}
		catch
		{
		}
		return null;
	}
}
