using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class AddMarketingTagPopupViewModel
{
	public string Id { get; set; }

	public IMarketingTag Entity { get; set; }

	public string PopupId { get; set; }

	public string DicesId { get; set; }

	public string Prefix { get; set; }

	public string JsonDataId { get; set; }

	public string IdAttributeName { get; set; }
}
