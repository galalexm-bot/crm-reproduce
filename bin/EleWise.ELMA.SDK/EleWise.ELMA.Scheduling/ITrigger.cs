using System;

namespace EleWise.ELMA.Scheduling;

public interface ITrigger
{
	string Name { get; }

	Guid Id { get; }

	TimeSpan OvertimeToRun { get; }

	DateTime? GetNextTimeAfter(DateTime? dateTime, DateTime now);
}
