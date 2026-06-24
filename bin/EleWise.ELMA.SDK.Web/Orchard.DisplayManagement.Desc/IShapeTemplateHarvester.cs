using System.Collections.Generic;

namespace Orchard.DisplayManagement.Descriptors.ShapeTemplateStrategy;

public interface IShapeTemplateHarvester : IDependency
{
	IEnumerable<string> SubPaths();

	IEnumerable<HarvestShapeHit> HarvestShape(HarvestShapeInfo info);
}
