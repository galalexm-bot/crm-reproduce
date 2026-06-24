using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Metadata;

public interface ICompositeMetadata : IMetadata, IXsiType
{
	IEnumerable<IMetadata> GetCompositeParts();
}
