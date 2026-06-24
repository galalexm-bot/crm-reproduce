using System;

namespace EleWise.ELMA.Services;

public interface ITimestampService
{
	long GetTimestamp();

	long GetTimeStampRelativeToNow(TimeSpan timeOffset);
}
