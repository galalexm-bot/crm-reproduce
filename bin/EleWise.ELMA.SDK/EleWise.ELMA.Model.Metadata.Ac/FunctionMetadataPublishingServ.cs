using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Model.Events.Publication;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.Actors;

internal sealed class FunctionMetadataPublishingServerInstanceActor : Actor, IFunctionMetadataPublishingServerInstanceActor, IServerPlacementActor, IActorWithGuidKey, IActor
{
	private readonly IFunctionMetadataPublishingEventHandler functionMetadataPublishingEventHandler;

	private static FunctionMetadataPublishingServerInstanceActor lWwPlJbLFEmWxLC0J4UR;

	public FunctionMetadataPublishingServerInstanceActor(IFunctionMetadataPublishingEventHandler functionMetadataPublishingEventHandler)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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
			this.functionMetadataPublishingEventHandler = functionMetadataPublishingEventHandler;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
			{
				num = 1;
			}
		}
	}

	public Task PublicationSuccess(Guid functionMetadataUid, UIMetadataPublishResult result)
	{
		return (Task)MNCc3UbLoD5FFK7IO7PO(functionMetadataPublishingEventHandler, functionMetadataUid, result);
	}

	public Task PublicationError(Guid functionMetadataUid, Exception exception)
	{
		return (Task)qA0GCUbLbZ1jyKWwMtFi(functionMetadataPublishingEventHandler, functionMetadataUid, exception);
	}

	internal static bool p49sPTbLBsJ3Ukwa0qeX()
	{
		return lWwPlJbLFEmWxLC0J4UR == null;
	}

	internal static FunctionMetadataPublishingServerInstanceActor fXauF1bLWxbA925onOo7()
	{
		return lWwPlJbLFEmWxLC0J4UR;
	}

	internal static object MNCc3UbLoD5FFK7IO7PO(object P_0, Guid functionMetadataUid, object P_2)
	{
		return ((IFunctionMetadataPublishingEventHandler)P_0).Complete(functionMetadataUid, (UIMetadataPublishResult)P_2);
	}

	internal static object qA0GCUbLbZ1jyKWwMtFi(object P_0, Guid functionMetadataUid, object P_2)
	{
		return ((IFunctionMetadataPublishingEventHandler)P_0).Error(functionMetadataUid, (Exception)P_2);
	}
}
