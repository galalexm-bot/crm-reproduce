using EleWise.ELMA.TestFramework.Core;

namespace EleWise.ELMA.TestFramework.BDD;

internal sealed class ScenarioExecutionContext : IScenarioExecutionContext
{
	private static ScenarioExecutionContext _003CCurrent_003Ek__BackingField;

	private TestContext _003CTestContext_003Ek__BackingField;

	private IScenario _003CCurrentScenario_003Ek__BackingField;

	private IStep _003CCurrentStep_003Ek__BackingField;

	private object _003CModel_003Ek__BackingField;

	public static ScenarioExecutionContext Current
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

	public TestContext TestContext
	{
		get
		{
			return _003CTestContext_003Ek__BackingField;
		}
		set
		{
			_003CTestContext_003Ek__BackingField = value;
		}
	}

	public IScenario CurrentScenario
	{
		get
		{
			return _003CCurrentScenario_003Ek__BackingField;
		}
		set
		{
			_003CCurrentScenario_003Ek__BackingField = value;
		}
	}

	public IStep CurrentStep
	{
		get
		{
			return _003CCurrentStep_003Ek__BackingField;
		}
		set
		{
			_003CCurrentStep_003Ek__BackingField = value;
		}
	}

	public object Model
	{
		get
		{
			return _003CModel_003Ek__BackingField;
		}
		set
		{
			_003CModel_003Ek__BackingField = value;
		}
	}
}
