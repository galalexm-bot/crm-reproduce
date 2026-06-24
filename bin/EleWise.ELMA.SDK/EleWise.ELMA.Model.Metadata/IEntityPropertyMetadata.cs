using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Metadata;

public interface IEntityPropertyMetadata : IPropertyMetadata, INamedMetadata, IOrderedMetadata, IMetadata, IXsiType
{
	bool Input { get; set; }

	bool Output { get; set; }
}
