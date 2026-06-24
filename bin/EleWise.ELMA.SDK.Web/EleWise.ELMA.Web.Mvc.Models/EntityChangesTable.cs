using System.Collections.Generic;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Web.Mvc.Models;

public class EntityChangesTable
{
	public IEntity EntityOld { get; set; }

	public IEntity EntityNew { get; set; }

	public List<EntityChangesRow> Rows { get; set; }

	public bool FullView { get; set; }

	public EntityChangesTable()
	{
		Rows = new List<EntityChangesRow>();
	}
}
