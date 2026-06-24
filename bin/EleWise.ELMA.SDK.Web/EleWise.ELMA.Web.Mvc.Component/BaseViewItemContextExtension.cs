using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component(Order = int.MaxValue)]
internal sealed class BaseViewItemContextExtension : IViewItemContentExtension
{
	public bool Check(ViewItem viewItem, IEntity entity)
	{
		return true;
	}

	public object GetModel(params object[] parameters)
	{
		if (parameters.Length == 0)
		{
			return null;
		}
		return parameters[0];
	}
}
