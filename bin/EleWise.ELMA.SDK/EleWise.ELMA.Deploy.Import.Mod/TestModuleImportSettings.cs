using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.Modules;

internal sealed class TestModuleImportSettings : IConfigImportSettings, IImportSettings
{
	private static TestModuleImportSettings hoF6IhEJSFpUM9v1Ydir;

	public BPMAppFakeManifest FakeManifest => (BPMAppFakeManifest)S5uLJGEJqXLIVP5vbHHD(OriginalSettings);

	public ICollection<TestImportMessages> TestResult => OriginalSettings.TestResult;

	public string FileName
	{
		get
		{
			return (string)flGZO9EJKjXf1Fa271LP(OriginalSettings);
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
					wNWeQCEJXsGCiUUx2xuj(OriginalSettings, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int ImportStep
	{
		get
		{
			return Twp6nNEJT2RG6xWfIwgE(OriginalSettings);
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
					FmZDPeEJk2VWLS6J8MI7(OriginalSettings, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ElmaStoreComponentManifest Manifest
	{
		get
		{
			return (ElmaStoreComponentManifest)VKe07aEJnbHOlwiR4BRU(OriginalSettings);
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
					OriginalSettings.Manifest = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid? ModuleHeaderUid { get; set; }

	public ModuleInfoMetadata ModuleMetadata
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleMetadata_003Ek__BackingField;
		}
		[CompilerGenerated]
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
					_003CModuleMetadata_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
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

	public IReadOnlyCollection<ModuleVersion> ModuleMetadataContext { get; set; }

	public bool HasErrors => TestResult.Any((TestImportMessages tr) => _003C_003Ec.xfB7AD86uFaAI2axEaKp(tr) == TestImportMessagesType.Error);

	public IConfigImportSettings OriginalSettings { get; }

	public bool Incompatible
	{
		[CompilerGenerated]
		get
		{
			return _003CIncompatible_003Ek__BackingField;
		}
		[CompilerGenerated]
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
					_003CIncompatible_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TestModuleImportSettings(IConfigImportSettings settings, IReadOnlyCollection<ModuleVersion> moduleMetadataContext)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.ArgumentNotNull(settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210732723));
		Contract.ArgumentNotNull(moduleMetadataContext, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x3136A058));
		OriginalSettings = settings;
		ModuleMetadataContext = moduleMetadataContext;
	}

	internal static object S5uLJGEJqXLIVP5vbHHD(object P_0)
	{
		return ((IConfigImportSettings)P_0).FakeManifest;
	}

	internal static bool iGSmBUEJiII1ehlAjRtQ()
	{
		return hoF6IhEJSFpUM9v1Ydir == null;
	}

	internal static TestModuleImportSettings nqXY2REJRBL43IhnmWfJ()
	{
		return hoF6IhEJSFpUM9v1Ydir;
	}

	internal static object flGZO9EJKjXf1Fa271LP(object P_0)
	{
		return ((IConfigImportSettings)P_0).FileName;
	}

	internal static void wNWeQCEJXsGCiUUx2xuj(object P_0, object P_1)
	{
		((IConfigImportSettings)P_0).FileName = (string)P_1;
	}

	internal static int Twp6nNEJT2RG6xWfIwgE(object P_0)
	{
		return ((IImportSettings)P_0).ImportStep;
	}

	internal static void FmZDPeEJk2VWLS6J8MI7(object P_0, int value)
	{
		((IImportSettings)P_0).ImportStep = value;
	}

	internal static object VKe07aEJnbHOlwiR4BRU(object P_0)
	{
		return ((IConfigImportSettings)P_0).Manifest;
	}
}
