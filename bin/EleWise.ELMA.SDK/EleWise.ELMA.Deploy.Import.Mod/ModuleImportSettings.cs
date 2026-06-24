using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.Modules;

[Serializable]
[DataContract]
internal sealed class ModuleImportSettings : IConfigImportSettings, IImportSettings
{
	[DataMember]
	private IConfigImportSettings originalSettings;

	internal static ModuleImportSettings nwerhZEMgPREj4gNbC4K;

	[IgnoreDataMember]
	public BPMAppFakeManifest FakeManifest => originalSettings.FakeManifest;

	[IgnoreDataMember]
	public ICollection<TestImportMessages> TestResult => originalSettings.TestResult;

	[IgnoreDataMember]
	public string FileName
	{
		get
		{
			return (string)zODXuYEMcuTA7yrCRVJE(originalSettings);
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					PtgO9iEMz3IaZ9NLyL1y(originalSettings, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[IgnoreDataMember]
	public int ImportStep
	{
		get
		{
			return ATrEn4EJFiYGcm4FZGx3(originalSettings);
		}
		set
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
					cipOIJEJBkSxl4QxycoY(originalSettings, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[IgnoreDataMember]
	public ElmaStoreComponentManifest Manifest
	{
		get
		{
			return (ElmaStoreComponentManifest)oXs4ZEEJWvK6EsDngxx0(originalSettings);
		}
		set
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
					pSGgVXEJonJWSN3pQ5xx(originalSettings, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public bool Compatible { get; }

	public ModuleImportSettings(TestModuleImportSettings testSettings)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		N0PCkWEMYB5VSgxfNNDY();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				originalSettings = (IConfigImportSettings)AlFBQaEMUoXoBvYbI21x(testSettings);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			case 1:
				vnvYSlEMLDDKobXElLmR(testSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341C9F17));
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num = 3;
				}
				break;
			default:
				Compatible = !daO6vHEMsIXpP4o4DWL1(testSettings);
				num = 2;
				break;
			}
		}
	}

	internal static void N0PCkWEMYB5VSgxfNNDY()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void vnvYSlEMLDDKobXElLmR(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object AlFBQaEMUoXoBvYbI21x(object P_0)
	{
		return ((TestModuleImportSettings)P_0).OriginalSettings;
	}

	internal static bool daO6vHEMsIXpP4o4DWL1(object P_0)
	{
		return ((TestModuleImportSettings)P_0).Incompatible;
	}

	internal static bool xR46d2EM5gYMTD87FTdP()
	{
		return nwerhZEMgPREj4gNbC4K == null;
	}

	internal static ModuleImportSettings B3SdovEMjXhZ0CFeIe0x()
	{
		return nwerhZEMgPREj4gNbC4K;
	}

	internal static object zODXuYEMcuTA7yrCRVJE(object P_0)
	{
		return ((IConfigImportSettings)P_0).FileName;
	}

	internal static void PtgO9iEMz3IaZ9NLyL1y(object P_0, object P_1)
	{
		((IConfigImportSettings)P_0).FileName = (string)P_1;
	}

	internal static int ATrEn4EJFiYGcm4FZGx3(object P_0)
	{
		return ((IImportSettings)P_0).ImportStep;
	}

	internal static void cipOIJEJBkSxl4QxycoY(object P_0, int value)
	{
		((IImportSettings)P_0).ImportStep = value;
	}

	internal static object oXs4ZEEJWvK6EsDngxx0(object P_0)
	{
		return ((IConfigImportSettings)P_0).Manifest;
	}

	internal static void pSGgVXEJonJWSN3pQ5xx(object P_0, object P_1)
	{
		((IConfigImportSettings)P_0).Manifest = (ElmaStoreComponentManifest)P_1;
	}
}
