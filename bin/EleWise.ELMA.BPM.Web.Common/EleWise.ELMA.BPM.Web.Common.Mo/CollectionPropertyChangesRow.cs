using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public sealed class CollectionPropertyChangesRow
{
	public MvcHtmlString Caption { get; set; }

	public IEnumerable<IEntity> NewEntities { get; set; }

	public IEnumerable<IEntity> OldEntities { get; set; }

	public CollectionPropertyChangesRow(PropertyChangesRow changesRow)
	{
		Caption = changesRow.Caption;
		IEnumerable<IEntity> oldStateEnum = changesRow.OldState as IEnumerable<IEntity>;
		IEnumerable<IEntity> newStateEnum = changesRow.NewState as IEnumerable<IEntity>;
		if (oldStateEnum != null && newStateEnum != null)
		{
			OldEntities = oldStateEnum.Where((IEntity a) => !newStateEnum.Contains(a)).ToList();
			NewEntities = newStateEnum.Where((IEntity a) => !oldStateEnum.Contains(a)).ToList();
		}
		else
		{
			NewEntities = new List<IEntity>();
			OldEntities = new List<IEntity>();
		}
	}
}
