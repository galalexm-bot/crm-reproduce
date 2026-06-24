using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.BPM.Web.Security.Extensions;

[Component]
public class BlockUserSelectGroupResolver : IEntitySelectGroupResolver
{
	public bool CheckType(Guid typeUid)
	{
		return typeUid == InterfaceActivator.UID<IUser>();
	}

	public IEnumerable<EntitySelectGroup> GetGroups(Guid typeUid, IEnumerable<IEntity> entities)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		UrlHelper url = new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext);
		return new List<EntitySelectGroup>
		{
			new EntitySelectGroup
			{
				Header = SR.T("Заблокированные пользователи"),
				ShowHeader = true,
				Order = int.MaxValue,
				Styles = new EntitySelectGroupStyles
				{
					FontColor = Color.Gray,
					IconUrl = url.ObjectIcon(ObjectIconFormat.x16, UserStatus.Blocked)
				},
				Entities = from IUser h in entities
					where h.Status == UserStatus.Blocked
					select h
			}
		};
	}
}
