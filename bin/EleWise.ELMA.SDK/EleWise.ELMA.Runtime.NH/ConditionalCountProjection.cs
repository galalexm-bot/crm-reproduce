using System;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.SqlCommand;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

[Serializable]
public class ConditionalCountProjection : SimpleProjection
{
	private readonly ICriterion criterion;

	internal static ConditionalCountProjection wxNftLWpzEXED69mkL3Y;

	public override bool IsAggregate
	{
		get
		{
			//Discarded unreachable code: IL_006a, IL_0079, IL_011d, IL_012c
			int num = 6;
			int num2 = num;
			IProjection[] array2 = default(IProjection[]);
			IProjection[] array = default(IProjection[]);
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 4:
					array2 = array;
					num2 = 9;
					break;
				case 5:
					if (array != null)
					{
						num2 = 4;
						break;
					}
					goto case 3;
				case 3:
					return false;
				case 1:
					if (!OptM8pWabPIL3535Hg6q(array2[num3]))
					{
						num2 = 2;
						break;
					}
					goto case 7;
				default:
					if (num3 >= array2.Length)
					{
						num2 = 3;
						break;
					}
					goto case 1;
				case 6:
					array = (IProjection[])sHKLPmWao1MJPX7q7ATL(criterion);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 5;
					}
					break;
				case 9:
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					return true;
				case 2:
					num3++;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 8;
					}
					break;
				}
			}
		}
	}

	public override bool IsGrouped
	{
		get
		{
			//Discarded unreachable code: IL_0074, IL_00fc, IL_010b, IL_011a
			int num = 2;
			int num2 = num;
			IProjection[] array2 = default(IProjection[]);
			int num3 = default(int);
			IProjection[] array = default(IProjection[]);
			while (true)
			{
				switch (num2)
				{
				case 2:
					array2 = (IProjection[])sHKLPmWao1MJPX7q7ATL(criterion);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					num3 = 0;
					num2 = 5;
					break;
				case 3:
					return true;
				case 10:
					num3++;
					num2 = 9;
					break;
				case 8:
					return false;
				default:
					array = array2;
					num2 = 6;
					break;
				case 5:
				case 9:
					if (num3 < array.Length)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 7;
						}
						break;
					}
					goto case 8;
				case 1:
					if (array2 != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 8;
				case 4:
				case 7:
					if (!OTA4mwWa8MEY0YQvNXW3(array[num3]))
					{
						num2 = 10;
						break;
					}
					goto case 3;
				}
			}
		}
	}

	public ConditionalCountProjection(ICriterion criterion)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uqkB84WaWxJFbKA4Srhc();
		((SimpleProjection)this)._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.criterion = criterion;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override SqlString ToSqlString(ICriteria criteria, int position, ICriteriaQuery criteriaQuery)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		SqlString val = default(SqlString);
		while (true)
		{
			switch (num2)
			{
			default:
				return ((SqlStringBuilder)khrTAOWaQTUQO5BekkjK(khrTAOWaQTUQO5BekkjK(khrTAOWaQTUQO5BekkjK(khrTAOWaQTUQO5BekkjK(((SqlStringBuilder)kAw9kXWafRKpM82mI7jB(((SqlStringBuilder)s0l131WaEbaMeABcRcqr((object)new SqlStringBuilder(), u8uVluWaGRiUjVelsfm1(0x17ADCCD8 ^ 0x17AFD5F0))).Add((string)u8uVluWaGRiUjVelsfm1(0x4DC2B14D ^ 0x4DC0A875)), val)).Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108782752)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A7E3A5)), u8uVluWaGRiUjVelsfm1(-475857671 ^ -475864251)), u8uVluWaGRiUjVelsfm1(0x53FA00CE ^ 0x53F81822)), ((object[])CbEXqqWaCkgKD6fktcTU(this, position))[0])).ToSqlString();
			case 1:
				val = (SqlString)weDs8gWahZWJRhH4d5n6(criterion, criteria, criteriaQuery);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override IType[] GetTypes(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		return (IType[])(object)new IType[1] { (IType)NHibernateUtil.Int32 };
	}

	public override TypedValue[] GetTypedValues(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		return (TypedValue[])q653T4WavJlhkZ2ddNAv(criterion, criteria, criteriaQuery);
	}

	public override SqlString ToGroupSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		//Discarded unreachable code: IL_0089, IL_0098, IL_00a8
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		int num = 10;
		SqlStringBuilder val = default(SqlStringBuilder);
		IProjection[] array = default(IProjection[]);
		int num3 = default(int);
		IProjection[] array2 = default(IProjection[]);
		IProjection val2 = default(IProjection);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					YsZAwOWaIZZSoR4Oevj7(val, S3At4qWauYZGOyUPfmLV(val) - 1);
					num2 = 4;
					continue;
				case 8:
					if (array != null)
					{
						num2 = 3;
						continue;
					}
					goto case 13;
				default:
					if (num3 >= array2.Length)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 1;
				case 9:
					array = (IProjection[])sHKLPmWao1MJPX7q7ATL(criterion);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 8;
					}
					continue;
				case 14:
					if (!OTA4mwWa8MEY0YQvNXW3(val2))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 11;
				case 1:
					val2 = array2[num3];
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					return (SqlString)Ma2AFZWaV8oTjX90wIh6(val);
				case 2:
				case 6:
					break;
				case 13:
					if (S3At4qWauYZGOyUPfmLV(val) >= 2)
					{
						num2 = 5;
						continue;
					}
					goto case 4;
				case 7:
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					val = new SqlStringBuilder();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 9;
					}
					continue;
				case 11:
					((SqlStringBuilder)kAw9kXWafRKpM82mI7jB(val, O1IYJYWaZL1LviNgRjH1(val2, criteria, criteriaQuery))).Add((string)u8uVluWaGRiUjVelsfm1(-477139494 ^ -477142568));
					num2 = 2;
					continue;
				case 3:
					array2 = array;
					num2 = 7;
					continue;
				}
				break;
			}
			num3++;
			num = 12;
		}
	}

	internal static void uqkB84WaWxJFbKA4Srhc()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool jxhQmFWaFZKA1hYTySdA()
	{
		return wxNftLWpzEXED69mkL3Y == null;
	}

	internal static ConditionalCountProjection UP9Tq3WaBLxE8ruxNxEy()
	{
		return wxNftLWpzEXED69mkL3Y;
	}

	internal static object sHKLPmWao1MJPX7q7ATL(object P_0)
	{
		return ((ICriterion)P_0).GetProjections();
	}

	internal static bool OptM8pWabPIL3535Hg6q(object P_0)
	{
		return ((IProjection)P_0).get_IsAggregate();
	}

	internal static object weDs8gWahZWJRhH4d5n6(object P_0, object P_1, object P_2)
	{
		return ((ICriterion)P_0).ToSqlString((ICriteria)P_1, (ICriteriaQuery)P_2);
	}

	internal static object u8uVluWaGRiUjVelsfm1(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object s0l131WaEbaMeABcRcqr(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((string)P_1);
	}

	internal static object kAw9kXWafRKpM82mI7jB(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((SqlString)P_1);
	}

	internal static object khrTAOWaQTUQO5BekkjK(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((string)P_1);
	}

	internal static object CbEXqqWaCkgKD6fktcTU(object P_0, int P_1)
	{
		return ((SimpleProjection)P_0).GetColumnAliases(P_1);
	}

	internal static object q653T4WavJlhkZ2ddNAv(object P_0, object P_1, object P_2)
	{
		return ((ICriterion)P_0).GetTypedValues((ICriteria)P_1, (ICriteriaQuery)P_2);
	}

	internal static bool OTA4mwWa8MEY0YQvNXW3(object P_0)
	{
		return ((IProjection)P_0).get_IsGrouped();
	}

	internal static object O1IYJYWaZL1LviNgRjH1(object P_0, object P_1, object P_2)
	{
		return ((IProjection)P_0).ToGroupSqlString((ICriteria)P_1, (ICriteriaQuery)P_2);
	}

	internal static int S3At4qWauYZGOyUPfmLV(object P_0)
	{
		return ((SqlStringBuilder)P_0).get_Count();
	}

	internal static object YsZAwOWaIZZSoR4Oevj7(object P_0, int P_1)
	{
		return ((SqlStringBuilder)P_0).RemoveAt(P_1);
	}

	internal static object Ma2AFZWaV8oTjX90wIh6(object P_0)
	{
		return ((SqlStringBuilder)P_0).ToSqlString();
	}
}
