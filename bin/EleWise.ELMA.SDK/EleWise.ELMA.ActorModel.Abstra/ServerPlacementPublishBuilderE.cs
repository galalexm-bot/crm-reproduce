using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ActorModel.Abstractions;

public static class ServerPlacementPublishBuilderExtension
{
	public class Publisher<T> where T : IServerPlacementActor
	{
		private readonly IServerPlacementPublishService serverPlacementPublishService;

		private static object PrweYLZEwcchbMsfkpjc;

		internal Publisher(IServerPlacementPublishService serverPlacementPublishService)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					this.serverPlacementPublishService = serverPlacementPublishService;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public Task Publish(Func<T, Task> action, bool ignoreError = false, Action<Guid, Exception> errorAction = null)
		{
			return serverPlacementPublishService.Publish(action, ignoreError, errorAction);
		}

		public Task<IReadOnlyDictionary<Guid, TRes>> Publish<TRes>(Func<T, Task<TRes>> action, bool ignoreError = false, Action<Guid, Exception> errorAction = null)
		{
			return serverPlacementPublishService.Publish(action, ignoreError, errorAction);
		}

		internal static bool jAQ5TQZE4IG5Fb1CDnEE()
		{
			return PrweYLZEwcchbMsfkpjc == null;
		}

		internal static object U0bp0AZE6goFT1NSX9S3()
		{
			return PrweYLZEwcchbMsfkpjc;
		}
	}

	public static Publisher<T> For<T>(this IServerPlacementPublishService serverPlacementPublishService) where T : IServerPlacementActor
	{
		return new Publisher<T>(serverPlacementPublishService);
	}
}
