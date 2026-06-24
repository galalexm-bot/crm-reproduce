using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Content.Models.Toolbar;

public class ToolbarTreeModel : TreeModel
{
	public ToolbarTreeItem Root { get; set; }

	public ToolbarTreeItem ChangedRoot { get; set; }

	public string VirtualPath { get; set; }

	public string UrlReferrer { get; set; }

	public IWebToolbar Toolbar { get; set; }

	public IWorkPlace WorkPlace { get; set; }

	public IWorkPlace[] WorkPlaces { get; set; }
}
