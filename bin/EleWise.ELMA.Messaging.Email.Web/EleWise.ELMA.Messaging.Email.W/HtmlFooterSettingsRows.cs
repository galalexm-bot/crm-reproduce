using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging.Email.Models;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html.FileBrowser;
using EleWise.ELMA.Web.Mvc.Html.Forms;
using EleWise.ELMA.Web.Mvc.Models.Settings;
using HtmlAgilityPack;

namespace EleWise.ELMA.Messaging.Email.Web.Components;

[Component]
public class HtmlFooterSettingsRows : IGlobalSettingsRows
{
	public IEnumerable<IRowDriver> GetRowDrivers(Guid moduleGuid)
	{
		return null;
	}

	public GlobalSettingsSaveResult SaveSettings(Guid moduleGuid, ControllerContext context, GlobalSettingsBase settingsModel)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		GlobalSettingsSaveResult globalSettingsSaveResult = new GlobalSettingsSaveResult
		{
			ErrorMessage = string.Empty,
			Success = true
		};
		EmailSettingsModule service = Locator.GetService<EmailSettingsModule>();
		if (service == null)
		{
			globalSettingsSaveResult.ErrorMessage = SR.T("Не удалось загрузить настройки модуля");
			globalSettingsSaveResult.Success = false;
			return globalSettingsSaveResult;
		}
		if (moduleGuid == service.ModuleGuid)
		{
			try
			{
				HtmlDocument val = new HtmlDocument
				{
					OptionFixNestedTags = true,
					OptionAutoCloseOnEnd = true,
					OptionDefaultStreamEncoding = Encoding.UTF8
				};
				val.LoadHtml(service.Settings.HtmlBodyFooter.ToString());
				HtmlNode documentNode = val.get_DocumentNode();
				FooterFileModel htmlFiles = GetHtmlFiles(documentNode);
				htmlFiles.HtmlFooter = documentNode.get_InnerHtml();
				DataAccessManager.BLOBManager.SetBLOB(EmailSettings.HtmlFooterFileUid, "HtmlFooterFile", ClassSerializationHelper.SerializeObjectByJson(htmlFiles));
				service.SaveSettings();
				globalSettingsSaveResult.Success = true;
				globalSettingsSaveResult.ErrorMessage = null;
				return globalSettingsSaveResult;
			}
			catch (Exception ex)
			{
				globalSettingsSaveResult.Success = false;
				globalSettingsSaveResult.ErrorMessage = SR.T("Ошибка при сохранении настроек системы: {0}", ex.Message);
				return globalSettingsSaveResult;
			}
		}
		return globalSettingsSaveResult;
	}

	private FooterFileModel GetHtmlFiles(HtmlNode node, FooterFileModel model = null)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		FooterFileModel footerFileModel = model ?? new FooterFileModel();
		if ((int)node.get_NodeType() == 1 && node.get_Name().Equals("img", StringComparison.OrdinalIgnoreCase))
		{
			HtmlAttribute val = (node.get_Attributes().Contains("src") ? node.get_Attributes().get_Item("src") : null);
			if (val != null && val.get_Value().IndexOf("http:", StringComparison.OrdinalIgnoreCase) < 0 && val.get_Value().IndexOf("https:", StringComparison.OrdinalIgnoreCase) < 0)
			{
				string filePhysicalPath = new ImageBrowserController(ComponentManager.Current.GetExtensionPoints<IMediaFileProvider>()).GetByPath(val.get_Value()).GetFilePhysicalPath(val.get_Value());
				string text = Guid.NewGuid().ToString();
				footerFileModel.FileInfo.Add(text, filePhysicalPath);
				val.set_Value($"cid:{text}");
			}
		}
		if (node.get_HasChildNodes())
		{
			foreach (HtmlNode item in (IEnumerable<HtmlNode>)node.get_ChildNodes())
			{
				GetHtmlFiles(item, footerFileModel);
			}
			return footerFileModel;
		}
		return footerFileModel;
	}
}
