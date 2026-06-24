using System;
using System.Data;
using System.Data.Common;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.Type;
using NHibernate.UserTypes;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

[Serializable]
public class EnumNHType<TEnum> : IUserType where TEnum : EnumBase
{
	private static object k79walW0LjNnUpX2rd8L;

	public SqlType[] SqlTypes => (SqlType[])(object)new SqlType[1] { ((NullableType)NHibernateUtil.Guid).get_SqlType() };

	public Type ReturnedType => typeof(TEnum);

	public virtual bool IsMutable => false;

	public new virtual bool Equals(object x, object y)
	{
		//Discarded unreachable code: IL_00e7, IL_00f6, IL_0105, IL_0115, IL_0179, IL_0188
		int num = 4;
		int num2 = num;
		TEnum val2 = default(TEnum);
		TEnum val = default(TEnum);
		while (true)
		{
			switch (num2)
			{
			case 10:
				if (!((EnumBase)val2 == (EnumBase)null))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 5;
			case 1:
				if (!((EnumBase)val == (EnumBase)null))
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 10;
			case 6:
			case 8:
				return false;
			default:
				return val.Equals(val2);
			case 2:
				if (!((EnumBase)val2 == (EnumBase)null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 5:
				return true;
			case 7:
			case 9:
				if ((EnumBase)val == (EnumBase)null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 2;
			case 3:
				val2 = y as TEnum;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				val = x as TEnum;
				num2 = 3;
				break;
			}
		}
	}

	public virtual int GetHashCode(object x)
	{
		//Discarded unreachable code: IL_006a, IL_0079
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return typeof(TEnum).GetHashCode() + 473;
			default:
				return x.GetHashCode();
			case 1:
				if (x != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public object NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
	{
		//Discarded unreachable code: IL_0047
		int num = 2;
		int num2 = num;
		Guid uid = default(Guid);
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return ModelHelper.GetEnumValue(typeof(TEnum), uid);
			case 2:
				obj = ((NullableType)NHibernateUtil.Guid).NullSafeGet(rs, names[0], session);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return null;
			case 4:
				uid = (Guid)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (obj != null)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			}
		}
	}

	public void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_006b, IL_0137
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 7:
				return;
			case 1:
				if (!(value is Guid))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				if (value == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 8;
			case 3:
				return;
			default:
				((IDataParameter)cmd.Parameters[index]).Value = DBNull.Value;
				num2 = 6;
				continue;
			case 5:
				((IDataParameter)cmd.Parameters[index]).Value = ((TEnum)value).Value;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 7;
				}
				continue;
			case 6:
				return;
			case 8:
				if (value is TEnum)
				{
					num2 = 5;
					continue;
				}
				goto case 1;
			case 4:
				break;
			}
			((IDataParameter)cmd.Parameters[index]).Value = (Guid)value;
			num2 = 3;
		}
	}

	public virtual object DeepCopy(object value)
	{
		return value;
	}

	public virtual object Replace(object original, object target, object owner)
	{
		return original;
	}

	public virtual object Assemble(object cached, object owner)
	{
		return cached;
	}

	public virtual object Disassemble(object value)
	{
		return value;
	}

	public EnumNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool EGkeQhW0U5GvoPNscvGi()
	{
		return k79walW0LjNnUpX2rd8L == null;
	}

	internal static object n6HgUsW0skaM6XgERID3()
	{
		return k79walW0LjNnUpX2rd8L;
	}
}
