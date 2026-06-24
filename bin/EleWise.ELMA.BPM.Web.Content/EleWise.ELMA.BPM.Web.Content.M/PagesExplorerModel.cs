using System.Collections.Generic;
using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class PagesExplorerModel
{
	public string Id { get; set; }

	public IPageFolder Folder { get; set; }

	public List<IPortalObject> Items { get; set; }

	public int? Height { get; set; }

	public string DisabledItemsJson { get; set; }

	public bool Personal { get; set; }
}
