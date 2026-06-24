using System;

namespace EleWise.ELMA.Model.Metadata;

public interface ILinkedObject
{
	Guid Uid { get; }

	string Name { get; }

	Guid TypeUid { get; }

	Guid SubtypeUid { get; }
}
