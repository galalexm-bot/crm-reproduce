using System;
using System.Reflection;
using EleWise.ELMA.UI.Metadata;

namespace EleWise.ELMA.UI.Descriptors;

public interface IFormDescriptor
{
	Guid Uid { get; }

	long MetadataItemId { get; }

	long MetadataItemHederId { get; }

	Guid MetadataItemHederUid { get; }

	long? AuthorId { get; }

	FormMetadata Metadata { get; }

	Assembly Assembly { get; }

	Type ControllerType { get; }
}
