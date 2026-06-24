using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime;

[Serializable]
public class BackupStatus
{
	public enum BackupContext
	{
		Unknown,
		NotNeeded,
		DoneAutomatically,
		DoneManually
	}

	private readonly string[] ContextDescription;

	private BackupContext backupStatus;

	internal static BackupStatus b4AxVDWoFXMel7oDD6QV;

	public BackupContext CurrentStatus
	{
		get
		{
			return backupStatus;
		}
		set
		{
			//Discarded unreachable code: IL_0052, IL_0061
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					backupStatus = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return;
				case 0:
					return;
				case 2:
					if (backupStatus != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 3;
				}
			}
		}
	}

	public string CurrentDescription => (string)GdCvh0WobsHctswTrWpM(ContextDescription[Uk1spGWoon8oFmikjreK(backupStatus)]);

	public bool IsCurrentStatusDetermined => backupStatus != BackupContext.Unknown;

	public bool IsVisible
	{
		[CompilerGenerated]
		get
		{
			return _003CIsVisible_003Ek__BackingField;
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
					_003CIsVisible_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public BackupStatus()
	{
		//Discarded unreachable code: IL_00ad, IL_00b2
		No1Y94Woh0H4r87qq4jk();
		ContextDescription = new string[4]
		{
			(string)llgWx6WoE0rmmSjVd4jL(MqHWBoWoG3odvJBgov2R(0x66F566B6 ^ 0x66F4EBB4)),
			SR.M((string)MqHWBoWoG3odvJBgov2R(-309639236 ^ -309671396)),
			(string)llgWx6WoE0rmmSjVd4jL(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107948562)),
			(string)llgWx6WoE0rmmSjVd4jL(MqHWBoWoG3odvJBgov2R(-1123633026 ^ -1123600870))
		};
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
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
			backupStatus = BackupContext.Unknown;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool WeFpdCWoBhHqQMrAkSWX()
	{
		return b4AxVDWoFXMel7oDD6QV == null;
	}

	internal static BackupStatus BCZmwgWoWIsx8btTmWSZ()
	{
		return b4AxVDWoFXMel7oDD6QV;
	}

	internal static int Uk1spGWoon8oFmikjreK(object P_0)
	{
		return Convert.ToInt32(P_0);
	}

	internal static object GdCvh0WobsHctswTrWpM(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void No1Y94Woh0H4r87qq4jk()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object MqHWBoWoG3odvJBgov2R(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object llgWx6WoE0rmmSjVd4jL(object P_0)
	{
		return SR.M((string)P_0);
	}
}
