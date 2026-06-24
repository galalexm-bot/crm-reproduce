using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.SqlCommand;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

[Serializable]
public class AliasesSQLCriterion : AbstractCriterion
{
	private readonly SqlString _sql;

	private readonly TypedValue[] _typedValues;

	internal static AliasesSQLCriterion GGWZDKWDtgOou2hKdKgq;

	public AliasesSQLCriterion(SqlString sql, object[] values, IType[] types)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_008f, IL_009e
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		sbRATYWD6AEEDPvomk3k();
		((AbstractCriterion)this)._002Ector();
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
				num2 = 0;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num = 0;
				}
				break;
			case 6:
				_typedValues[num2] = new TypedValue(types[num2], values[num2]);
				num = 7;
				break;
			case 5:
				_typedValues = (TypedValue[])(object)new TypedValue[values.Length];
				num = 2;
				break;
			default:
				if (num2 >= _typedValues.Length)
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num = 1;
					}
					break;
				}
				goto case 6;
			case 4:
				_sql = sql;
				num = 5;
				break;
			case 7:
				num2++;
				num = 3;
				break;
			case 1:
				return;
			}
		}
	}

	public override TypedValue[] GetTypedValues(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		return _typedValues;
	}

	public override IProjection[] GetProjections()
	{
		return null;
	}

	public override string ToString()
	{
		return ((object)_sql).ToString();
	}

	public override SqlString ToSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		//Discarded unreachable code: IL_0153, IL_0162, IL_0235, IL_0244, IL_0271, IL_0280, IL_02a5
		int num = 12;
		int num2 = num;
		int num3 = default(int);
		IEnumerator<Parameter> enumerator = default(IEnumerator<Parameter>);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		List<Parameter> list2 = default(List<Parameter>);
		Parameter current = default(Parameter);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 10:
				num3 = 0;
				num2 = 3;
				break;
			case 3:
			case 6:
				if (num3 >= _typedValues.Length)
				{
					num2 = 7;
					break;
				}
				goto case 8;
			case 8:
				enumerator = _003C_003Ec__DisplayClass6_.criteriaQuery.NewQueryParameter(_typedValues[num3]).GetEnumerator();
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 1;
				}
				break;
			case 11:
				_003C_003Ec__DisplayClass6_.criteriaQuery = criteriaQuery;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				list2 = _sql.GetParameters().ToList();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 4;
				}
				break;
			case 12:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 6;
				}
				break;
			case 2:
				num3++;
				num2 = 6;
				break;
			default:
				_003C_003Ec__DisplayClass6_.criteria = criteria;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				try
				{
					while (true)
					{
						IL_01b3:
						int num5;
						if (!AhJsqDWD7d5gYFgYf0Ss(enumerator))
						{
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
							{
								num5 = 0;
							}
							goto IL_0171;
						}
						goto IL_01d9;
						IL_01d9:
						current = enumerator.Current;
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num5 = 1;
						}
						goto IL_0171;
						IL_0171:
						while (true)
						{
							switch (num5)
							{
							case 1:
							{
								MSyi2HWDAvVTPvXdMCqE(list2[num4++], wqFB5ZWDH4L47jh3N71i(current));
								int num6 = 3;
								num5 = num6;
								continue;
							}
							case 3:
								goto IL_01b3;
							case 2:
								goto IL_01d9;
							case 0:
								break;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					int num8;
					if (enumerator == null)
					{
						int num7 = 2;
						num8 = num7;
						goto IL_021a;
					}
					goto IL_024f;
					IL_021a:
					switch (num8)
					{
					default:
						goto end_IL_0201;
					case 2:
						goto end_IL_0201;
					case 1:
						break;
					case 0:
						goto end_IL_0201;
					}
					goto IL_024f;
					IL_024f:
					enumerator.Dispose();
					num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num8 = 0;
					}
					goto IL_021a;
					end_IL_0201:;
				}
				goto case 2;
			case 5:
				return _003C_003Ec__DisplayClass6_.sql;
			case 4:
				num4 = 0;
				num2 = 10;
				break;
			case 7:
			{
				List<string> list = (from m in ((IEnumerable)GvOYQVWD08GlPLBVeA10(((object)_sql).ToString(), Ea2xVNWDxS2pI6x7QfKa(-97972138 ^ -97841370))).OfType<Match>()
					select (string)_003C_003Ec.TTvxM7QdRCUkdF7O3HJV(m)).ToList();
				_003C_003Ec__DisplayClass6_.sql = _sql;
				list.ForEach(_003C_003Ec__DisplayClass6_._003CToSqlString_003Eb__1);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 4;
				}
				break;
			}
			}
		}
	}

	internal static void sbRATYWD6AEEDPvomk3k()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool x4CbeBWDwk9DhcJ46Dk1()
	{
		return GGWZDKWDtgOou2hKdKgq == null;
	}

	internal static AliasesSQLCriterion paAv0wWD4xltwvy4q7sP()
	{
		return GGWZDKWDtgOou2hKdKgq;
	}

	internal static object wqFB5ZWDH4L47jh3N71i(object P_0)
	{
		return ((Parameter)P_0).get_BackTrack();
	}

	internal static void MSyi2HWDAvVTPvXdMCqE(object P_0, object P_1)
	{
		((Parameter)P_0).set_BackTrack(P_1);
	}

	internal static bool AhJsqDWD7d5gYFgYf0Ss(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object Ea2xVNWDxS2pI6x7QfKa(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object GvOYQVWD08GlPLBVeA10(object P_0, object P_1)
	{
		return Regex.Matches((string)P_0, (string)P_1);
	}
}
