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
public class MoneyNHType : IUserType
{
	public class Convention : AutoRegisterUserTypeConvention<MoneyNHType>
	{
		internal static Convention iNNOXfQY23F7aaNEYaVf;

		public Convention()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool wPgwe5QYeZ5jth0N6PbT()
		{
			return iNNOXfQY23F7aaNEYaVf == null;
		}

		internal static Convention x3ubw9QYPMBMJr0nSXiX()
		{
			return iNNOXfQY23F7aaNEYaVf;
		}
	}

	internal static MoneyNHType ayqxjcW0csXBWaAUMQvh;

	public SqlType[] SqlTypes => (SqlType[])(object)new SqlType[1] { (SqlType)WyYP9IWmG9IshyVkFoFL(NHibernateUtil.Double) };

	public Type ReturnedType => Hi5hjLWmBuccUWo3oHWT(typeof(Money).TypeHandle);

	public virtual bool IsMutable => false;

	public new virtual bool Equals(object x, object y)
	{
		//Discarded unreachable code: IL_0045, IL_0054, IL_0094, IL_00a3, IL_0113, IL_0122
		int num = 2;
		Money money = default(Money);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return money.CompareTo(y) == 0;
				case 4:
				case 6:
					return false;
				case 3:
					money = (Money)x;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 5;
					}
					break;
				case 1:
					if (y != null)
					{
						num2 = 7;
						break;
					}
					goto case 8;
				default:
					if (y is Money)
					{
						num2 = 3;
						break;
					}
					goto case 4;
				case 8:
					return true;
				case 7:
					if (!(x is Money))
					{
						goto end_IL_0012;
					}
					goto default;
				case 2:
					if (x == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 7;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public virtual int GetHashCode(object x)
	{
		int num = 3;
		int num2 = num;
		Money money = default(Money);
		double value = default(double);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return Hi5hjLWmBuccUWo3oHWT(typeof(Money).TypeHandle).GetHashCode() + 473;
			case 3:
				if (x is Money)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 2:
				money = (Money)x;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				value = money.Value;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return value.GetHashCode();
			default:
				if (money.HasValue)
				{
					money = (Money)x;
					num2 = 5;
				}
				else
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	public object NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
	{
		int num = 3;
		int num2 = num;
		object obj = default(object);
		Money money = default(Money);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				money.Value = Convert.ToDouble(obj);
				num2 = 4;
				continue;
			case 2:
				money = default(Money);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				obj = mASA6tWmW2jjPGmn8XXs(NHibernateUtil.Double, rs, names[0], session);
				num2 = 2;
				continue;
			case 4:
				break;
			}
			break;
		}
		return money;
	}

	public void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_00ed
		int num = 3;
		int num2 = num;
		Money money = default(Money);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return;
			case 2:
			case 6:
				VsmlhkWmhwDxRLpQ7Qpc(apKQqCWmbHtmk2AoK6Mh(F6PO9dWmomtkbOZSCdE7(cmd), index), DBNull.Value);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				if (value == null)
				{
					num2 = 2;
					continue;
				}
				goto case 4;
			case 4:
				if (value is Money)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 2;
			case 5:
				return;
			case 1:
				money = (Money)value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (!money.HasValue)
			{
				num2 = 6;
				continue;
			}
			object obj = apKQqCWmbHtmk2AoK6Mh(F6PO9dWmomtkbOZSCdE7(cmd), index);
			money = (Money)value;
			VsmlhkWmhwDxRLpQ7Qpc(obj, money.Value);
			num2 = 7;
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

	public MoneyNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j4trsiWmEkiI8FJGVUsC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool DmtGyEW0zprKFIlPNbjE()
	{
		return ayqxjcW0csXBWaAUMQvh == null;
	}

	internal static MoneyNHType wym8BfWmF6L0xollA0Nn()
	{
		return ayqxjcW0csXBWaAUMQvh;
	}

	internal static Type Hi5hjLWmBuccUWo3oHWT(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object mASA6tWmW2jjPGmn8XXs(object P_0, object P_1, object P_2, object P_3)
	{
		return ((NullableType)P_0).NullSafeGet((DbDataReader)P_1, (string)P_2, (ISessionImplementor)P_3);
	}

	internal static object F6PO9dWmomtkbOZSCdE7(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static object apKQqCWmbHtmk2AoK6Mh(object P_0, int P_1)
	{
		return ((DbParameterCollection)P_0)[P_1];
	}

	internal static void VsmlhkWmhwDxRLpQ7Qpc(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static object WyYP9IWmG9IshyVkFoFL(object P_0)
	{
		return ((NullableType)P_0).get_SqlType();
	}

	internal static void j4trsiWmEkiI8FJGVUsC()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
