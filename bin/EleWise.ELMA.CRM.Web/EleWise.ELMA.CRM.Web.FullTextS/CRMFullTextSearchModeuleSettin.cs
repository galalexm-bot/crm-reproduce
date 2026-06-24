using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.FullTextSearch;
using EleWise.ELMA.CRM.Web.FullTextSearch.Models;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.FullTextSearch.Manager;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.FullTextSearch.Services;
using EleWise.ELMA.FullTextSearch.Settings;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Web.FullTextSearch.Components;

[Component(Type = ComponentType.Web)]
public class CRMFullTextSearchModeuleSettingsRender : IFullTextSearchModuleSettingsRender
{
	private IFullTextSearchService fullTextSearchService;

	private IndexQueueManager indexQueueManager;

	public IGlobalSettingsModule Module => Locator.GetService<CRMFullTextSearchSettingsModule>();

	public CRMFullTextSearchModeuleSettingsRender(IFullTextSearchService fullTextSearchService, IndexQueueManager indexQueueManager)
	{
		this.fullTextSearchService = fullTextSearchService;
		this.indexQueueManager = indexQueueManager;
	}

	public bool IsSupported(IFullTextSearchModuleSettings settings)
	{
		return settings is CRMFullTextSearchSettings;
	}

	public MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		CRMFullTextSearchSettingsModel cRMFullTextSearchSettingsModel = new CRMFullTextSearchSettingsModel();
		cRMFullTextSearchSettingsModel.Settings = serviceNotNull.Settings;
		cRMFullTextSearchSettingsModel.IndexState = fullTextSearchService.GetIndexState();
		cRMFullTextSearchSettingsModel.ReIndexState = indexQueueManager.HasIndexAllReIndexByTypeQueue();
		return PartialExtensions.Partial(html, "FullTextSearch/Settings/FullTextSearchCRMSettingsViewForm", (object)cRMFullTextSearchSettingsModel);
	}

	public MvcHtmlString RenderEdit(HtmlHelper html)
	{
		CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
		return PartialExtensions.Partial(html, "FullTextSearch/Settings/FullTextSearchCRMSettingsEditForm", (object)serviceNotNull.Settings);
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
