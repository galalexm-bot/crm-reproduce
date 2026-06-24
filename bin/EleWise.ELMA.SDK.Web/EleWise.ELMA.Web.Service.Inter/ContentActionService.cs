using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Templates.Content.IconPack;
using EleWise.ELMA.Web.Service.Internal.Model;

namespace EleWise.ELMA.Web.Service.Internal;

[Service]
internal sealed class ContentActionService : IContentActionService
{
	private static ControllerActionRegistry ControllerActionRegistry => Locator.GetService<ControllerActionRegistry>();

	public IEnumerable<EleWise.ELMA.Web.Service.Internal.Model.ContentAction> LoadAll()
	{
		if (ControllerActionRegistry == null)
		{
			return Enumerable.Empty<EleWise.ELMA.Web.Service.Internal.Model.ContentAction>();
		}
		return (from action in ControllerActionRegistry.All().OfType<IContentAction>()
			where action.Id == "EleWise.ELMA.Web.Components.FormActionProvider" || action.ActionType != EleWise.ELMA.Web.Content.ContentAction.ActionTypeDialog
			select action).Select(Convert);
	}

	public FormBindingModel LoadFormBindingModel(ContentActionId id)
	{
		string[] array = id.Value.Split(new string[1] { "-BEFE1D44-62F6-457E-B628-F6CDC62FC2C9-" }, StringSplitOptions.None);
		string text = ((array.Length > 1) ? array[array.Length - 2] : "");
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		return ClassSerializationHelper.DeserializeObjectByXml<FormBindingModel>(text);
	}

	public ContentActionId LoadActionId(FormBindingModel formBindingModel, Guid buttonUid)
	{
		return new ContentActionId
		{
			Value = GenerateButtonId(formBindingModel, buttonUid)
		};
	}

	private static EleWise.ELMA.Web.Service.Internal.Model.ContentAction Convert(IContentAction action)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		string typeProviderId = ((action.Id == "EleWise.ELMA.Web.Components.FormActionProvider") ? "EleWise.ELMA.Web.Components.FormActionProvider" : (action.Id.StartsWith("configuration_pagev2") ? "EleWise.ELMA.Web.Content.ContentActionConstants.PageLinkTypeProvider" : "ActionsLinkTypeProvider"));
		RequestContext requestContext = new RequestContext(HttpContextAccessor.CurrentContext, new RouteData());
		UrlHelper url = new UrlHelper(requestContext);
		return new EleWise.ELMA.Web.Service.Internal.Model.ContentAction
		{
			TypeProviderId = typeProviderId,
			Id = action.Id,
			Name = action.Name,
			Category = SR.T(action.Category),
			Order = action.Order,
			ActionType = SR.T(action.ActionType),
			Image16 = url.GetIcon(action.Image16),
			Image24 = url.GetIcon(action.Image24),
			Image32 = url.GetIcon(action.Image32),
			Href = action.GetHref(requestContext)
		};
	}

	private static string GenerateButtonId(FormBindingModel model, Guid buttonUid)
	{
		string text = ClassSerializationHelper.SerializeObjectByXml(model);
		string text2 = model.ViewType?.ToString() ?? string.Empty;
		Guid guid = ((model.HeaderUid != Guid.Empty) ? model.HeaderUid : (model.FormUid ?? Guid.Empty));
		string text3 = ((!string.IsNullOrEmpty(model.PopupHeader)) ? model.PopupHeader : model.FormName);
		return string.Join("-BEFE1D44-62F6-457E-B628-F6CDC62FC2C9-", model.TypeUid, guid, text2, text3, model.PopupWidth, text, buttonUid);
	}
}
