using System;
using System.Data;
using System.Data.Common;
using System.Web;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.Type;
using NHibernate.UserTypes;

namespace EleWise.ELMA.HtmlStrings;

[Serializable]
public class HtmlStringType : IUserType
{
	private StringSqlType _sqlType;

	private static HtmlStringType pNHU7V8Su105iJacA4J;

	Type ReturnedType => typeof(HtmlString);

	bool IsMutable => true;

	SqlType[] SqlTypes
	{
		get
		{
			int num = 1;
			int num2 = num;
			SqlType[] result = default(SqlType[]);
			while (true)
			{
				switch (num2)
				{
				default:
					return result;
				case 1:
					result = (SqlType[])(object)new StringSqlType[1] { _sqlType };
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public HtmlStringType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		gHpxat8qgbR4EyZNJsQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				_sqlType = (StringSqlType)new StringClobSqlType();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	bool IUserType.Equals(object x, object y)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (!(y is HtmlString))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				HtmlString obj = (HtmlString)x;
				HtmlString htmlString = (HtmlString)y;
				return Lo66cr8X0TOiLwMKT05(qQIyw48Ky6RkhrmYx2O(obj), htmlString.ToHtmlString());
			}
			case 2:
				if (y == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto IL_0087;
			case 3:
				if (x == null)
				{
					num2 = 2;
					continue;
				}
				goto IL_0087;
			default:
				return true;
			case 4:
				break;
				IL_0087:
				if (x is HtmlString)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			break;
		}
		return false;
	}

	int IUserType.GetHashCode(object x)
	{
		//Discarded unreachable code: IL_0065, IL_0074
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return 0;
			case 1:
				return ((HtmlString)x).ToHtmlString().GetHashCode();
			case 2:
				if (x is HtmlString)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	object IUserType.NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
	{
		int num = 1;
		int num2 = num;
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return FromStringValue((string)obj);
			case 1:
				obj = ((NullableType)NHibernateUtil.StringClob).NullSafeGet(rs, names[0], session);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	void IUserType.NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = ToString(value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				lQLt7Q8n53FEI45FKgF(f9V2OJ8kHPXYjviaIaK(rAd3318TioZSAVmDQIE(cmd), index), (text != null) ? ((IConvertible)text) : ((IConvertible)DBNull.Value));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	object IUserType.DeepCopy(object value)
	{
		//Discarded unreachable code: IL_0075
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				text = ToString(value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (text != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				return null;
			default:
				return new HtmlString(text);
			}
		}
	}

	object IUserType.Replace(object original, object target, object owner)
	{
		//Discarded unreachable code: IL_006f, IL_007e
		int num = 3;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (text != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				text = ToString(original);
				num2 = 2;
				break;
			default:
				return null;
			case 1:
				return new HtmlString(text);
			}
		}
	}

	object IUserType.Assemble(object cached, object owner)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_00ce, IL_00dd
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return null;
			case 2:
				if (!xtMUAd82dLuNwIC1oRi(cached.GetType(), m8e5wK8O1ceMVOl4WSA(typeof(string).TypeHandle)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 1;
			case 1:
				return new HtmlString((string)cached);
			case 3:
				if (cached != null)
				{
					num2 = 2;
					continue;
				}
				goto case 4;
			case 5:
				return (HtmlString)cached;
			}
			if (xtMUAd82dLuNwIC1oRi(cached.GetType(), m8e5wK8O1ceMVOl4WSA(typeof(HtmlString).TypeHandle)))
			{
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 2;
				}
				continue;
			}
			return null;
		}
	}

	object IUserType.Disassemble(object value)
	{
		int num = 1;
		int num2 = num;
		HtmlString htmlString = default(HtmlString);
		while (true)
		{
			switch (num2)
			{
			case 1:
				htmlString = value as HtmlString;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return null;
			}
			if (htmlString == null)
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			return qQIyw48Ky6RkhrmYx2O(htmlString);
		}
	}

	private string ToString(object val)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return val.ToString();
			case 1:
				if (val == null)
				{
					return null;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private object FromStringValue(string xml)
	{
		//Discarded unreachable code: IL_0056, IL_0065
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (xml != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return null;
			case 1:
				return new HtmlString(xml);
			}
		}
	}

	internal static void gHpxat8qgbR4EyZNJsQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool lD4j3O8ilxgMsMbomLQ()
	{
		return pNHU7V8Su105iJacA4J == null;
	}

	internal static HtmlStringType rv6oya8R19XuNeaHFMX()
	{
		return pNHU7V8Su105iJacA4J;
	}

	internal static object qQIyw48Ky6RkhrmYx2O(object P_0)
	{
		return ((HtmlString)P_0).ToHtmlString();
	}

	internal static bool Lo66cr8X0TOiLwMKT05(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object rAd3318TioZSAVmDQIE(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static object f9V2OJ8kHPXYjviaIaK(object P_0, int P_1)
	{
		return ((DbParameterCollection)P_0)[P_1];
	}

	internal static void lQLt7Q8n53FEI45FKgF(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static Type m8e5wK8O1ceMVOl4WSA(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool xtMUAd82dLuNwIC1oRi(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}
}
