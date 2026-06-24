using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Cache;
using NHibernate.Cfg;

namespace EleWise.ELMA.Runtime.NH;

public class NHQueryCacheFactoryWrapper : IQueryCacheFactory
{
	private static NHQueryCacheFactoryWrapper uTooeEWDWW0Bwn5N3aYm;

	public NHQueryCacheFactoryWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nkDSKsWDhJbc0DJErjJw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public IQueryCache GetQueryCache(string regionName, UpdateTimestampsCache updateTimestampsCache, Settings settings, IDictionary<string, string> props)
	{
		return (IQueryCache)(object)new NHQueryCacheWrapper(regionName, updateTimestampsCache, settings, props);
	}

	internal static void nkDSKsWDhJbc0DJErjJw()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool LFuk5xWDoTvhB4wEGFMR()
	{
		return uTooeEWDWW0Bwn5N3aYm == null;
	}

	internal static NHQueryCacheFactoryWrapper ziPYSVWDbhrASZyROB4O()
	{
		return uTooeEWDWW0Bwn5N3aYm;
	}
}
