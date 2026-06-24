using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.TestFramework.Core;

namespace EleWise.ELMA.TestFramework.Results;

internal sealed class TestFixtureResult : TestSuiteResult
{
	private readonly ITestFixture _003CTestFixture_003Ek__BackingField;

	public ITestFixture TestFixture => _003CTestFixture_003Ek__BackingField;

	public TestFixtureResult(ITestFixture testFixture)
	{
		_003CTestFixture_003Ek__BackingField = testFixture;
		base.Name = testFixture.Name;
		base.Id = testFixture.Type.get_FullName();
		if (testFixture.Skip)
		{
			base.Status = TestStatus.Skipped;
			base.SkipReason = testFixture.SkipReason;
		}
		System.Collections.Generic.IEnumerator<ITestMethod> enumerator = testFixture.Tests.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ITestMethod current = enumerator.get_Current();
				if (TestFixture.Skip || current.Skip)
				{
					base.Skipped++;
					AddChildResult(new TestResult(current)
					{
						Status = TestStatus.Skipped,
						SkipReason = (current.SkipReason ?? testFixture.SkipReason)
					});
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}
}
