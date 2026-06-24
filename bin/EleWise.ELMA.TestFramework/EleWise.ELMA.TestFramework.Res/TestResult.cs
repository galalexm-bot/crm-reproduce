using EleWise.ELMA.TestFramework.Core;

namespace EleWise.ELMA.TestFramework.Results;

internal sealed class TestResult : TestSuiteResult
{
	private readonly ITestMethod _003CTest_003Ek__BackingField;

	public ITestMethod Test => _003CTest_003Ek__BackingField;

	public TestResult(ITestMethod test)
	{
		_003CTest_003Ek__BackingField = test;
		base.Name = test.Name;
		base.Id = test.FullName;
	}
}
