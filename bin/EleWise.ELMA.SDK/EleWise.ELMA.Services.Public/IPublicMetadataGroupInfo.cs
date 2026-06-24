using System;

namespace EleWise.ELMA.Services.Public;

public interface IPublicMetadataGroupInfo
{
	Guid GroupUid { get; }

	int Order { get; }

	string DisplayName { get; }
}
