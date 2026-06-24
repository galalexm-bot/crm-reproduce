using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component(Order = int.MinValue)]
public class LastActivitySelectGroupResolver : IEntitySelectGroupResolver
{
	public IEnumerable<IEntityLastObjectsResolver> LastExtensions { get; set; }

	public bool CheckType(Guid typeUid)
	{
		return LastExtensions.Any((IEntityLastObjectsResolver e) => e.CheckType(typeUid));
	}

	public IEnumerable<EntitySelectGroup> GetGroups(Guid typeUid, IEnumerable<IEntity> entities)
	{
		yield return new EntitySelectGroup
		{
			Header = SR.T("Последняя активность"),
			ShowHeader = false,
			ShowOnTop = true,
			Order = int.MinValue,
			Entities = entities.Intersect(LastExtensions.Where((IEntityLastObjectsResolver e) => e.CheckType(typeUid)).SelectMany((IEntityLastObjectsResolver e) => e.GetObjects(typeUid, null)))
		};
	}
}
