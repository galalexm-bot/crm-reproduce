using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.TestFramework.Results;

namespace EleWise.ELMA.TestFramework.Notification;

[ServiceContract]
internal interface ITestNotifier
{
	Action<TestSuiteInfo> OnStart { get; set; }

	Action<TestFixtureInfo> OnFixtureStart { get; set; }

	Action<TestInfo> OnTestStart { get; set; }

	Action<TestResult> OnTestEnd { get; set; }

	Action<TestFixtureResult> OnFixtureEnd { get; set; }

	Action<TestSuiteResult> OnEnd { get; set; }

	void NotifyStart(TestSuiteInfo info);

	void NotifyFixtureStart(TestFixtureInfo info);

	void NotifyTestStart(TestInfo info);

	void NotifyTestEnd(TestResult result);

	void NotifyFixtureDone(TestFixtureResult result);

	void NotifyEnd(TestSuiteResult result);
}
