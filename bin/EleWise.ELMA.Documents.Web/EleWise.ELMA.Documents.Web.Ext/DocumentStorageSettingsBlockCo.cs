using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Web.Mvc.Models.Settings;

namespace EleWise.ELMA.Documents.Web.Extensions;

public class DocumentStorageSettingsBlockControllerBase<TSettings, TSettingsModule> : IDocumentStorageSettingsBlockController where TSettings : DocumentStorageSettingsBase, new()where TSettingsModule : DocumentStorageSettingsBlockBase<TSettings>
{
	public TSettingsModule Block { get; set; }

	IDocumentStorageSettingsBlock IDocumentStorageSettingsBlockController.Block => Block;

	public DocumentStorageSettingsBlockControllerBase(TSettingsModule block)
	{
		Block = block;
	}

	public virtual MvcHtmlString Header(HtmlHelper html)
	{
		return MvcHtmlString.Create(Block.BlockName);
	}

	public virtual MvcHtmlString RenderDisplay(HtmlHelper html)
	{
		return PartialExtensions.Partial(html, "Document/StorageSettings", (object)this);
	}

	public virtual MvcHtmlString RenderEdit(HtmlHelper html)
	{
		return PartialExtensions.Partial(html, "Document/StorageSettingsEdit", (object)this);
	}

	public virtual GlobalSettingsSaveResult SaveSettings(ControllerContext context)
	{
		GlobalSettingsSaveResult globalSettingsSaveResult = new GlobalSettingsSaveResult();
		try
		{
			Block.SaveSettings();
			globalSettingsSaveResult.Success = true;
			globalSettingsSaveResult.ErrorMessage = null;
			return globalSettingsSaveResult;
		}
		catch (Exception ex)
		{
			globalSettingsSaveResult.Success = false;
			globalSettingsSaveResult.ErrorMessage = ex.Message;
			return globalSettingsSaveResult;
		}
	}
}
