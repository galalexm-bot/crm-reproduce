using System;

namespace EleWise.ELMA.Cache.Models;

public interface IMetadataUidDifference
{
	Guid[] ExistUids { get; }

	Guid[] MissedGuids { get; }
}
