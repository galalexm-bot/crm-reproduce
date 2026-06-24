using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Panels;

namespace EleWise.ELMA.Web.Mvc.Models.Boxes;

public class AutocompleteComboBox
{
	public string AutocompleteActionUrl { get; set; }

	public bool MultiSelect { get; set; }

	public string HiddenForValues { get; set; }

	public HtmlAttributes HtmlAttributes { get; set; }

	public string Name { get; set; }

	public string ContainerId { get; set; }

	public string SelectorPostfix { get; set; }

	public string ControllerName { get; set; }

	public string ActionName { get; set; }

	public RouteValueDictionary RouteValueDictionary { get; set; }

	public IEnumerable<AutocompleteItem> SelectedEntities { get; set; }

	public Func<AutocompleteItem, object> SelectedItemTemplate { get; set; }

	public string SelectedItemTemplateJs { get; set; }

	public bool AlternativeVision { get; set; }

	public int MinimumChars { get; set; }

	public bool AutoFill { get; set; }

	public string OnChange { get; set; }

	public string OnClose { get; set; }

	public Popup SelectPopup { get; set; }

	public Popup CreatePopup { get; set; }

	public bool HideSelect { get; set; }

	public string SelectImageUrl { get; set; }

	public string SelectImageOnClick { get; set; }

	public string CreatePopupParams { get; set; }

	public string CreateImageUrl { get; set; }

	public string CreateImageOnClick { get; set; }

	public List<IFormCreator> FormCreator { get; set; }

	public string OnItemCreate { get; set; }

	public bool NeedClear { get; set; }

	public string ClearImageOnClick { get; set; }

	public bool Encode { get; set; }

	public IEnumerable<SelectListItem> BindTo { get; set; }

	public bool ShowDropDownIcon { get; set; }

	public string ComboBoxSelectImageUrl { get; set; }

	public string ComboBoxSelectOnClick { get; set; }

	public bool ShowComboBoxAddIcon { get; set; }

	public string ComboBoxAddImageUrl { get; set; }

	public string ComboBoxAddOnClick { get; set; }

	public bool ComboBoxAddLoading { get; set; }

	public string ComboBoxAddLoadingFunc { get; set; }

	public bool ComboBoxAddIconEnabled { get; set; }

	public bool ShowComboBoxDeleteIcon { get; set; }

	public string ComboBoxDeleteImageUrl { get; set; }

	public string ComboBoxDeleteOnClick { get; set; }

	public bool UseTemplate { get; set; }

	public Func<AutocompleteItem, object> Template { get; set; }

	public string TemplateJs { get; set; }

	public string TemplateOnLoad { get; set; }

	public bool ShowEditTemplateIcon { get; set; }

	public string EditTemplateImageUrl { get; set; }

	public string EditTemplateOnClick { get; set; }

	public bool NeedButtonDownloadAttachments { get; set; }

	public DownloadButtonModel DownloadButton { get; set; }

	public AutocompleteComboBox()
	{
		Name = "";
		SelectorPostfix = "";
		AutoFill = true;
		RouteValueDictionary = new RouteValueDictionary();
		SelectedEntities = new List<AutocompleteItem>();
		MinimumChars = 1;
		ContainerId = $"Container{UIExtensions.PrepareId(Guid.NewGuid().ToString())}";
		SelectPopup = new Popup
		{
			RegisterOnce = true,
			Width = 570,
			PopupHeader = SR.T("Выберите элементы")
		};
		Encode = true;
		ShowDropDownIcon = true;
	}
}
