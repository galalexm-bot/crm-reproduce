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

[Component]
internal sealed class ComponentScriptModuleType : IScriptModuleType
{
	public static readonly Guid TypeUid;

	internal static ComponentScriptModuleType yCUdC2j3oaBFOER7mVj;

	public Guid Uid => TypeUid;

	public string Name => SR.T((string)UaTLj4jDVKNSKoTnIJq(0x68BBB53E ^ 0x68BB7C4A));

	public string GenerateSourceCode(object parameters)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return string.Empty;
			case 1:
				BPPrtTjt1PKRr6OfNbT(parameters, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583794054));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (parameters is ComponentMetadata componentMetadata)
			{
				return (string)oG9hJvjwdUUrd581uUg(componentMetadata);
			}
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
			{
				num2 = 2;
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
			case 1:
				codeGenerator.Metadata = (IMetadata)metadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				codeGenerator = new ComponentServerScriptModuleCodeGenerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return (string)kMZHuQj6dRS1vDHolOu(AU5TiHj4yS0fYclcPyS(), codeGenerator.GenerateMainFile().Data);
			}
		}
	}

	public ComponentScriptModuleType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ComponentScriptModuleType()
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
				TypeUid = new Guid((string)UaTLj4jDVKNSKoTnIJq(0x53CB464B ^ 0x53CB8FE9));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object UaTLj4jDVKNSKoTnIJq(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool bDfsYbjpFjjbW7MduLU()
	{
		return yCUdC2j3oaBFOER7mVj == null;
	}

	internal static ComponentScriptModuleType BWUEFhjasTjx84n12Im()
	{
		return yCUdC2j3oaBFOER7mVj;
	}

	internal static void BPPrtTjt1PKRr6OfNbT(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object oG9hJvjwdUUrd581uUg(object P_0)
	{
		return ComponentScriptModuleType.GenerateSourceCode(P_0);
	}

	internal static object AU5TiHj4yS0fYclcPyS()
	{
		return Encoding.UTF8;
	}

	internal static object kMZHuQj6dRS1vDHolOu(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}
}
