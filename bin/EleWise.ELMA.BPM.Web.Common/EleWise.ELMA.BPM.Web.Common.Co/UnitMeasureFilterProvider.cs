using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
public class UnitMeasureFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "{5BAD3C16-3332-4267-8538-91ED38C63450}";

	public static readonly Guid UID = new Guid("{5BAD3C16-3332-4267-8538-91ED38C63450}");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (filter is IUnitMeasureFilter unitMeasureFilter)
		{
			unitMeasureFilter.IsSelectList = false;
		}
	}

	public virtual string GetFilterProviderData(Type entityType, PropertyMetadata propertyMetadata, ViewAttributes viewAttributes)
	{
		return null;
	}

	public IEntityFilter GetFilter(Guid uid, IEntityFilter filter)
	{
		try
		{
			if (filter is IUnitMeasureFilter result)
			{
				return result;
			}
			return (IUnitMeasureFilter)InterfaceActivator.Create(typeof(IUnitMeasureFilter));
		}
		catch
		{
		}
		return null;
	}
}
