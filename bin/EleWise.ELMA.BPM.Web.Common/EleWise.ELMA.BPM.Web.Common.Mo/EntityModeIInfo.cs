using System;
using System.Web.Routing;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models.Selectors;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public abstract class EntityModeIInfo
{
	public IFormCreator Creator { get; set; }

	public string PopupId { get; set; }

	public string InputId { get; set; }

	public string ContainerId { get; set; }

	public Guid EntityType { get; set; }

	public string CreatorPrefix { get; set; }

	public ObjectCreatorParams CreatorParams { get; set; }

	public Type Type { get; set; }

	public string PropertyCollectionOnCallback { get; set; }

	public string ViewFormUid { get; set; }

	public string UniqueId { get; set; }

	public abstract RouteValueDictionary GetRoute(Guid typeUid, string prefix);
}
