namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

public class DefaultHomePagePortlet
{
	public IPortlet Portlet { get; private set; }

	public string Zone { get; private set; }

	public int Order { get; private set; }

	public DefaultHomePagePortlet(IPortlet portlet, string zone, int order)
	{
		Portlet = portlet;
		Zone = zone;
		Order = order;
	}
}
