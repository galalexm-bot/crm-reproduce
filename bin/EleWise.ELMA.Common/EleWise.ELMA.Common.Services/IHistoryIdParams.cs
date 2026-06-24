using System;

namespace EleWise.ELMA.Common.Services;

public interface IHistoryIdParams
{
	Guid TypeUid { get; }

	string Id { get; }
}
