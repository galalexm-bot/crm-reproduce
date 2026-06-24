using System;
using System.Data;
using System.Data.Common;
using EleWise.ELMA.Common.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.Type;
using NHibernate.UserTypes;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

[Serializable]
public class WorkTimeNHType : IUserType
{
	public class Convention : AutoRegisterUserTypeConvention<WorkTimeNHType>
	{
		internal static Convention cxAdJEQYk6qW8xlym30A;

		public Convention()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool I8Z6UlQYn6yb7H1y5EX7()
		{
			return cxAdJEQYk6qW8xlym30A == null;
		}

		internal static Convention U1s9qwQYO5u604aOPsuk()
		{
			return cxAdJEQYk6qW8xlym30A;
		}
	}

	internal static WorkTimeNHType MXyNOuW0JGW6iZ95nUFe;

	public SqlType[] SqlTypes => (SqlType[])(object)new SqlType[1] { ((NullableType)NHibernateUtil.Int64).get_SqlType() };

	public Type ReturnedType => UsAFaHW0j5bWDALthCYB(typeof(WorkTime).TypeHandle);

	public virtual bool IsMutable => false;

	public new virtual bool Equals(object x, object y)
	{
		//Discarded unreachable code: IL_0079, IL_0088, IL_00d5, IL_00e4, IL_013c, IL_014b, IL_015a
		int num = 7;
		int num2 = num;
		WorkTime workTime = default(WorkTime);
		WorkTime workTime2 = default(WorkTime);
		while (true)
		{
			switch (num2)
			{
			case 10:
				return false;
			case 5:
				workTime = (WorkTime)x;
				num2 = 12;
				break;
			case 7:
				if (x != null)
				{
					num2 = 6;
					break;
				}
				goto case 4;
			case 2:
				return true;
			case 6:
			case 9:
				if (x is WorkTime)
				{
					num2 = 11;
					break;
				}
				goto case 10;
			case 8:
				if (workTime.HasValue)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			default:
				if (workTime2.HasValue)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			case 4:
				if (y != null)
				{
					num2 = 9;
					break;
				}
				goto case 2;
			case 12:
				workTime2 = (WorkTime)y;
				num2 = 8;
				break;
			case 1:
			case 3:
				return workTime.Value == workTime2.Value;
			case 11:
				if (y is WorkTime)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 10;
			}
		}
	}

	public virtual int GetHashCode(object x)
	{
		//Discarded unreachable code: IL_0088
		int num = 1;
		int num2 = num;
		long value = default(long);
		WorkTime workTime = default(WorkTime);
		while (true)
		{
			switch (num2)
			{
			case 3:
				value = workTime.Value;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				return typeof(WorkTime).GetHashCode() + 473;
			case 5:
				workTime = (WorkTime)x;
				num2 = 3;
				break;
			default:
				workTime = (WorkTime)x;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 5;
				}
				break;
			case 1:
				if (x is WorkTime)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 6:
				if (workTime.HasValue)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 4;
			case 2:
				return value.GetHashCode();
			}
		}
	}

	public object NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
	{
		int num = 4;
		int num2 = num;
		WorkTime workTime = default(WorkTime);
		object obj = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return workTime;
			case 3:
				workTime = default(WorkTime);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				obj = ((NullableType)NHibernateUtil.Double).NullSafeGet(rs, names[0], session);
				num2 = 3;
				break;
			case 1:
				workTime.Value = h5BVqkW0lmPOhfkP9QOW(obj);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_0067, IL_0076
		int num = 3;
		int num2 = num;
		WorkTime workTime = default(WorkTime);
		while (true)
		{
			switch (num2)
			{
			case 4:
				workTime = (WorkTime)value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				return;
			case 2:
			case 7:
				BJvYFoW05uvCHglUrqQT(tIbcYDW0giQshWZBolEi(ycPAWfW0rx5iQRRbjjbq(cmd), index), DBNull.Value);
				num2 = 6;
				continue;
			case 5:
				return;
			case 1:
				if (value is WorkTime)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 2;
			case 3:
				if (value == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 1;
			}
			if (!workTime.HasValue)
			{
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 7;
				}
				continue;
			}
			DbParameter dbParameter = cmd.Parameters[index];
			workTime = (WorkTime)value;
			BJvYFoW05uvCHglUrqQT(dbParameter, workTime.Value);
			num2 = 5;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
			{
				num2 = 2;
			}
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

	public WorkTimeNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kPfJ1pW0Yy2LBfDHkJh2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rTAKXLW09Qq96YCL483d()
	{
		return MXyNOuW0JGW6iZ95nUFe == null;
	}

	internal static WorkTimeNHType dnXniBW0dHcgSpmC90yX()
	{
		return MXyNOuW0JGW6iZ95nUFe;
	}

	internal static long h5BVqkW0lmPOhfkP9QOW(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object ycPAWfW0rx5iQRRbjjbq(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static object tIbcYDW0giQshWZBolEi(object P_0, int P_1)
	{
		return ((DbParameterCollection)P_0)[P_1];
	}

	internal static void BJvYFoW05uvCHglUrqQT(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static Type UsAFaHW0j5bWDALthCYB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void kPfJ1pW0Yy2LBfDHkJh2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
