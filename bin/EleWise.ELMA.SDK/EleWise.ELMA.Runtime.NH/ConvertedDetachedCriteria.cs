using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Impl;

namespace EleWise.ELMA.Runtime.NH;

public class ConvertedDetachedCriteria : DetachedCriteria
{
	private static ConvertedDetachedCriteria uLPbIeWDGH1E6NMDq1wY;

	public ConvertedDetachedCriteria(ICriteria criteria)
	{
		//Discarded unreachable code: IL_0031, IL_0036
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		lsGGBTWDQaylkrEn2enb();
		((DetachedCriteria)this)._002Ector((CriteriaImpl)criteria, criteria);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				gZ2A5nWDCOangUykZFbA((object)(CriteriaImpl)criteria, null);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void lsGGBTWDQaylkrEn2enb()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void gZ2A5nWDCOangUykZFbA(object P_0, object P_1)
	{
		((CriteriaImpl)P_0).set_Session((ISessionImplementor)P_1);
	}

	internal static bool emh5khWDEqW9e1ilrVtP()
	{
		return uLPbIeWDGH1E6NMDq1wY == null;
	}

	internal static ConvertedDetachedCriteria yk9kOxWDfJW5NxxTbS9N()
	{
		return uLPbIeWDGH1E6NMDq1wY;
	}
}
