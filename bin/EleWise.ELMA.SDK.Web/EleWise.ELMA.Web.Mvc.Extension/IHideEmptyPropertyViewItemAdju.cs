using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IHideEmptyPropertyViewItemAdjustment
{
	bool IsApplicable(PropertyViewItem propertyViewItem, object entity);

	void Adjust(PropertyViewItem propertyViewItem, object entity);
}
