using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.Extensions;

[Component]
public class SoftDeletableCatalogChecker : ISystemCatalogChecker
{
	public bool CantDelete(object entity)
	{
		if (entity is ISoftDeletable softDeletable)
		{
			return softDeletable.IsDeleted;
		}
		return false;
	}
}
