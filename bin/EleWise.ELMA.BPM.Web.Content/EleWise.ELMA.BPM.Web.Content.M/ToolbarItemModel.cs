using System.ComponentModel.DataAnnotations;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Content.Models.Toolbar;

public class ToolbarItemModel
{
	[System.ComponentModel.DataAnnotations.Required]
	[EleWise.ELMA.Model.Attributes.Required(true)]
	public LinkModel Link { get; set; }

	public ToolbarTreeItem ToolbarItem { get; set; }

	public bool IsNew { get; set; }

	public string ParentId { get; set; }

	public ToolbarItemModel()
	{
		Link = new LinkModel();
	}

	public ToolbarItemModel(ToolbarTreeItem toolbarItem, ContentActionRegistry contentActionRegistry, string actionProviderId, string actionId)
	{
		Link = LinkModel.Create(contentActionRegistry, actionProviderId, actionId);
		ToolbarItem = toolbarItem;
	}
}
