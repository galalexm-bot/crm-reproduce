using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component]
internal sealed class PageV2LinkTypeProvider : LinkTypeProvider, ILinkTypeProvider
{
	public override bool ShowInTree => false;

	public string Id => "EleWise.ELMA.Web.Content.ContentActionConstants.PageLinkTypeProvider";

	public string Name => SR.T("Страница");

	public int? Order => 0;

	public override MvcHtmlString GetSelectedScript(HtmlHelper htmlHelper)
	{
		return MvcHtmlString.Create("BuildActionId()");
	}

	public IContentAction Get(string id)
	{
		string text = id.Replace("configuration_pagev2_", "");
		int num = text.IndexOf('?');
		string[] array = ((num != -1) ? text.Substring(0, num) : text).Split('_');
		string text2 = array[0];
		string text3 = array[1];
		string url = text.Substring(text2.Length + 1);
		return new ContentAction
		{
			Id = "configuration_pagev2_" + text3,
			DescriptionForLocalization = text2,
			NameForLocalization = text2,
			LinkTemplate = (RequestContext context) => "/UI/Page/" + url,
			Image24 = "#page_outline.svg",
			ReferenceType = "Page",
			Category = SR.M("Страницы конфигурации")
		};
	}

	public MvcHtmlString RenderSelector(HtmlHelper htmlHelper)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		object obj = default(object);
		if (!htmlHelper.get_ViewData().TryGetValue("PageName", ref obj))
		{
			return new MvcHtmlString(SR.T("Не задано имя страницы"));
		}
		ComponentMetadataItemHeaderFilter filter = new ComponentMetadataItemHeaderFilter
		{
			Name = obj.ToString(),
			IsPublished = true,
			MetadataTypeUid = PageComponentMetadata.TypeUid
		};
		ComponentMetadataItemHeader componentMetadataItemHeader = AbstractNHEntityManager<ComponentMetadataItemHeader, long>.Instance.Find(filter, FetchOptions.First).FirstOrDefault();
		if (componentMetadataItemHeader == null)
		{
			return new MvcHtmlString(SR.T("Не найдено опубликованной страницы с именем \"{0}\"", obj));
		}
		ComponentMetadataItem published = componentMetadataItemHeader.Published;
		PageComponentMetadata pageComponentMetadata = (PageComponentMetadata)published.Metadata;
		List<string> propertyNames = (from property in PortalObjectHelper.GetPageInputs(pageComponentMetadata.Content.Context)
			select property.Name).ToList();
		Assembly assembly = ComponentManager.FindLoadedAssembly(ScriptExecutionHandlerHelper.CreateFullAssemblyName(published.AssemblyName, published.AssemblyVersion), isFullName: true);
		if (assembly == null)
		{
			ScriptModule scriptModule = published.ScriptModule;
			assembly = ComponentManager.LoadAssembly(scriptModule.AssemblyRaw, scriptModule.DebugRaw);
		}
		string name = pageComponentMetadata.FullTypeName + "+" + pageComponentMetadata.Content.Context.Name;
		object context = InterfaceActivator.Create(assembly.GetType(name));
		PageInputsModel pageInputsModel = new PageInputsModel
		{
			ActionId = "configuration_pagev2_" + componentMetadataItemHeader.DisplayName + "_" + componentMetadataItemHeader.Name,
			Context = context,
			PropertyNames = propertyNames
		};
		return PartialExtensions.Partial(htmlHelper, "ContentSelectors/PageV2InputsSelector", (object)pageInputsModel);
	}

	protected override string ValueElement(HtmlHelper htmlHelper)
	{
		return null;
	}

	protected override string TextElement(HtmlHelper htmlHelper)
	{
		return null;
	}
}
