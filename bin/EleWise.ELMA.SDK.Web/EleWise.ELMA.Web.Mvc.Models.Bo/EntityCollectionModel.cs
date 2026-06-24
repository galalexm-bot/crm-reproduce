using System;
using System.Collections.Generic;
using System.Web.Routing;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.Models.Buttons;

namespace EleWise.ELMA.Web.Mvc.Models.Boxes;

public class EntityCollectionModel : AutocompleteEntityComboBox
{
	public IEnumerable<IEntity> EntityCollection { get; set; }

	[Obsolete]
	public IEnumerable<Tuple<IEntity, bool>> DataSource { get; set; }

	public Type RootType { get; set; }

	public string UniqueId { get; set; }

	public Guid? ViewFormUid { get; set; }

	public string CreateCallback { get; set; }

	public string EditCallback { get; set; }

	public string DeleteCallback { get; set; }

	public Guid? EditFormUid { get; set; }

	[Obsolete]
	public bool CanEdit { get; set; }

	[Obsolete]
	public bool CanCreate { get; set; }

	public ICollection<ActionButtonType> HideActions { get; set; }

	public RouteValueDictionary EditEntityFormRoute { get; set; }
}
