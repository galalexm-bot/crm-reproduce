using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Validation;

public class StringRangeLengthAttribute : ValidationAttribute
{
	internal static StringRangeLengthAttribute hmeJlio5Xu76t2AoMuuN;

	public int MinValue
	{
		[CompilerGenerated]
		get
		{
			return _003CMinValue_003Ek__BackingField;
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
					_003CMinValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string MaxValue
	{
		[CompilerGenerated]
		get
		{
			return _003CMaxValue_003Ek__BackingField;
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
					_003CMaxValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public StringRangeLengthAttribute(int minValue, string maxValue)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_004e, IL_005d
		AqMnh2o5nLKKKvvHCPsK();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 6:
				MaxValue = maxValue;
				num = 4;
				continue;
			case 3:
				if (string.IsNullOrEmpty(maxValue))
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num = 0;
					}
					continue;
				}
				goto case 5;
			case 5:
			{
				if (int.TryParse(maxValue, out var _))
				{
					num = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num = 5;
					}
					continue;
				}
				break;
			}
			case 2:
				MinValue = minValue;
				num = 3;
				continue;
			case 1:
			case 4:
				break;
			}
			svxdVgo5PllMI02j0ta6(this, (!string.IsNullOrEmpty(MaxValue)) ? t323lao5efDCF8GOXEAD(fbMdAVo52tUAapbrEYeU(HiL2Uko5O3MhBLVniTDm(-978351861 ^ -978342383)), MinValue, MaxValue) : string.Format((string)fbMdAVo52tUAapbrEYeU(HiL2Uko5O3MhBLVniTDm(-1852837372 ^ -1852844590)), MinValue));
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
			{
				num = 0;
			}
		}
	}

	public StringRangeLengthAttribute(int minValue, string maxValue, string message)
	{
		//Discarded unreachable code: IL_002a, IL_00be, IL_0150
		AqMnh2o5nLKKKvvHCPsK();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
		{
			num = 1;
		}
		while (true)
		{
			object obj;
			switch (num)
			{
			case 6:
				if (HrKHuJo51IYlhBOMrfJJ(MaxValue))
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num = 0;
					}
					continue;
				}
				obj = t323lao5efDCF8GOXEAD(fbMdAVo52tUAapbrEYeU(HiL2Uko5O3MhBLVniTDm(-309639236 ^ -309632858)), MinValue, MaxValue);
				break;
			case 5:
				if (!HrKHuJo51IYlhBOMrfJJ(message))
				{
					int num2 = 4;
					num = num2;
					continue;
				}
				goto case 6;
			case 4:
			case 8:
				svxdVgo5PllMI02j0ta6(this, message);
				num = 9;
				continue;
			case 3:
				if (!HrKHuJo51IYlhBOMrfJJ(maxValue))
				{
					num = 2;
					continue;
				}
				goto case 5;
			case 9:
				return;
			case 1:
				MinValue = minValue;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num = 3;
				}
				continue;
			case 2:
			{
				if (int.TryParse(maxValue, out var _))
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num = 7;
					}
					continue;
				}
				goto case 5;
			}
			default:
				obj = MyxaSdo5NFd0cyhLR3KG(fbMdAVo52tUAapbrEYeU(HiL2Uko5O3MhBLVniTDm(-1876063057 ^ -1876055175)), MinValue);
				break;
			case 7:
				MaxValue = maxValue;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num = 5;
				}
				continue;
			}
			message = (string)obj;
			num = 8;
		}
	}

	public override bool IsValid(object value)
	{
		//Discarded unreachable code: IL_0052, IL_00d9
		int num = 4;
		int num2 = num;
		bool flag = default(bool);
		string text = default(string);
		int result = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!flag)
				{
					num2 = 7;
					break;
				}
				goto case 5;
			case 6:
				if (zGk6vdo53YMIHn7fQplX(text) >= MinValue)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return false;
			case 5:
				return zGk6vdo53YMIHn7fQplX(text) <= result;
			case 7:
				return true;
			default:
				flag = int.TryParse(MaxValue, out result);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				if (value != null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 2:
				return true;
			case 3:
				text = (string)value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool zqDaA1o5TdgkRbuwhxBX()
	{
		return hmeJlio5Xu76t2AoMuuN == null;
	}

	internal static StringRangeLengthAttribute YwY4gyo5kcC1woYoDnBT()
	{
		return hmeJlio5Xu76t2AoMuuN;
	}

	internal static void AqMnh2o5nLKKKvvHCPsK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object HiL2Uko5O3MhBLVniTDm(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object fbMdAVo52tUAapbrEYeU(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object t323lao5efDCF8GOXEAD(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void svxdVgo5PllMI02j0ta6(object P_0, object P_1)
	{
		((ValidationAttribute)P_0).ErrorMessage = (string)P_1;
	}

	internal static bool HrKHuJo51IYlhBOMrfJJ(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object MyxaSdo5NFd0cyhLR3KG(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static int zGk6vdo53YMIHn7fQplX(object P_0)
	{
		return ((string)P_0).Length;
	}
}
