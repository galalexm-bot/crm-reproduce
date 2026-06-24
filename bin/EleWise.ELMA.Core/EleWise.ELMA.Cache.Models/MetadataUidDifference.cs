using System;

namespace EleWise.ELMA.Cache.Models;

internal sealed class MetadataUidDifference : IMetadataUidDifference
{
	private readonly Guid[] _003CExistUids_003Ek__BackingField;

	private readonly Guid[] _003CMissedGuids_003Ek__BackingField;

	public Guid[] ExistUids => _003CExistUids_003Ek__BackingField;

	public Guid[] MissedGuids => _003CMissedGuids_003Ek__BackingField;

	public MetadataUidDifference(Guid[] existUids, Guid[] missedGuids)
	{
		_003CExistUids_003Ek__BackingField = existUids;
		_003CMissedGuids_003Ek__BackingField = missedGuids;
	}
}
