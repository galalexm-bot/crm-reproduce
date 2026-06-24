using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Loader;
using NHibernate.Loader.Criteria;
using NHibernate.Param;
using NHibernate.Transform;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public class SqlQueryBuilder
{
	private readonly ISession session;

	private static SqlQueryBuilder yrgmuFhYEgYRlhkR4G5Y;

	internal List<List<object>> PartsParametersList { get; set; }

	public SqlQueryBuilder(ISession session)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		lrgZwkhYC8C3g79KSYRo();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				PartsParametersList = new List<List<object>>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				this.session = session;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public string AddPartQuery(ICriteria criteria)
	{
		return AddPartQuery(criteria, null);
	}

	public string AddPartQuery(ICriteria criteria, string rootAlias)
	{
		int num = 2;
		string text = default(string);
		CriteriaLoader loader = default(CriteriaLoader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return (string)BXVZWhhYuHDuCAZnWRhN(text, CriteriaSpecification.RootAlias, rootAlias);
				case 2:
					loader = HibernateHqlAndCriteriaToSqlTranslator.GetLoader(criteria);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					text = D2M3syhYZF2engTmY32g(loader).ToString();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (string.IsNullOrEmpty(rootAlias))
					{
						return text;
					}
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					PartsParametersList.Add(((ISessionImplementor)D1vipphYv90IZkxnTKUK(session)).NullSafeSet(from p in ((CriteriaQueryTranslator)Ae4Gw1hY8QH3EYswJeaJ(loader)).get_CollectedParameters()
						select (IType)_003C_003Ec.UocCuevmlLK8V77O08X3(p), from p in ((CriteriaQueryTranslator)Ae4Gw1hY8QH3EYswJeaJ(loader)).get_CollectedParameters()
						select _003C_003Ec.sx18bovmrAuqv8GCmGha(p)).ToList());
					num = 3;
					break;
				}
				break;
			}
		}
	}

	public ISQLQuery Build<T>(string queryString)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		ISQLQuery val = (ISQLQuery)((IQuery)session.CreateSQLQuery(queryString)).SetResultTransformer(Transformers.AliasToBean(typeof(T))).CleanUpCache(cleanUpCache: false);
		if (PartsParametersList.Count > 0)
		{
			int num = 0;
			{
				foreach (List<object> partsParameters in PartsParametersList)
				{
					if (partsParameters.Count == 0)
					{
						continue;
					}
					foreach (object item in partsParameters)
					{
						((IQuery)val).SetParameter(num, item);
						num++;
					}
				}
				return val;
			}
		}
		return val;
	}

	public string GetAliaseIdentifier(ICriteria criteria, string alias = "this")
	{
		//Discarded unreachable code: IL_00b2, IL_020c, IL_021b, IL_022b, IL_025e, IL_026d
		int num = 5;
		PropertyInfo property = default(PropertyInfo);
		Type type = default(Type);
		string[] array = default(string[]);
		FieldInfo field = default(FieldInfo);
		CriteriaLoader val = default(CriteriaLoader);
		int num3 = default(int);
		IEntityAliases[] array2 = default(IEntityAliases[]);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					property = type.GetProperty((string)moZBhnhYVcLvZObTSX7w(0x7247028A ^ 0x7244A1A0), BindingFlags.Instance | BindingFlags.NonPublic);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 10;
					}
					continue;
				case 8:
					array = (string[])WhhDrqhYRbiqTomZYtrE(field, val);
					num2 = 11;
					continue;
				case 14:
					if (nDlPvghYicbA1WTytGPi(property, null))
					{
						num2 = 10;
						continue;
					}
					goto IL_0297;
				case 7:
					field = type.GetField((string)moZBhnhYVcLvZObTSX7w(-1751176224 ^ -1751349080), BindingFlags.Instance | BindingFlags.NonPublic);
					num2 = 6;
					continue;
				case 21:
					num3++;
					num2 = 20;
					continue;
				case 3:
				case 12:
					if (!toe2HIhYq8PFjTXNF2Sx(array[num3], alias))
					{
						num2 = 17;
						continue;
					}
					goto case 21;
				case 19:
					array2 = (IEntityAliases[])property.GetValue(val, null);
					num = 13;
					break;
				case 22:
					type = ((object)val).GetType();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (BshRdlhYIjWZHqlXKXGZ(alias))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 18;
				case 18:
					val = (CriteriaLoader)wiU2enhYSJNycI7X09LO(criteria);
					num2 = 22;
					continue;
				case 10:
					num4 = -1;
					num2 = 7;
					continue;
				case 1:
				case 2:
				case 9:
					if (num4 != -1)
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto IL_0297;
				case 11:
					num3 = 0;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 16;
					}
					continue;
				case 17:
					num4 = num3;
					num = 2;
					break;
				case 13:
					if (array2.Length != 0)
					{
						num2 = 15;
						continue;
					}
					return (string)moZBhnhYVcLvZObTSX7w(--1360331293 ^ 0x51158343);
				case 15:
					return array2[num4].get_SuffixedKeyAliases()[0];
				case 6:
					if (!(field != null))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 8;
				case 4:
					alias = (string)moZBhnhYVcLvZObTSX7w(0x1FFEF86A ^ 0x1FFD5B74);
					num2 = 18;
					continue;
				case 16:
				case 20:
					{
						if (num3 < array.Length)
						{
							num2 = 3;
							continue;
						}
						goto case 1;
					}
					IL_0297:
					return "";
				}
				break;
			}
		}
	}

	public static string GetCriteriaAlias(ICriteria criteria)
	{
		return (string)PNOdOFhYKyfEXCS0xlUl(Ae4Gw1hY8QH3EYswJeaJ(wiU2enhYSJNycI7X09LO(criteria)));
	}

	public static string EntityTitleProperty(Guid entityUid)
	{
		return EntityTitleProperty(ModelHelper.GetEntityType(entityUid));
	}

	public static string EntityTitleProperty(Type entityType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (JxpARkhYXopnwbLfhUZU(entityType, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)VZ7MR4hYkmbMe8dsvqnX(H0TY3FhYTQfQuqReW7DY((EntityMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.TypeOf(entityType))));
			default:
				return null;
			}
		}
	}

	public static string EntityTitleProperty<T>()
	{
		return EntityTitleProperty(typeof(T));
	}

	private static string EntityTitlePropertyString(object entityTitleProperty)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (entityTitleProperty != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return null;
			default:
				return (string)KksFqvhYnAaDt7hCjxSG((SimpleTypeSettings)((IPropertyMetadata)entityTitleProperty).Settings);
			}
		}
	}

	internal static void lrgZwkhYC8C3g79KSYRo()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool pgmJsChYf11wv1X6X4bl()
	{
		return yrgmuFhYEgYRlhkR4G5Y == null;
	}

	internal static SqlQueryBuilder M1wZSJhYQGDv0PircNoE()
	{
		return yrgmuFhYEgYRlhkR4G5Y;
	}

	internal static object D1vipphYv90IZkxnTKUK(object P_0)
	{
		return ((ISession)P_0).GetSessionImplementation();
	}

	internal static object Ae4Gw1hY8QH3EYswJeaJ(object P_0)
	{
		return ((CriteriaLoader)P_0).get_Translator();
	}

	internal static object D2M3syhYZF2engTmY32g(object P_0)
	{
		return ((Loader)P_0).get_SqlString();
	}

	internal static object BXVZWhhYuHDuCAZnWRhN(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static bool BshRdlhYIjWZHqlXKXGZ(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object moZBhnhYVcLvZObTSX7w(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object wiU2enhYSJNycI7X09LO(object P_0)
	{
		return HibernateHqlAndCriteriaToSqlTranslator.GetLoader((ICriteria)P_0);
	}

	internal static bool nDlPvghYicbA1WTytGPi(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static object WhhDrqhYRbiqTomZYtrE(object P_0, object P_1)
	{
		return ((FieldInfo)P_0).GetValue(P_1);
	}

	internal static bool toe2HIhYq8PFjTXNF2Sx(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object PNOdOFhYKyfEXCS0xlUl(object P_0)
	{
		return ((CriteriaQueryTranslator)P_0).get_RootSQLAlias();
	}

	internal static bool JxpARkhYXopnwbLfhUZU(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object H0TY3FhYTQfQuqReW7DY(object P_0)
	{
		return ((ClassMetadata)P_0).GetTitleProperty();
	}

	internal static object VZ7MR4hYkmbMe8dsvqnX(object P_0)
	{
		return EntityTitlePropertyString(P_0);
	}

	internal static object KksFqvhYnAaDt7hCjxSG(object P_0)
	{
		return ((SimpleTypeSettings)P_0).FieldName;
	}
}
