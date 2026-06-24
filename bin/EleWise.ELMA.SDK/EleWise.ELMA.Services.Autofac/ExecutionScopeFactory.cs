using Autofac;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services.Scope;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services.Autofac;

[Service]
internal sealed class ExecutionScopeFactory : IExecutionScopeFactory
{
	private readonly ILifetimeScope globalScope;

	internal static ExecutionScopeFactory PLY8TvBmYtZUb04ISW5W;

	public ExecutionScopeFactory(ILifetimeScope globalScope)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
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
			this.globalScope = globalScope;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
			{
				num = 1;
			}
		}
	}

	public IExecutionScopeBuilder CreateScope()
	{
		return new ExecutionScopeBuilder(globalScope);
	}

	internal static bool LiEOI3BmLoopHdiMRGOm()
	{
		return PLY8TvBmYtZUb04ISW5W == null;
	}

	internal static ExecutionScopeFactory WYEovHBmUEkwpsoSrbgY()
	{
		return PLY8TvBmYtZUb04ISW5W;
	}
}
