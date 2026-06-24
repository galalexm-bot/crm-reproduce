using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts;

public abstract class ScriptType : ScriptTypeBase
{
	private static ScriptType kUlsmrbiUfstdI2uv7iW;

	protected virtual string ReturnType => null;

	protected virtual IEnumerable<ScriptMethodParameter> Parameters => null;

	public override ScriptMethodDeclaration GenerateMethod(string name, IDictionary<string, object> generationParams = null)
	{
		ScriptMethodDeclaration scriptMethodDeclaration = new ScriptMethodDeclaration
		{
			Name = name,
			ReturnType = ReturnType
		};
		if (Parameters != null)
		{
			scriptMethodDeclaration.Parameters.AddRange(Parameters);
		}
		return scriptMethodDeclaration;
	}

	protected ScriptType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool iBLiTAbisxya0LWXXY32()
	{
		return kUlsmrbiUfstdI2uv7iW == null;
	}

	internal static ScriptType Orr1E8bicqsmoC3Rp4es()
	{
		return kUlsmrbiUfstdI2uv7iW;
	}
}
