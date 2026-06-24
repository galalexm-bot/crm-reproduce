using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.SqlCommand;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

[Serializable]
public class EqExpression : AbstractCriterion
{
	private static readonly TypedValue[] NoTypedValues;

	private readonly string _lhsPropertyName;

	private readonly string _rhsPropertyName;

	private readonly object _rhsValue;

	private readonly IEntityPropertyMetadata _lhsPropertyMetadata;

	private readonly IEntityPropertyMetadata _rhsPropertyMetadata;

	internal static EqExpression N4x2CBWDvnjFW7aBF7HH;

	public EqExpression(string alias, string lhsPropertyName, string rhsPropertyName, EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_0089, IL_008e
		M7iynTWDunyZA3WpjNSf();
		this._002Ector((string)(string.IsNullOrWhiteSpace(alias) ? lhsPropertyName : LT7wx7WDIZMJDy8G9H0t(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C00479), alias, lhsPropertyName)), metadata, (string)(string.IsNullOrWhiteSpace(alias) ? rhsPropertyName : LT7wx7WDIZMJDy8G9H0t(GxUXZHWDVGWiYeFlK4Fs(-576149596 ^ -576133722), alias, rhsPropertyName)), metadata);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public EqExpression(string lhsPropertyName, EntityMetadata lhsMetadata, string rhsPropertyName, EntityMetadata rhsMetadata)
	{
		//Discarded unreachable code: IL_0050, IL_0055, IL_01c5, IL_01d4, IL_01e3
		SingletonReader.JJCZtPuTvSt();
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals0.lhsPropertyName = lhsPropertyName;
		CS_0024_003C_003E8__locals0.rhsPropertyName = rhsPropertyName;
		((AbstractCriterion)this)._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
		{
			num = 1;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 12:
				CS_0024_003C_003E8__locals0.lhsPropertyName = (string)QySHnhWDib0LExKc7FCo(CS_0024_003C_003E8__locals0.lhsPropertyName, num2 + 1);
				num = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num = 0;
				}
				break;
			case 7:
				if (num2 < 0)
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num = 3;
					}
					break;
				}
				goto case 10;
			case 1:
				_lhsPropertyName = CS_0024_003C_003E8__locals0.lhsPropertyName;
				num = 6;
				break;
			case 9:
				return;
			case 10:
				CS_0024_003C_003E8__locals0.rhsPropertyName = (string)QySHnhWDib0LExKc7FCo(CS_0024_003C_003E8__locals0.rhsPropertyName, num2 + 1);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num = 0;
				}
				break;
			case 6:
				num2 = mS9lMuWDSpdfvulALSmO(CS_0024_003C_003E8__locals0.lhsPropertyName, '.');
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num = 2;
				}
				break;
			case 4:
				_rhsPropertyName = CS_0024_003C_003E8__locals0.rhsPropertyName;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num = 11;
				}
				break;
			case 2:
				if (num2 < 0)
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num = 5;
					}
					break;
				}
				goto case 12;
			case 11:
				num2 = mS9lMuWDSpdfvulALSmO(CS_0024_003C_003E8__locals0.rhsPropertyName, '.');
				num = 7;
				break;
			case 5:
			case 8:
				_lhsPropertyMetadata = ((IEntityPropertyMetadata)lhsMetadata.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass7_0.C6NvDLQ95HOZ4PANv3wk(_003C_003Ec__DisplayClass7_0.FYDXk1Q9gpsxcx3dNGTo(p), CS_0024_003C_003E8__locals0.lhsPropertyName))) ?? lhsMetadata.TableParts.FirstOrDefault((TablePartMetadata tp) => _003C_003Ec__DisplayClass7_0.C6NvDLQ95HOZ4PANv3wk(_003C_003Ec__DisplayClass7_0.vwUL4wQ9jYBZbfLRop0p(tp), CS_0024_003C_003E8__locals0.lhsPropertyName));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num = 4;
				}
				break;
			default:
				_rhsPropertyMetadata = ((IEntityPropertyMetadata)rhsMetadata.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass7_0.C6NvDLQ95HOZ4PANv3wk(_003C_003Ec__DisplayClass7_0.FYDXk1Q9gpsxcx3dNGTo(p), CS_0024_003C_003E8__locals0.rhsPropertyName))) ?? rhsMetadata.TableParts.FirstOrDefault((TablePartMetadata tp) => _003C_003Ec__DisplayClass7_0.C6NvDLQ95HOZ4PANv3wk(_003C_003Ec__DisplayClass7_0.vwUL4wQ9jYBZbfLRop0p(tp), CS_0024_003C_003E8__locals0.rhsPropertyName));
				num = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num = 9;
				}
				break;
			}
		}
	}

	public EqExpression(string alias, string lhsPropertyName, EntityMetadata metadata, object rhsValue)
	{
		//Discarded unreachable code: IL_0060, IL_0065
		M7iynTWDunyZA3WpjNSf();
		this._002Ector((string)(djPDNaWDRSpQuktgf97s(alias) ? lhsPropertyName : LT7wx7WDIZMJDy8G9H0t(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C94D7B6), alias, lhsPropertyName)), metadata, rhsValue);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public EqExpression(string lhsPropertyName, EntityMetadata metadata, object rhsValue)
	{
		//Discarded unreachable code: IL_0033, IL_0038
		M7iynTWDunyZA3WpjNSf();
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals0.lhsPropertyName = lhsPropertyName;
		((AbstractCriterion)this)._002Ector();
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
				num2 = mS9lMuWDSpdfvulALSmO(CS_0024_003C_003E8__locals0.lhsPropertyName, '.');
				num = 4;
				continue;
			case 3:
				_lhsPropertyName = CS_0024_003C_003E8__locals0.lhsPropertyName;
				num = 2;
				continue;
			case 4:
				if (num2 >= 0)
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num = 1;
					}
					continue;
				}
				break;
			default:
				_rhsValue = rhsValue;
				num = 6;
				continue;
			case 6:
				return;
			case 1:
				CS_0024_003C_003E8__locals0.lhsPropertyName = CS_0024_003C_003E8__locals0.lhsPropertyName.Substring(num2 + 1);
				num = 5;
				continue;
			case 5:
				break;
			}
			_lhsPropertyMetadata = ((IEntityPropertyMetadata)metadata.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass9_0.W88EnLQ9cMakgyFwWvfS(p.Name, CS_0024_003C_003E8__locals0.lhsPropertyName))) ?? metadata.TableParts.FirstOrDefault((TablePartMetadata tp) => _003C_003Ec__DisplayClass9_0.W88EnLQ9cMakgyFwWvfS(_003C_003Ec__DisplayClass9_0.sxV3VYQ9zf6rmu75aabo(tp), CS_0024_003C_003E8__locals0.lhsPropertyName));
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
			{
				num = 0;
			}
		}
	}

	public override SqlString ToSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		//Discarded unreachable code: IL_0142, IL_01b3, IL_032e, IL_0353, IL_041d, IL_042c, IL_0464, IL_0473, IL_04fb, IL_050a, IL_0541, IL_0550, IL_0560, IL_05af, IL_05f8, IL_064b, IL_065a, IL_0669, IL_075a, IL_0769, IL_0779, IL_0788, IL_07c3, IL_07d2, IL_07e1
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected O, but got Unknown
		int num = 44;
		int num3 = default(int);
		SqlStringBuilder val2 = default(SqlStringBuilder);
		SqlString[] columnNames = default(SqlString[]);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		IRuntimeApplication serviceNotNull = default(IRuntimeApplication);
		SqlString[] array3 = default(SqlString[]);
		Parameter[] array = default(Parameter[]);
		IType val = default(IType);
		int num4 = default(int);
		SqlString[] array2 = default(SqlString[]);
		IProjection val3 = default(IProjection);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 31:
					num3 = 0;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 14;
					}
					continue;
				case 28:
				case 41:
					if (num3 > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 50;
				case 27:
					if (_lhsPropertyMetadata != null)
					{
						num2 = 18;
						continue;
					}
					goto case 29;
				case 47:
					val2 = new SqlStringBuilder();
					num2 = 9;
					continue;
				case 38:
					if (DVMoKuWDqUKH28oqYqns(_rhsPropertyName))
					{
						num2 = 59;
						continue;
					}
					columnNames = CriterionUtil.GetColumnNames(_lhsPropertyName, (IProjection)null, _003C_003Ec__DisplayClass10_.criteriaQuery, criteria);
					num2 = 39;
					continue;
				case 10:
					serviceNotNull = Locator.GetServiceNotNull<IRuntimeApplication>();
					num2 = 47;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 14;
					}
					continue;
				case 22:
				case 34:
					return val2.ToSqlString();
				case 14:
				case 16:
					if (num3 < array3.Length)
					{
						num2 = 28;
						continue;
					}
					goto case 7;
				case 36:
					if (array.Any())
					{
						num2 = 31;
						continue;
					}
					goto case 7;
				case 4:
					throw new QueryException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487249722), TlOboxWDkcEW79248k6t(_003C_003Ec__DisplayClass10_.criteriaQuery, criteria), _lhsPropertyName));
				case 2:
				case 15:
				case 26:
					if (!(_rhsValue is string))
					{
						num = 25;
						break;
					}
					goto case 35;
				case 59:
					val = (IType)KpN8kjWDKSIqnCsiSBGH(_003C_003Ec__DisplayClass10_.criteriaQuery, criteria, _lhsPropertyName);
					num2 = 53;
					continue;
				case 17:
					if (num4 <= 0)
					{
						num2 = 61;
						continue;
					}
					goto case 33;
				case 50:
					CqFPr2WDP6nLpQPe9rOD(c7FU7cWDeN0DY7yZFL07(val2.Add(array3[num3]), GxUXZHWDVGWiYeFlK4Fs(-1217523399 ^ -1217415771)), array[num3]);
					num2 = 19;
					continue;
				case 6:
				case 58:
					throw new QueryException(string.Format((string)GxUXZHWDVGWiYeFlK4Fs(-1978478350 ^ -1978609962), nGX6oBWDTvHqGv3y5OoK(this), _lhsPropertyName, W6bnsUWDXNICG8h8ujMZ(val), _rhsValue.GetType()));
				case 23:
				case 30:
				case 45:
					if (!val.get_IsCollectionType())
					{
						num2 = 26;
						continue;
					}
					goto case 4;
				case 18:
				case 56:
					if (DtRaYxWDnvSQNcxYRdIv(serviceNotNull) == null)
					{
						num2 = 20;
						continue;
					}
					goto case 5;
				case 32:
				case 63:
					num4 = 0;
					num2 = 24;
					continue;
				case 43:
					_003C_003Ec__DisplayClass10_.criteriaQuery = criteriaQuery;
					num2 = 10;
					continue;
				case 51:
					if (W6bnsUWDXNICG8h8ujMZ(val).IsInstanceOfType(_rhsValue))
					{
						num2 = 30;
						continue;
					}
					goto case 60;
				case 7:
					return (SqlString)vfpq8aWD1O8FfPZHLRK1(val2);
				case 44:
					_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 43;
					}
					continue;
				case 48:
					c7FU7cWDeN0DY7yZFL07(val2, GxUXZHWDVGWiYeFlK4Fs(0x31326106 ^ 0x31327EBA));
					num2 = 34;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 18;
					}
					continue;
				default:
					val2.Add((string)GxUXZHWDVGWiYeFlK4Fs(0xA592A41 ^ 0xA588EE7));
					num2 = 50;
					continue;
				case 19:
					num3++;
					num2 = 16;
					continue;
				case 60:
					if (!W6bnsUWDXNICG8h8ujMZ(val).IsInheritOrSame<IEntity<long>>())
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 64;
				case 5:
					return ((IMainDatabaseProvider)DtRaYxWDnvSQNcxYRdIv(serviceNotNull)).EqualToSqlString(criteria, _003C_003Ec__DisplayClass10_.criteriaQuery, columnNames, _lhsPropertyMetadata, array2, _rhsPropertyMetadata);
				case 20:
					if (columnNames.Length <= 1)
					{
						num = 32;
						break;
					}
					goto case 54;
				case 12:
					if (!(_rhsValue is int))
					{
						num2 = 21;
						continue;
					}
					goto case 2;
				case 9:
					val3 = null;
					num2 = 38;
					continue;
				case 21:
					if (!val.get_ReturnedClass().IsInheritOrSame<EnumBase>())
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 40;
				case 29:
					if (_rhsPropertyMetadata != null)
					{
						num2 = 56;
						continue;
					}
					goto case 20;
				case 39:
					array2 = (SqlString[])OFUBonWDNwk0oIR4CWcS(_rhsPropertyName, val3, _003C_003Ec__DisplayClass10_.criteriaQuery, criteria);
					num2 = 27;
					continue;
				case 24:
				case 42:
					if (num4 >= columnNames.Length)
					{
						num = 52;
						break;
					}
					goto case 17;
				case 64:
					if (!(_rhsValue is long))
					{
						num2 = 62;
						continue;
					}
					goto case 2;
				case 49:
					if (_rhsValue is long)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 12;
				case 35:
					if (_lhsPropertyMetadata == null)
					{
						num2 = 37;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 32;
						}
						continue;
					}
					goto case 57;
				case 53:
					if (_rhsValue == null)
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 11;
				case 40:
					if (_rhsValue is Guid)
					{
						num2 = 2;
						continue;
					}
					goto case 6;
				case 1:
				case 61:
					BOn8nPWDpE31bJWW0gAX(val2, ((SqlStringBuilder)c7FU7cWDeN0DY7yZFL07(Y5L07QWD36hYr6FNUsCo((object)new SqlStringBuilder(), columnNames[num4]), GxUXZHWDVGWiYeFlK4Fs(0x5F3078B6 ^ 0x5F31DC2A))).Add(array2[num4]).ToSqlString());
					num2 = 13;
					continue;
				case 54:
					c7FU7cWDeN0DY7yZFL07(val2, GxUXZHWDVGWiYeFlK4Fs(0x7C1EE318 ^ 0x7C1EFCAE));
					num2 = 60;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 63;
					}
					continue;
				case 8:
					if (val.get_ReturnedClass().IsInheritOrSame<IEntity<int>>())
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 64;
						}
						continue;
					}
					goto case 46;
				case 13:
					num4++;
					num2 = 42;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 20;
					}
					continue;
				case 62:
					if (!(_rhsValue is int))
					{
						num2 = 46;
						continue;
					}
					goto case 2;
				case 57:
					if (serviceNotNull.MainProvider != null)
					{
						num2 = 40;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 55;
						}
						continue;
					}
					goto case 25;
				case 52:
					if (columnNames.Length <= 1)
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto case 48;
				case 46:
					if (W6bnsUWDXNICG8h8ujMZ(val).IsInheritOrSame<Enum>())
					{
						num = 49;
						break;
					}
					goto case 21;
				case 3:
					array = ((IEnumerable<TypedValue>)sYGaHfWD2wZSrTorDFix(this, criteria, _003C_003Ec__DisplayClass10_.criteriaQuery)).SelectMany(_003C_003Ec__DisplayClass10_._003CToSqlString_003Eb__1).ToArray();
					num2 = 36;
					continue;
				case 33:
					c7FU7cWDeN0DY7yZFL07(val2, GxUXZHWDVGWiYeFlK4Fs(-1939377524 ^ -1939417558));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 1;
					}
					continue;
				case 11:
					if (_rhsValue is Type)
					{
						num = 45;
						break;
					}
					goto case 51;
				case 55:
					return ((IMainDatabaseProvider)DtRaYxWDnvSQNcxYRdIv(serviceNotNull)).EqualToSqlString(criteria, _003C_003Ec__DisplayClass10_.criteriaQuery, _lhsPropertyName, _lhsPropertyMetadata, _rhsValue);
				case 25:
				case 37:
					array3 = Array.ConvertAll((string[])zBRWjBWDOVLEV9mgxhsJ(_003C_003Ec__DisplayClass10_.criteriaQuery, criteria, _lhsPropertyName), (Converter<string, SqlString>)((string col) => new SqlString(col)));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
		}
	}

	public override TypedValue[] GetTypedValues(ICriteria criteria, ICriteriaQuery criteriaQuery)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (DVMoKuWDqUKH28oqYqns(_rhsPropertyName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return NoTypedValues;
			default:
				return (TypedValue[])ONrxlKWDaRrNfdbovQFb(criteriaQuery, criteria, null, _lhsPropertyName, new object[1] { _rhsValue });
			}
		}
	}

	public override string ToString()
	{
		return (string)i05vDVWDD4BBQ4p6oQkd(_lhsPropertyName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B370F95), (!string.IsNullOrEmpty(_rhsPropertyName)) ? _rhsPropertyName : _rhsValue);
	}

	public override IProjection[] GetProjections()
	{
		return null;
	}

	static EqExpression()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				NoTypedValues = (TypedValue[])(object)new TypedValue[0];
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				M7iynTWDunyZA3WpjNSf();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void M7iynTWDunyZA3WpjNSf()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object LT7wx7WDIZMJDy8G9H0t(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object GxUXZHWDVGWiYeFlK4Fs(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool wbGkDuWD8KLLrlZrlUvv()
	{
		return N4x2CBWDvnjFW7aBF7HH == null;
	}

	internal static EqExpression T4EtUQWDZO2LTJvt4mxk()
	{
		return N4x2CBWDvnjFW7aBF7HH;
	}

	internal static int mS9lMuWDSpdfvulALSmO(object P_0, char P_1)
	{
		return ((string)P_0).LastIndexOf(P_1);
	}

	internal static object QySHnhWDib0LExKc7FCo(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static bool djPDNaWDRSpQuktgf97s(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static bool DVMoKuWDqUKH28oqYqns(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object KpN8kjWDKSIqnCsiSBGH(object P_0, object P_1, object P_2)
	{
		return ((ICriteriaQuery)P_0).GetTypeUsingProjection((ICriteria)P_1, (string)P_2);
	}

	internal static Type W6bnsUWDXNICG8h8ujMZ(object P_0)
	{
		return ((IType)P_0).get_ReturnedClass();
	}

	internal static Type nGX6oBWDTvHqGv3y5OoK(object P_0)
	{
		return P_0.GetType();
	}

	internal static object TlOboxWDkcEW79248k6t(object P_0, object P_1)
	{
		return ((ICriteriaQuery)P_0).GetEntityName((ICriteria)P_1);
	}

	internal static object DtRaYxWDnvSQNcxYRdIv(object P_0)
	{
		return ((IRuntimeApplication)P_0).MainProvider;
	}

	internal static object zBRWjBWDOVLEV9mgxhsJ(object P_0, object P_1, object P_2)
	{
		return ((ICriteriaQuery)P_0).GetColumnsUsingProjection((ICriteria)P_1, (string)P_2);
	}

	internal static object sYGaHfWD2wZSrTorDFix(object P_0, object P_1, object P_2)
	{
		return ((AbstractCriterion)P_0).GetTypedValues((ICriteria)P_1, (ICriteriaQuery)P_2);
	}

	internal static object c7FU7cWDeN0DY7yZFL07(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((string)P_1);
	}

	internal static object CqFPr2WDP6nLpQPe9rOD(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((Parameter)P_1);
	}

	internal static object vfpq8aWD1O8FfPZHLRK1(object P_0)
	{
		return ((SqlStringBuilder)P_0).ToSqlString();
	}

	internal static object OFUBonWDNwk0oIR4CWcS(object P_0, object P_1, object P_2, object P_3)
	{
		return CriterionUtil.GetColumnNames((string)P_0, (IProjection)P_1, (ICriteriaQuery)P_2, (ICriteria)P_3);
	}

	internal static object Y5L07QWD36hYr6FNUsCo(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((SqlString)P_1);
	}

	internal static object BOn8nPWDpE31bJWW0gAX(object P_0, object P_1)
	{
		return ((SqlStringBuilder)P_0).Add((SqlString)P_1);
	}

	internal static object ONrxlKWDaRrNfdbovQFb(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return CriterionUtil.GetTypedValues((ICriteriaQuery)P_0, (ICriteria)P_1, (IProjection)P_2, (string)P_3, (object[])P_4);
	}

	internal static object i05vDVWDD4BBQ4p6oQkd(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}
}
