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
internal sealed class ComponentViewScriptModuleType : IScriptModuleType
{
	public static readonly Guid TypeUid;

	internal static ComponentViewScriptModuleType vTeUHMlyLQSKXvopHsh;

	public Guid Uid => TypeUid;

	public string Name => SR.T((string)kLNu9Al9FOMuEwYyxNV(-1751176224 ^ -1751127638));

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
				SjuD7WldjjSYGIqeVO8(parameters, kLNu9Al9FOMuEwYyxNV(-1921202237 ^ -1921252019));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (!(parameters is ComponentMetadata metadata))
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			return ComponentViewScriptModuleType.GenerateSourceCode((object)metadata);
		}
	}

	public ScriptCompileResult Compile(ScriptModule module)
	{
		throw new NotImplementedException();
	}

	private static string GenerateSourceCode(object metadata)
	{
		int num = 1;
		int num2 = num;
		ICodeGenerator codeGenerator = default(ICodeGenerator);
		while (true)
		{
			switch (num2)
			{
			case 1:
				codeGenerator = new ComponentViewScriptModuleCodeGenerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return (string)fgIPr2ljtiDFiwD9wut(P5ZT8JlrkWmX3L99dM4(), eQLF1Zl57yjQUydtk2d(qOJNmUlg7s1P1al1tOR(codeGenerator)));
			default:
				bL7CfSllxl5OgeZTKlv(codeGenerator, metadata);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ComponentViewScriptModuleType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ComponentViewScriptModuleType()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				TypeUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108027208));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object kLNu9Al9FOMuEwYyxNV(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool s2ePmFlMnH3m0xeoxJK()
	{
		return vTeUHMlyLQSKXvopHsh == null;
	}

	internal static ComponentViewScriptModuleType rQi5oClJCjfG3jYu7uE()
	{
		return vTeUHMlyLQSKXvopHsh;
	}

	internal static void SjuD7WldjjSYGIqeVO8(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void bL7CfSllxl5OgeZTKlv(object P_0, object P_1)
	{
		((ICodeGenerator)P_0).Metadata = (IMetadata)P_1;
	}

	internal static object P5ZT8JlrkWmX3L99dM4()
	{
		return Encoding.UTF8;
	}

	internal static object qOJNmUlg7s1P1al1tOR(object P_0)
	{
		return ((ICodeGenerator)P_0).GenerateMainFile();
	}

	internal static object eQLF1Zl57yjQUydtk2d(object P_0)
	{
		return ((GeneratedFileInfo)P_0).Data;
	}

	internal static object fgIPr2ljtiDFiwD9wut(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}
}
