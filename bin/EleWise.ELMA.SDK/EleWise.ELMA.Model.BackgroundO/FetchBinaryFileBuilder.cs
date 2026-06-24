using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.BackgroundOperations.FetchBinaryFile;

public class FetchBinaryFileBuilder : ICreatingBuilder
{
	private FetchBinaryFileBackgroundOperation operation;

	internal static FetchBinaryFileBuilder atp4ybWzBhfhyki5yqro;

	public FetchBinaryFileBuilder(string key)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sJyvomWzbyOeQYNGTj5Z();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
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
			FetchBinaryFileBackgroundOperation fetchBinaryFileBackgroundOperation = new FetchBinaryFileBackgroundOperation();
			bLhofiWzh0ZZEmv8HEap(fetchBinaryFileBackgroundOperation, key);
			operation = fetchBinaryFileBackgroundOperation;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
			{
				num = 1;
			}
		}
	}

	public IBackgroundOperation Create()
	{
		return operation;
	}

	public ICreatingBuilder WhenCompleted<TContext>(Action<FetchBinaryFileSuccessDelegateBuilder<TContext>> onSuccess, Action<FetchBinaryFileErrorDelegateBuilder<TContext>> onError)
	{
		FetchBinaryFileSuccessDelegateBuilder<TContext> obj = new FetchBinaryFileSuccessDelegateBuilder<TContext>(operation.SuccessCallback);
		FetchBinaryFileErrorDelegateBuilder<TContext> obj2 = new FetchBinaryFileErrorDelegateBuilder<TContext>(operation.ErrorCallback);
		onSuccess(obj);
		onError(obj2);
		return this;
	}

	internal static void sJyvomWzbyOeQYNGTj5Z()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void bLhofiWzh0ZZEmv8HEap(object P_0, object P_1)
	{
		((FetchBinaryFileBackgroundOperation)P_0).Key = (string)P_1;
	}

	internal static bool Oo1hVQWzWtt4HakUY8iu()
	{
		return atp4ybWzBhfhyki5yqro == null;
	}

	internal static FetchBinaryFileBuilder GpyTJcWzotgjxOBgTv3T()
	{
		return atp4ybWzBhfhyki5yqro;
	}
}
