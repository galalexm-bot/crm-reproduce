using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;

namespace EleWise.ELMA.DTO;

public interface IExtendEntityResult
{
	bool Extended { get; set; }

	IPropertyMetadata[] ExtendedProperties { get; set; }
}
