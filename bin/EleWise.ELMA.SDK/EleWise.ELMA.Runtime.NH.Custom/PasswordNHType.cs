using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using EleWise.ELMA.Common.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Type;
using NHibernate.UserTypes;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

[Serializable]
public class PasswordNHType : ICompositeUserType
{
	internal static string HashColumn;

	internal static string SaltColumn;

	internal static PasswordNHType AomFKAWx0k8QfhdlO8U0;

	public bool IsMutable => true;

	public string[] PropertyNames => new string[2] { HashColumn, SaltColumn };

	public IType[] PropertyTypes => (IType[])(object)new IType[2]
	{
		(IType)NHibernateUtil.String,
		(IType)NHibernateUtil.String
	};

	public Type ReturnedClass => b6ve8sWxdgdZBPxHycUB(typeof(PasswordInfo).TypeHandle);

	internal static string GenerateHashName(string propertyName)
	{
		return (string)wLxn9HWxMTFHtYC8dkIf(propertyName, HashColumn);
	}

	internal static string GenerateSaltName(string propertyName)
	{
		return propertyName + SaltColumn;
	}

	public object DeepCopy(object value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (value == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return tRPIudWx9EILMGjIQe1S(hpfi6kWxJP24vRQCxSC2(value));
			default:
				return null;
			}
		}
	}

	public object Assemble(object cached, ISessionImplementor session, object owner)
	{
		return DeepCopy(cached);
	}

	public object Disassemble(object value, ISessionImplementor session)
	{
		return DeepCopy(value);
	}

	public new bool Equals(object x, object y)
	{
		//Discarded unreachable code: IL_0071, IL_0080
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return true;
			default:
				if (y == null)
				{
					num2 = 4;
					break;
				}
				return x.Equals(y);
			case 1:
			case 4:
				return false;
			case 3:
				if (x != y)
				{
					if (x == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public int GetHashCode(object x)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return x.GetHashCode();
			case 1:
				if (x == null)
				{
					return b6ve8sWxdgdZBPxHycUB(typeof(PasswordInfo).TypeHandle).GetHashCode() + 327;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public object NullSafeGet(DbDataReader dr, string[] names, ISessionImplementor session, object owner)
	{
		//Discarded unreachable code: IL_0039, IL_0048
		int num = 1;
		int num2 = num;
		object obj2 = default(object);
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				obj2 = o1n9gDWxlocUCKso5jcc(NHibernateUtil.String, dr, names[1], session);
				num2 = 3;
				break;
			case 3:
				if (obj != null)
				{
					num2 = 4;
					break;
				}
				goto case 5;
			case 2:
				return new PasswordInfo((string)R42xhIWxrcEoHucOHhYi(obj), Convert.ToString(obj2), Guid.Empty);
			case 5:
				return null;
			case 4:
				if (obj2 == null)
				{
					num2 = 5;
					break;
				}
				goto case 2;
			case 1:
				obj = o1n9gDWxlocUCKso5jcc(NHibernateUtil.String, dr, names[0], session);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void NullSafeSet(IDbCommand cmd, object value, int index, ISessionImplementor session)
	{
		int num = 1;
		PasswordInfo passwordInfo = default(PasswordInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					zikrpBWx5YlJ5O7iBH7f((IDataParameter)((IList)lijaS7WxgLqfGFE4o8rK(cmd))[index], DBNull.Value);
					num2 = 3;
					continue;
				case 6:
					return;
				case 5:
					return;
				case 3:
					((IDataParameter)cmd.Parameters[index + 1]).Value = DBNull.Value;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 6;
					}
					continue;
				default:
					if (passwordInfo != null)
					{
						zikrpBWx5YlJ5O7iBH7f((IDataParameter)((IList)lijaS7WxgLqfGFE4o8rK(cmd))[index], WVEho9WxjA1LkD5NngrN(passwordInfo));
						num2 = 4;
						continue;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					break;
				case 1:
					passwordInfo = (PasswordInfo)hpfi6kWxJP24vRQCxSC2(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			zikrpBWx5YlJ5O7iBH7f((IDataParameter)DXLCSjWxYUdhCXLNaH2t(lijaS7WxgLqfGFE4o8rK(cmd), index + 1), passwordInfo.Salt);
			num = 5;
		}
	}

	public void NullSafeSet(DbCommand cmd, object value, int index, bool[] settable, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_0101, IL_0110
		int num = 2;
		int num2 = num;
		PasswordInfo passwordInfo = default(PasswordInfo);
		while (true)
		{
			switch (num2)
			{
			case 4:
				((IDataParameter)((DbParameterCollection)VKNMqJWxLN4QwheC9vel(cmd))[index + 1]).Value = passwordInfo.Salt;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 9;
				}
				break;
			case 2:
				passwordInfo = (PasswordInfo)hpfi6kWxJP24vRQCxSC2(value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (!settable[1])
				{
					num2 = 8;
					break;
				}
				goto case 4;
			case 1:
				if (passwordInfo == null)
				{
					num2 = 7;
					break;
				}
				if (settable[0])
				{
					num2 = 6;
					break;
				}
				goto case 3;
			case 11:
				((IDataParameter)qowtRRWxUXRTkhsLT1LX(VKNMqJWxLN4QwheC9vel(cmd), index + 1)).Value = DBNull.Value;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 4;
				}
				break;
			case 10:
				return;
			case 8:
				return;
			case 5:
				return;
			case 12:
				if (!settable[1])
				{
					num2 = 10;
					break;
				}
				goto case 11;
			case 7:
				if (settable[0])
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 12;
			case 6:
				zikrpBWx5YlJ5O7iBH7f(((DbParameterCollection)VKNMqJWxLN4QwheC9vel(cmd))[index], WVEho9WxjA1LkD5NngrN(passwordInfo));
				num2 = 3;
				break;
			case 9:
				return;
			default:
				zikrpBWx5YlJ5O7iBH7f(qowtRRWxUXRTkhsLT1LX(VKNMqJWxLN4QwheC9vel(cmd), index), DBNull.Value);
				num2 = 12;
				break;
			}
		}
	}

	public object Replace(object original, object target, ISessionImplementor session, object owner)
	{
		return DeepCopy(original);
	}

	public object GetPropertyValue(object component, int property)
	{
		//Discarded unreachable code: IL_005b, IL_006a, IL_007a, IL_0089
		int num = 1;
		int num2 = num;
		PasswordInfo passwordInfo = default(PasswordInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				passwordInfo = (PasswordInfo)hpfi6kWxJP24vRQCxSC2(component);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (property == 0)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 5:
				if (property != 1)
				{
					num2 = 4;
					break;
				}
				return RI2YGlWxsCiwCZE4N1EY(passwordInfo);
			case 2:
			case 3:
				return WVEho9WxjA1LkD5NngrN(passwordInfo);
			case 4:
				throw new Exception((string)yFRSY0WxzqMZneE5CVvU(A8cfCUWxclknv3E51tae(0x4EA5403C ^ 0x4EA769B4), property));
			}
		}
	}

	public void SetPropertyValue(object component, int property, object value)
	{
		//Discarded unreachable code: IL_00d6, IL_00e5, IL_0115
		int num = 4;
		int num2 = num;
		PasswordInfo passwordInfo = default(PasswordInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 8:
				throw new Exception((string)yFRSY0WxzqMZneE5CVvU(A8cfCUWxclknv3E51tae(-1858887263 ^ -1859024855), property));
			case 6:
				passwordInfo.Hash = (string)R42xhIWxrcEoHucOHhYi(value);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				throw new ArgumentNullException((string)A8cfCUWxclknv3E51tae(0x61EC0CB8 ^ 0x61EE2550));
			case 3:
				passwordInfo = (PasswordInfo)hpfi6kWxJP24vRQCxSC2(component);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (property != 0)
				{
					num2 = 7;
					break;
				}
				goto case 6;
			case 4:
				if (component != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			case 7:
				if (property != 1)
				{
					num2 = 8;
					break;
				}
				mjdRgHW0FVQxnwJVcCCn(passwordInfo, R42xhIWxrcEoHucOHhYi(value));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				return;
			}
		}
	}

	private static PasswordInfo AsPasswordInfo(object value)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (value != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return null;
			default:
				return (value as PasswordInfo) ?? throw new InvalidCastException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE100031), b6ve8sWxdgdZBPxHycUB(typeof(PasswordInfo).TypeHandle), value.GetType()));
			}
		}
	}

	public PasswordNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		WGkXB4W0BnKbaNtCulEl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PasswordNHType()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				HashColumn = (string)A8cfCUWxclknv3E51tae(0x31326106 ^ 0x31304B40);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				SaltColumn = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675367949);
				num2 = 3;
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object wLxn9HWxMTFHtYC8dkIf(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool Row85sWxmWBETuBWULrk()
	{
		return AomFKAWx0k8QfhdlO8U0 == null;
	}

	internal static PasswordNHType zv0LI6WxyZi1xnvLbsiY()
	{
		return AomFKAWx0k8QfhdlO8U0;
	}

	internal static object hpfi6kWxJP24vRQCxSC2(object P_0)
	{
		return AsPasswordInfo(P_0);
	}

	internal static object tRPIudWx9EILMGjIQe1S(object P_0)
	{
		return ((PasswordInfo)P_0).Clone();
	}

	internal static Type b6ve8sWxdgdZBPxHycUB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object o1n9gDWxlocUCKso5jcc(object P_0, object P_1, object P_2, object P_3)
	{
		return ((NullableType)P_0).NullSafeGet((DbDataReader)P_1, (string)P_2, (ISessionImplementor)P_3);
	}

	internal static object R42xhIWxrcEoHucOHhYi(object P_0)
	{
		return Convert.ToString(P_0);
	}

	internal static object lijaS7WxgLqfGFE4o8rK(object P_0)
	{
		return ((IDbCommand)P_0).Parameters;
	}

	internal static void zikrpBWx5YlJ5O7iBH7f(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static object WVEho9WxjA1LkD5NngrN(object P_0)
	{
		return ((PasswordInfo)P_0).Hash;
	}

	internal static object DXLCSjWxYUdhCXLNaH2t(object P_0, int P_1)
	{
		return ((IList)P_0)[P_1];
	}

	internal static object VKNMqJWxLN4QwheC9vel(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static object qowtRRWxUXRTkhsLT1LX(object P_0, int P_1)
	{
		return ((DbParameterCollection)P_0)[P_1];
	}

	internal static object RI2YGlWxsCiwCZE4N1EY(object P_0)
	{
		return ((PasswordInfo)P_0).Salt;
	}

	internal static object A8cfCUWxclknv3E51tae(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object yFRSY0WxzqMZneE5CVvU(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void mjdRgHW0FVQxnwJVcCCn(object P_0, object P_1)
	{
		((PasswordInfo)P_0).Salt = (string)P_1;
	}

	internal static void WGkXB4W0BnKbaNtCulEl()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
