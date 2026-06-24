using System.Collections.Generic;

namespace EleWise.ELMA.TestFramework.Core;

internal sealed class ComponentTestFixtureTree
{
	private int _003CComponentCount_003Ek__BackingField;

	private int _003CTestComponentCount_003Ek__BackingField;

	private int _003CTotalTestsCount_003Ek__BackingField;

	private System.Collections.Generic.ICollection<ComponentTestFixture> _003CTestModules_003Ek__BackingField;

	public int ComponentCount
	{
		get
		{
			return _003CComponentCount_003Ek__BackingField;
		}
		set
		{
			_003CComponentCount_003Ek__BackingField = value;
		}
	}

	public int TestComponentCount
	{
		get
		{
			return _003CTestComponentCount_003Ek__BackingField;
		}
		set
		{
			_003CTestComponentCount_003Ek__BackingField = value;
		}
	}

	public int TotalTestsCount
	{
		get
		{
			return _003CTotalTestsCount_003Ek__BackingField;
		}
		set
		{
			_003CTotalTestsCount_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<ComponentTestFixture> TestModules
	{
		get
		{
			return _003CTestModules_003Ek__BackingField;
		}
		set
		{
			_003CTestModules_003Ek__BackingField = value;
		}
	}
}
