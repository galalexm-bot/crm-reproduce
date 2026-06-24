using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints
{
	[Component]
	public class UserGroupLink : IEntityLink
	{
		public Type EntityType => InterfaceActivator.TypeOf<IUserGroup>();

		public Guid TypeUid => Guid.Empty;

		public string IdParam => "id";

		public bool LoadEntityIfNull => false;

		public string Area(IEntity entity)
		{
			return "EleWise.ELMA.BPM.Web.Security";
		}

		public string Action(IEntity entity)
		{
			return "View";
		}

		public string Controller(IEntity entity)
		{
			return "UserGroup";
		}

		public RouteValueDictionary GetParams(IEntity entity)
		{
			return null;
		}

		public string Href(RequestContext html, IEntity entity)
		{
			return null;
		}
	}
}
namespace EleWise.ELMA.BPM.Web.Security.Components.Links
{
	[Component]
	public class UserGroupLink : IObjectLink
	{
		public bool CheckType(Type type)
		{
			return typeof(IUserGroup).IsAssignableFrom(type);
		}

		public string Url(RequestContext context, object obj)
		{
			return $"javascript:showUserGroupInfo('{((IEntity<long>)obj).Id}');";
		}
	}
}
