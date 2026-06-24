using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Common;

public sealed class TimeZoneModel
{
	internal static TimeZoneModel jfEcy3hqyZsvoIJ4yimr;

	public string TimeZoneId
	{
		[CompilerGenerated]
		get
		{
			return _003CTimeZoneId_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CTimeZoneId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int Offset
	{
		[CompilerGenerated]
		get
		{
			return _003COffset_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003COffset_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool Dst
	{
		[CompilerGenerated]
		get
		{
			return _003CDst_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CDst_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[JsonIgnore]
	public TZSettings Settings => new TZSettings(TZSettings.TZType.Custom, Offset);

	public TimeZoneModel(string timeZoneId, string name, int offset, bool dst)
	{
		//Discarded unreachable code: IL_001a
		ucuuSThq9Hj8xlCR57uA();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 2:
				Offset = offset;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num = 0;
				}
				break;
			case 3:
			{
				Name = name;
				int num2 = 2;
				num = num2;
				break;
			}
			case 4:
				TimeZoneId = timeZoneId;
				num = 3;
				break;
			default:
				Dst = dst;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public override string ToString()
	{
		return (string)BEh10Bhqr1vcTE04WEQB(kv6PMLhqdHRs6jVJBgdU(0x12441CA4 ^ 0x124759F8), new object[4]
		{
			(Offset / 60).ToString((string)kv6PMLhqdHRs6jVJBgdU(0x6DC147B0 ^ 0x6DC20238)),
			ts6rRQhqlk4DAC8Q74O7(Offset % 60).ToString((string)kv6PMLhqdHRs6jVJBgdU(0x10E41EDB ^ 0x10E75B41)),
			SR.T(Name),
			Dst ? SR.T((string)kv6PMLhqdHRs6jVJBgdU(0x1637C429 ^ 0x1634818B)) : string.Empty
		});
	}

	public string ToJson()
	{
		return JsonConvert.SerializeObject((object)this);
	}

	private bool Equals(TimeZoneModel other)
	{
		//Discarded unreachable code: IL_00c1, IL_00d0
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (string.Equals(Name, (string)n3JAJEhqj4PiKRpPErHr(other)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			case 3:
				return Dst == KVPR0ihqYuIZrd09v5Px(other);
			default:
				return false;
			case 4:
				if (Offset == other.Offset)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 1:
				if (!mco4DZhq5y8r3v14N7Li(TimeZoneId, byGoUnhqg9HmVtFYvraY(other)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public override bool Equals(object obj)
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (obj == null)
					{
						break;
					}
					if (this == obj)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 1;
						}
						continue;
					}
					if (obj is TimeZoneModel)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return false;
				case 2:
					return false;
				case 1:
					return true;
				default:
					return Equals((TimeZoneModel)obj);
				}
				break;
			}
			num = 2;
		}
	}

	public override int GetHashCode()
	{
		//Discarded unreachable code: IL_002d, IL_003c, IL_0072
		int num = 1;
		int num2 = num;
		int num3;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (TimeZoneId != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			case 2:
				num3 = 0;
				break;
			default:
				num3 = TimeZoneId.GetHashCode();
				break;
			}
			break;
		}
		return (((((num3 * 397) ^ ((Name != null) ? Name.GetHashCode() : 0)) * 397) ^ Offset) * 397) ^ Dst.GetHashCode();
	}

	public static bool operator ==(TimeZoneModel left, TimeZoneModel right)
	{
		return CsI4cqhqLy2vJ6bH2LVm(left, right);
	}

	public static bool operator !=(TimeZoneModel left, TimeZoneModel right)
	{
		return !object.Equals(left, right);
	}

	internal static bool d72pGRhqM0xtkeaAuOwI()
	{
		return (object)jfEcy3hqyZsvoIJ4yimr == null;
	}

	internal static TimeZoneModel ktJ5XThqJFj5wPZcvyBa()
	{
		return jfEcy3hqyZsvoIJ4yimr;
	}

	internal static void ucuuSThq9Hj8xlCR57uA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object kv6PMLhqdHRs6jVJBgdU(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static int ts6rRQhqlk4DAC8Q74O7(int P_0)
	{
		return Math.Abs(P_0);
	}

	internal static object BEh10Bhqr1vcTE04WEQB(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object byGoUnhqg9HmVtFYvraY(object P_0)
	{
		return ((TimeZoneModel)P_0).TimeZoneId;
	}

	internal static bool mco4DZhq5y8r3v14N7Li(object P_0, object P_1)
	{
		return string.Equals((string)P_0, (string)P_1);
	}

	internal static object n3JAJEhqj4PiKRpPErHr(object P_0)
	{
		return ((TimeZoneModel)P_0).Name;
	}

	internal static bool KVPR0ihqYuIZrd09v5Px(object P_0)
	{
		return ((TimeZoneModel)P_0).Dst;
	}

	internal static bool CsI4cqhqLy2vJ6bH2LVm(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}
}
