using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

[ExtensionPoint(ComponentType.Server | ComponentType.Test)]
public interface IPublicApiNodeProvider
{
	IEnumerable<IPublicApiNode> CreatePublicApiNodes();
}
