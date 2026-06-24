using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class PacketAttribute : Attribute
{
	private int version;

	private static PacketAttribute fOOgZdEppa5dyyPhNkLS;

	public int Version
	{
		get
		{
			return version;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					if (value <= 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num2 = 1;
						}
						break;
					}
					version = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					throw new ArgumentOutOfRangeException((string)JoDiSwEpwtp997M4iNyn(kFI7lxEptRTgsRmYn4OJ(0x57A5235E ^ 0x57A1A6AE)));
				case 0:
					return;
				}
			}
		}
	}

	public string ContentType
	{
		[CompilerGenerated]
		get
		{
			return _003CContentType_003Ek__BackingField;
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
					_003CContentType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
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

	[DefaultValue(true)]
	public bool Active
	{
		[CompilerGenerated]
		get
		{
			return _003CActive_003Ek__BackingField;
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
					_003CActive_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PacketAttribute(int version, string contentType, bool active = true)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		H1HTEpEp491UcOGgPG6M();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				ContentType = contentType;
				num = 2;
				break;
			case 2:
				Active = active;
				num = 3;
				break;
			case 1:
				Version = version;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			}
		}
	}

	internal static object kFI7lxEptRTgsRmYn4OJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object JoDiSwEpwtp997M4iNyn(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool hDcZv8EpabEJrKfh2pOj()
	{
		return fOOgZdEppa5dyyPhNkLS == null;
	}

	internal static PacketAttribute BOFeWiEpD0WDHV6JsMpG()
	{
		return fOOgZdEppa5dyyPhNkLS;
	}

	internal static void H1HTEpEp491UcOGgPG6M()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
