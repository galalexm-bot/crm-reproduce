using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Metadata;

public interface IOrderedMetadata : IMetadata, IXsiType
{
	int Order { get; set; }
}
