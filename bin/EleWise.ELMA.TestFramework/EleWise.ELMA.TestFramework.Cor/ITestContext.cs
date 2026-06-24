using System;
using Bridge.QUnit;
using EleWise.ELMA.TestFramework.Notification;
using EleWise.ELMA.TestFramework.Results;
using EleWise.ELMA.TestFramework.Services;

namespace EleWise.ELMA.TestFramework.Core;

internal interface ITestContext
{
	Func<Assert> Assert { get; set; }

	ITestNotifier Notifier { get; set; }

	ITestFactory TestFactory { get; set; }

	ITestMethod CurrentTest { get; set; }

	TestSuiteResult CurrentResult { get; }

	ITestFixture CurrentTestFixture { get; set; }

	int ScenarioCount { get; set; }

	void SetResult(TestSuiteResult value);

	void PopResult();
}
