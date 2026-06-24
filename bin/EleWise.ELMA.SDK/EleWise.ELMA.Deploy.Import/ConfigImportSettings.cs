using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import;

[Serializable]
public sealed class ConfigImportSettings : IConfigImportSettings, IImportSettings
{
	internal static ConfigImportSettings Ba5NWSEyFU9HxhJY13A7;

	public int ImportStep
	{
		[CompilerGenerated]
		get
		{
			return _003CImportStep_003Ek__BackingField;
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
					_003CImportStep_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ICollection<TestImportMessages> TestResult { get; }

	public string FileName
	{
		[CompilerGenerated]
		get
		{
			return _003CFileName_003Ek__BackingField;
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
					_003CFileName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
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
		[CompilerGenerated]
		get
		{
			return _003CManifest_003Ek__BackingField;
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
					_003CManifest_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public BPMAppFakeManifest FakeManifest { get; }

	public ConfigImportSettings()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		SingletonReader.JJCZtPuTvSt();
		TestResult = new List<TestImportMessages>();
		FakeManifest = new BPMAppFakeManifest();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
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
			CreateFileName();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
			{
				num = 1;
			}
		}
	}

	public ConfigImportSettings(string fileName)
	{
		//Discarded unreachable code: IL_004a, IL_004f
		SingletonReader.JJCZtPuTvSt();
		TestResult = new List<TestImportMessages>();
		FakeManifest = new BPMAppFakeManifest();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				FileName = fileName;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num = 0;
				}
				break;
			case 2:
				SXJBL3Eybf9sohkXs9Sb(fileName, acl2k2Eyo2qMdg53HpmG(0x8317432 ^ 0x8310A28));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public void CreateFileName()
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
				FileName = buawlKEyhXv1AW3X8xsG().ToString();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool VKDZoUEyBBLuWbBWYoqv()
	{
		return Ba5NWSEyFU9HxhJY13A7 == null;
	}

	internal static ConfigImportSettings qBF70bEyWBXtY79laOH3()
	{
		return Ba5NWSEyFU9HxhJY13A7;
	}

	internal static object acl2k2Eyo2qMdg53HpmG(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void SXJBL3Eybf9sohkXs9Sb(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static Guid buawlKEyhXv1AW3X8xsG()
	{
		return Guid.NewGuid();
	}
}
