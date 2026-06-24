using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Messages.Web.Components.Links;

[Component]
public class InformationChannelLink : IEntityLink
{
	public Type EntityType => null;

	public Guid TypeUid => InterfaceActivator.UID<IInformationChannel>();

	public string IdParam => "BaseMessageFilter.ChannelId";

	public bool LoadEntityIfNull => true;

	public string Area(IEntity entity)
	{
		return "EleWise.ELMA.Messages.Web";
	}

	public string Action(IEntity entity)
	{
		return "List";
	}

	public string Controller(IEntity entity)
	{
		return "BaseMessage";
	}

	public RouteValueDictionary GetParams(IEntity entity)
	{
		if (entity != null)
		{
			return new RouteValueDictionary
			{
				{ "BaseMessageFilter.ChannelMessages", true },
				{
					"BaseMessageFilter.ChannelId",
					entity.GetId()
				}
			};
		}
		return null;
	}

	public string Href(RequestContext html, IEntity entity)
	{
		return null;
	}
}
