using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IPropertyIsEmpty
{
	bool? IsEmpty(PropertyViewItem propertyViewItem, object entity, EntityMetadata metadata);
}
