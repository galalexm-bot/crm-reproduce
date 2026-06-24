using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Model.Events.Publication;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.Actors;

internal sealed class DataClassMetadataPublishingServerInstanceActor : Actor, IDataClassMetadataPublishingServerInstanceActor, IServerPlacementActor, IActorWithGuidKey, IActor
{
	private readonly IDataClassMetadataPublishingEventHandler dataClassMetadataPublishingEventHandler;

	internal static DataClassMetadataPublishingServerInstanceActor j8nk1IbYKY6pFfS6K1ON;

	public DataClassMetadataPublishingServerInstanceActor(IDataClassMetadataPublishingEventHandler dataClassMetadataPublishingEventHandler)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.dataClassMetadataPublishingEventHandler = dataClassMetadataPublishingEventHandler;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
			{
				num = 1;
			}
		}
	}

	public Task Complete(Guid publicationToken, UIMetadataPublishResult result)
	{
		return (Task)I2bNjdbYkj1EJNJr3AO7(dataClassMetadataPublishingEventHandler, publicationToken, result);
	}

	public Task Error(Guid publicationToken, Exception exception)
	{
		return (Task)RgkbjYbYn2pnMHQwWwnV(dataClassMetadataPublishingEventHandler, publicationToken, exception);
	}

	internal static bool IJCUUxbYXAtKwUsvhwWZ()
	{
		return j8nk1IbYKY6pFfS6K1ON == null;
	}

	internal static DataClassMetadataPublishingServerInstanceActor DruahVbYTs4D18UZFoEg()
	{
		return j8nk1IbYKY6pFfS6K1ON;
	}

	internal static object I2bNjdbYkj1EJNJr3AO7(object P_0, Guid publicationToken, object P_2)
	{
		return ((IDataClassMetadataPublishingEventHandler)P_0).Complete(publicationToken, (UIMetadataPublishResult)P_2);
	}

	internal static object RgkbjYbYn2pnMHQwWwnV(object P_0, Guid publicationToken, object P_2)
	{
		return ((IDataClassMetadataPublishingEventHandler)P_0).Error(publicationToken, (Exception)P_2);
	}
}
