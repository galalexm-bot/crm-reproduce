using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ActorModel.NHCacheWrapper;

internal sealed class NHCacheWrapperSynchronizer : Actor, INHCacheWrapperSynchronizer, IServerPlacementActor, IActorWithGuidKey, IActor
{
	internal static NHCacheWrapperSynchronizer M8Hcn4faMM2rMGlRVk1x;

	public Task DisableCache(IList<string> regions)
	{
		foreach (string region in regions)
		{
			if (region != null && NHCacheProviderWrapper.TryGetCache(region, out var cache))
			{
				cache?.Disable();
			}
		}
		return Task.CompletedTask;
	}

	public Task EnableCache(IList<string> regions)
	{
		foreach (string region in regions)
		{
			if (region != null && NHCacheProviderWrapper.TryGetCache(region, out var cache))
			{
				cache?.Enable();
			}
		}
		return Task.CompletedTask;
	}

	public NHCacheWrapperSynchronizer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xjQIWwfadSdbXLneHTdt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void xjQIWwfadSdbXLneHTdt()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool IcvdWkfaJDy5XyvdvSwS()
	{
		return M8Hcn4faMM2rMGlRVk1x == null;
	}

	internal static NHCacheWrapperSynchronizer Ie0B0Gfa9QXUOlMSlj6u()
	{
		return M8Hcn4faMM2rMGlRVk1x;
	}
}
