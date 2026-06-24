using System.Collections.Generic;
using System.Linq;
using System.Text;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Type;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

public class CalculatedProjection : SimpleProjection
{
	public enum CalculationType
	{
		Addition,
		Subtraction,
		Division,
		Multiplication,
		Minus
	}

	private readonly CalculationType calculationType;

	private readonly IProjection firstProjection;

	private readonly IProjection secondProjection;

	private readonly string firstPropertyName;

	private readonly string secondPropertyName;

	internal static CalculatedProjection ahiS0CWDJ20J86TI2dnS;

	public override bool IsGrouped => false;

	public override bool IsAggregate => false;

	protected internal CalculatedProjection(CalculationType type, string firstPropertyName, string secondPropertyName)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		o718MJWDl7UhVEHMr2pg();
		((SimpleProjection)this)._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				this.firstPropertyName = firstPropertyName;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.secondPropertyName = secondPropertyName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				calculationType = type;
				num = 3;
				break;
			case 0:
				return;
			}
		}
	}

	protected internal CalculatedProjection(CalculationType type, IProjection firstProjection, IProjection secondProjection)
	{
		//Discarded unreachable code: IL_001e
		o718MJWDl7UhVEHMr2pg();
		((SimpleProjection)this)._002Ector();
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				this.secondProjection = secondProjection;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				this.firstProjection = firstProjection;
				num2 = 2;
				break;
			case 0:
				return;
			case 3:
				calculationType = type;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		//Discarded unreachable code: IL_0043, IL_004d, IL_005c, IL_00ac
		int num = 5;
		string text2 = default(string);
		string text4 = default(string);
		while (true)
		{
			int num2 = num;
			string text3;
			while (true)
			{
				string text;
				switch (num2)
				{
				case 6:
					text = firstPropertyName;
					break;
				case 5:
					if (firstProjection != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				case 1:
					if (secondProjection == null)
					{
						num2 = 2;
						continue;
					}
					text3 = ((object)secondProjection).ToString();
					goto end_IL_0012;
				case 2:
					text3 = secondPropertyName;
					goto end_IL_0012;
				default:
					return (string)xNsSm4WDgcDHak1HCBV8(new string[5]
					{
						(string)ol6SDfWDrfGXCXkZWMQb(--1360331293 ^ 0x51151DAB),
						text2,
						TypeToString(calculationType),
						text4,
						(string)ol6SDfWDrfGXCXkZWMQb(--1333735954 ^ 0x4F7F2DAE)
					});
				case 3:
					if (calculationType == CalculationType.Minus)
					{
						return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852838478) + TypeToString(calculationType) + text2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867820560);
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					text = ((object)firstProjection).ToString();
					break;
				}
				text2 = text;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			text4 = text3;
			num = 3;
		}
	}

	public override IType[] GetTypes(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		//Discarded unreachable code: IL_0071, IL_0080, IL_00ed, IL_012f, IL_015f, IL_01db, IL_01ea, IL_0227, IL_0236, IL_0246
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		int num2 = num;
		IType type = default(IType);
		List<IType> list = default(List<IType>);
		IType[] types = default(IType[]);
		while (true)
		{
			switch (num2)
			{
			case 17:
				type = criteriaQuery.GetType(criteria, secondPropertyName);
				num2 = 19;
				break;
			case 19:
				if (mFvo4vWDYGbn7xCMamIO(list) == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				if (((object)list[0]).Equals((object)type))
				{
					num2 = 5;
					break;
				}
				goto default;
			case 9:
			case 13:
			case 16:
				if (secondProjection == null)
				{
					num2 = 4;
					break;
				}
				goto case 18;
			case 14:
				list.Add((IType)p6LruDWDjKKQ9HJZrkMB(criteriaQuery, criteria, firstPropertyName));
				num2 = 13;
				break;
			case 3:
				list = new List<IType>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 2;
				}
				break;
			case 15:
				list.AddRange((IEnumerable<IType>)MGnuq3WD55wGo2p6S0YE(firstProjection, criteria, criteriaQuery));
				num2 = 9;
				break;
			case 7:
				throw new HibernateException((string)ol6SDfWDrfGXCXkZWMQb(-309639236 ^ -309766086));
			case 4:
				if (string.IsNullOrWhiteSpace(secondPropertyName))
				{
					num2 = 11;
					break;
				}
				goto case 17;
			case 18:
				types = secondProjection.GetTypes(criteria, criteriaQuery);
				num2 = 8;
				break;
			case 2:
				if (firstProjection != null)
				{
					num2 = 15;
					break;
				}
				goto case 12;
			case 8:
				if (list.SequenceEqual(types))
				{
					num2 = 6;
					break;
				}
				goto case 7;
			default:
				throw new HibernateException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C512779));
			case 5:
			case 6:
			case 11:
				return (IType[])hUtiqWWDL8FPsLjMDju5(list);
			case 12:
				if (string.IsNullOrWhiteSpace(firstPropertyName))
				{
					num2 = 16;
					break;
				}
				goto case 14;
			}
		}
	}

	public override SqlString ToSqlString(ICriteria criteria, int loc, ICriteriaQuery criteriaQuery)
	{
		//Discarded unreachable code: IL_0055, IL_0064, IL_0074, IL_0083, IL_0145, IL_0154, IL_0255
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		int num = 11;
		int num2 = num;
		SqlString val = default(SqlString);
		SqlString val2 = default(SqlString);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 6:
				val = (SqlString)w9pnouWDcjgn63W6q90u(firstProjection.ToSqlString(criteria, loc, criteriaQuery));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 4;
				}
				continue;
			case 4:
				val2 = (SqlString)w9pnouWDcjgn63W6q90u(fFQFJwWDsOPsLSTZibO6(secondProjection, criteria, loc, criteriaQuery));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 1;
				}
				continue;
			case 11:
				if (calculationType == CalculationType.Minus)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 10;
					}
					continue;
				}
				if (firstProjection == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 3;
			case 8:
				val2 = new SqlString((string)ekr4rbWDUKiwvXY3NOuc(criteriaQuery, criteria, secondPropertyName));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 0;
				}
				continue;
			case 10:
				if (firstProjection != null)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 12;
			case 3:
				if (secondProjection != null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 2;
			case 5:
				return (SqlString)m5yZ0iWtBtYsHeidrAmu(((SqlStringBuilder)c3eYaVWDzFuytlYBCpg3(c3eYaVWDzFuytlYBCpg3(((SqlStringBuilder)c3eYaVWDzFuytlYBCpg3(new SqlStringBuilder().Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2ACFCCB)), TypeToString(calculationType))).Add(val), ol6SDfWDrfGXCXkZWMQb(-541731959 ^ -541733835)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837799785))).Add((string)((object[])vknCyyWtFgApMbEMg41G(this, loc))[0]));
			case 12:
				obj = (object)new SqlString((string)ekr4rbWDUKiwvXY3NOuc(criteriaQuery, criteria, firstPropertyName));
				break;
			default:
				return (SqlString)m5yZ0iWtBtYsHeidrAmu(((SqlStringBuilder)c3eYaVWDzFuytlYBCpg3(c3eYaVWDzFuytlYBCpg3(((SqlStringBuilder)c3eYaVWDzFuytlYBCpg3(qAXHfpWto5qfZFGOpNb5(mFLvLCWtWWp7n5YGoSrM((object)new SqlStringBuilder(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765858660)), val), KmlRjVWtb9r5UX9iM41i(calculationType))).Add(val2), ol6SDfWDrfGXCXkZWMQb(-2112703338 ^ -2112705750)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E06366))).Add((string)((object[])vknCyyWtFgApMbEMg41G(this, loc))[0]));
			case 2:
			case 7:
				val = new SqlString((string)ekr4rbWDUKiwvXY3NOuc(criteriaQuery, criteria, firstPropertyName));
				num2 = 8;
				continue;
			case 9:
				obj = w9pnouWDcjgn63W6q90u(fFQFJwWDsOPsLSTZibO6(firstProjection, criteria, loc, criteriaQuery));
				break;
			}
			val = (SqlString)obj;
			num2 = 5;
		}
	}

	public override SqlString ToGroupSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			switch (num2)
			{
			default:
				return new SqlString(new object[1] { stringBuilder.ToString() });
			case 1:
				stringBuilder = new StringBuilder();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static string TypeToString(CalculationType type)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				switch (type)
				{
				default:
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 1;
					}
					goto end_IL_0012;
				case CalculationType.Addition:
					break;
				case CalculationType.Subtraction:
					return (string)ol6SDfWDrfGXCXkZWMQb(--1360331293 ^ 0x51150C71);
				case CalculationType.Multiplication:
					return (string)ol6SDfWDrfGXCXkZWMQb(--1867379187 ^ 0x6F4DA3A3);
				case CalculationType.Division:
					return (string)ol6SDfWDrfGXCXkZWMQb(-1765851862 ^ -1765844614);
				case CalculationType.Minus:
					return (string)ol6SDfWDrfGXCXkZWMQb(-541731959 ^ -541729307);
				}
				goto default;
			default:
				return (string)ol6SDfWDrfGXCXkZWMQb(0x12A5FAC7 ^ 0x12A5B519);
			case 1:
				{
					return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858867585);
				}
				end_IL_0012:
				break;
			}
		}
	}

	internal static void o718MJWDl7UhVEHMr2pg()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool slvZvtWD935i0Umw86SB()
	{
		return ahiS0CWDJ20J86TI2dnS == null;
	}

	internal static CalculatedProjection I8L1cbWDdJrBABAGx1pP()
	{
		return ahiS0CWDJ20J86TI2dnS;
	}

	internal static object ol6SDfWDrfGXCXkZWMQb(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object xNsSm4WDgcDHak1HCBV8(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object MGnuq3WD55wGo2p6S0YE(object P_0, object P_1, object P_2)
	{
		return ((IProjection)P_0).GetTypes((ICriteria)P_1, (ICriteriaQuery)P_2);
	}

	internal static object p6LruDWDjKKQ9HJZrkMB(object P_0, object P_1, object P_2)
	{
		return ((ICriteriaQuery)P_0).GetType((ICriteria)P_1, (string)P_2);
	}

	internal static int mFvo4vWDYGbn7xCMamIO(object P_0)
	{
		return ((List<IType>)P_0).Count;
	}

	internal static object hUtiqWWDL8FPsLjMDju5(object P_0)
	{
		return ((List<IType>)P_0).ToArray();
	}

	internal static object ekr4rbWDUKiwvXY3NOuc(object P_0, object P_1, object P_2)
	{
		return ((ICriteriaQuery)P_0).GetColumn((ICriteria)P_1, (string)P_2);
	}

	internal static object fFQFJwWDsOPsLSTZibO6(object P_0, object P_1, int P_2, object P_3)
	{
		return ((IProjection)P_0).ToSqlString((ICriteria)P_1, P_2, (ICriteriaQuery)P_3);
	}

	internal static object w9pnouWDcjgn63W6q90u(object P_0)
	{
		return StringHelper.RemoveAsAliasesFromSql((SqlString)P_0);
	}

	internal static object c3eYaVWDzFuytlYBCpg3(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((string)P_1);
	}

	internal static object vknCyyWtFgApMbEMg41G(object P_0, int P_1)
	{
		return ((SimpleProjection)P_0).GetColumnAliases(P_1);
	}

	internal static object m5yZ0iWtBtYsHeidrAmu(object P_0)
	{
		return ((SqlStringBuilder)P_0).ToSqlString();
	}

	internal static object mFLvLCWtWWp7n5YGoSrM(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((string)P_1);
	}

	internal static object qAXHfpWto5qfZFGOpNb5(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((SqlString)P_1);
	}

	internal static object KmlRjVWtb9r5UX9iM41i(CalculationType type)
	{
		return TypeToString(type);
	}
}
