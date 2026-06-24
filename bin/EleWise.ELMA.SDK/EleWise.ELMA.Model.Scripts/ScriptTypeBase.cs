using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts;

public abstract class ScriptTypeBase : IScriptType
{
	private static ScriptTypeBase DwjmXdbize0r4m5rO0XV;

	public abstract Guid Uid { get; }

	public abstract string Name { get; }

	public virtual string ListReferenceAdd => null;

	public abstract ScriptMethodDeclaration GenerateMethod(string name, IDictionary<string, object> generationParams = null);

	protected object GetParameterValue(IDictionary<string, object> generationParams, string name)
	{
		if (generationParams == null)
		{
			return null;
		}
		generationParams.TryGetValue(name, out var value);
		return value;
	}

	protected ScriptTypeBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		b7ABaebRW1tCmaHfi1uZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void b7ABaebRW1tCmaHfi1uZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool JOQTfIbRF8C627oRfVTk()
	{
		return DwjmXdbize0r4m5rO0XV == null;
	}

	internal static ScriptTypeBase byxjUQbRBOXyxNtf5YX1()
	{
		return DwjmXdbize0r4m5rO0XV;
	}
}
