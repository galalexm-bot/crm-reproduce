using System;

namespace EleWise.ELMA.Services.Scope;

public interface IExecutionScope : IDisposable
{
	object Resolve(Type objectType);

	T Resolve<T>() where T : class;
}
