using System;
using Autofac;

namespace EleWise.ELMA.ComponentModel;

public interface ILifetimeScopeAccessor
{
	ILifetimeScope Current { get; }

	ServiceScope CurrentType { get; set; }

	void SetAccessor(Func<ILifetimeScope> accessor);
}
