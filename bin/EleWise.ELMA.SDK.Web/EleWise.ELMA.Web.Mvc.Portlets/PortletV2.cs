using System;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Security;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.Web.Mvc.Portlets;

internal sealed class PortletV2 : Portlet<UIPortletPersonalization>
{
	private readonly PortletComponentMetadata metadata;

	public override Guid Uid { get; }

	public override Type SettingsType { get; }

	public override string Name => metadata.DisplayName;

	public override string Description => metadata.Description;

	public override string Category { get; }

	internal PortletV2(ComponentMetadataItem componentMetadataItem)
		: base(initFromSelfType: false)
	{
		Contract.ArgumentNotNull(componentMetadataItem, "componentMetadataItem");
		Uid = componentMetadataItem.Header.Uid;
		metadata = (PortletComponentMetadata)componentMetadataItem.Metadata;
		Assembly assembly = ComponentManager.FindLoadedAssembly(ScriptExecutionHandlerHelper.CreateFullAssemblyName(componentMetadataItem.AssemblyName, componentMetadataItem.AssemblyVersion), isFullName: true);
		if (assembly == null)
		{
			assembly = ComponentManager.LoadAssembly(componentMetadataItem.ScriptModule.AssemblyRaw, componentMetadataItem.ScriptModule.DebugRaw);
		}
		if (assembly == null)
		{
			throw new Exception("Сборка для портлета не найдена!");
		}
		Category = SR.T("Портлеты конфигурации");
		string name = metadata.FullTypeName + "+" + metadata.PersonalizationContext.Name;
		SettingsType = assembly.GetType(name);
	}

	internal PortletV2(PortletComponentMetadata portletMetadata, Assembly assembly, string category)
		: base(initFromSelfType: false)
	{
		Contract.ArgumentNotNull(portletMetadata, "portletMetadata");
		Contract.ArgumentNotNull(assembly, "assembly");
		Contract.ArgumentNotNullOrEmpty(category, "category");
		metadata = portletMetadata;
		Uid = metadata.Uid;
		Category = category;
		string name = metadata.FullTypeName + "+" + metadata.PersonalizationContext.Name;
		SettingsType = assembly.GetType(name);
	}

	public override MvcHtmlString Content(HtmlHelper html, UIPortletPersonalization data)
	{
		return ChildActionExtensions.Action(html, "PortletV2", "UI", (object)new
		{
			area = "EleWise.ELMA.SDK.Web",
			portletUid = Uid,
			settings = data
		});
	}

	protected override Permission PortletPermission()
	{
		return null;
	}
}
