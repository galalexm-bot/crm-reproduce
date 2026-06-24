using System.Collections.Generic;
using System.Reflection;

namespace EleWise.ELMA.TestFramework.Core;

internal sealed class TestAssembly : ITestAssembly
{
	private readonly Assembly _003CAssembly_003Ek__BackingField;

	private readonly string _003CName_003Ek__BackingField;

	private System.Collections.Generic.IEnumerable<ITestFixture> _003CTestFixtures_003Ek__BackingField;

	public Assembly Assembly => _003CAssembly_003Ek__BackingField;

	public string Name => _003CName_003Ek__BackingField;

	public System.Collections.Generic.IEnumerable<ITestFixture> TestFixtures
	{
		get
		{
			return _003CTestFixtures_003Ek__BackingField;
		}
		set
		{
			_003CTestFixtures_003Ek__BackingField = value;
		}
	}

	public TestAssembly(Assembly assembly)
	{
		_003CAssembly_003Ek__BackingField = assembly;
		_003CName_003Ek__BackingField = assembly.get_FullName();
		TestFixtures = (System.Collections.Generic.IEnumerable<ITestFixture>)new List<ITestFixture>();
	}
}
