using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.TestFramework.Results;

namespace EleWise.ELMA.TestFramework.Core;

internal sealed class TestFixture : ITestFixture
{
	private readonly System.Type _003CType_003Ek__BackingField;

	private readonly string _003CName_003Ek__BackingField;

	private System.Collections.Generic.IEnumerable<ITestMethod> _003CTests_003Ek__BackingField;

	private object _003CInstance_003Ek__BackingField;

	private MethodInfo _003CSetUp_003Ek__BackingField;

	private MethodInfo _003CTearDown_003Ek__BackingField;

	private Func<System.Threading.Tasks.Task> _003COneTimeSetUp_003Ek__BackingField;

	private TestFixtureResult _003CResult_003Ek__BackingField;

	private bool _003CSkip_003Ek__BackingField;

	private string _003CSkipReason_003Ek__BackingField;

	public System.Type Type => _003CType_003Ek__BackingField;

	public string Name => _003CName_003Ek__BackingField;

	public System.Collections.Generic.IEnumerable<ITestMethod> Tests
	{
		get
		{
			return _003CTests_003Ek__BackingField;
		}
		private set
		{
			_003CTests_003Ek__BackingField = value;
		}
	}

	public object Instance
	{
		get
		{
			return _003CInstance_003Ek__BackingField;
		}
		set
		{
			_003CInstance_003Ek__BackingField = value;
		}
	}

	public MethodInfo SetUp
	{
		get
		{
			return _003CSetUp_003Ek__BackingField;
		}
		set
		{
			_003CSetUp_003Ek__BackingField = value;
		}
	}

	public MethodInfo TearDown
	{
		get
		{
			return _003CTearDown_003Ek__BackingField;
		}
		set
		{
			_003CTearDown_003Ek__BackingField = value;
		}
	}

	public Func<System.Threading.Tasks.Task> OneTimeSetUp
	{
		get
		{
			return _003COneTimeSetUp_003Ek__BackingField;
		}
		set
		{
			_003COneTimeSetUp_003Ek__BackingField = value;
		}
	}

	public TestFixtureResult Result
	{
		get
		{
			return _003CResult_003Ek__BackingField;
		}
		set
		{
			_003CResult_003Ek__BackingField = value;
		}
	}

	public bool Skip
	{
		get
		{
			return _003CSkip_003Ek__BackingField;
		}
		private set
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
		private set
		{
			_003CSkipReason_003Ek__BackingField = value;
		}
	}

	public TestFixture(System.Type type)
		: this(type, type.get_Name())
	{
	}

	public TestFixture(System.Type type, string name)
	{
		_003CType_003Ek__BackingField = type;
		_003CName_003Ek__BackingField = name ?? type.get_Name();
		Initialize();
	}

	private void Initialize()
	{
		IgnoreAttribute attribute = AttributeHelper<IgnoreAttribute>.GetAttribute(Type, inherited: false);
		if (attribute != null)
		{
			Skip = true;
			SkipReason = attribute.Reason;
		}
		List<ITestMethod> val = new List<ITestMethod>();
		MethodInfo[] methods = Type.GetMethods((BindingFlags)22);
		foreach (MethodInfo val2 in methods)
		{
			if (AttributeHelper<SetUpAttribute>.GetAttribute((MemberInfo)(object)val2, inherited: false) != null)
			{
				SetUp = val2;
			}
			if (AttributeHelper<TearDownAttribute>.GetAttribute((MemberInfo)(object)val2, inherited: false) != null)
			{
				TearDown = val2;
			}
			TestAttribute attribute2 = AttributeHelper<TestAttribute>.GetAttribute((MemberInfo)(object)val2, inherited: false);
			if (attribute2 != null)
			{
				TestMethod testMethod = new TestMethod(this, val2, attribute2.Name, attribute2.IsExpectedCountSet ? new int?(attribute2.ExpectedCount) : null);
				IgnoreAttribute attribute3 = AttributeHelper<IgnoreAttribute>.GetAttribute((MemberInfo)(object)val2, inherited: false);
				if (attribute3 != null)
				{
					testMethod.Skip = true;
					testMethod.SkipReason = attribute3.Reason;
				}
				val.Add((ITestMethod)testMethod);
			}
		}
		Tests = (System.Collections.Generic.IEnumerable<ITestMethod>)val;
	}
}
