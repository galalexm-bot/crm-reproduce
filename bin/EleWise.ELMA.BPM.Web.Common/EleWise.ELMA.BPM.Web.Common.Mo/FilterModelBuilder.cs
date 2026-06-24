using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.WebPages;
using EleWise.ELMA.Web.Mvc.Models.ActionItems;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class FilterModelBuilder
{
	public FilterModel Model { get; private set; }

	public FilterModelBuilder(FilterModel model)
	{
		Model = model;
	}

	public FilterModelBuilder DisableSaveColumns(List<string> disableSaveColumns)
	{
		Model.DisableSaveColumns = disableSaveColumns;
		return this;
	}

	public FilterModelBuilder ShowOnlyMyProperty(string showOnlyMyProperty)
	{
		return ShowOnlyMyProperty(showOnlyMyProperty, "");
	}

	public FilterModelBuilder ShowOnlyMyProperty(string showOnlyMyProperty, string displayName)
	{
		Model.ShowOnlyMyProperty = showOnlyMyProperty;
		Model.ShowOnlyMyPropertyDisplayName = displayName;
		return this;
	}

	public FilterModelBuilder ShowFullTextInAttachments(bool showFullTextInAttachments)
	{
		return ShowFullTextInAttachments(showFullTextInAttachments, "");
	}

	public FilterModelBuilder ShowFullTextInAttachments(bool showFullTextInAttachments, string displayName)
	{
		Model.ShowFullTextInAttachments = showFullTextInAttachments;
		Model.ShowFullTextInAttachmentsDisplayName = displayName;
		return this;
	}

	public FilterModelBuilder ApplayFilterScript(string applayFilterScript)
	{
		Model.ApplayFilterScript = applayFilterScript;
		return this;
	}

	public FilterModelBuilder GridAction(string gridAction)
	{
		Model.GridAction = gridAction;
		return this;
	}

	public FilterModelBuilder HiddenInputs(Dictionary<string, object> hiddenInputs)
	{
		Model.HiddenInputs = hiddenInputs;
		return this;
	}

	public FilterModelBuilder HiddenInput(string name, object value)
	{
		if (Model.HiddenInputs == null)
		{
			Model.HiddenInputs = new Dictionary<string, object>();
		}
		Model.HiddenInputs[name] = value;
		return this;
	}

	public FilterModelBuilder SetFastSaveFilterRoute(string action, string actionSave, string controller, string area)
	{
		if (!string.IsNullOrEmpty(action))
		{
			Model.FastSaveFilterAction = action;
		}
		if (!string.IsNullOrEmpty(actionSave))
		{
			Model.FastSaveFilterActionSave = actionSave;
		}
		if (!string.IsNullOrEmpty(controller))
		{
			Model.FastSaveFilterController = controller;
		}
		if (!string.IsNullOrEmpty(area))
		{
			Model.FastSaveFilterArea = area;
		}
		return this;
	}

	public FilterModelBuilder HeaderContent(Func<HtmlHelper<FilterModel>, HelperResult> headerContent)
	{
		Model.HeaderContent = (HtmlHelper<FilterModel> html) => MvcHtmlString.Create(headerContent(html).ToHtmlString());
		return this;
	}

	public FilterModelBuilder HeaderContent(Func<HtmlHelper<FilterModel>, MvcHtmlString> headerContent)
	{
		Model.HeaderContent = headerContent;
		return this;
	}

	public FilterModelBuilder SimpleSearchTr(Func<HtmlHelper<FilterModel>, HelperResult> simpleSearchTr)
	{
		Model.SimpleSearchTr = (HtmlHelper<FilterModel> html) => MvcHtmlString.Create(simpleSearchTr(html).ToHtmlString());
		return this;
	}

	public FilterModelBuilder SimpleSearchTr(Func<HtmlHelper<FilterModel>, MvcHtmlString> simpleSearchTr)
	{
		Model.SimpleSearchTr = simpleSearchTr;
		return this;
	}

	public FilterModelBuilder SubmitText(string submitText)
	{
		Model.SubmitText = submitText;
		return this;
	}

	public FilterModelBuilder EnableSave(bool? enableSave = true)
	{
		Model.EnableSave = enableSave;
		return this;
	}

	public FilterModelBuilder ExtededSearchText(string extededSearchText)
	{
		Model.ExtededSearchText = extededSearchText;
		return this;
	}

	public FilterModelBuilder SimpleSearchText(string simpleSearchText)
	{
		Model.SimpleSearchText = simpleSearchText;
		return this;
	}

	public FilterModelBuilder FilterUrl(string filterUrl)
	{
		Model.FilterUrl = filterUrl;
		return this;
	}

	[Obsolete("Испльзовать точку расширения IFilterPropertiesExtension, и ставить свойствам Hidden=true")]
	public FilterModelBuilder HiddenColumns(List<string> hiddenColumns)
	{
		Model.HiddenColumns = hiddenColumns;
		return this;
	}

	[Obsolete("Испльзовать точку расширения IFilterPropertiesExtension, и ставить свойствам Visible=false")]
	public FilterModelBuilder IgnoreColumns(List<string> ignoreColumns)
	{
		Model.IgnoreColumns = ignoreColumns;
		return this;
	}

	public FilterModelBuilder DefaultFields(List<Guid> defaultFields)
	{
		Model.DefaultFields = defaultFields;
		return this;
	}

	public FilterModelBuilder ForceMoveFields(List<Guid> forceMoveFields)
	{
		Model.ForceMoveFields = forceMoveFields;
		return this;
	}

	public FilterModelBuilder SaveFilterCallback(string value)
	{
		Model.SaveFilterCallback = value;
		return this;
	}

	public FilterModelBuilder Header(string header)
	{
		Model.Header = header;
		return this;
	}

	public FilterModelBuilder FilterLinkUrl(string url)
	{
		Model.FilterLinkUrl = url;
		return this;
	}

	public FilterModelBuilder FilterLinkSaveSelector(string saveSelector)
	{
		Model.FilterLinkSaveSelector = saveSelector;
		return this;
	}

	public FilterModelBuilder FilterMenuItemCode(string codeId)
	{
		Model.FilterMenuItemCode = codeId;
		return this;
	}

	public FilterModelBuilder AddButton(ActionButton button)
	{
		Model.Buttons.Add(button);
		return this;
	}
}
