using System;
using Bridge;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Components;

[Component]
internal sealed class UserLink : IObjectLink
{
	public bool Check(object obj)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (obj is Entity entity)
		{
			return entity.TypeUid == MetadataConstants.EntityUserTypeImplementationUid;
		}
		return false;
	}

	public string Url(object obj)
	{
		return "/Security/User/Profile/-9999999999999";
	}

	public Action<object> Action(object obj)
	{
		return Script.Write<Action<object>>("function(obj) { showUserInfo(obj.Id); }", new object[0]);
	}
}
