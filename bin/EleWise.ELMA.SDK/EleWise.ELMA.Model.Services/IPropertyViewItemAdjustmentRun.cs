using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.Services;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IPropertyViewItemAdjustmentRuntime2
{
	void Adjust(PropertyViewItem propertyViewItem, object model, ViewType viewType);
}
