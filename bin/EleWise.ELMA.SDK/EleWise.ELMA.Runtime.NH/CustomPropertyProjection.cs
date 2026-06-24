using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Persister.Entity;
using NHibernate.SqlCommand;
using NHibernate.Tuple;
using NHibernate.Tuple.Entity;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

[Serializable]
public class CustomPropertyProjection : SimpleProjection, IPropertyProjection
{
	private string propertyName;

	private bool grouped;

	private string entityName;

	private string tableName;

	private PropertyMetadata propertyMetadata;

	private bool forOrder;

	private readonly ITransformationProvider transformationProvider;

	internal static CustomPropertyProjection Xw8eTiWtToqY11D8aECt;

	public string PropertyName => propertyName;

	public override bool IsGrouped => grouped;

	public override bool IsAggregate => false;

	public static string GetExpressionFromString(string exp, out string entityName)
	{
		//Discarded unreachable code: IL_0145, IL_0154, IL_0205, IL_023d, IL_024c, IL_025b
		int num = 3;
		List<string> list = default(List<string>);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					entityName = (string)dY5JLQWt3D0XVL2Kmy1H(list[1], ak9gAeWt2rR0wf6Z8mWU(-1978478350 ^ -1978424670), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978480074));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 12;
					}
					continue;
				case 10:
					num3++;
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 4;
					}
					continue;
				case 12:
					return (string)dY5JLQWt3D0XVL2Kmy1H(list[0], ak9gAeWt2rR0wf6Z8mWU(0x76DD48E ^ 0x76CA6DE), ak9gAeWt2rR0wf6Z8mWU(0x48A7E34A ^ 0x48A7F98E));
				case 6:
					return exp;
				case 4:
					list = new List<string>
					{
						(string)poNTDOWt1fUTkV2sld1i(exp, 0, num3 - 3),
						(string)kWZkO4WtN2tLrPJvxBWu(exp, num3)
					};
					num2 = 15;
					continue;
				case 2:
					if (!spvdSIWtODqAqUPDUPUc(exp))
					{
						num2 = 13;
						continue;
					}
					goto case 9;
				case 1:
				case 14:
					if (num3 < yNefbQWtPyaVT7tWSU4x(exp))
					{
						num2 = 5;
						continue;
					}
					goto case 4;
				case 8:
					if (num3 > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 9:
					return string.Empty;
				case 13:
					num3 = by24Z2Wte5T1pv6D0pNq(exp, ak9gAeWt2rR0wf6Z8mWU(-521266112 ^ -521388932), StringComparison.OrdinalIgnoreCase);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					num3 += 3;
					num = 7;
					break;
				case 3:
					entityName = "";
					num = 2;
					break;
				case 5:
				case 11:
					if (exp[num3] == '_')
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 4;
				case 7:
					if (yNefbQWtPyaVT7tWSU4x(exp) > num3)
					{
						goto case 1;
					}
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	public static string GetStringFromExpression(string colName, string entityName)
	{
		return (string)Y64xdPWtp76xwlOeLlJQ(ak9gAeWt2rR0wf6Z8mWU(-398663332 ^ -398540518), dY5JLQWt3D0XVL2Kmy1H(colName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2026008B), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53DDEF3)), entityName.Replace((string)ak9gAeWt2rR0wf6Z8mWU(-1837662597 ^ -1837669185), (string)ak9gAeWt2rR0wf6Z8mWU(-1765851862 ^ -1765912710)));
	}

	protected internal CustomPropertyProjection(string propertyName, bool grouped, string entityName, string tableName, PropertyMetadata propertyMetadata, bool forOrder)
	{
		//Discarded unreachable code: IL_001a
		mdBexYWtaoXQRV2icJUG();
		((SimpleProjection)this)._002Ector();
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 1:
				this.entityName = entityName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num = 0;
				}
				break;
			case 7:
				this.propertyName = propertyName;
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num = 4;
				}
				break;
			case 2:
				this.propertyMetadata = propertyMetadata;
				num = 6;
				break;
			case 4:
				this.grouped = grouped;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num = 1;
				}
				break;
			case 3:
				return;
			case 6:
				this.forOrder = forOrder;
				num = 3;
				break;
			case 5:
			{
				transformationProvider = Locator.GetService<ITransformationProvider>();
				int num2 = 7;
				num = num2;
				break;
			}
			default:
				this.tableName = (string)FBLae2WttotT1iBbImXn(pp36MdWtDRmGbt2fa4fs(transformationProvider), tableName);
				num = 2;
				break;
			}
		}
	}

	public CustomPropertyProjection(string propertyName, string entityName, string tableName, PropertyMetadata propertyMetadata, bool forOrder = false)
	{
		//Discarded unreachable code: IL_0032, IL_0037
		mdBexYWtaoXQRV2icJUG();
		this._002Ector(propertyName, grouped: false, entityName, tableName, propertyMetadata, forOrder);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override string ToString()
	{
		return propertyName;
	}

	public override IType[] GetTypes(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 2;
		StandardProperty val = default(StandardProperty);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (val != null)
					{
						goto end_IL_0012;
					}
					goto case 1;
				default:
					val = ((EntityMetamodel)SiWlD5Wt6QTWKBpdB9dF(HdRVM5Wt4oGvYXSdrVJo(IFG59PWtwTP5Tq8OV0AI(criteriaQuery), entityName))).get_Properties().FirstOrDefault((StandardProperty p) => SB1ZFZWtMfm3EdfEWGLF(((Property)p).get_Name(), propertyName));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					return (IType[])(object)new IType[1] { ((Property)val).get_Type() };
				case 1:
					return (IType[])(object)new IType[1] { (IType)sSJqtNWtHDwxveQbFlFu(criteriaQuery, criteria, propertyName) };
				case 2:
					if (spvdSIWtODqAqUPDUPUc(entityName))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	protected override int GetColumnCount(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass19_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return ((IEnumerable<IType>)NG03yvWtAoo1yl9ntoL1(this, criteria, _003C_003Ec__DisplayClass19_.criteriaQuery)).Sum((Func<IType, int>)_003C_003Ec__DisplayClass19_._003CGetColumnCount_003Eb__0);
			default:
				_003C_003Ec__DisplayClass19_.criteriaQuery = criteriaQuery;
				num2 = 3;
				break;
			case 1:
				_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override SqlString ToSqlString(ICriteria criteria, int loc, ICriteriaQuery criteriaQuery)
	{
		//Discarded unreachable code: IL_00e6, IL_00f5, IL_016f, IL_0222
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		int num = 9;
		int num2 = num;
		string[] array = default(string[]);
		SqlStringBuilder val = default(SqlStringBuilder);
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 9:
				array = (string[])U73JhfWt7pJYnQbXUjTP(criteriaQuery, criteria, propertyName, entityName, tableName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 8;
				}
				break;
			case 6:
				val.Add((string)ak9gAeWt2rR0wf6Z8mWU(-2106517564 ^ -2106378414));
				num2 = 10;
				break;
			case 13:
				if (array.Length == 0)
				{
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 3;
					}
				}
				else
				{
					val = new SqlStringBuilder();
					num2 = 17;
				}
				break;
			default:
				if (num3 >= array.Length)
				{
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 2;
			case 15:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
			case 18:
				return val.ToSqlString();
			case 17:
				num3 = 0;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 11;
				}
				break;
			case 10:
				H9PqHQWtmE8AiEj7y8L9(val, (loc + num3).ToString());
				num2 = 12;
				break;
			case 1:
				H9PqHQWtmE8AiEj7y8L9(val, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3332072));
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 12;
				}
				break;
			case 2:
				text = array[num3];
				num2 = 4;
				break;
			case 16:
				if (forOrder)
				{
					num2 = 7;
					break;
				}
				goto case 5;
			case 5:
				if (num3 < array.Length - 1)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 15;
			case 8:
				if (array == null)
				{
					num2 = 3;
					break;
				}
				goto case 13;
			case 12:
				H9PqHQWtmE8AiEj7y8L9(val, ak9gAeWt2rR0wf6Z8mWU(-957824448 ^ -957821382));
				num2 = 16;
				break;
			case 3:
			case 14:
				throw new Exception((string)NgPqKyWtxwNZsR2VHoau(ak9gAeWt2rR0wf6Z8mWU(0x269E5FCA ^ 0x269C7F96)));
			case 4:
				H9PqHQWtmE8AiEj7y8L9(val, forOrder ? vmpEStWt0IH5QTmhDBMA(transformationProvider, propertyMetadata, text) : text);
				num2 = 6;
				break;
			}
		}
	}

	public override SqlString ToGroupSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new InvalidOperationException((string)ak9gAeWt2rR0wf6Z8mWU(-882126494 ^ -882249274));
			case 1:
				if (grouped)
				{
					return new SqlString((string)oAuD4mWtyDLGLfRbNQ54(criteriaQuery, criteria, propertyName));
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool spvdSIWtODqAqUPDUPUc(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object ak9gAeWt2rR0wf6Z8mWU(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static int by24Z2Wte5T1pv6D0pNq(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).IndexOf((string)P_1, P_2);
	}

	internal static int yNefbQWtPyaVT7tWSU4x(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object poNTDOWt1fUTkV2sld1i(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object kWZkO4WtN2tLrPJvxBWu(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object dY5JLQWt3D0XVL2Kmy1H(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static bool ySQ2nBWtk1o0SK3TAyV2()
	{
		return Xw8eTiWtToqY11D8aECt == null;
	}

	internal static CustomPropertyProjection BPOZ2IWtnN4ordONijY1()
	{
		return Xw8eTiWtToqY11D8aECt;
	}

	internal static object Y64xdPWtp76xwlOeLlJQ(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void mdBexYWtaoXQRV2icJUG()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object pp36MdWtDRmGbt2fa4fs(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object FBLae2WttotT1iBbImXn(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object IFG59PWtwTP5Tq8OV0AI(object P_0)
	{
		return ((ICriteriaQuery)P_0).get_Factory();
	}

	internal static object HdRVM5Wt4oGvYXSdrVJo(object P_0, object P_1)
	{
		return ((ISessionFactoryImplementor)P_0).GetEntityPersister((string)P_1);
	}

	internal static object SiWlD5Wt6QTWKBpdB9dF(object P_0)
	{
		return ((IEntityPersister)P_0).get_EntityMetamodel();
	}

	internal static object sSJqtNWtHDwxveQbFlFu(object P_0, object P_1, object P_2)
	{
		return ((ICriteriaQuery)P_0).GetType((ICriteria)P_1, (string)P_2);
	}

	internal static object NG03yvWtAoo1yl9ntoL1(object P_0, object P_1, object P_2)
	{
		return ((SimpleProjection)P_0).GetTypes((ICriteria)P_1, (ICriteriaQuery)P_2);
	}

	internal static object U73JhfWt7pJYnQbXUjTP(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return ((ICriteriaQuery)P_0).GetColumnsForSubclassProperty((ICriteria)P_1, (string)P_2, (string)P_3, (string)P_4);
	}

	internal static object NgPqKyWtxwNZsR2VHoau(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object vmpEStWt0IH5QTmhDBMA(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).GetSqlOrderBy((PropertyMetadata)P_1, (string)P_2);
	}

	internal static object H9PqHQWtmE8AiEj7y8L9(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((string)P_1);
	}

	internal static object oAuD4mWtyDLGLfRbNQ54(object P_0, object P_1, object P_2)
	{
		return ((ICriteriaQuery)P_0).GetColumn((ICriteria)P_1, (string)P_2);
	}

	internal static bool SB1ZFZWtMfm3EdfEWGLF(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
