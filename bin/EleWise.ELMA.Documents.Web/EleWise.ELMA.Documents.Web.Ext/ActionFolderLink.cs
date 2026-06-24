using System;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Extensions.Links;

[Component]
public class ActionFolderLink : IEntityLink
{
	public Type EntityType => null;

	public Guid TypeUid => InterfaceActivator.UID<IActionFolder>();

	public string IdParam => "id";

	public bool LoadEntityIfNull => true;

	public string Area(IEntity entity)
	{
		return "EleWise.ELMA.Documents.Web";
	}

	public string Action(IEntity entity)
	{
		return "View";
	}

	public string Controller(IEntity entity)
	{
		return "Folder";
	}

	public RouteValueDictionary GetParams(IEntity entity)
	{
		return null;
	}

	public string Href(RequestContext html, IEntity entity)
	{
		if (entity is IActionFolder actionFolder)
		{
			IContentAction contentAction = Locator.GetServiceNotNull<ContentActionRegistry>().Get(actionFolder.ActionTypeProviderId, actionFolder.ActionId);
			if (contentAction == null)
			{
				return null;
			}
			return Run(contentAction, html);
		}
		return null;
	}

	private string Run(IContentAction action, RequestContext requestContext)
	{
		return new ContentActionModel(action).Run(requestContext);
	}
}
