using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFormViewItemTransformate
{
	FormViewItem Transformate(FormViewItem formViewItem, object model);
}
