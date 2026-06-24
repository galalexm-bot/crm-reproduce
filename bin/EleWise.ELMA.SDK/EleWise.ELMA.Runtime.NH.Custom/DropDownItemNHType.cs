using System;
using System.Data;
using System.Data.Common;
using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.Type;
using NHibernate.UserTypes;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

[Serializable]
public class DropDownItemNHType : AbstractStringType, IUserType
{
	private static DropDownItemNHType mCMWL8WyFPWayUFpPvCJ;

	public override Type ReturnedClass => XYu32gWybdc6kUAdtb5n(typeof(DropDownItem).TypeHandle);

	public override string Name => (string)c1CNinWyhYLQ3TeMGQEi(-1824388195 ^ -1824512109);

	SqlType[] SqlTypes => (SqlType[])(object)new SqlType[1] { (SqlType)e2Zmp0Wy8LVksvJwF72r(this) };

	Type ReturnedType => dr87SmWyZYrEkEcWaOem(this);

	public DropDownItemNHType()
	{
		//Discarded unreachable code: IL_002f, IL_0034
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		CX4BiQWyokwIUeFexohO();
		((AbstractStringType)this)._002Ector((SqlType)new StringSqlType());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal DropDownItemNHType(StringSqlType sqlType)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		((AbstractStringType)this)._002Ector((SqlType)(object)sqlType);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void Set(DbCommand cmd, object value, int index, ISessionImplementor session)
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
				HVd8SHWyfLqDjUqcE49Y(aj2Z75WyEvUOjLfxD8Lx(d6YWLSWyGdwAcuiqRbJg(cmd), index), ((NullableType)this).ToString(value));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override object Get(DbDataReader rs, int index, ISessionImplementor session)
	{
		return new DropDownItem((string)dW1yH4WyQwtGbQFlp4Ue(rs[index]));
	}

	public override object Get(DbDataReader rs, string name, ISessionImplementor session)
	{
		return new DropDownItem(Convert.ToString(rs[name]));
	}

	public override string ToString(object val)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (val != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return null;
			default:
				return val.ToString();
			}
		}
	}

	public override object FromStringValue(string xml)
	{
		return new DropDownItem(xml);
	}

	bool IUserType.Equals(object x, object y)
	{
		return ROFjMbWyCxhMbny3vVjU(this, x, y);
	}

	int IUserType.GetHashCode(object x)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return 0;
			case 1:
				if (x != null)
				{
					return x.GetHashCode();
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	object IUserType.NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
	{
		return new DropDownItem((string)yjmgj9WyvLlSBvNZDV3Q(this, rs, names, session));
	}

	object IUserType.DeepCopy(object value)
	{
		return value;
	}

	object IUserType.Replace(object original, object target, object owner)
	{
		return original;
	}

	object IUserType.Assemble(object cached, object owner)
	{
		return cached;
	}

	object IUserType.Disassemble(object value)
	{
		return value;
	}

	internal static void CX4BiQWyokwIUeFexohO()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool QVRO4iWyB9BnWgc0CHvX()
	{
		return mCMWL8WyFPWayUFpPvCJ == null;
	}

	internal static DropDownItemNHType EOGuX9WyWf6aPiysqROk()
	{
		return mCMWL8WyFPWayUFpPvCJ;
	}

	internal static Type XYu32gWybdc6kUAdtb5n(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object c1CNinWyhYLQ3TeMGQEi(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object d6YWLSWyGdwAcuiqRbJg(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static object aj2Z75WyEvUOjLfxD8Lx(object P_0, int P_1)
	{
		return ((DbParameterCollection)P_0)[P_1];
	}

	internal static void HVd8SHWyfLqDjUqcE49Y(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static object dW1yH4WyQwtGbQFlp4Ue(object P_0)
	{
		return Convert.ToString(P_0);
	}

	internal static bool ROFjMbWyCxhMbny3vVjU(object P_0, object P_1, object P_2)
	{
		return ((AbstractType)P_0).IsEqual(P_1, P_2);
	}

	internal static object yjmgj9WyvLlSBvNZDV3Q(object P_0, object P_1, object P_2, object P_3)
	{
		return ((NullableType)P_0).NullSafeGet((DbDataReader)P_1, (string[])P_2, (ISessionImplementor)P_3);
	}

	internal static object e2Zmp0Wy8LVksvJwF72r(object P_0)
	{
		return ((NullableType)P_0).get_SqlType();
	}

	internal static Type dr87SmWyZYrEkEcWaOem(object P_0)
	{
		return ((AbstractType)P_0).get_ReturnedClass();
	}
}
