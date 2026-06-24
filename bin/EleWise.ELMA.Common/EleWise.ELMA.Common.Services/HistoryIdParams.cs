using System;

namespace EleWise.ELMA.Common.Services;

public sealed class HistoryIdParams : IHistoryIdParams
{
	public Guid TypeUid { get; set; }

	public string Id { get; set; }
}
