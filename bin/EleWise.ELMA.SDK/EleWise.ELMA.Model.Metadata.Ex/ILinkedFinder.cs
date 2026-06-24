using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Metadata.ExtensionPoints;

[ExtensionPoint(ComponentType.Server)]
public interface ILinkedFinder
{
	FindLinkedObjectsResult FindLinkedObjects(ICollection<ILinkedObject> objectsToSearching, LinkedObjectsContext context);

	FindLinkedObjectsResult FindLinkedObjects(ICollection<ILinkedObject> objectsToSearching, RuntimeObjectsContext emptyContext);
}
