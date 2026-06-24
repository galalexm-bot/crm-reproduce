using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UI.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.Actors;

internal sealed class DataClassesMetadataPublishingActor : DataClassMetadataPublishingActorBase, IDataClassesMetadataPublishingActor, IActorWithGuidKey, IActor
{
	internal static DataClassesMetadataPublishingActor uJwYo1bjkJQahN5TWY1Z;

	public DataClassesMetadataPublishingActor(ILoggerFactory loggerFactory, IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager, ICheckDataClassService checkDataClassService, ISearchMetadataService searchMetadataService, IDataClassAssemblyBuilderService dataClassAssemblyBuilderService, IDataClassMetadataItemManager dataClassMetadataItemManager, IDataClassTypeReferenceManager dataClassTypeReferenceManager, ISessionProvider sessionProvider, IUnitOfWorkManager unitOfWorkManager, IServerPlacementPublishService serverPlacementPublishService, ISearchFormServiceInternal searchFormService)
	{
		//Discarded unreachable code: IL_004c, IL_0051
		ghUflLbj2TphvsFXn8sk();
		base._002Ector((ILogger)q4V4VdbjPT6sxpEPFaAp(loggerFactory, r4MfgXbjeogClvjfC6e9(typeof(DataClassesMetadataPublishingActor).TypeHandle)), dataClassMetadataItemHeaderManager, checkDataClassService, searchMetadataService, dataClassAssemblyBuilderService, dataClassMetadataItemManager, dataClassTypeReferenceManager, sessionProvider, unitOfWorkManager, serverPlacementPublishService, searchFormService);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[AsyncStateMachine(typeof(_003CPublish_003Ed__1))]
	public Task<Guid> Publish(Guid[] dataClassMetadataHeadersUid, string comment)
	{
		_003CPublish_003Ed__1 stateMachine = default(_003CPublish_003Ed__1);
		stateMachine._003C_003E4__this = this;
		stateMachine.dataClassMetadataHeadersUid = dataClassMetadataHeadersUid;
		stateMachine.comment = comment;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Guid>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<Guid> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public Task PublishComplete()
	{
		return Complete();
	}

	internal static void ghUflLbj2TphvsFXn8sk()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type r4MfgXbjeogClvjfC6e9(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object q4V4VdbjPT6sxpEPFaAp(object P_0, Type type)
	{
		return ((ILoggerFactory)P_0).CreateLogger(type);
	}

	internal static bool OEdoc6bjn4SK9Md8PSh3()
	{
		return uJwYo1bjkJQahN5TWY1Z == null;
	}

	internal static DataClassesMetadataPublishingActor yqkZxYbjO6BBHWTmIImw()
	{
		return uJwYo1bjkJQahN5TWY1Z;
	}
}
