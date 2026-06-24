using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

internal sealed class ComponentServerControllerGenerator : ClassGenerator
{
	private ComponentMetadata componentMetadata;

	private static ComponentServerControllerGenerator hPSncTBIv6ZBYdT76Mcu;

	internal ISyntaxNode Generate()
	{
		return ((string)cnmvE4BIuGX88jSS6r22(componentMetadata)).NamespaceDeclaration(((string)qcBg6jBIIu616YuqiJns(componentMetadata)).ClassDeclaration(Accessibility.NotApplicable, DeclarationModifiers.Partial, null, null, new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4784ADEF).ClassDeclaration(Accessibility.Private, DeclarationModifiers.Partial) }));
	}

	protected override void InitInternal(IMetadata metadata)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				T0tgdiBISkgxta9CU6fL(metadata, jvieGMBIVn48xBF2Ny8V(0x4DC2B14D ^ 0x4DC2F873));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				componentMetadata = (ComponentMetadata)metadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				Contract.CheckArgument(metadata is ComponentMetadata, (string)jvieGMBIVn48xBF2Ny8V(-475857671 ^ -475794727));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public ComponentServerControllerGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qxH6sKBIibN9oPGFVZIk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object cnmvE4BIuGX88jSS6r22(object P_0)
	{
		return ((ComponentMetadata)P_0).Namespace;
	}

	internal static object qcBg6jBIIu616YuqiJns(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static bool jiTpPxBI8DNDuZpuicZ4()
	{
		return hPSncTBIv6ZBYdT76Mcu == null;
	}

	internal static ComponentServerControllerGenerator qVbRadBIZUkYns2BMnGi()
	{
		return hPSncTBIv6ZBYdT76Mcu;
	}

	internal static object jvieGMBIVn48xBF2Ny8V(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void T0tgdiBISkgxta9CU6fL(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void qxH6sKBIibN9oPGFVZIk()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
