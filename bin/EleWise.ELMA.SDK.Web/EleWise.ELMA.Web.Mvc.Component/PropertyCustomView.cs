using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Inputs;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal class PropertyCustomView : IPropertyCustomView
{
	private class FakeController : Controller
	{
		[HttpGet]
		public ActionResult Action()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			return (ActionResult)new EmptyResult();
		}
	}

	public bool HasCustomView(IPropertyMetadata property, bool readOnly)
	{
		ControllerContext controllerContext = ControllerContextCreator.Create((Controller)(object)new FakeController());
		EntityInput entityInput = ComponentManager.Current.GetExtensionPoints<IInput>().OfType<EntityInput>().FirstOrDefault((EntityInput inp) => inp.TypeUid == property.TypeUid);
		if (entityInput != null)
		{
			if (!readOnly)
			{
				return entityInput.HasEditor(property, controllerContext);
			}
			return entityInput.HasDisplay(property, controllerContext);
		}
		return false;
	}
}
