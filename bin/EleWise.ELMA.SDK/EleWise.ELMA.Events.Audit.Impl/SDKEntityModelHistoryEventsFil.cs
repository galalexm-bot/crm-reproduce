using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Events.Audit.Impl;

[Component]
internal class SDKEntityModelHistoryEventsFilter : EntityModelHistoryEventsFilterBase
{
	private static SDKEntityModelHistoryEventsFilter ik3qVkGc5QKW8dItV5nl;

	protected override Type[] ExcludeTypes => new Type[7]
	{
		hiVxwXGcLyG9Rb8f08sJ(typeof(ISchedulerJobRunInfo).TypeHandle),
		hiVxwXGcLyG9Rb8f08sJ(typeof(ISchedulerTaskJob).TypeHandle),
		hiVxwXGcLyG9Rb8f08sJ(typeof(ISchedulerTask).TypeHandle),
		hiVxwXGcLyG9Rb8f08sJ(typeof(IInstanceExpressionPermissionHolder).TypeHandle),
		hiVxwXGcLyG9Rb8f08sJ(typeof(IInstanceSettingsPermissionHolder).TypeHandle),
		hiVxwXGcLyG9Rb8f08sJ(typeof(ICreateFilePreviewQueueItem).TypeHandle),
		typeof(IIndexQueue)
	};

	public SDKEntityModelHistoryEventsFilter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KSYVIkGcUFQF0Oqia2B0();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type hiVxwXGcLyG9Rb8f08sJ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool dufvXdGcjYtKaiAumeyC()
	{
		return ik3qVkGc5QKW8dItV5nl == null;
	}

	internal static SDKEntityModelHistoryEventsFilter NGMO6pGcYjeb4t4tqJ4A()
	{
		return ik3qVkGc5QKW8dItV5nl;
	}

	internal static void KSYVIkGcUFQF0Oqia2B0()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
