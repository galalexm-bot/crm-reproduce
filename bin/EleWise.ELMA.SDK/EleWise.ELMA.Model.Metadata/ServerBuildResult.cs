using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

public sealed class ServerBuildResult
{
	internal static ServerBuildResult BlynMeb3KnbjicaUMoAm;

	public byte[] AssemblyRaw { get; }

	public byte[] DebugRaw { get; }

	public string AssemblyName { get; }

	public byte[] DocumentationRaw { get; }

	public ServerBuildResult(byte[] assemblyRaw, byte[] debugRaw, string assemblyName, byte[] documentationRaw = null)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xOGEfTb3kk9JixclDZO2();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				AssemblyName = assemblyName;
				num = 4;
				break;
			case 1:
				return;
			default:
				DebugRaw = debugRaw;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num = 2;
				}
				break;
			case 3:
				AssemblyRaw = assemblyRaw;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num = 0;
				}
				break;
			case 4:
				DocumentationRaw = documentationRaw;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void xOGEfTb3kk9JixclDZO2()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool I8DOKYb3XfQ9TEautI7o()
	{
		return BlynMeb3KnbjicaUMoAm == null;
	}

	internal static ServerBuildResult EjjFeab3TaNPuERi2MC3()
	{
		return BlynMeb3KnbjicaUMoAm;
	}
}
