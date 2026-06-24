namespace EleWise.ELMA.BPM.Web.Common.Models;

public class CatalogViewModel : EntityViewModel
{
	public bool HasViewPermission { get; set; }

	public bool HasEditPermission { get; set; }

	public bool HasAddPermission { get; set; }

	public bool HasDeletePermission { get; set; }
}
