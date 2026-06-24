using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.Documents.Web.ContentLinkTypeProviders;

[Component]
[ActionWizardItem(Order = 40, Image32 = "#folder.svg", Category = ActionWizardItemCategory.Link)]
public class FolderContentLinkProviders : LinkTypeProvider, ILinkTypeProvider
{
	public string Id => "FolderLinkTypeProvider";

	public string Name => SR.M("Папка");

	public int? Order => 25;

	public override string Image => "#folder.svg";

	public FolderManager FolderManager { get; set; }

	public ISecurityService SecurityService { get; set; }

	public IContentAction Get(string id)
	{
		if (!string.IsNullOrEmpty(id))
		{
			IFolder folder = null;
			if (long.TryParse(id, out var l_id))
			{
				SecurityService.RunWithElevatedPrivilegiesAndWithDeleted(delegate
				{
					folder = FolderManager.LoadOrNull(l_id);
				});
				ContentAction result = null;
				if (folder != null)
				{
					result = ((folder is IFilterDocumentFolder) ? new ContentAction
					{
						Id = id,
						Image24 = "#search.svg",
						ReferenceType = "Folder",
						Routes = new ActionRoute("View", "FilterDocument", new
						{
							area = "EleWise.ELMA.Documents.Web",
							FilterId = id,
							type = "filter"
						}),
						MatchCurrentDelegate = (RequestContext requestContext) => 0
					} : new ContentAction
					{
						Id = id,
						Image24 = "#folder.svg",
						ReferenceType = "Folder",
						Routes = new ActionRoute("View", "Folder", new
						{
							area = "EleWise.ELMA.Documents.Web",
							id = id,
							type = "folder"
						}),
						MatchCurrentDelegate = (RequestContext requestContext) => 0
					});
				}
				return result;
			}
			return null;
		}
		return null;
	}

	public MvcHtmlString RenderSelector(HtmlHelper htmlHelper)
	{
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/FolderSelector", (object)new FolderSelectorModel());
	}

	protected override string ValueElement(HtmlHelper htmlHelper)
	{
		return null;
	}

	protected override string TextElement(HtmlHelper htmlHelper)
	{
		return null;
	}

	public override MvcHtmlString GetSelectedScript(HtmlHelper htmlHelper)
	{
		return MvcHtmlString.Create("{var value = $('input[name=\"Folder.Id\"]').val(); var text = $('input[name=\"Folder.folder_name\"]').val(); if(!!value) {({value: value, text: text})} else undefined}");
	}

	public override string GetActionName(IContentAction contentAction)
	{
		long id = long.Parse(contentAction.Id);
		string text = SR.M("Не найдено");
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			IFolder folder = FolderManager.LoadOrNull(id);
			if (folder != null)
			{
				text = folder.Name;
			}
		});
		return text;
	}
}
