using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Models.DynamicForms;

namespace EleWise.ELMA.BPM.Web.Common.Components;

public static class DownloadButtonHelper
{
	private class ViewPropertiesModel
	{
		public Guid? TypeUid;

		public long ItemId;

		public string UidProperty;
	}

	private static ICheckAnyAttachmentServiceExt checkAnyAttachmentServiceExt;

	private static ICheckAnyAttachmentServiceExt CheckAnyAttachmentServiceExt => checkAnyAttachmentServiceExt ?? (checkAnyAttachmentServiceExt = Locator.GetServiceNotNull<ICheckAnyAttachmentServiceExt>());

	public static DownloadButtonModel GetButtonDownloadModel(this HtmlHelper html, ViewDataDictionary viewData)
	{
		ViewPropertiesModel viewProperties = GetViewProperties(html, viewData);
		return new DownloadButtonModel
		{
			Id = viewProperties.UidProperty,
			ImageUrl = "#save.svg",
			Text = SR.T("Скачать вложения"),
			Action = "downloadFilesForProperty(this,\"" + viewProperties.TypeUid.ToString() + "\")",
			NeedHide = false,
			TypeUid = (viewProperties.TypeUid.HasValue ? viewProperties.TypeUid.Value.ToString() : string.Empty),
			ItemId = viewProperties.ItemId
		};
	}

	public static DownloadButtonModel GetDownloadButtonModel(this HtmlHelper html, ViewDataDictionary viewData, bool onlyScripts = false)
	{
		DownloadButtonModel buttonDownloadModel = html.GetButtonDownloadModel(viewData);
		buttonDownloadModel.OnlyScripts = onlyScripts;
		return buttonDownloadModel;
	}

	public static string GetGuidStrProperty(this HtmlHelper html, ViewDataDictionary viewData)
	{
		EntityPropertyMetadata entityPropertyMetadata = null;
		if (viewData != null && viewData.get_ModelMetadata() != null && viewData.get_ModelMetadata().get_AdditionalValues() != null)
		{
			viewData.get_ModelMetadata().get_AdditionalValues().TryGetValue("ElmaPropertyMetadata", out var value);
			if (value != null)
			{
				entityPropertyMetadata = value as EntityPropertyMetadata;
			}
		}
		if (entityPropertyMetadata != null)
		{
			return entityPropertyMetadata.UidStr;
		}
		return string.Empty;
	}

	public static MvcHtmlString GetButtonDownload(this HtmlHelper html, ViewDataDictionary viewData)
	{
		return PartialExtensions.Partial(html, "DisplayTemplates/DownloadButton", (object)html.GetButtonDownloadModel(viewData));
	}

	public static Tuple<Guid?, bool> GetGuidAndAnyFilesProperty(this HtmlHelper html, ViewDataDictionary viewData)
	{
		ViewPropertiesModel viewProperties = GetViewProperties(html, viewData);
		bool item = false;
		if (viewProperties.TypeUid.HasValue)
		{
			_ = viewProperties.TypeUid.Value;
			if (viewProperties.TypeUid.Value != Guid.Empty && viewProperties.ItemId != 0L && !viewProperties.UidProperty.IsNullOrEmpty())
			{
				item = CheckAnyAttachmentServiceExt.CheckAnyTwoAndMoreAttachmentsFromProperty(viewProperties.TypeUid.Value, viewProperties.ItemId, viewProperties.UidProperty);
			}
		}
		return new Tuple<Guid?, bool>(viewProperties.TypeUid, item);
	}

	private static ViewPropertiesModel GetViewProperties(HtmlHelper html, ViewDataDictionary viewData)
	{
		Guid? guid = Guid.Empty;
		if (viewData.get_Item("View") is FormViewItem formViewItem)
		{
			guid = formViewItem.MetadataUid;
		}
		else if (viewData.get_Item("View") is PropertyViewItem propertyViewItem && propertyViewItem.FormViewItem != null)
		{
			guid = propertyViewItem.FormViewItem.MetadataUid;
		}
		else if (viewData.get_Item("DynamicFormChangeResultViewModel") is DynamicFormChangeResultViewModel dynamicFormChangeResultViewModel && dynamicFormChangeResultViewModel.View != null)
		{
			guid = dynamicFormChangeResultViewModel.View.MetadataUid;
		}
		string guidStrProperty = html.GetGuidStrProperty(viewData);
		long.TryParse((viewData.get_Item("ViewItemId") != null) ? viewData.get_Item("ViewItemId").ToString() : "0", out var result);
		if (result == 0L)
		{
			long.TryParse((viewData.get_Item("DynamicFormsProviderData") != null) ? viewData.get_Item("DynamicFormsProviderData").ToString() : "0", out result);
		}
		return new ViewPropertiesModel
		{
			TypeUid = (guid.HasValue ? guid.Value : Guid.Empty),
			ItemId = result,
			UidProperty = guidStrProperty
		};
	}
}
