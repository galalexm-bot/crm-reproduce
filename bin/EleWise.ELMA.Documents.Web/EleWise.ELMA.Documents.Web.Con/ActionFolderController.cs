using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.Documents.FullTextSearch;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.Documents.Web.Controllers;

public class ActionFolderController : DmsController<IActionFolder, long>
{
	public ContentActionRegistry ContentActionRegistry { get; set; }

	[HttpGet]
	public ActionResult EditForm(long parentId, long? id, string popupId)
	{
		ActionFolderModel actionFolderModel = new ActionFolderModel();
		actionFolderModel.PopupId = popupId;
		if (!id.HasValue)
		{
			actionFolderModel.Entity = base.Manager.Create();
			actionFolderModel.Entity.Folder = FolderManager.Instance.Load(parentId);
		}
		else
		{
			actionFolderModel.Entity = base.Manager.Load(id.Value);
			actionFolderModel.Link = LinkModel.Create(ContentActionRegistry, actionFolderModel.Entity.ActionTypeProviderId, actionFolderModel.Entity.ActionId);
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)actionFolderModel);
	}

	private bool IndexingIsWorking()
	{
		IFullTextSearchService serviceNotNull = Locator.GetServiceNotNull<IFullTextSearchService>();
		DocumentsFullTextSearchSettingsModule serviceNotNull2 = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		if (serviceNotNull.IndexingIsWorking() && serviceNotNull2.Settings != null)
		{
			return serviceNotNull2.Settings.Indexing;
		}
		return false;
	}

	[HttpPost]
	public ActionResult Save(ActionFolderModel model)
	{
		if (string.IsNullOrEmpty(model.Link.ActionTypeProviderId) || string.IsNullOrEmpty(model.Link.ActionId))
		{
			base.Notifier.Error(SR.T("Не выбрано действие для папки"));
		}
		else
		{
			model.Entity.ActionTypeProviderId = model.Link.ActionTypeProviderId;
			model.Entity.ActionId = model.Link.ActionId;
			model.Entity.Virtual = true;
			model.Entity.Save();
			if (model.Entity != null)
			{
				if (IndexingIsWorking())
				{
					base.Notifier.Information(MvcHtmlString.Create(string.Format("<div>{0}</div> <br/><div style='font-size: 80%; font-style: italic; font-weight: normal !important;'> {1}</div>", SR.T("Сохранена папка-действие \"{0}\"", model.Entity.Name.HtmlEncode()), SR.T("Для занесения данных в индекс может потребоваться некоторое время").HtmlEncode())));
				}
				else
				{
					base.Notifier.Information(SR.T("Сохранена папка-действие \"{0}\"", model.Entity.Name));
				}
			}
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("View", "Folder", (object)new
		{
			id = model.Entity.Folder.Id
		});
	}
}
