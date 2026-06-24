using System;

namespace EleWise.ELMA.History.Models;

internal sealed class CollectorStateInfo
{
	public Guid CollectorGuid { get; set; }

	public string Query { get; set; }

	public CollectorStateInfo()
	{
	}

	public CollectorStateInfo(Guid collectorGuid, string query)
	{
		CollectorGuid = collectorGuid;
		Query = query;
	}
}
