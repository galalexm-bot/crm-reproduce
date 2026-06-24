using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Impl;
using NHibernate.Loader;
using NHibernate.Loader.Criteria;
using NHibernate.Persister.Entity;

namespace EleWise.ELMA.Helpers;

public class HibernateHqlAndCriteriaToSqlTranslator
{
	internal static HibernateHqlAndCriteriaToSqlTranslator O4kBGNhUJBUJxHip0JJ4;

	public static string ToSql(ICriteria criteria)
	{
		return ((object)((Loader)WEqmqXhUlyXFgj2i4RoT(criteria)).get_SqlString()).ToString();
	}

	public static CriteriaImpl GetCriteriaImpl(ICriteria criteria)
	{
		//Discarded unreachable code: IL_003d, IL_004c, IL_0071, IL_0080
		int num = 4;
		CriteriaImpl val = default(CriteriaImpl);
		DetachedCriteriaAdapter detachedCriteriaAdapter = default(DetachedCriteriaAdapter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (val == null)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 5:
					if (detachedCriteriaAdapter == null)
					{
						num2 = 2;
						break;
					}
					goto default;
				default:
					return GetCriteriaImpl((ICriteria)vep3oKhUgJkpR9DSjS5K(detachedCriteriaAdapter.DetachedCriteria, aHIVjhhUrLexZcHQSc3G(detachedCriteriaAdapter)));
				case 2:
					return null;
				case 1:
					return val;
				case 6:
					detachedCriteriaAdapter = criteria as DetachedCriteriaAdapter;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 5;
					}
					break;
				case 4:
					val = (CriteriaImpl)(object)((criteria is CriteriaImpl) ? criteria : null);
					num2 = 3;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	public static CriteriaLoader GetLoader(ICriteria criteria)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		int num = 3;
		ISessionFactoryImplementor val3 = default(ISessionFactoryImplementor);
		SessionImpl val2 = default(SessionImpl);
		string[] array = default(string[]);
		CriteriaImpl val = default(CriteriaImpl);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					val3 = (ISessionFactoryImplementor)XHWp2ThUY88XaX1RJp4x(val2);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					return new CriteriaLoader((IOuterJoinLoadable)pccO1shUs0Oma50tid0C(val3, array[0]), val3, val, array[0], ((AbstractSessionImpl)val2).get_EnabledFilters());
				case 1:
					array = (string[])Cps5ZDhUUF2AyqvhnrF4(val3, uZBQOIhULebEQkh8ZceI(val));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					val2 = (SessionImpl)DhShA8hUjigYlHmC14tQ(val);
					num2 = 4;
					continue;
				case 3:
					break;
				}
				break;
			}
			val = (CriteriaImpl)qX3ukjhU5GjUDpNXYp2Y(criteria);
			num = 2;
		}
	}

	public HibernateHqlAndCriteriaToSqlTranslator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Umt6oehUcPAik0nyatQo();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object WEqmqXhUlyXFgj2i4RoT(object P_0)
	{
		return GetLoader((ICriteria)P_0);
	}

	internal static bool Fthlv5hU9FCM2VGfGBqq()
	{
		return O4kBGNhUJBUJxHip0JJ4 == null;
	}

	internal static HibernateHqlAndCriteriaToSqlTranslator GflHZMhUdgJTAUXTnnMu()
	{
		return O4kBGNhUJBUJxHip0JJ4;
	}

	internal static object aHIVjhhUrLexZcHQSc3G(object P_0)
	{
		return ((DetachedCriteriaAdapter)P_0).Session;
	}

	internal static object vep3oKhUgJkpR9DSjS5K(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).GetExecutableCriteria((ISession)P_1);
	}

	internal static object qX3ukjhU5GjUDpNXYp2Y(object P_0)
	{
		return GetCriteriaImpl((ICriteria)P_0);
	}

	internal static object DhShA8hUjigYlHmC14tQ(object P_0)
	{
		return ((CriteriaImpl)P_0).get_Session();
	}

	internal static object XHWp2ThUY88XaX1RJp4x(object P_0)
	{
		return ((SessionImpl)P_0).get_SessionFactory();
	}

	internal static object uZBQOIhULebEQkh8ZceI(object P_0)
	{
		return ((CriteriaImpl)P_0).get_EntityOrClassName();
	}

	internal static object Cps5ZDhUUF2AyqvhnrF4(object P_0, object P_1)
	{
		return ((ISessionFactoryImplementor)P_0).GetImplementors((string)P_1);
	}

	internal static object pccO1shUs0Oma50tid0C(object P_0, object P_1)
	{
		return ((ISessionFactoryImplementor)P_0).GetEntityPersister((string)P_1);
	}

	internal static void Umt6oehUcPAik0nyatQo()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
