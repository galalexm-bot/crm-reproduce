using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.Modules;

internal sealed class Validator
{
	private static readonly ISet<string> emptyModuleIds;

	private readonly ILogger logger;

	internal static Validator ttojsAEJOrbvpqtRBq8v;

	public Validator(ILogger logger)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ErwQ1vEJPF0ZWd3dRshV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.logger = logger;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
			{
				num = 1;
			}
		}
	}

	public void Validate(IReadOnlyCollection<IConfigImportSettings> configImportSettings)
	{
		if (configImportSettings == null || configImportSettings.Count == 0)
		{
			throw Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571A6215)));
		}
		if (configImportSettings.Count == 1)
		{
			ValidateModule(configImportSettings.First(), emptyModuleIds);
		}
		else
		{
			ValidateApplication(configImportSettings);
		}
	}

	public void ValidateApplication(IReadOnlyCollection<IConfigImportSettings> configImportSettings)
	{
		ValidateApplicationHeader(configImportSettings.First());
		HashSet<string> moduleIds = configImportSettings.First().Manifest.BpmApps.Select((BpmAppManifest b) => (string)_003C_003Ec.mvo1t586R1lRE0guLbJr(b)).ToHashSet();
		foreach (IConfigImportSettings item in configImportSettings.Skip(1))
		{
			ValidateModule(item, moduleIds);
		}
		ElmaStoreComponentManifest manifest = configImportSettings.First().Manifest;
		Info(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978630439), manifest.Title, manifest.Id));
	}

	public void ValidateApplicationHeader(IConfigImportSettings import)
	{
		//Discarded unreachable code: IL_003a, IL_0044
		int num = 2;
		int num2 = num;
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				obj = null;
				goto IL_0124;
			case 2:
				if (import != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			default:
				throw Error((string)A02ZeyEJ3fOWxUSYOoJd(wUdxMWEJN2OIwFvN7Vp9(0x307E9FD1 ^ 0x307A5D85)));
			case 5:
				throw Error(SR.T((string)wUdxMWEJN2OIwFvN7Vp9(-195614443 ^ -195826733), import.Manifest.Title, kqBTYtEJtEXATeUhTgbK(jOE9CHEJ1gL8EKt5Ovwe(import))));
			case 4:
				if (!hJIqNoEJDuKe4JAZD5e3(Wr26ZWEJa1W9ksQN3c7Z(jOE9CHEJ1gL8EKt5Ovwe(import)), Guid.Empty))
				{
					return;
				}
				num2 = 5;
				break;
			case 1:
				{
					obj = jOE9CHEJ1gL8EKt5Ovwe(import);
					goto IL_0124;
				}
				IL_0124:
				if (obj != null)
				{
					if (QA77skEJpJflDUV7GIwa(import.Manifest) == ManifestComponentType.Application)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 5;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ValidateModule(IConfigImportSettings import, ISet<string> moduleIds)
	{
		if (import?.Manifest == null)
		{
			throw Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x7415D28)));
		}
		if (import.Manifest.ProductType != 0 || import.Manifest.ModuleUid == Guid.Empty || import.Manifest.BpmApps.Count > 0)
		{
			throw Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335271525), import.Manifest.Title, import.Manifest.Id));
		}
		if (moduleIds.Count > 0 && !moduleIds.Contains(import.Manifest.Id))
		{
			throw Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112456858), import.Manifest.Title, import.Manifest.Id));
		}
		Info(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A1E722), import.Manifest.Title, import.Manifest.Id));
	}

	private Exception Error(string message)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				logger.Log(LogLevel.Error, null, message);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new ModuleValidationException(message);
			}
		}
	}

	private void Info(string message)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				logger.Log(LogLevel.Information, null, message);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	static Validator()
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
				emptyModuleIds = new HashSet<string>(0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				ErwQ1vEJPF0ZWd3dRshV();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void ErwQ1vEJPF0ZWd3dRshV()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool gWaBd1EJ2RrPAQPH9q22()
	{
		return ttojsAEJOrbvpqtRBq8v == null;
	}

	internal static Validator JTQtJYEJeKRD0DmtN9ED()
	{
		return ttojsAEJOrbvpqtRBq8v;
	}

	internal static object jOE9CHEJ1gL8EKt5Ovwe(object P_0)
	{
		return ((IConfigImportSettings)P_0).Manifest;
	}

	internal static object wUdxMWEJN2OIwFvN7Vp9(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object A02ZeyEJ3fOWxUSYOoJd(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static ManifestComponentType QA77skEJpJflDUV7GIwa(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).ProductType;
	}

	internal static Guid Wr26ZWEJa1W9ksQN3c7Z(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).ModuleUid;
	}

	internal static bool hJIqNoEJDuKe4JAZD5e3(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object kqBTYtEJtEXATeUhTgbK(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Id;
	}
}
