using System;
using System.Data;
using System.Data.Common;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.Type;
using NHibernate.UserTypes;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities.EntityReferences;

[Serializable]
public class ReferenceOnEntityTypeNHType : IUserType
{
	internal static ReferenceOnEntityTypeNHType TIhQF7hVVtPSHchC3epB;

	public SqlType[] SqlTypes => (SqlType[])(object)new SqlType[1] { (SqlType)CPF77ghVOeiANVc9WGv5(NHibernateUtil.Guid) };

	public Type ReturnedType => Sn3HeIhVR1lqcfbrLWug(typeof(ReferenceOnEntityType).TypeHandle);

	public bool IsMutable => true;

	public new bool Equals(object x, object y)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (x == y)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (x != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			case 2:
				return false;
			case 3:
				if (y != null)
				{
					return x.Equals(y);
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 2;
				}
				break;
			default:
				return true;
			}
		}
	}

	public int GetHashCode(object x)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return x.GetHashCode();
			default:
				return Sn3HeIhVR1lqcfbrLWug(typeof(ReferenceOnEntityType).TypeHandle).GetHashCode() + 473;
			case 1:
				if (x == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
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
		//Discarded unreachable code: IL_0046
		int num = 2;
		int num2 = num;
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return new ReferenceOnEntityType
				{
					TypeUid = (Guid)obj
				};
			default:
				return null;
			case 1:
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				obj = Cui7DVhVqydfV94fSwJm(NHibernateUtil.Guid, rs, names[0], session);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
	{
		int num = 2;
		ReferenceOnEntityType referenceOnEntityType = default(ReferenceOnEntityType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					break;
				case 2:
					if (value == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						referenceOnEntityType = (ReferenceOnEntityType)value;
						num2 = 3;
					}
					continue;
				case 0:
					return;
				case 3:
					mU3CpRhVkGg9ytERHQNq(byM2vRhVKsVDkJHkTGmJ(iCidWLhVXUY5NSfZYpge(cmd), index), DDB9JOhVTTVgCCAPN09x(referenceOnEntityType));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return;
				}
				break;
			}
			((IDataParameter)byM2vRhVKsVDkJHkTGmJ(cmd.Parameters, index)).Value = DBNull.Value;
			num = 4;
		}
	}

	public object DeepCopy(object value)
	{
		int num = 2;
		int num2 = num;
		ReferenceOnEntityType referenceOnEntityType = default(ReferenceOnEntityType);
		while (true)
		{
			switch (num2)
			{
			default:
				return new ReferenceOnEntityType
				{
					TypeUid = DDB9JOhVTTVgCCAPN09x(referenceOnEntityType)
				};
			case 2:
				if (value == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					break;
				}
				referenceOnEntityType = (ReferenceOnEntityType)hwZKvyhVnNARqTgiHYEV(value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return null;
			}
		}
	}

	public object Replace(object original, object target, object owner)
	{
		return DeepCopy(original);
	}

	public object Assemble(object cached, object owner)
	{
		return DeepCopy(cached);
	}

	public object Disassemble(object value)
	{
		return DeepCopy(value);
	}

	private static ReferenceOnEntityType AsReferenceOnEntityType(object value)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 0;
					}
					break;
				}
				return (value as ReferenceOnEntityType) ?? throw new InvalidCastException((string)xJ80YZhVecvExTN3LDKO(Hv100nhV20f6BHLbiHdM(0x1ECE530A ^ 0x1ECC7AF4), typeof(ReferenceOnEntityType), value.GetType()));
			default:
				return null;
			}
		}
	}

	public ReferenceOnEntityTypeNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Tb0eiohVPvnkrO2EncaH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ijddjShVS9prXwuDadYk()
	{
		return TIhQF7hVVtPSHchC3epB == null;
	}

	internal static ReferenceOnEntityTypeNHType fatmkjhVioECiZA3Q4p4()
	{
		return TIhQF7hVVtPSHchC3epB;
	}

	internal static Type Sn3HeIhVR1lqcfbrLWug(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Cui7DVhVqydfV94fSwJm(object P_0, object P_1, object P_2, object P_3)
	{
		return ((NullableType)P_0).NullSafeGet((DbDataReader)P_1, (string)P_2, (ISessionImplementor)P_3);
	}

	internal static object byM2vRhVKsVDkJHkTGmJ(object P_0, int P_1)
	{
		return ((DbParameterCollection)P_0)[P_1];
	}

	internal static object iCidWLhVXUY5NSfZYpge(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static Guid DDB9JOhVTTVgCCAPN09x(object P_0)
	{
		return ((ReferenceOnEntityType)P_0).TypeUid;
	}

	internal static void mU3CpRhVkGg9ytERHQNq(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static object hwZKvyhVnNARqTgiHYEV(object P_0)
	{
		return AsReferenceOnEntityType(P_0);
	}

	internal static object CPF77ghVOeiANVc9WGv5(object P_0)
	{
		return ((NullableType)P_0).get_SqlType();
	}

	internal static object Hv100nhV20f6BHLbiHdM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object xJ80YZhVecvExTN3LDKO(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void Tb0eiohVPvnkrO2EncaH()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
