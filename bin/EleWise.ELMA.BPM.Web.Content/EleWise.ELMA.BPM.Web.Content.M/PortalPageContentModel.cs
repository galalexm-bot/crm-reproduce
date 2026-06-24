using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Web.Mvc.Models.Portal;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class PortalPageContentModel : IPageContentModel
{
	public IPortalObject Page { get; set; }

	public PortalModel PortalModel { get; set; }

	public bool CanChangeShared { get; set; }
}
