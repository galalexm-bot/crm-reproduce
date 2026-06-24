// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.FullTextSearch.Components.CRMFullTextSearchModeuleSettingsRender
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

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
using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace EleWise.ELMA.CRM.Web.FullTextSearch.Components
{
  [Component(Type = ComponentType.Web)]
  public class CRMFullTextSearchModeuleSettingsRender : IFullTextSearchModuleSettingsRender
  {
    private IFullTextSearchService fullTextSearchService;
    private IndexQueueManager indexQueueManager;

    public CRMFullTextSearchModeuleSettingsRender(
      IFullTextSearchService fullTextSearchService,
      IndexQueueManager indexQueueManager)
    {
      this.fullTextSearchService = fullTextSearchService;
      this.indexQueueManager = indexQueueManager;
    }

    public bool IsSupported(IFullTextSearchModuleSettings settings) => settings is CRMFullTextSearchSettings;

    public MvcHtmlString RenderDisplay(HtmlHelper html)
    {
      CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
      return html.Partial("FullTextSearch/Settings/FullTextSearchCRMSettingsViewForm", (object) new CRMFullTextSearchSettingsModel()
      {
        Settings = serviceNotNull.Settings,
        IndexState = this.fullTextSearchService.GetIndexState(),
        ReIndexState = this.indexQueueManager.HasIndexAllReIndexByTypeQueue()
      });
    }

    public MvcHtmlString RenderEdit(HtmlHelper html)
    {
      CRMFullTextSearchSettingsModule serviceNotNull = Locator.GetServiceNotNull<CRMFullTextSearchSettingsModule>();
      return html.Partial("FullTextSearch/Settings/FullTextSearchCRMSettingsEditForm", (object) serviceNotNull.Settings);
    }

    public FullTextSettingsSaveResult SaveSettings(ControllerContext context)
    {
      FullTextSettingsSaveResult settingsSaveResult = new FullTextSettingsSaveResult();
      try
      {
        this.Module.SaveSettings();
        settingsSaveResult.Success = true;
        settingsSaveResult.ErrorMessage = (string) null;
      }
      catch (Exception ex)
      {
        settingsSaveResult.Success = false;
        settingsSaveResult.ErrorMessage = EleWise.ELMA.SR.T("Ошибка при сохранении настроек: {0}", (object) ex.Message);
      }
      return settingsSaveResult;
    }

    public IGlobalSettingsModule Module => (IGlobalSettingsModule) Locator.GetService<CRMFullTextSearchSettingsModule>();
  }
}
