using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.TestFramework.Mocking;

internal class MockFunctionWithParam<T> : Mock
{
	private readonly Action<T> fn;

	public MockFunctionWithParam(string name, Action<T> fn)
		: base(name)
	{
		this.fn = fn;
	}

	public System.Threading.Tasks.Task Call(T arg)
	{
		IncrementCallCounter();
		fn.Invoke(arg);
		return System.Threading.Tasks.Task.get_CompletedTask();
	}
}
