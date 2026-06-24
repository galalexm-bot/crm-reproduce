using System;

namespace EleWise.ELMA.Services;

public interface IWorkWithFormDependeciesService
{
	bool IsActive();

	void Run(Action action);
}
