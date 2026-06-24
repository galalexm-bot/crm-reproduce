using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.Modules;

internal sealed class ModuleConfigImportExtension : ConfigImportExtension
{
	internal static ModuleConfigImportExtension ksWjKwEMf3d2d1h8mrBr;

	public override void OnPostCompleteTest(PostCompleteTestImportParameters parameters)
	{
		int num = 2;
		int num2 = num;
		TestModuleImportSettings testModuleImportSettings = default(TestModuleImportSettings);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				base.OnPostCompleteTest(parameters);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			case 3:
				if (!zv7Y9eEM8rEgae7LqOUt(testModuleImportSettings))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					parameters.ServiceData.Add((string)C3vviYEMZd1wgv1X8aQM(0x3CE17B75 ^ 0x3CE5C7C5), string.Empty);
					num2 = 4;
				}
				break;
			case 1:
				if ((testModuleImportSettings = KvDhXWEMvTcDw3PkJMtv(parameters) as TestModuleImportSettings) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 3;
					}
					break;
				}
				return;
			case 0:
				return;
			}
		}
	}

	public ModuleConfigImportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object KvDhXWEMvTcDw3PkJMtv(object P_0)
	{
		return ((PostCompleteTestImportParameters)P_0).ImportSettings;
	}

	internal static bool zv7Y9eEM8rEgae7LqOUt(object P_0)
	{
		return ((TestModuleImportSettings)P_0).Incompatible;
	}

	internal static object C3vviYEMZd1wgv1X8aQM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool CN5ROnEMQFVSvZX1dAEC()
	{
		return ksWjKwEMf3d2d1h8mrBr == null;
	}

	internal static ModuleConfigImportExtension Kd3H2UEMCApmrOmbtLWn()
	{
		return ksWjKwEMf3d2d1h8mrBr;
	}
}
