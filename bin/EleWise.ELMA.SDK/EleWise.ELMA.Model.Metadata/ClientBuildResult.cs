using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

public sealed class ClientBuildResult
{
	private static ClientBuildResult AjZMELb1canb0fBQbsiH;

	public byte[] AssemblyRaw { get; }

	public byte[] JsAssemblyRaw { get; }

	public byte[] MinJsAssemblyRaw { get; }

	public string AssemblyName { get; }

	public byte[] DocumentationRaw { get; }

	public ClientBuildResult(byte[] assemblyRaw, byte[] jsAssemblyRaw, byte[] minJsAssemblyRaw, string assemblyName, byte[] documentationRaw = null)
	{
		//Discarded unreachable code: IL_002a
		aYgIETbNB8GqbvkZcBEP();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				AssemblyRaw = assemblyRaw;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num = 2;
				}
				break;
			case 3:
				AssemblyName = assemblyName;
				num = 4;
				break;
			case 4:
				DocumentationRaw = documentationRaw;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num = 1;
				}
				break;
			case 5:
			{
				MinJsAssemblyRaw = minJsAssemblyRaw;
				int num2 = 3;
				num = num2;
				break;
			}
			case 1:
				return;
			case 2:
				JsAssemblyRaw = jsAssemblyRaw;
				num = 5;
				break;
			}
		}
	}

	internal static void aYgIETbNB8GqbvkZcBEP()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool rAadq2b1z6H0ECKUPFC4()
	{
		return AjZMELb1canb0fBQbsiH == null;
	}

	internal static ClientBuildResult VnaT9ObNFNeiXrXyCuVX()
	{
		return AjZMELb1canb0fBQbsiH;
	}
}
