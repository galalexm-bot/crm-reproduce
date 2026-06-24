using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[Component]
public class HierarchicalEntityFilterProvider : IEntityFilterProvider
{
	public const string UID_S = "{C4820978-7591-4324-BE26-A38E41D09365}";

	public static readonly Guid UID = new Guid("{C4820978-7591-4324-BE26-A38E41D09365}");

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
