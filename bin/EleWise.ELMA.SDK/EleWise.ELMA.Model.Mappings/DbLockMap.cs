using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Mappings;

internal sealed class DbLockMap : ClassMapping<DbLock>
{
	internal static DbLockMap ocqJJjhbGded5QAkNiXx;

	public DbLockMap()
	{
		//Discarded unreachable code: IL_001e
		LSgk6KhbQmUfeWyp1wIa();
		base._002Ector();
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			default:
			{
				ParameterExpression parameterExpression = (ParameterExpression)O8uw0ShbZbr7u8BpMV5H(hJjnwJhb8j4E6K1bmjGx(typeof(DbLock).TypeHandle), TDvwSXhbC9N18tT2QyEL(-1217523399 ^ -1217471519));
				((PropertyContainerCustomizer<DbLock>)(object)this).Property<Guid>(Expression.Lambda<Func<DbLock, Guid>>((Expression)DZR679hbIKYf7cFbR28w(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 3;
				}
				break;
			}
			case 2:
				((ClassCustomizer<DbLock>)(object)this).Lazy(false);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 6;
				}
				break;
			case 3:
				yGjROJhbvC72cxua84xt(this, TDvwSXhbC9N18tT2QyEL(-1633514411 ^ -1633477781));
				num2 = 2;
				break;
			case 6:
			{
				ParameterExpression parameterExpression = (ParameterExpression)O8uw0ShbZbr7u8BpMV5H(hJjnwJhb8j4E6K1bmjGx(typeof(DbLock).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889550686));
				((ClassCustomizer<DbLock>)(object)this).Id<string>(Expression.Lambda<Func<DbLock, string>>((Expression)DZR679hbIKYf7cFbR28w(parameterExpression, (MethodInfo)E0g6Ebhbu4KEpXJo7xc3((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(Entity<string>).TypeHandle)), new ParameterExpression[1] { parameterExpression }), (Action<IIdMapper>)delegate(IIdMapper i)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							_003C_003Ec.w4wkN9ClwpyhYOoZfgoM(i, _003C_003Ec.Ag4mPRCltLheGeC6MK3h());
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				});
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 7;
				}
				break;
			}
			case 7:
			{
				ParameterExpression parameterExpression = (ParameterExpression)O8uw0ShbZbr7u8BpMV5H(hJjnwJhb8j4E6K1bmjGx(typeof(DbLock).TypeHandle), TDvwSXhbC9N18tT2QyEL(0x17ADCCD8 ^ 0x17AD0600));
				((PropertyContainerCustomizer<DbLock>)(object)this).Property<string>(Expression.Lambda<Func<DbLock, string>>(Expression.Property(parameterExpression, (MethodInfo)FmmM34hbVikmvvjrGDCc((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num5 = 1;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						default:
							return;
						case 1:
							_003C_003Ec.QckoAjCl4IS1jfuQsXSa(p, int.MaxValue);
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num6 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 1;
				}
				break;
			}
			case 1:
			{
				ParameterExpression parameterExpression = (ParameterExpression)O8uw0ShbZbr7u8BpMV5H(hJjnwJhb8j4E6K1bmjGx(typeof(DbLock).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767738589));
				((PropertyContainerCustomizer<DbLock>)(object)this).Property<DateTime?>(Expression.Lambda<Func<DbLock, DateTime?>>(Expression.Property(parameterExpression, (MethodInfo)FmmM34hbVikmvvjrGDCc((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					p.Type<DateTimeWithoutOffsetNHType>();
				});
				num2 = 4;
				break;
			}
			case 4:
			{
				ParameterExpression parameterExpression = (ParameterExpression)O8uw0ShbZbr7u8BpMV5H(hJjnwJhb8j4E6K1bmjGx(typeof(DbLock).TypeHandle), TDvwSXhbC9N18tT2QyEL(--1360331293 ^ 0x5115C8C5));
				((PropertyContainerCustomizer<DbLock>)(object)this).Property<DateTime?>(Expression.Lambda<Func<DbLock, DateTime?>>((Expression)DZR679hbIKYf7cFbR28w(parameterExpression, (MethodInfo)FmmM34hbVikmvvjrGDCc((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					p.Type<DateTimeWithoutOffsetNHType>();
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	internal static void LSgk6KhbQmUfeWyp1wIa()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object TDvwSXhbC9N18tT2QyEL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void yGjROJhbvC72cxua84xt(object P_0, object P_1)
	{
		((ClassCustomizer<DbLock>)P_0).Table((string)P_1);
	}

	internal static Type hJjnwJhb8j4E6K1bmjGx(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object O8uw0ShbZbr7u8BpMV5H(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object E0g6Ebhbu4KEpXJo7xc3(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
	{
		return MethodBase.GetMethodFromHandle(P_0, P_1);
	}

	internal static object DZR679hbIKYf7cFbR28w(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object FmmM34hbVikmvvjrGDCc(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static bool rsFyCjhbEBpg9lxGVcpP()
	{
		return ocqJJjhbGded5QAkNiXx == null;
	}

	internal static DbLockMap lElT2Dhbfvr4gCcOk7Jy()
	{
		return ocqJJjhbGded5QAkNiXx;
	}
}
