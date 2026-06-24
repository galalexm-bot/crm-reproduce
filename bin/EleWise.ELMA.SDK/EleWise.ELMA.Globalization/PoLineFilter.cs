using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Globalization;

public class PoLineFilter : Filter
{
	internal static PoLineFilter XJNwAGGEAFGV4v8DUYAs;

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
				case 1:
					_003CFileName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
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

	public bool Untranslated
	{
		[CompilerGenerated]
		get
		{
			return _003CUntranslated_003Ek__BackingField;
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
					_003CUntranslated_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
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

	public bool Fuzzy
	{
		[CompilerGenerated]
		get
		{
			return _003CFuzzy_003Ek__BackingField;
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
					_003CFuzzy_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool HighPriority
	{
		[CompilerGenerated]
		get
		{
			return _003CHighPriority_003Ek__BackingField;
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
					_003CHighPriority_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool LowPriority
	{
		[CompilerGenerated]
		get
		{
			return _003CLowPriority_003Ek__BackingField;
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
					_003CLowPriority_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
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

	public bool Checked(PoLineDescriptor descriptor)
	{
		//Discarded unreachable code: IL_00c0, IL_00cf, IL_010c, IL_011b
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				return false;
			case 2:
				if (!Untranslated)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 3:
				if (q1htN0GEmVaRGmqkbbXS(gUhy2IGE0sayQKHNK3A4(descriptor)))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			case 6:
				return false;
			case 7:
				return false;
			default:
				return false;
			case 1:
			case 4:
				if (Fuzzy == VkW2WSGEylp5SfaGw5Ud(descriptor))
				{
					if (HighPriority != !descriptor.IsLow)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 1;
						}
						break;
					}
					if (LowPriority == VifVPLGEM7lMBZKbm7jd(descriptor))
					{
						return true;
					}
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 7;
					}
				}
				else
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	public PoLineFilter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.PushGlobal();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool KuIm2aGE7CC6uF82hRTV()
	{
		return XJNwAGGEAFGV4v8DUYAs == null;
	}

	internal static PoLineFilter vfpHkfGExDlO3g4JiHE3()
	{
		return XJNwAGGEAFGV4v8DUYAs;
	}

	internal static object gUhy2IGE0sayQKHNK3A4(object P_0)
	{
		return ((PoLineDescriptor)P_0).Value;
	}

	internal static bool q1htN0GEmVaRGmqkbbXS(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool VkW2WSGEylp5SfaGw5Ud(object P_0)
	{
		return ((PoLineDescriptor)P_0).IsFuzzy;
	}

	internal static bool VifVPLGEM7lMBZKbm7jd(object P_0)
	{
		return ((PoLineDescriptor)P_0).IsLow;
	}
}
