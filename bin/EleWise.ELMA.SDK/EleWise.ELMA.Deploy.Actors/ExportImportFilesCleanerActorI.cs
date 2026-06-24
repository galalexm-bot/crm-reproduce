using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Actors;

[Component(Type = ComponentType.Server)]
internal sealed class ExportImportFilesCleanerActorInitHandler : IActorInitHandler
{
	internal static ExportImportFilesCleanerActorInitHandler JxkEJFEccmt2ExfYcjYU;

	public Task Init(IActorModelRuntime actorModelRuntime)
	{
		return actorModelRuntime.GetActor<IExportImportFileCleanerActor>(Guid.Empty).Start();
	}

	public ExportImportFilesCleanerActorInitHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VVyc55EzB8GeipJhrcUM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool bGEDvREczdEldtwTpU0B()
	{
		return JxkEJFEccmt2ExfYcjYU == null;
	}

	internal static ExportImportFilesCleanerActorInitHandler UYQi2NEzFY7YUQE121Uj()
	{
		return JxkEJFEccmt2ExfYcjYU;
	}

	internal static void VVyc55EzB8GeipJhrcUM()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
