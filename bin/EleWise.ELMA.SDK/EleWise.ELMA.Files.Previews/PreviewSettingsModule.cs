using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

[Component]
public class PreviewSettingsModule : GlobalSettingsModuleBase<PreviewSettings>
{
	public static Guid UID;

	private static PreviewSettingsModule n5udJXGNSdojtEV1VSGt;

	public override Guid ModuleGuid => UID;

	public override string ModuleName => (string)t81mgJGNKuK8JPiE5RaJ(yC93tAGNqPFrH5drF12o(0x1637C429 ^ 0x16342B87));

	public bool IsEnabledPreview(IFilePreviewCreator creator)
	{
		//Discarded unreachable code: IL_00f2, IL_0101, IL_0111
		int num = 6;
		CreatorInfo creatorInfo = default(CreatorInfo);
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (Settings == null)
					{
						num2 = 4;
						break;
					}
					goto case 8;
				case 2:
					return !GcDoVaGNXMi2vL9QZbIK(creatorInfo);
				case 1:
					return true;
				case 7:
					if (creatorInfo == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 2;
				case 6:
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
					num2 = 5;
					break;
				default:
					return true;
				case 8:
					if (Settings.Infos != null)
					{
						goto end_IL_0012;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					_003C_003Ec__DisplayClass5_.creator = creator;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			creatorInfo = Settings.Infos.FirstOrDefault(_003C_003Ec__DisplayClass5_._003CIsEnabledPreview_003Eb__0);
			num = 7;
		}
	}

	public PreviewSettingsModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PreviewSettingsModule()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				POurBoGNTFkIAtjrgaY0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				UID = new Guid((string)yC93tAGNqPFrH5drF12o(-16752921 ^ -16535295));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object yC93tAGNqPFrH5drF12o(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object t81mgJGNKuK8JPiE5RaJ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool E4sOedGNiF3RaGkVboPa()
	{
		return n5udJXGNSdojtEV1VSGt == null;
	}

	internal static PreviewSettingsModule PVNbTMGNRDYekYjc5UZZ()
	{
		return n5udJXGNSdojtEV1VSGt;
	}

	internal static bool GcDoVaGNXMi2vL9QZbIK(object P_0)
	{
		return ((CreatorInfo)P_0).Disable;
	}

	internal static void POurBoGNTFkIAtjrgaY0()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
