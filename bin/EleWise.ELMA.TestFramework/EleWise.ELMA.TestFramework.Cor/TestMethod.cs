using System.Reflection;

namespace EleWise.ELMA.TestFramework.Core;

internal sealed class TestMethod : ITestMethod
{
	private readonly MethodInfo _003CMethod_003Ek__BackingField;

	private string _003CName_003Ek__BackingField;

	private string _003CFullName_003Ek__BackingField;

	private int? _003CExpectedCount_003Ek__BackingField;

	private ITestFixture _003CFixture_003Ek__BackingField;

	private bool _003CSkip_003Ek__BackingField;

	private string _003CSkipReason_003Ek__BackingField;

	public MethodInfo Method => _003CMethod_003Ek__BackingField;

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public string FullName
	{
		get
		{
			return _003CFullName_003Ek__BackingField;
		}
		set
		{
			_003CFullName_003Ek__BackingField = value;
		}
	}

	public int? ExpectedCount
	{
		get
		{
			return _003CExpectedCount_003Ek__BackingField;
		}
		set
		{
			_003CExpectedCount_003Ek__BackingField = value;
		}
	}

	public ITestFixture Fixture
	{
		get
		{
			return _003CFixture_003Ek__BackingField;
		}
		private set
		{
			_003CFixture_003Ek__BackingField = value;
		}
	}

	public bool Skip
	{
		get
		{
			return _003CSkip_003Ek__BackingField;
		}
		set
		{
			_003CSkip_003Ek__BackingField = value;
		}
	}

	public string SkipReason
	{
		get
		{
			return _003CSkipReason_003Ek__BackingField;
		}
		set
		{
			_003CSkipReason_003Ek__BackingField = value;
		}
	}

	public TestMethod(ITestFixture testFixture, MethodInfo method)
		: this(testFixture, method, ((MemberInfo)method).get_Name())
	{
	}

	public TestMethod(ITestFixture testFixture, MethodInfo method, string name)
		: this(testFixture, method, ((MemberInfo)method).get_Name(), null)
	{
	}

	public TestMethod(ITestFixture testFixture, MethodInfo method, string name, int? expectedCount)
	{
		Fixture = testFixture;
		Name = name ?? ((MemberInfo)method).get_Name();
		_003CMethod_003Ek__BackingField = method;
		FullName = method.get_ScriptName();
		if (expectedCount.get_HasValue())
		{
			ExpectedCount = expectedCount.get_Value();
		}
	}
}
