using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Diagnostics;

public interface IWorkTreeElement
{
	long Id { get; }

	string Name { get; set; }

	TimeSpan TotalTime { get; }

	Exception Exception { get; }

	IEnumerable<IWorkTreeElement> WorkTree { get; }
}
