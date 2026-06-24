using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html.Forms;

namespace EleWise.ELMA.Web.Mvc.Models.Settings;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public abstract class GlobalSettingsModuleControllerBase<TSettings, TSettingsModule> : IRowDriverSettingsModuleController, IGlobalSettingsModuleController, IFormDriver<IRowDriver> where TSettings : GlobalSettingsBase, new()where TSettingsModule : GlobalSettingsModuleBase<TSettings>
{
	public virtual string ModuleName => Module.ModuleName;

	public virtual bool Editable => true;

	public virtual bool Visible => true;

	public TSettingsModule Module { get; set; }

	IGlobalSettingsModule IGlobalSettingsModuleController.Module => Module;

	protected GlobalSettingsModuleControllerBase(TSettingsModule module)
	{
		Module = module;
	}

	protected virtual IEnumerable<RowDriverForModel<TSettings>> GetRows()
	{
		return new FormDriverForModel<TSettings>().GetRowDrivers();
	}

	public virtual MvcHtmlString Header(HtmlHelper html)
	{
		return MvcHtmlString.Create(ModuleName);
	}

	public virtual MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return PartialExtensions.Partial(html, "Templates/GlobalSettings", (object)this);
	}

	public virtual MvcHtmlString RenderEdit(HtmlHelper html)
	{
		return PartialExtensions.Partial(html, "Templates/GlobalSettingsEdit", (object)this);
	}

	public IEnumerable<IRowDriver> GetRowDrivers()
	{
		foreach (RowDriverForModel<TSettings> row in GetRows())
		{
			yield return row;
		}
		IEnumerable<IGlobalSettingsRows> extensionPoints = ComponentManager.Current.GetExtensionPoints<IGlobalSettingsRows>();
		foreach (IRowDriver item in extensionPoints.SelectMany((IGlobalSettingsRows row) => row.GetRowDrivers(Module.ModuleGuid)))
		{
			yield return item;
		}
	}

	protected virtual void ReadSettings(ControllerContext context)
	{
	}

	public GlobalSettingsSaveResult SaveSettings(ControllerContext context)
	{
		GlobalSettingsSaveResult globalSettingsSaveResult = new GlobalSettingsSaveResult();
		try
		{
			using (IEnumerator<GlobalSettingsSaveResult> enumerator = (from row in ComponentManager.Current.GetExtensionPoints<IGlobalSettingsRows>()
				select row.SaveSettings(Module.ModuleGuid, context, Module.Settings) into r
				where !r.Success
				select r).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					return enumerator.Current;
				}
			}
			ReadSettings(context);
			Module.SaveSettings();
			globalSettingsSaveResult.Success = true;
			globalSettingsSaveResult.ErrorMessage = null;
			return globalSettingsSaveResult;
		}
		catch (Exception ex)
		{
			globalSettingsSaveResult.Success = false;
			globalSettingsSaveResult.ErrorMessage = SR.T("Ошибка при сохранении настроек системы: {0}", ex.Message);
			Logger.Log.Error(SR.T("Ошибка при сохранении настроек системы"), ex);
			return globalSettingsSaveResult;
		}
	}
}
