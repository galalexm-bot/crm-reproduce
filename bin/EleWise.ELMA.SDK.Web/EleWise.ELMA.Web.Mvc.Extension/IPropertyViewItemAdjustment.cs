using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IPropertyViewItemAdjustment : IPropertyViewItemAdjustmentRuntime2
{
	new void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType);
}
