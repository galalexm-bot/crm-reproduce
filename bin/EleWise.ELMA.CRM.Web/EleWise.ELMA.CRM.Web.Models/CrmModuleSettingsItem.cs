using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Models;

public class CrmModuleSettingsItem
{
	public string Category { get; set; }

	public string Url { get; set; }

	public string Image { get; set; }

	public string Text { get; set; }

	public string Description { get; set; }

	public int Order { get; set; }

	public IEnumerable<CrmModuleSettingsItem> Inheritors { get; set; }
}
