using System.Reflection;

namespace EleWise.ELMA.TestFramework.Core;

internal interface ITestMethod
{
	string Name { get; }

	string FullName { get; set; }

	MethodInfo Method { get; }

	int? ExpectedCount { get; set; }

	ITestFixture Fixture { get; }

	bool Skip { get; }

	string SkipReason { get; }
}
