using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.TestFramework.Mocking;

internal class MockFunctionWithParamAndOutput<T, TResult> : Mock
{
	private readonly Func<T, TResult> fn;

	public MockFunctionWithParamAndOutput(string name, Func<T, TResult> fn)
		: base(name)
	{
		this.fn = fn;
	}

	public System.Threading.Tasks.Task<TResult> Call(T param)
	{
		IncrementCallCounter();
		return System.Threading.Tasks.Task.FromResult<TResult>(fn.Invoke(param));
	}
}
