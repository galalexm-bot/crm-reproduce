using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.OmniSharp.Models;

internal sealed class ScriptReference : IScriptReference
{
	internal static ScriptReference xD0OFJWlMKy3JyKpefiA;

	public string Name { get; }

	public string HintPath { get; }

	public byte[] AssemblyRaw { get; }

	public byte[] DocumentationRaw { get; }

	public ScriptReference(string name, string hintPath, byte[] assemblyRaw, byte[] documentationRaw = null)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		k8xAP7WldQHME8n7RRUd();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 4:
				AssemblyRaw = assemblyRaw;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				HintPath = hintPath;
				num = 4;
				break;
			case 0:
				return;
			case 3:
				Name = name;
				num = 2;
				break;
			case 1:
				DocumentationRaw = documentationRaw ?? Array.Empty<byte>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void k8xAP7WldQHME8n7RRUd()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool P1nSIFWlJL1d1NlrSHtR()
	{
		return xD0OFJWlMKy3JyKpefiA == null;
	}

	internal static ScriptReference Q4DtvbWl9RF1tQpyN9K6()
	{
		return xD0OFJWlMKy3JyKpefiA;
	}
}
