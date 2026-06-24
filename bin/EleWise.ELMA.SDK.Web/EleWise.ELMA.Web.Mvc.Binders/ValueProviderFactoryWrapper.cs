using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Binders;

internal class ValueProviderFactoryWrapper : ValueProviderFactory
{
	private readonly IValueProviderFactory valueProviderFactory;

	public ValueProviderFactoryWrapper(IValueProviderFactory valueProviderFactory)
	{
		this.valueProviderFactory = valueProviderFactory;
	}

	public override IValueProvider GetValueProvider(ControllerContext controllerContext)
	{
		return valueProviderFactory.GetValueProvider(controllerContext);
	}
}
