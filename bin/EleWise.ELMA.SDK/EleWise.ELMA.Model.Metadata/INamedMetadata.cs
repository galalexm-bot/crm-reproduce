using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata;

public interface INamedMetadata
{
	string Name { get; set; }

	string DisplayName { get; set; }

	string Description { get; set; }

	List<MetadataImage> Images { get; set; }
}
