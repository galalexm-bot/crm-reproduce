using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.FullTextSearch;
using EleWise.ELMA.Documents.Web.FullTextSearch.Models;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.FullTextSearch.Components;

[Component(Type = ComponentType.Web)]
public class DocumentsFullTextSearchModeuleSettingsRender : IFullTextSearchModuleSettingsRender
{
	private IFullTextSearchService fullTextSearchService;

	private IndexQueueManager indexQueueManager;

	public IGlobalSettingsModule Module => Locator.GetService<DocumentsFullTextSearchSettingsModule>();

	public DocumentsFullTextSearchModeuleSettingsRender(IFullTextSearchService fullTextSearchService, IndexQueueManager indexQueueManager)
	{
		this.fullTextSearchService = fullTextSearchService;
		this.indexQueueManager = indexQueueManager;
	}

	public bool IsSupported(IFullTextSearchModuleSettings settings)
	{
		return settings is DocumentsFullTextSearchSettings;
	}

	public MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		DocumentsFullTextSearchModuleSettingsModel documentsFullTextSearchModuleSettingsModel = new DocumentsFullTextSearchModuleSettingsModel();
		documentsFullTextSearchModuleSettingsModel.IndexState = fullTextSearchService.GetIndexState();
		documentsFullTextSearchModuleSettingsModel.Settings = serviceNotNull.Settings;
		documentsFullTextSearchModuleSettingsModel.ReIndexState = indexQueueManager.HasIndexAllReIndexByTypeQueue();
		return PartialExtensions.Partial(html, "FullTextSearch/Settings/FullTextSearchDocumentSettingsViewForm", (object)documentsFullTextSearchModuleSettingsModel);
	}

	public MvcHtmlString RenderEdit(HtmlHelper html)
	{
		DocumentsFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<DocumentsFullTextSearchSettingsModule>();
		return PartialExtensions.Partial(html, "FullTextSearch/Settings/FullTextSearchDocumentSettingsEditForm", (object)serviceNotNull.Settings);
	}

	public FullTextSettingsSaveResult SaveSettings(ControllerContext context)
	{
		FullTextSettingsSaveResult fullTextSettingsSaveResult = new FullTextSettingsSaveResult();
		try
		{
			Module.SaveSettings();
			fullTextSettingsSaveResult.Success = true;
			fullTextSettingsSaveResult.ErrorMessage = null;
			return fullTextSettingsSaveResult;
		}
		catch (Exception ex)
		{
			fullTextSettingsSaveResult.Success = false;
			fullTextSettingsSaveResult.ErrorMessage = SR.T("Ошибка при сохранении настроек: {0}", ex.Message);
			return fullTextSettingsSaveResult;
		}
	}
}
