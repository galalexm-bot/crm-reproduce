using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Extensions;

[Component]
public class ProcessHeaderSelectGroupResolver : IEntitySelectGroupResolver
{
	public bool CheckType(Guid typeUid)
	{
		return typeUid == InterfaceActivator.UID<IProcessHeader>();
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
				Header = SR.T("Удалённые"),
				ShowHeader = true,
				Order = int.MaxValue,
				Styles = new EntitySelectGroupStyles
				{
					FontColor = Color.Gray,
					IconUrl = url.Image("#delete.svg")
				},
				Entities = from IProcessHeader h in entities
					where h.Status == WorkflowProcessStatus.Deleted
					select h
			}
		};
	}
}
