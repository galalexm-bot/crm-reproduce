namespace EleWise.ELMA.BPM.Web.Common.Models;

public class PortletGridFilterModel
{
	public object ViewModel { get; set; }

	public string ViewName { get; set; }

	public string FilterGridId { get; set; }

	public bool ShowFilterFields { get; set; }

	public FilterModel FilterModel { get; set; }
}
