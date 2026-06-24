using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IPropertyIsEmptyOrDefault : IPropertyIsEmpty
{
	bool? IsEmptyOrDefault(PropertyViewItem propertyViewItem, object entity, EntityMetadata metadata);
}
