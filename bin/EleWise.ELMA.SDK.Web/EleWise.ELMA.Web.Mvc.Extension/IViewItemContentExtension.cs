using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IViewItemContentExtension
{
	bool Check(ViewItem viewItem, IEntity entity);

	object GetModel(params object[] parameters);
}
