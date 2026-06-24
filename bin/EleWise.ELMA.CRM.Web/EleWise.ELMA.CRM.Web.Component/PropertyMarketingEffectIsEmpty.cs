using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Types;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class PropertyMarketingEffectIsEmpty : IPropertyIsEmpty
{
	private readonly Guid _marketingEffectGuid = new Guid("2c2ae8eb-9f42-4d3e-b990-157357c1a535");

	public bool? IsEmpty(PropertyViewItem propertyViewItem, object entity, EntityMetadata metadata)
	{
		if (metadata == null)
		{
			return null;
		}
		IPropertyMetadata propertyMetadata = metadata.GetPropertiesAndTableParts().FirstOrDefault((IPropertyMetadata p) => p.PropertyUid == propertyViewItem.PropertyUid);
		if (propertyMetadata == null || propertyMetadata.SubTypeUid != _marketingEffectGuid || !((MarketingEffectSettings)propertyMetadata.Settings).IsComposite)
		{
			return null;
		}
		Guid[] marketingGuids = new Guid[3]
		{
			_marketingEffectGuid,
			new Guid("53f2d16c-4d27-4891-a3ea-9f8fe7f68a00"),
			new Guid("c29d5357-56dc-4e65-9c89-91faed78abca")
		};
		IMetadataRuntimeService metadataService = Locator.GetServiceNotNull<IMetadataRuntimeService>();
		return (from p in metadata.Properties
			where marketingGuids.Contains(p.SubTypeUid)
			select p into prop
			select metadataService.GetTypeDescriptor(prop.TypeUid, prop.SubTypeUid).IsEmpty(prop, entity.GetPropertyValue(prop.Name, null))).Aggregate((bool a, bool b) => a && b);
	}
}
