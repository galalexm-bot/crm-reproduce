using System.Collections.Generic;
using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class OrganizerModel
{
	public List<IPortalObject> WorkplacePages { get; set; }

	public List<IHomePageSetting> SelectedPageSettings { get; set; }

	public string DisabledItems { get; set; }

	public bool AdminPermission { get; set; }

	public bool ReadOnly { get; set; }

	public OrganizerModel()
	{
		WorkplacePages = new List<IPortalObject>();
		SelectedPageSettings = new List<IHomePageSetting>();
	}
}
