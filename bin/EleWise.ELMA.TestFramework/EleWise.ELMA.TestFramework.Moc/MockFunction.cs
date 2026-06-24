using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.TestFramework.Mocking;

internal class MockFunction : Mock
{
	private readonly Action fn;

	public MockFunction(string name, Action fn)
		: base(name)
	{
		this.fn = fn;
	}

	public System.Threading.Tasks.Task Call()
	{
		IncrementCallCounter();
		fn.Invoke();
		return System.Threading.Tasks.Task.get_CompletedTask();
	}
}
