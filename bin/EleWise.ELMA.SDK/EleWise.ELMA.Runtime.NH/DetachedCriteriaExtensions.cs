using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Runtime.NH;

public static class DetachedCriteriaExtensions
{
	private static DetachedCriteriaExtensions grSHAQWpaQMlKveRF7fv;

	public static ICriteria Adapt(this DetachedCriteria criteria, ISession session)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (criteria == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (ICriteria)(object)new DetachedCriteriaAdapter(criteria, session);
			default:
				return null;
			}
		}
	}

	internal static bool YSaF3BWpDlfZqmcO6AZe()
	{
		return grSHAQWpaQMlKveRF7fv == null;
	}

	internal static DetachedCriteriaExtensions uNRMZ1Wpt29bfIbM5KBX()
	{
		return grSHAQWpaQMlKveRF7fv;
	}
}
