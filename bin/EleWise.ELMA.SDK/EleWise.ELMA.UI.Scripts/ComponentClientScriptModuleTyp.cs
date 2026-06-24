using System;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.UI.CodeGeneration;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Scripts;

public static class ComponentClientScriptModuleTypeConstants
{
	public static readonly Guid TypeUid;

	internal static ComponentClientScriptModuleTypeConstants Kfp9uel7BjdyGQqhJk7;

	static ComponentClientScriptModuleTypeConstants()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				TypeUid = new Guid((string)QDeBiOlmFhqbjLn3h6A(-1088304168 ^ -1088353758));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object QDeBiOlmFhqbjLn3h6A(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool kjRovAlxlyY0K88xJe2()
	{
		return Kfp9uel7BjdyGQqhJk7 == null;
	}

	internal static ComponentClientScriptModuleTypeConstants HRr6F8l02vtJ1K1Cxx0()
	{
		return Kfp9uel7BjdyGQqhJk7;
	}
}
[Component]
internal sealed class ComponentClientScriptModuleType : IScriptModuleType
{
	public static readonly Guid TypeUid;

	private static ComponentClientScriptModuleType WVaBLjgHwSQOHU5G7BQ;

	public Guid Uid => TypeUid;

	public string Name => (string)KmBxOZg0kEibEf90XHS(YPPeSggxwjaIYor1hdG(-787452571 ^ -787437361));

	public string GenerateSourceCode(object parameters)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(parameters is ComponentMetadata componentMetadata))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)cKiS0sgyl0V1xW9hm8o(componentMetadata);
			default:
				return string.Empty;
			case 2:
				fFPyCdgmk9Dmv5s4pVg(parameters, YPPeSggxwjaIYor1hdG(0x4DC2B14D ^ 0x4DC273C3));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public ScriptCompileResult Compile(ScriptModule module)
	{
		throw new NotImplementedException();
	}

	private static string GenerateSourceCode(object metadata)
	{
		int num = 2;
		int num2 = num;
		ICodeGenerator codeGenerator = default(ICodeGenerator);
		while (true)
		{
			switch (num2)
			{
			case 2:
				codeGenerator = new ComponentClientScriptModuleCodeGenerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)V214wwgl3qDgBhElp4s(W6igUHgJg5sBPBqHOSE(), sj7F7Xgdn0pL2thos1g(xgcK43g9T2p4jZefn0A(codeGenerator)));
			case 1:
				NvQWbngM4iEaqJfLkUa(codeGenerator, metadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ComponentClientScriptModuleType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vxa4dBgrYeEhZYbDuZ3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ComponentClientScriptModuleType()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				TypeUid = ComponentClientScriptModuleTypeConstants.TypeUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object YPPeSggxwjaIYor1hdG(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object KmBxOZg0kEibEf90XHS(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool Kkv7h4gANYFkvesXx6G()
	{
		return WVaBLjgHwSQOHU5G7BQ == null;
	}

	internal static ComponentClientScriptModuleType xlOCCfg7riaM0GtnbwD()
	{
		return WVaBLjgHwSQOHU5G7BQ;
	}

	internal static void fFPyCdgmk9Dmv5s4pVg(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object cKiS0sgyl0V1xW9hm8o(object P_0)
	{
		return ComponentClientScriptModuleType.GenerateSourceCode(P_0);
	}

	internal static void NvQWbngM4iEaqJfLkUa(object P_0, object P_1)
	{
		((ICodeGenerator)P_0).Metadata = (IMetadata)P_1;
	}

	internal static object W6igUHgJg5sBPBqHOSE()
	{
		return Encoding.UTF8;
	}

	internal static object xgcK43g9T2p4jZefn0A(object P_0)
	{
		return ((ICodeGenerator)P_0).GenerateMainFile();
	}

	internal static object sj7F7Xgdn0pL2thos1g(object P_0)
	{
		return ((GeneratedFileInfo)P_0).Data;
	}

	internal static object V214wwgl3qDgBhElp4s(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static void vxa4dBgrYeEhZYbDuZ3()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
