using System;

namespace EleWise.ELMA.Scheduling;

public interface IStepScheduler
{
	void RunTrigger(Guid triggerId);
}
