using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints
{
	[Component]
	public class UserLink : IEntityLink
	{
		public Type EntityType => InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>();

		public Guid TypeUid => InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>();

		public string IdParam => "id";

		public bool LoadEntityIfNull => false;

		public string Area(IEntity entity)
		{
			return "EleWise.ELMA.BPM.Web.Security";
		}

		public string Action(IEntity entity)
		{
			return "Profile";
		}

		public string Controller(IEntity entity)
		{
			return "User";
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
	public class UserLink : IObjectLink
	{
		public bool CheckType(Type type)
		{
			return typeof(EleWise.ELMA.Security.IUser).IsAssignableFrom(type);
		}

		public string Url(RequestContext context, object obj)
		{
			return $"javascript:showUserInfo('{((IEntity<long>)obj).Id}');";
		}
	}
}
