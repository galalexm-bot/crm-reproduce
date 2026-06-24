using System;
using System.Drawing;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Scheduling;

public interface IJob
{
	Guid Id { get; }

	string Name { get; }

	Image Icon { get; }

	[NotNull]
	JobResult Do(DateTime dateToRun);
}
