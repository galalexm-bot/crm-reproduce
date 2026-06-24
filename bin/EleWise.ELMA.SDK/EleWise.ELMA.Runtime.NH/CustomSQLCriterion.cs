using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.SqlCommand;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

[Serializable]
public class CustomSQLCriterion : AbstractCriterion
{
	private readonly SqlString _sql;

	private readonly TypedValue[] _typedValues;

	private readonly Func<SqlString, ICriteria, ICriteriaQuery, SqlString> _toSqlStringFunc;

	internal static CustomSQLCriterion GUsxdLWtJJOyev0cM217;

	public CustomSQLCriterion(string sql, object[] values, IType[] types, Func<SqlString, ICriteria, ICriteriaQuery, SqlString> toSqlStringFunc = null)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(SqlString.Parse(sql), values, types, toSqlStringFunc);
	}

	public CustomSQLCriterion(SqlString sql, object[] values, IType[] types, Func<SqlString, ICriteria, ICriteriaQuery, SqlString> toSqlStringFunc = null)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		SingletonReader.JJCZtPuTvSt();
		((AbstractCriterion)this)._002Ector();
		_sql = sql;
		_typedValues = (TypedValue[])(object)new TypedValue[values.Length];
		_toSqlStringFunc = toSqlStringFunc;
		for (int i = 0; i < _typedValues.Length; i++)
		{
			_typedValues[i] = new TypedValue(types[i], values[i]);
		}
	}

	public override IProjection[] GetProjections()
	{
		return null;
	}

	public override TypedValue[] GetTypedValues(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		return _typedValues;
	}

	public override SqlString ToSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		//Discarded unreachable code: IL_00b7, IL_00c6, IL_00d6, IL_0139, IL_0148, IL_0153, IL_0214, IL_024c, IL_025b
		int num = 7;
		int num4 = default(int);
		SqlString val = default(SqlString);
		IEnumerator<Parameter> enumerator = default(IEnumerator<Parameter>);
		Parameter current = default(Parameter);
		List<Parameter> list = default(List<Parameter>);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					num4 = 0;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 12;
					}
					continue;
				case 8:
					val = _toSqlStringFunc(_sql, criteria, criteriaQuery);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 5;
					}
					continue;
				case 3:
					val = _sql;
					num = 4;
					break;
				default:
					enumerator = criteriaQuery.NewQueryParameter(_typedValues[num4]).GetEnumerator();
					num = 5;
					break;
				case 11:
					return (SqlString)LHr1EAWtYtwFHb9a6Bam(val, iXekqUWt5T5YSrV4YUc9(-105199646 ^ -105322696), vgnR3qWtjbGOX3944xgG(criteriaQuery, criteria));
				case 2:
					num4++;
					num2 = 10;
					continue;
				case 5:
					try
					{
						while (true)
						{
							int num5;
							if (!sTdu9hWtrp7cIMDn58w2(enumerator))
							{
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
								{
									num5 = 0;
								}
								goto IL_0157;
							}
							goto IL_01cb;
							IL_01cb:
							current = enumerator.Current;
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
							{
								num5 = 2;
							}
							goto IL_0157;
							IL_0157:
							while (true)
							{
								switch (num5)
								{
								case 2:
									list[num3++].set_BackTrack(Ao4jjGWtl50j3k45JqJT(current));
									num5 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
									{
										num5 = 2;
									}
									continue;
								case 3:
									break;
								default:
									goto IL_01cb;
								case 1:
									goto end_IL_01a5;
								}
								break;
							}
							continue;
							end_IL_01a5:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									gjFoiMWtgsbPtxYrTkpy(enumerator);
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
									{
										num6 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 2;
				case 4:
					if (_toSqlStringFunc != null)
					{
						num2 = 8;
						continue;
					}
					goto case 11;
				case 10:
				case 12:
					if (num4 < _typedValues.Length)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 3;
				case 6:
					num3 = 0;
					num2 = 9;
					continue;
				case 7:
					list = _sql.GetParameters().ToList();
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return ((object)_sql).ToString();
	}

	internal static object Ao4jjGWtl50j3k45JqJT(object P_0)
	{
		return ((Parameter)P_0).get_BackTrack();
	}

	internal static bool sTdu9hWtrp7cIMDn58w2(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void gjFoiMWtgsbPtxYrTkpy(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object iXekqUWt5T5YSrV4YUc9(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object vgnR3qWtjbGOX3944xgG(object P_0, object P_1)
	{
		return ((ICriteriaQuery)P_0).GetSQLAlias((ICriteria)P_1);
	}

	internal static object LHr1EAWtYtwFHb9a6Bam(object P_0, object P_1, object P_2)
	{
		return ((SqlString)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static bool ylOPSXWt906yAvM16CS2()
	{
		return GUsxdLWtJJOyev0cM217 == null;
	}

	internal static CustomSQLCriterion zfHaWOWtdjsjv594aeba()
	{
		return GUsxdLWtJJOyev0cM217;
	}
}
