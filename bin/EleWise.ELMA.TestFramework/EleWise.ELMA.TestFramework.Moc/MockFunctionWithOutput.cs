using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.TestFramework.Mocking;

internal class MockFunctionWithOutput<TResult> : Mock
{
	private readonly Func<TResult> fn;

	public MockFunctionWithOutput(string name, Func<TResult> fn)
		: base(name)
	{
		this.fn = fn;
	}

	public System.Threading.Tasks.Task<TResult> Call()
	{
		IncrementCallCounter();
		return System.Threading.Tasks.Task.FromResult<TResult>(fn.Invoke());
	}
}
