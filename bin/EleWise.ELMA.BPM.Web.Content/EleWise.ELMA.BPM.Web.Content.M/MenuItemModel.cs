using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class MenuItemModel
{
	public IMenuItem MenuItem { get; set; }

	public long? ParentItemId { get; set; }

	public LinkModel Link { get; set; }

	public IEnumerable<SelectListItem> ItemsList { get; set; }

	public bool HasChildrens { get; set; }

	public MembersTableModel Members { get; set; }

	public MenuItemModel()
	{
		Link = new LinkModel();
	}
}
