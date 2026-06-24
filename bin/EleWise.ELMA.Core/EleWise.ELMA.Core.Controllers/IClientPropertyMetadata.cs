using System;

namespace EleWise.ELMA.Core.Controllers;

public interface IClientPropertyMetadata
{
	Guid Uid { get; }

	string Name { get; }

	string DisplayName { get; }

	string Description { get; }

	Guid TypeUid { get; }

	Guid SubTypeUid { get; }

	bool Required { get; }

	bool Nullable { get; }
}
