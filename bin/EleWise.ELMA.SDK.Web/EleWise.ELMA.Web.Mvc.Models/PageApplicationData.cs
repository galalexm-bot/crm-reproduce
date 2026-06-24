using System;
using System.Collections.Generic;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.UI.Services;

namespace EleWise.ELMA.Web.Mvc.Models;

public sealed class PageApplicationData
{
	public static string DynamicFormsProviderDataKey = "__DynamicFormsProviderData";

	public Guid PageUid { get; }

	public Dictionary<string, object> InputModel { get; }

	public Guid ApplicationId { get; set; }

	public DynamicFormSettings DynamicFormSettings { get; set; }

	public PageApplicationData(Guid pageUid)
		: this(pageUid, new Dictionary<string, object>())
	{
	}

	public PageApplicationData(Guid pageUid, Dictionary<string, object> inputModel)
	{
		PageUid = pageUid;
		InputModel = inputModel;
		DynamicFormSettings = new DynamicFormSettings
		{
			DynamicFormsProviderUid = ComponentDynamicFormProvider.UID,
			ViewProviderUid = ComponentViewItemProvider.UID
		};
		if (inputModel.TryGetValue(DynamicFormsProviderDataKey, out var value))
		{
			DynamicFormSettings.DynamicFormsProviderData = value.ToString();
			DynamicFormSettings.ViewItemId = value.ToString();
		}
	}
}
