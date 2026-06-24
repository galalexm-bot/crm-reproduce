using System;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB.Visualizer;

public interface IVisualizer : IDisposable
{
	Builder CabBuilder { get; }

	WorkItem CabRootWorkItem { get; }

	void Initialize(WorkItem cabRootWorkItem, Builder cabBuilder);
}
