using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class PropertyAttribute : Attribute
{
	private Guid typeUid;

	private Guid subTypeUid;

	private static PropertyAttribute zZWrmroVv8buulErSYmC;

	public Guid TypeUid => typeUid;

	public Guid SubTypeUid => subTypeUid;

	public PropertyAttribute(string typeUid)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				Contract.ArgumentNotNull(typeUid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103DB075));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				this.typeUid = new Guid(typeUid);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public PropertyAttribute(string typeUid, string subTypeUid)
	{
		//Discarded unreachable code: IL_002a
		WiNlpZoVuuFEexCSs5Fy();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 3:
				Contract.ArgumentNotNull(subTypeUid, (string)oFUrAboVIWPLosTqmgbs(0x2ACE37D ^ 0x2AEBAA9));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num = 1;
				}
				break;
			default:
			{
				this.subTypeUid = new Guid(subTypeUid);
				int num2 = 4;
				num = num2;
				break;
			}
			case 2:
				Contract.ArgumentNotNull(typeUid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217640391));
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num = 3;
				}
				break;
			case 1:
				this.typeUid = new Guid(typeUid);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public PropertyAttribute(Guid typeUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WiNlpZoVuuFEexCSs5Fy();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.typeUid = typeUid;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public PropertyAttribute(Guid typeUid, Guid subTypeUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WiNlpZoVuuFEexCSs5Fy();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				this.typeUid = typeUid;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num = 0;
				}
				break;
			default:
				this.subTypeUid = subTypeUid;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	internal static bool BWUVpvoV8tCeejnTpqGH()
	{
		return zZWrmroVv8buulErSYmC == null;
	}

	internal static PropertyAttribute gHbOH8oVZKaVaLLIHyMO()
	{
		return zZWrmroVv8buulErSYmC;
	}

	internal static void WiNlpZoVuuFEexCSs5Fy()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object oFUrAboVIWPLosTqmgbs(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
