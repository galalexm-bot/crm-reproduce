using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Enums;

namespace EleWise.ELMA.Model.Metadata;

public interface IDeltaRootMetadata : IMetadata, IXsiType
{
	PublicationType GetPublicationTypeOnChange(IMetadata oldMetadata);
}
