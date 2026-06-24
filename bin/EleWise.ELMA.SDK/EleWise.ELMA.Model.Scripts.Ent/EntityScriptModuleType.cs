using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Templates;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Entities;

[Component]
public class EntityScriptModuleType : IScriptModuleType
{
	public const string UID_S = "{1E1A9184-9A34-4D26-AF3C-B2E7ABE2954C}";

	public static readonly Guid UID;

	internal static EntityScriptModuleType g588WOb1EnIu9MrWHtdW;

	public Guid Uid => UID;

	public string Name => (string)b6MSp2b18d2Xhk0cEdhr(PN1aqTb1vCLmA6iEJG6U(-1751176224 ^ -1751265456));

	public static string GenerateSourceCode(EntityScriptCodeGenerationParams p)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass2_.p = p;
				num2 = 3;
				break;
			case 2:
				return ResourceTemplateGenerator.GenerateTemplate<EntityScriptModuleType>((string)PN1aqTb1vCLmA6iEJG6U(-420743386 ^ -420932788), _003C_003Ec__DisplayClass2_._003CGenerateSourceCode_003Eb__0);
			case 3:
				_003C_003Ec__DisplayClass2_.summary = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787314353), ((NamedMetadata)qV3Mptb1CTKYxMWaE2uc(_003C_003Ec__DisplayClass2_.p)).DisplayName);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public string GenerateSourceCode(object parameters)
	{
		//Discarded unreachable code: IL_0041, IL_0050
		int num = 2;
		int num2 = num;
		EntityScriptCodeGenerationParamsUI p = default(EntityScriptCodeGenerationParamsUI);
		while (true)
		{
			switch (num2)
			{
			default:
				return EntityScriptModuleType.GenerateSourceCode((object)p);
			case 1:
				return (string)QrtDQ3b1ZSrQGWI7RrDL((EntityScriptCodeGenerationParams)parameters);
			case 2:
				if ((p = parameters as EntityScriptCodeGenerationParamsUI) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public ScriptCompileResult Compile(ScriptModule module)
	{
		throw new NotImplementedException();
	}

	private static string GenerateSourceCode(object p)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (BqLpSjb1IYQwl4Ml5sKX(_003C_003Ec__DisplayClass9_.p) == RuntimeVersion.Version2)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return ResourceTemplateGenerator.GenerateTemplate<EntityScriptModuleType>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFC1C00), _003C_003Ec__DisplayClass9_._003CGenerateSourceCode_003Eb__1);
			default:
				return ResourceTemplateGenerator.GenerateTemplate<EntityScriptModuleType>((string)PN1aqTb1vCLmA6iEJG6U(-1886646897 ^ -1886459541), _003C_003Ec__DisplayClass9_._003CGenerateSourceCode_003Eb__0);
			case 4:
				_003C_003Ec__DisplayClass9_.summary = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853024722), kUlefBb1ugmlim4ELYKH(_003C_003Ec__DisplayClass9_.p));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass9_.p = (EntityScriptCodeGenerationParamsUI)p;
				num2 = 4;
				break;
			case 3:
				_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
				num2 = 2;
				break;
			}
		}
	}

	public EntityScriptModuleType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WIggBab1V9aTqxZyZNTE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EntityScriptModuleType()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				WIggBab1V9aTqxZyZNTE();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824461133));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object qV3Mptb1CTKYxMWaE2uc(object P_0)
	{
		return ((EntityScriptCodeGenerationParams)P_0).Metadata;
	}

	internal static object PN1aqTb1vCLmA6iEJG6U(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool s9lNSnb1f0V0AGnXF4WM()
	{
		return g588WOb1EnIu9MrWHtdW == null;
	}

	internal static EntityScriptModuleType pE3tP2b1QtBkuOPP12Wc()
	{
		return g588WOb1EnIu9MrWHtdW;
	}

	internal static object b6MSp2b18d2Xhk0cEdhr(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object QrtDQ3b1ZSrQGWI7RrDL(object P_0)
	{
		return GenerateSourceCode((EntityScriptCodeGenerationParams)P_0);
	}

	internal static object kUlefBb1ugmlim4ELYKH(object P_0)
	{
		return ((EntityScriptCodeGenerationParamsUI)P_0).MdDisplayName;
	}

	internal static RuntimeVersion BqLpSjb1IYQwl4Ml5sKX(object P_0)
	{
		return ((EntityScriptCodeGenerationParamsUI)P_0).RuntimeVersion;
	}

	internal static void WIggBab1V9aTqxZyZNTE()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
