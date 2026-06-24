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
internal sealed class TestScriptModuleType : IScriptModuleType
{
	public static readonly Guid TypeUid;

	internal static TestScriptModuleType zNyNrAYcKqdB06S9N1S;

	public Guid Uid => TypeUid;

	public string Name => (string)l1q9CLLWompOJNTegIe(SD81CALBUXJpW7oYvti(-1088304168 ^ -1088354916));

	public string GenerateSourceCode(object parameters)
	{
		//Discarded unreachable code: IL_0067, IL_0076
		int num = 3;
		int num2 = num;
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if ((componentMetadata = parameters as ComponentMetadata) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return string.Empty;
			case 1:
				return (string)XeFYkJLoG7e6tApNKGB(componentMetadata);
			case 3:
				Contract.ArgumentNotNull(parameters, (string)SD81CALBUXJpW7oYvti(--1333735954 ^ 0x4F7FF09C));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 2;
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
				codeGenerator = new ComponentTestScriptModuleCodeGenerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return (string)EP0UCWLfTvp6GQfmmsR(Mjf4o2Lhc6IIsBxkqfa(), sdveyALENsDd4QfBQgD(qF6BPpLGLWMtn1lHrWj(codeGenerator)));
			case 1:
				PQWigKLbIOEFCwESP4n(codeGenerator, metadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public TestScriptModuleType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wpK7KeLQuCBUqKd2QFG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static TestScriptModuleType()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				wpK7KeLQuCBUqKd2QFG();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				TypeUid = new Guid((string)SD81CALBUXJpW7oYvti(0x5F3078B6 ^ 0x5F30B638));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object SD81CALBUXJpW7oYvti(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object l1q9CLLWompOJNTegIe(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool YjW9opYzDdMedbecit1()
	{
		return zNyNrAYcKqdB06S9N1S == null;
	}

	internal static TestScriptModuleType tet5TiLFN9NyxPLkRsT()
	{
		return zNyNrAYcKqdB06S9N1S;
	}

	internal static object XeFYkJLoG7e6tApNKGB(object P_0)
	{
		return TestScriptModuleType.GenerateSourceCode(P_0);
	}

	internal static void PQWigKLbIOEFCwESP4n(object P_0, object P_1)
	{
		((ICodeGenerator)P_0).Metadata = (IMetadata)P_1;
	}

	internal static object Mjf4o2Lhc6IIsBxkqfa()
	{
		return Encoding.UTF8;
	}

	internal static object qF6BPpLGLWMtn1lHrWj(object P_0)
	{
		return ((ICodeGenerator)P_0).GenerateMainFile();
	}

	internal static object sdveyALENsDd4QfBQgD(object P_0)
	{
		return ((GeneratedFileInfo)P_0).Data;
	}

	internal static object EP0UCWLfTvp6GQfmmsR(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static void wpK7KeLQuCBUqKd2QFG()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
