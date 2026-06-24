using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Content;

[Component]
public class UserImageSetableObjectIcon : IObjectIcon
{
	private static readonly Type _type = typeof(IUserImageSetable);

	public bool CheckType(Type type)
	{
		return _type.IsAssignableFrom(type);
	}

	public string Icon(UrlHelper url, ObjectIconFormat format, object obj)
	{
		IUserImageSetable userImageSetable = (IUserImageSetable)obj;
		if (string.IsNullOrEmpty(userImageSetable.ImageUrl))
		{
			return null;
		}
		return userImageSetable.ImageUrl;
	}
}
