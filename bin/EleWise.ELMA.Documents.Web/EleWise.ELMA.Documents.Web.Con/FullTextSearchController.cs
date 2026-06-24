using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Documents.FullTextSearch;
using EleWise.ELMA.Documents.FullTextSearch.Components;
using EleWise.ELMA.Documents.FullTextSearch.Model;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.Documents.Web.Controllers;

public class FullTextSearchController : BPMController
{
	[CustomGridAction]
	public ActionResult FullSearchResultGrid(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel filterModel)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		IFullTextSearchService serviceNotNull = Locator.GetServiceNotNull<IFullTextSearchService>();
		DocumentsFullTextSearchSettingsModule serviceNotNull2 = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		if (serviceNotNull.IndexingIsWorking() && serviceNotNull2.Settings != null && serviceNotNull2.Settings.Indexing)
		{
			IDocumentFilter documentFilter = ((filterModel != null && filterModel.Filter != null) ? ((IDocumentFilter)filterModel.Filter) : InterfaceActivator.Create<IDocumentFilter>());
			if (command == null)
			{
				command = new GridCommand();
				string text = Convert.ToString(((ControllerBase)this).get_ViewData().get_Item("ResultGridId") ?? "document_search_grid_view");
				string text2 = ((ControllerBase)this).get_ControllerContext().get_HttpContext().Request.Params.Get("gridUniqueName");
				if (!string.IsNullOrWhiteSpace(text2) && text2.Contains(text))
				{
					string text3 = ((ControllerBase)this).get_ControllerContext().get_HttpContext().Request.Params.Get($"{text}-{GridUrlParameters.get_PageSize()}");
					if (!string.IsNullOrWhiteSpace(text3) && int.TryParse(text3, out var result))
					{
						command.set_PageSize(result);
					}
					string text4 = ((ControllerBase)this).get_ControllerContext().get_HttpContext().Request.Params.Get($"{text}-{GridUrlParameters.get_CurrentPage()}");
					if (!string.IsNullOrWhiteSpace(text4) && int.TryParse(text4, out var result2))
					{
						command.set_Page(result2);
					}
				}
			}
			FullTextSearchModel model = new FullTextSearchModel();
			model.SearchString = documentFilter.SearchString;
			model.Folder = documentFilter.Folder;
			model.DisableArchive = documentFilter.DisableArchive;
			model.IsArchived = documentFilter.IsArchived;
			model.HierarchicalByFolder = documentFilter.HierarchicalByFolder;
			model.PageIndex = command.get_Page();
			model.PageSize = command.get_PageSize();
			SearchVoid(ref model);
			GridData<FullTextSearchResultItem, IDocumentFilter> gridData = new GridData<FullTextSearchResultItem, IDocumentFilter>();
			gridData.Count = model.Result.CountAllResult;
			gridData.DataSource = model.Result.Items;
			gridData.IsPageable = true;
			gridData.PageSize = command.get_PageSize();
			gridData.Command = command;
			gridData.PageIndex = command.get_Page();
			if (model.Result != null && model.Result.Error != null)
			{
				((ControllerBase)this).get_ViewData().set_Item("FullTextSearchError", (object)model.Result.Error.Message);
			}
			return (ActionResult)(object)((Controller)this).PartialView("FullSearchResultGrid", (object)gridData);
		}
		GridData<FullTextSearchResultItem, IDocumentFilter> gridData2 = new GridData<FullTextSearchResultItem, IDocumentFilter>();
		gridData2.Count = 0;
		gridData2.DataSource = new List<FullTextSearchResultItem>();
		gridData2.IsPageable = true;
		if (command != null)
		{
			gridData2.PageSize = command.get_PageSize();
			gridData2.Command = command;
			gridData2.PageIndex = command.get_Page();
		}
		return (ActionResult)(object)((Controller)this).PartialView("FullSearchResultGrid", (object)gridData2);
	}

	private void SearchVoid(ref FullTextSearchModel model)
	{
		DocumentFullTextSearchResultModel resultModel = new DocumentFullTextSearchResultModel
		{
			SearchFolder = model.Folder,
			IsArchived = model.IsArchived,
			DisableArchive = model.DisableArchive,
			HierarchicalByFolder = model.HierarchicalByFolder,
			TypeUid = MetadataLoader.LoadMetadata(typeof(IDocument)).Uid
		};
		FullTextSearchResultModel result = Locator.GetServiceNotNull<IFullTextSearchService>().Search(typeof(IDocumentsFullTextSearchObject), resultModel, model.SearchString, model.PageIndex, model.PageSize);
		model.Result = result;
	}

	[HttpPost]
	public ActionResult IndexingOff()
	{
		Locator.GetServiceNotNull<IFullTextSearchService>().StopIndexingType(typeof(IDocumentsFullTextSearchObject));
		DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		serviceNotNull.Settings.Indexing = false;
		serviceNotNull.Settings.IndexingStopInfo = null;
		serviceNotNull.SaveSettings();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "FullTextSearch", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common"
		});
	}

	[HttpPost]
	public ActionResult IndexingVersionOff()
	{
		DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		serviceNotNull.Settings.IndexingVersion = false;
		serviceNotNull.Settings.IndexingStopInfo = null;
		serviceNotNull.SaveSettings();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index", "FullTextSearch", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common"
		});
	}

	[HttpGet]
	public ActionResult IndexingOn(bool indexVersion)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		IIndexQueue indexQueue = InterfaceActivator.Create<IIndexQueue>();
		indexQueue.QueueType = IndexQueueType.IndexByType;
		indexQueue.CardTypeUid = DocumentsFullTextSearchExtension.DocumentCardUid;
		indexQueue.Save();
		DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		serviceNotNull.Settings.Indexing = true;
		serviceNotNull.Settings.IndexingStopInfo = null;
		if (indexVersion)
		{
			serviceNotNull.Settings.IndexingVersion = true;
		}
		serviceNotNull.SaveSettings();
		JsonResult val = new JsonResult();
		val.set_Data((object)new
		{
			Result = true
		});
		val.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return (ActionResult)val;
	}
}
