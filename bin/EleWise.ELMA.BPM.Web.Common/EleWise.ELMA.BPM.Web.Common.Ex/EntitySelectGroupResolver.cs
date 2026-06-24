using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component(Order = int.MaxValue)]
public class EntitySelectGroupResolver : IEntitySelectGroupResolver
{
	public bool CheckType(Guid typeUid)
	{
		return true;
	}

	public IEnumerable<EntitySelectGroup> GetGroups(Guid typeUid, IEnumerable<IEntity> entities)
	{
		return new List<EntitySelectGroup>
		{
			new EntitySelectGroup
			{
				Header = SR.T("Остальные"),
				ShowHeader = false,
				ShowOnTop = true,
				Order = int.MaxValue,
				Entities = entities
			}
		};
	}
}
