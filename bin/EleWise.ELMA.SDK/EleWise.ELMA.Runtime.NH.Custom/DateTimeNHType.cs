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
public class DateTimeNHType : IUserType
{
	public class Convention : AutoRegisterUserTypeConvention<DateTimeNHType>
	{
		internal static Convention f1U2PJQYSOgHMW6QMCK3;

		public Convention()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			g7sSMBQYqTxAZiPuBoqr();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void g7sSMBQYqTxAZiPuBoqr()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool aX5YY4QYi36se9hJoUGv()
		{
			return f1U2PJQYSOgHMW6QMCK3 == null;
		}

		internal static Convention NQ5FE5QYRCccfEcEsXCq()
		{
			return f1U2PJQYSOgHMW6QMCK3;
		}
	}

	private static DateTimeNHType UyPlMxW0QdtRwHtxEUaG;

	public SqlType[] SqlTypes => (SqlType[])(object)new SqlType[1] { (SqlType)ywulcoW0RCuFbML4PCda(NHibernateUtil.DateTime) };

	public Type ReturnedType => vIvoHkW0qvDKUg4WBGo1(typeof(DateTime).TypeHandle);

	public bool IsMutable => false;

	public new bool Equals(object x, object y)
	{
		return M5RFiKW08EpWCKNHuPmE(NHibernateUtil.DateTime, x, y);
	}

	public int GetHashCode(object x)
	{
		return GUiw18W0ZjKFE9FW6uYi(NHibernateUtil.DateTime, x);
	}

	public virtual object NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
	{
		int num = 2;
		int num2 = num;
		DateTime? dateTime = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			default:
				return DXgiYeW0IHagdQpoxCQZ(dateTime.Value);
			case 1:
				if (!dateTime.HasValue)
				{
					return KWAPB6W0uJy12Rd1Kwxf(NHibernateUtil.DateTime, rs, names[0], session);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				dateTime = KWAPB6W0uJy12Rd1Kwxf(NHibernateUtil.DateTime, rs, names[0], session) as DateTime?;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public virtual void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
	{
		int num = 1;
		int num2 = num;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (value == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				}
				dateTime = (DateTime)value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				return;
			case 3:
				return;
			default:
				xxXQgyW0iuYomA9BV56F(LFDXNkW0SY9yoHqwINfg(XvGqgCW0VNwaUmtlcQee(cmd), index), DBNull.Value);
				num2 = 3;
				break;
			case 2:
				xxXQgyW0iuYomA9BV56F(LFDXNkW0SY9yoHqwINfg(cmd.Parameters, index), (dateTime != default(DateTime)) ? ((object)dateTime.ToServerDateTime()) : DBNull.Value);
				num2 = 4;
				break;
			}
		}
	}

	public object DeepCopy(object value)
	{
		return value;
	}

	public object Replace(object original, object target, object owner)
	{
		return original;
	}

	public virtual object Assemble(object cached, object owner)
	{
		return cached;
	}

	public object Disassemble(object value)
	{
		return value;
	}

	public DateTimeNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		J9WxScW0K3H3lBqXncCo();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool M5RFiKW08EpWCKNHuPmE(object P_0, object P_1, object P_2)
	{
		return ((AbstractType)P_0).IsEqual(P_1, P_2);
	}

	internal static bool rSDk1VW0CynC6BQ9qHXr()
	{
		return UyPlMxW0QdtRwHtxEUaG == null;
	}

	internal static DateTimeNHType rnt704W0vZoUQs5HFccN()
	{
		return UyPlMxW0QdtRwHtxEUaG;
	}

	internal static int GUiw18W0ZjKFE9FW6uYi(object P_0, object P_1)
	{
		return ((AbstractType)P_0).GetHashCode(P_1);
	}

	internal static object KWAPB6W0uJy12Rd1Kwxf(object P_0, object P_1, object P_2, object P_3)
	{
		return ((NullableType)P_0).NullSafeGet((DbDataReader)P_1, (string)P_2, (ISessionImplementor)P_3);
	}

	internal static DateTime DXgiYeW0IHagdQpoxCQZ(DateTime serverDateTime)
	{
		return serverDateTime.ToRuntimeDateTimeFromServer();
	}

	internal static object XvGqgCW0VNwaUmtlcQee(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static object LFDXNkW0SY9yoHqwINfg(object P_0, int P_1)
	{
		return ((DbParameterCollection)P_0)[P_1];
	}

	internal static void xxXQgyW0iuYomA9BV56F(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static object ywulcoW0RCuFbML4PCda(object P_0)
	{
		return ((NullableType)P_0).get_SqlType();
	}

	internal static Type vIvoHkW0qvDKUg4WBGo1(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void J9WxScW0K3H3lBqXncCo()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
