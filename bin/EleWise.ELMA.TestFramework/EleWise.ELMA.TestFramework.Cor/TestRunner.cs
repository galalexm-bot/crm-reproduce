using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Bridge;
using Bridge.QUnit;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.TestFramework.Helpers;
using EleWise.ELMA.TestFramework.Notification;
using EleWise.ELMA.TestFramework.Results;
using EleWise.ELMA.TestFramework.Services;

namespace EleWise.ELMA.TestFramework.Core;

[Service]
internal sealed class TestRunner : ITestRunner
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public ITestFixture testFixture;

		public TestRunner _003C_003E4__this;

		internal void _003CRun_003Eb__0()
		{
			testFixture.Instance = _003C_003E4__this.testFactory.CreateTest(testFixture.Type);
			System.Collections.Generic.IEnumerator<ITestMethod> enumerator = testFixture.Tests.GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					ITestMethod current = enumerator.get_Current();
					if (current != null)
					{
						_003C_003E4__this.Run(current);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public TestRunner _003C_003E4__this;

		public ITestMethod test;

		internal void _003CRun_003Eb__0(Assert assert)
		{
			_003C_003Ec__DisplayClass8_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_1();
			CS_0024_003C_003E8__locals0.assert = assert;
			_003C_003E4__this.context.CurrentTest = test;
			TestResult result = new TestResult(test);
			TestContext.Current.SetResult(result);
			_003C_003E4__this.context.Assert = () => CS_0024_003C_003E8__locals0.assert;
			if (test.ExpectedCount.get_HasValue())
			{
				CS_0024_003C_003E8__locals0.assert.Expect(test.ExpectedCount.get_Value());
			}
			Action val = CS_0024_003C_003E8__locals0.assert.Async();
			test.Method.Invoke(test.Fixture.Instance, new object[0]);
			val.Invoke();
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_1
	{
		public Assert assert;

		internal Assert _003CRun_003Eb__1()
		{
			return assert;
		}
	}

	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public ITestFixture testFixture;

		public TestRunner _003C_003E4__this;

		public Func<System.Threading.Tasks.Task> setup;

		internal void _003CCreateHooks_003Eb__2()
		{
			MethodInfo setUp = testFixture.SetUp;
			if (setUp != null)
			{
				setUp.Invoke(testFixture.Instance, new object[0]);
			}
		}

		internal void _003CCreateHooks_003Eb__3()
		{
			MethodInfo tearDown = testFixture.TearDown;
			if (tearDown != null)
			{
				tearDown.Invoke(testFixture.Instance, new object[0]);
			}
		}

		internal Promise _003CCreateHooks_003Eb__0()
		{
			_003C_003E4__this.SetTestFixture(testFixture);
			new Promise();
			return Promise.Promisify(setup).Invoke();
		}

		internal void _003CCreateHooks_003Eb__1()
		{
			_003C_003E4__this.SetTestFixture(testFixture);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Action<TestSuiteBeginCallbackArgs> _003C_003E9__13_1;

		public static Action<ModuleStartCallbackArgs> _003C_003E9__13_2;

		internal void _003CRegisterQUnitEventHandlers_003Eb__13_1(TestSuiteBeginCallbackArgs info)
		{
			TestContext.Current.Notifier?.NotifyStart(new TestSuiteInfo
			{
				TestCount = info.get_TotalTests()
			});
		}

		internal void _003CRegisterQUnitEventHandlers_003Eb__13_2(ModuleStartCallbackArgs info)
		{
			TestContext.Current.Notifier?.NotifyFixtureStart(new TestFixtureInfo
			{
				Name = info.get_Name()
			});
		}
	}

	private readonly ITestFactory testFactory;

	private bool hasStarted;

	private TestContext context;

	public TestRunner(ITestFactory testFactory)
	{
		this.testFactory = testFactory;
	}

	public void Run(System.Collections.Generic.IEnumerable<ITestAssembly> testAssemblies)
	{
		System.Collections.Generic.IEnumerator<ITestAssembly> enumerator = testAssemblies.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ITestAssembly current = enumerator.get_Current();
				Run(current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public void Run(ITestAssembly testAssembly)
	{
		Run(testAssembly.TestFixtures);
	}

	public void Run(System.Collections.Generic.IEnumerable<ITestFixture> testFixtures)
	{
		System.Collections.Generic.IEnumerator<ITestFixture> enumerator = testFixtures.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ITestFixture current = enumerator.get_Current();
				Run(current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public void Run(ITestFixture testFixture, ITestNotifier testNotifier = null, Func<System.Threading.Tasks.Task> setup = null)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals0.testFixture = testFixture;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		QUnitHelper.ModuleHooks hooks = CreateHooks(CS_0024_003C_003E8__locals0.testFixture, setup);
		StartQUnit();
		context.Notifier = testNotifier;
		if (CS_0024_003C_003E8__locals0.testFixture.Skip)
		{
			TestFixtureResult result = new TestFixtureResult(CS_0024_003C_003E8__locals0.testFixture);
			context.CurrentResult.AddChildResult(result);
			QUnitHelper.SkipModule(CS_0024_003C_003E8__locals0.testFixture.Name);
			return;
		}
		QUnitHelper.Module(CS_0024_003C_003E8__locals0.testFixture.Name, hooks, (Action)delegate
		{
			CS_0024_003C_003E8__locals0.testFixture.Instance = CS_0024_003C_003E8__locals0._003C_003E4__this.testFactory.CreateTest(CS_0024_003C_003E8__locals0.testFixture.Type);
			System.Collections.Generic.IEnumerator<ITestMethod> enumerator = CS_0024_003C_003E8__locals0.testFixture.Tests.GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					ITestMethod current = enumerator.get_Current();
					if (current != null)
					{
						CS_0024_003C_003E8__locals0._003C_003E4__this.Run(current);
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		});
	}

	public void Run(ITestMethod test)
	{
		_003C_003Ec__DisplayClass8_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.test = test;
		if (CS_0024_003C_003E8__locals0.test.Skip)
		{
			QUnit.Skip(CS_0024_003C_003E8__locals0.test.Name);
			return;
		}
		QUnit.Test(CS_0024_003C_003E8__locals0.test.Name, (Action<Assert>)delegate(Assert assert)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_1();
			CS_0024_003C_003E8__locals0.assert = assert;
			CS_0024_003C_003E8__locals0._003C_003E4__this.context.CurrentTest = CS_0024_003C_003E8__locals0.test;
			TestResult result = new TestResult(CS_0024_003C_003E8__locals0.test);
			TestContext.Current.SetResult(result);
			CS_0024_003C_003E8__locals0._003C_003E4__this.context.Assert = () => CS_0024_003C_003E8__locals0.assert;
			if (CS_0024_003C_003E8__locals0.test.ExpectedCount.get_HasValue())
			{
				CS_0024_003C_003E8__locals0.assert.Expect(CS_0024_003C_003E8__locals0.test.ExpectedCount.get_Value());
			}
			Action val = CS_0024_003C_003E8__locals0.assert.Async();
			CS_0024_003C_003E8__locals0.test.Method.Invoke(CS_0024_003C_003E8__locals0.test.Fixture.Instance, new object[0]);
			val.Invoke();
		});
	}

	private void StartQUnit()
	{
		if (!hasStarted)
		{
			hasStarted = true;
			QUnitHelper.Load();
			QUnit.Start();
			RegisterQUnitEventHandlers();
			InitializeTestExecutionContext();
		}
	}

	private QUnitHelper.ModuleHooks CreateHooks(ITestFixture testFixture, Func<System.Threading.Tasks.Task> setup)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
		CS_0024_003C_003E8__locals0.testFixture = testFixture;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.setup = setup;
		QUnitHelper.ModuleHooks moduleHooks = new QUnitHelper.ModuleHooks
		{
			BeforeEach = (Action)delegate
			{
				MethodInfo setUp = CS_0024_003C_003E8__locals0.testFixture.SetUp;
				if (setUp != null)
				{
					setUp.Invoke(CS_0024_003C_003E8__locals0.testFixture.Instance, new object[0]);
				}
			},
			AfterEach = (Action)delegate
			{
				MethodInfo tearDown = CS_0024_003C_003E8__locals0.testFixture.TearDown;
				if (tearDown != null)
				{
					tearDown.Invoke(CS_0024_003C_003E8__locals0.testFixture.Instance, new object[0]);
				}
			}
		};
		if (CS_0024_003C_003E8__locals0.setup != null)
		{
			moduleHooks.Before = Union<Action, Func<Promise>>.op_Implicit((Func<Promise>)delegate
			{
				CS_0024_003C_003E8__locals0._003C_003E4__this.SetTestFixture(CS_0024_003C_003E8__locals0.testFixture);
				new Promise();
				return Promise.Promisify(CS_0024_003C_003E8__locals0.setup).Invoke();
			});
		}
		else
		{
			moduleHooks.Before = Union<Action, Func<Promise>>.op_Implicit((Action)delegate
			{
				CS_0024_003C_003E8__locals0._003C_003E4__this.SetTestFixture(CS_0024_003C_003E8__locals0.testFixture);
			});
		}
		return moduleHooks;
	}

	private void SetTestFixture(ITestFixture testFixture)
	{
		context.CurrentTestFixture = testFixture;
		TestFixtureResult result = new TestFixtureResult(testFixture);
		TestContext.Current.SetResult(result);
	}

	private void InitializeTestExecutionContext()
	{
		TestContext testContext2 = (TestContext.Current = new TestContext());
		TestContext.Current.SetResult(new TestSuiteResult());
		context = testContext2;
	}

	private void RegisterQUnitEventHandlers()
	{
		QUnit.Begin((Action<TestSuiteBeginCallbackArgs>)delegate(TestSuiteBeginCallbackArgs info)
		{
			TestContext.Current.Notifier?.NotifyStart(new TestSuiteInfo
			{
				TestCount = info.get_TotalTests()
			});
		});
		QUnit.ModuleStart((Action<ModuleStartCallbackArgs>)delegate(ModuleStartCallbackArgs info)
		{
			TestContext.Current.Notifier?.NotifyFixtureStart(new TestFixtureInfo
			{
				Name = info.get_Name()
			});
		});
		QUnit.ModuleDone((Action<ModuleDoneCallbackArgs>)delegate(ModuleDoneCallbackArgs info)
		{
			TestFixtureResult testFixtureResult = context.CurrentResult as TestFixtureResult;
			testFixtureResult.Duration = info.get_Runtime();
			TestContext.Current.Notifier?.NotifyFixtureDone(testFixtureResult);
			_003CRegisterQUnitEventHandlers_003Eg__PopResult_007C13_0();
		});
		QUnit.TestStart((Action<TestStartCallbackArgs>)delegate(TestStartCallbackArgs info)
		{
			context.AssertCounter = 0;
			context.Notifier?.NotifyTestStart(new TestInfo
			{
				Name = info.get_Name(),
				Module = info.get_Module()
			});
		});
		QUnit.TestDone((Action<TestDoneCallbackArgs>)delegate(TestDoneCallbackArgs info)
		{
			if (context.CurrentResult is TestResult testResult)
			{
				testResult.Duration = info.get_Runtime();
				context.Notifier?.NotifyTestEnd(testResult);
				_003CRegisterQUnitEventHandlers_003Eg__PopResult_007C13_0();
			}
		});
		QUnit.Log((Action<AssertLogCallbackArgs>)delegate(AssertLogCallbackArgs info)
		{
			context.CurrentResult.AddAssertResult(new AssertResult
			{
				Id = string.Format("{0}_assert{1}", ((object)info).get_Item("testId"), (object)context.AssertCounter),
				Passed = info.get_Result(),
				Actual = info.get_Actual(),
				Expected = info.get_Expected(),
				Message = ((info.get_Message() != null) ? info.get_Message() : (info.get_Result() ? SR.T("Ок") : SR.T("Провалено"))),
				Negative = (bool)((object)info).get_Item("negative"),
				Module = info.get_Module(),
				Source = info.get_Source()
			});
			context.AssertCounter++;
		});
		QUnit.Done((Action<TestSuiteDoneCallbackArgs>)delegate(TestSuiteDoneCallbackArgs info)
		{
			hasStarted = false;
			if (context != null)
			{
				TestSuiteResult currentResult = context.CurrentResult;
				currentResult.Duration = info.get_Runtime();
				currentResult.ScenarioCount = context.ScenarioCount;
				context.Notifier?.NotifyEnd(currentResult);
				TestContext.Current = null;
			}
		});
	}

	internal static void _003CRegisterQUnitEventHandlers_003Eg__PopResult_007C13_0()
	{
		TestContext.Current.PopResult();
	}

	private void _003CRegisterQUnitEventHandlers_003Eb__13_3(ModuleDoneCallbackArgs info)
	{
		TestFixtureResult testFixtureResult = context.CurrentResult as TestFixtureResult;
		testFixtureResult.Duration = info.get_Runtime();
		TestContext.Current.Notifier?.NotifyFixtureDone(testFixtureResult);
		_003CRegisterQUnitEventHandlers_003Eg__PopResult_007C13_0();
	}

	private void _003CRegisterQUnitEventHandlers_003Eb__13_4(TestStartCallbackArgs info)
	{
		context.AssertCounter = 0;
		context.Notifier?.NotifyTestStart(new TestInfo
		{
			Name = info.get_Name(),
			Module = info.get_Module()
		});
	}

	private void _003CRegisterQUnitEventHandlers_003Eb__13_5(TestDoneCallbackArgs info)
	{
		if (context.CurrentResult is TestResult testResult)
		{
			testResult.Duration = info.get_Runtime();
			context.Notifier?.NotifyTestEnd(testResult);
			_003CRegisterQUnitEventHandlers_003Eg__PopResult_007C13_0();
		}
	}

	private void _003CRegisterQUnitEventHandlers_003Eb__13_6(AssertLogCallbackArgs info)
	{
		context.CurrentResult.AddAssertResult(new AssertResult
		{
			Id = string.Format("{0}_assert{1}", ((object)info).get_Item("testId"), (object)context.AssertCounter),
			Passed = info.get_Result(),
			Actual = info.get_Actual(),
			Expected = info.get_Expected(),
			Message = ((info.get_Message() != null) ? info.get_Message() : (info.get_Result() ? SR.T("Ок") : SR.T("Провалено"))),
			Negative = (bool)((object)info).get_Item("negative"),
			Module = info.get_Module(),
			Source = info.get_Source()
		});
		context.AssertCounter++;
	}

	private void _003CRegisterQUnitEventHandlers_003Eb__13_7(TestSuiteDoneCallbackArgs info)
	{
		hasStarted = false;
		if (context != null)
		{
			TestSuiteResult currentResult = context.CurrentResult;
			currentResult.Duration = info.get_Runtime();
			currentResult.ScenarioCount = context.ScenarioCount;
			context.Notifier?.NotifyEnd(currentResult);
			TestContext.Current = null;
		}
	}
}
