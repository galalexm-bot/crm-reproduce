using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc;

public class ViewAttributesContainer
{
	public ViewAttributes ViewAttributes { get; set; }

	public ViewAttributesContainer()
	{
	}

	public ViewAttributesContainer(ViewAttributes viewAttributes)
	{
		ViewAttributes = viewAttributes;
	}
}
