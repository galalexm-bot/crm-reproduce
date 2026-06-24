using EleWise.ELMA.Common.Models.Filters;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class FilterPortletModel
{
	public string InstanceId { get; set; }

	public IFilter Filter { get; set; }

	public bool ShowOnlyMy { get; set; }

	public bool ShowFilterFields { get; set; }
}
