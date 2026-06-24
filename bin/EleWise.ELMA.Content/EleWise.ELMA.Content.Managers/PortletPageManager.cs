using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Content.Managers;

public class PortletPageManager : PageBaseManager<IPortletPage>
{
	public new static PortletPageManager Instance => Locator.GetServiceNotNull<PortletPageManager>();
}
