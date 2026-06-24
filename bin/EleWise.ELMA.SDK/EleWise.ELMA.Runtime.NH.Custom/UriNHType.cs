using System;
using System.Data;
using System.Data.Common;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.Type;
using NHibernate.UserTypes;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

[Serializable]
public class UriNHType : IUserType
{
	public class Convention : AutoRegisterUserTypeConvention<UriNHType>
	{
		private static Convention VPuepxQYMlWtlADQ0X4F;

		public Convention()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			pNxq12QYdEkwNKqbRx0D();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void pNxq12QYdEkwNKqbRx0D()
		{
			SingletonReader.PushGlobal();
		}

		internal static bool iNaR0kQYJT4IBHlrXjfI()
		{
			return VPuepxQYMlWtlADQ0X4F == null;
		}

		internal static Convention NHcyCXQY9H9htIdWSjwv()
		{
			return VPuepxQYMlWtlADQ0X4F;
		}
	}

	private static UriNHType MXaQ6XWm9LVKskj7remg;

	public SqlType[] SqlTypes => (SqlType[])(object)new SqlType[1] { (SqlType)KvCJubWmcQPkThtEmH5T(NHibernateUtil.String) };

	public Type ReturnedType => aRwOV8Wmj8PNsLDNE4Cp(typeof(Uri).TypeHandle);

	public virtual bool IsMutable => true;

	public new virtual bool Equals(object x, object y)
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_00e0, IL_00eb, IL_0106, IL_0115
		int num = 4;
		int num2 = num;
		Uri uri = default(Uri);
		Uri uri2 = default(Uri);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			object obj2;
			object obj;
			switch (num2)
			{
			case 6:
				if (CCJNZAWmryK8Sf2RBcPk(uri, null))
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 7;
			case 8:
				if (CCJNZAWmryK8Sf2RBcPk(uri2, null))
				{
					num2 = 5;
					continue;
				}
				goto case 2;
			case 4:
				uri = x as Uri;
				num2 = 3;
				continue;
			case 11:
				return true;
			default:
				if (text2 != null)
				{
					num2 = 12;
					continue;
				}
				goto case 1;
			case 2:
				obj2 = null;
				break;
			case 7:
				obj = null;
				goto IL_01bd;
			case 14:
				if (text == null)
				{
					num2 = 11;
					continue;
				}
				goto default;
			case 3:
				uri2 = y as Uri;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 6;
				}
				continue;
			case 1:
				return false;
			case 9:
				return text2.Equals(text);
			case 5:
				if (string.IsNullOrEmpty((string)t08Iv6Wm5Hmq8aONDTKe(uri2)))
				{
					num2 = 2;
					continue;
				}
				obj2 = t08Iv6Wm5Hmq8aONDTKe(uri2);
				break;
			case 10:
				if (XpTTO0WmguLsURMTEpMi(uri.OriginalString))
				{
					num2 = 7;
					continue;
				}
				obj = t08Iv6Wm5Hmq8aONDTKe(uri);
				goto IL_01bd;
			case 13:
				if (text2 != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 14;
			case 12:
				{
					if (text != null)
					{
						num2 = 9;
						continue;
					}
					goto case 1;
				}
				IL_01bd:
				text2 = (string)obj;
				num2 = 8;
				continue;
			}
			text = (string)obj2;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
			{
				num2 = 13;
			}
		}
	}

	public virtual int GetHashCode(object x)
	{
		//Discarded unreachable code: IL_0063, IL_00d4, IL_010b
		int num = 4;
		Uri uri = default(Uri);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
					uri = x as Uri;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					return aRwOV8Wmj8PNsLDNE4Cp(typeof(Uri).TypeHandle).GetHashCode() + 473;
				case 5:
					return text.GetHashCode();
				case 2:
					if (XpTTO0WmguLsURMTEpMi(t08Iv6Wm5Hmq8aONDTKe(uri)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = t08Iv6Wm5Hmq8aONDTKe(uri);
					break;
				case 7:
					if (text != null)
					{
						goto end_IL_0012;
					}
					goto case 6;
				case 3:
					if (!CCJNZAWmryK8Sf2RBcPk(uri, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				default:
					obj = null;
					break;
				}
				text = (string)obj;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 7;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public object NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
	{
		//Discarded unreachable code: IL_0052
		int num = 2;
		int num2 = num;
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				return null;
			default:
				return CreateUri(Convert.ToString(obj));
			case 2:
				obj = xcyskSWmYtvRbOCfAAVK(NHibernateUtil.String, rs, names[0], session);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_00e3, IL_00f2, IL_0102
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 8:
				o7fUpLWmsjs2X78xlkIA(((DbParameterCollection)kTuS7sWmLARvOvQgppyQ(cmd))[index], t08Iv6Wm5Hmq8aONDTKe((Uri)value));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				return;
			case 7:
				return;
			case 5:
				o7fUpLWmsjs2X78xlkIA(ns933TWmUdEXIBP2P9yX(kTuS7sWmLARvOvQgppyQ(cmd), index), DBNull.Value);
				num2 = 4;
				break;
			case 2:
				if (value != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 1:
				if (value is Uri)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto default;
			case 3:
				o7fUpLWmsjs2X78xlkIA(ns933TWmUdEXIBP2P9yX(kTuS7sWmLARvOvQgppyQ(cmd), index), value);
				num2 = 7;
				break;
			default:
				if (!(value is string))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public virtual object DeepCopy(object value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				if (value is Uri)
				{
					return CloneUri((Uri)value);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual object Replace(object original, object target, object owner)
	{
		//Discarded unreachable code: IL_0061, IL_0070
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (original is Uri)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return null;
			default:
				return CloneUri((Uri)original);
			}
		}
	}

	public virtual object Assemble(object cached, object owner)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				if (cached is Uri)
				{
					return CloneUri((Uri)cached);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual object Disassemble(object value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!(value is Uri))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return CloneUri((Uri)value);
			default:
				return null;
			}
		}
	}

	private Uri CloneUri(Uri obj)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (CCJNZAWmryK8Sf2RBcPk(obj, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return null;
			case 1:
				return CreateUri(obj.OriginalString, forceCreate: true);
			}
		}
	}

	private Uri CreateUri(string url, bool forceCreate = false)
	{
		//Discarded unreachable code: IL_006f, IL_007e
		int num = 3;
		int num2 = num;
		string text;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!XpTTO0WmguLsURMTEpMi(url) || forceCreate)
				{
					num2 = 2;
					continue;
				}
				goto case 1;
			case 1:
				return null;
			case 2:
				text = url;
				if (text == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				text = string.Empty;
				break;
			}
			break;
		}
		return new Uri(text, UriKind.RelativeOrAbsolute);
	}

	public UriNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TjuCQVWmzNiIC9FjEQuj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool CCJNZAWmryK8Sf2RBcPk(object P_0, object P_1)
	{
		return (Uri)P_0 != (Uri)P_1;
	}

	internal static bool XpTTO0WmguLsURMTEpMi(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object t08Iv6Wm5Hmq8aONDTKe(object P_0)
	{
		return ((Uri)P_0).OriginalString;
	}

	internal static bool uj6BkjWmdOi2sgLRauUD()
	{
		return MXaQ6XWm9LVKskj7remg == null;
	}

	internal static UriNHType ebN0YbWmln6bRJcS6fLT()
	{
		return MXaQ6XWm9LVKskj7remg;
	}

	internal static Type aRwOV8Wmj8PNsLDNE4Cp(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object xcyskSWmYtvRbOCfAAVK(object P_0, object P_1, object P_2, object P_3)
	{
		return ((NullableType)P_0).NullSafeGet((DbDataReader)P_1, (string)P_2, (ISessionImplementor)P_3);
	}

	internal static object kTuS7sWmLARvOvQgppyQ(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static object ns933TWmUdEXIBP2P9yX(object P_0, int P_1)
	{
		return ((DbParameterCollection)P_0)[P_1];
	}

	internal static void o7fUpLWmsjs2X78xlkIA(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static object KvCJubWmcQPkThtEmH5T(object P_0)
	{
		return ((NullableType)P_0).get_SqlType();
	}

	internal static void TjuCQVWmzNiIC9FjEQuj()
	{
		SingletonReader.PushGlobal();
	}
}
