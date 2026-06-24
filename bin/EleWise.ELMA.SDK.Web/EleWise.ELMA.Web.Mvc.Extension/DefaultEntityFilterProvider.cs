using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[Component]
public class DefaultEntityFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "{3D23090B-7809-40AA-BEEC-B19042591A82}";

	public static readonly Guid UID = new Guid("{3D23090B-7809-40AA-BEEC-B19042591A82}");

	public Guid ProviderUid => UID;

	public void ApplyFilter(IEntityFilter filter, string data)
	{
		if (!string.IsNullOrEmpty(data))
		{
			filter.Query = data;
		}
	}

	public string GetFilterProviderData(Type entityType, PropertyMetadata propertyMetadata, ViewAttributes viewAttributes)
	{
		if (entityType == null || propertyMetadata == null)
		{
			return null;
		}
		EntitySettings entitySettings = ((viewAttributes != null && viewAttributes.TypeSettings != null) ? (viewAttributes.TypeSettings as EntitySettings) : (propertyMetadata.Settings as EntitySettings));
		if (entitySettings == null || string.IsNullOrEmpty(entitySettings.FilterQuery))
		{
			return null;
		}
		return entitySettings.FilterQuery;
	}

	public IEntityFilter GetFilter(Guid uid, IEntityFilter filter)
	{
		return null;
	}
}
