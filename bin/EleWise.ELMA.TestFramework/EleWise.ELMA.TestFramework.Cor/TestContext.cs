using System;
using System.Collections.Generic;
using Bridge.QUnit;
using EleWise.ELMA.TestFramework.Notification;
using EleWise.ELMA.TestFramework.Results;
using EleWise.ELMA.TestFramework.Services;

namespace EleWise.ELMA.TestFramework.Core;

internal sealed class TestContext : ITestContext
{
	private static TestContext _003CCurrent_003Ek__BackingField;

	private Func<Assert> _003CAssert_003Ek__BackingField;

	private ITestNotifier _003CNotifier_003Ek__BackingField;

	private ITestFactory _003CTestFactory_003Ek__BackingField;

	private TestSuiteResult _003CCurrentResult_003Ek__BackingField;

	private ITestMethod _003CCurrentTest_003Ek__BackingField;

	private ITestFixture _003CCurrentTestFixture_003Ek__BackingField;

	private int _003CAssertCounter_003Ek__BackingField;

	private int _003CScenarioCount_003Ek__BackingField;

	public static TestContext Current
	{
		get
		{
			return _003CCurrent_003Ek__BackingField;
		}
		set
		{
			_003CCurrent_003Ek__BackingField = value;
		}
	}

	public Func<Assert> Assert
	{
		get
		{
			return _003CAssert_003Ek__BackingField;
		}
		set
		{
			_003CAssert_003Ek__BackingField = value;
		}
	}

	public ITestNotifier Notifier
	{
		get
		{
			return _003CNotifier_003Ek__BackingField;
		}
		set
		{
			_003CNotifier_003Ek__BackingField = value;
		}
	}

	public ITestFactory TestFactory
	{
		get
		{
			return _003CTestFactory_003Ek__BackingField;
		}
		set
		{
			_003CTestFactory_003Ek__BackingField = value;
		}
	}

	public TestSuiteResult CurrentResult
	{
		get
		{
			return _003CCurrentResult_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentResult_003Ek__BackingField = value;
		}
	}

	public ITestMethod CurrentTest
	{
		get
		{
			return _003CCurrentTest_003Ek__BackingField;
		}
		set
		{
			_003CCurrentTest_003Ek__BackingField = value;
		}
	}

	public ITestFixture CurrentTestFixture
	{
		get
		{
			return _003CCurrentTestFixture_003Ek__BackingField;
		}
		set
		{
			_003CCurrentTestFixture_003Ek__BackingField = value;
		}
	}

	public int AssertCounter
	{
		get
		{
			return _003CAssertCounter_003Ek__BackingField;
		}
		set
		{
			_003CAssertCounter_003Ek__BackingField = value;
		}
	}

	public int ScenarioCount
	{
		get
		{
			return _003CScenarioCount_003Ek__BackingField;
		}
		set
		{
			_003CScenarioCount_003Ek__BackingField = value;
		}
	}

	public void SetResult(TestSuiteResult value)
	{
		if (CurrentResult != null)
		{
			value.Parent = CurrentResult;
		}
		CurrentResult = value;
	}

	public void PopResult()
	{
		TestSuiteResult currentResult = Current.CurrentResult;
		TestSuiteResult parent = currentResult.Parent;
		if (parent != null)
		{
			parent.AddChildResult(currentResult);
			if (currentResult.Failed > 0)
			{
				parent.FailedIds.Add(currentResult.Id);
				parent.FailedIds.AddRange((System.Collections.Generic.IEnumerable<string>)currentResult.FailedIds);
			}
		}
		Current.CurrentResult = parent;
	}
}
