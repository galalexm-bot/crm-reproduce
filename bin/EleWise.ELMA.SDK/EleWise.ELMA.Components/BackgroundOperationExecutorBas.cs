using System;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.BackgroundOperations;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Components;

[Component]
public abstract class BackgroundOperationExecutorBase : IBackgroundOperationExecutor
{
	private static BackgroundOperationExecutorBase cWwf2BfGYKxutA7RT9sF;

	public abstract bool CanExecute(IBackgroundOperation executionInfo);

	public abstract string GetDescription(IBackgroundOperation executionInfo);

	public Task<object> RunTask(IBackgroundOperation executionInfo, CancellationToken token)
	{
		try
		{
			using (CallContextSessionOwner.Create())
			{
				return RunTaskImpl(executionInfo, token);
			}
		}
		catch (Exception ex)
		{
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
			Exception ex2 = (CS_0024_003C_003E8__locals0.ex = ex);
			return Task.Factory.StartNew((Func<object>)delegate
			{
				throw CS_0024_003C_003E8__locals0.ex;
			});
		}
	}

	protected abstract Task<object> RunTaskImpl(IBackgroundOperation executionInfo, CancellationToken token);

	protected T CastTo<T>(IBackgroundOperation executionInfo) where T : class, IBackgroundOperation
	{
		if (!(executionInfo is T result))
		{
			throw new ArgumentNullException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -69833282), typeof(T).FullName));
		}
		return result;
	}

	protected BackgroundOperationExecutorBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KFlqwCfGsTNi7NwNRVus();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void KFlqwCfGsTNi7NwNRVus()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool cpRiEgfGLyliIYjCiN4o()
	{
		return cWwf2BfGYKxutA7RT9sF == null;
	}

	internal static BackgroundOperationExecutorBase UrnIFNfGUfQ476keQsVs()
	{
		return cWwf2BfGYKxutA7RT9sF;
	}
}
