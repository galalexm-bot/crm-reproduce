using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Binders;

public class DelimitedStringBinderAttribute : CustomModelBinderAttribute
{
	private readonly char[] separator;

	public DelimitedStringBinderAttribute(params char[] separator)
	{
		this.separator = separator;
	}

	public override IModelBinder GetBinder()
	{
		return (IModelBinder)(object)new DelimitedStringBinder(separator);
	}
}
