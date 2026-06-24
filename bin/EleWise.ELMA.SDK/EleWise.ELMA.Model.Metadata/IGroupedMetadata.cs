using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Metadata;

public interface IGroupedMetadata : IMetadata, IXsiType
{
	long GroupId { get; set; }
}
