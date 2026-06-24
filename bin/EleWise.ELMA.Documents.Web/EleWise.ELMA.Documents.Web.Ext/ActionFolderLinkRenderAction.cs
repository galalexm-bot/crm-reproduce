using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Extensions.Links;

[Component]
public class ActionFolderLinkRenderAction : IEntityLinkRenderAction
{
	public Type EntityType => null;

	public Guid TypeUid => InterfaceActivator.UID<IActionFolder>();

	public bool LoadEntityIfNull => true;

	public void Render(HtmlHelper html, IEntity entity)
	{
		if (entity is IActionFolder actionFolder)
		{
			Locator.GetService<ContentActionRegistry>().Get(actionFolder.ActionTypeProviderId, actionFolder.ActionId)?.OnRender(html);
		}
	}
}
