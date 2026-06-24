using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class JsonBinderAttribute : CustomModelBinderAttribute
{
	public override IModelBinder GetBinder()
	{
		return (IModelBinder)(object)new JsonModelBinder();
	}
}
