using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.BackgroundOperations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.BackgroundOperations.HttpRequest;

public class HttpRequestOptionalParametersBuilder : ICreatingBuilder
{
	private HttpRequestBackgroundOperation operation;

	internal static HttpRequestOptionalParametersBuilder oDSr3KOMlQdKGy7gX1U4;

	public HttpRequestHeadersBuilder Headers
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaders_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CHeaders_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	internal HttpRequestOptionalParametersBuilder(HttpRequestBackgroundOperation operation)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sQufIQOMmM2ySZis6HLb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				Headers = new HttpRequestHeadersBuilder(this, operation);
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
				{
					num = 2;
				}
				break;
			default:
				this.operation = operation;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public IBackgroundOperation Create()
	{
		return operation;
	}

	public ICreatingBuilder WhenCompleted<TContext>(Action<HttpSuccessDelegateBuilder<TContext>> onSuccess, Action<HttpErrorDelegateBuilder<TContext>> onError)
	{
		HttpSuccessDelegateBuilder<TContext> obj = new HttpSuccessDelegateBuilder<TContext>(operation.SuccessCallback);
		HttpErrorDelegateBuilder<TContext> obj2 = new HttpErrorDelegateBuilder<TContext>(operation.ErrorCallback);
		onSuccess(obj);
		onError(obj2);
		return this;
	}

	internal static void sQufIQOMmM2ySZis6HLb()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool l8HPxjOM0X4rxQeaEdCt()
	{
		return oDSr3KOMlQdKGy7gX1U4 == null;
	}

	internal static HttpRequestOptionalParametersBuilder PLFNtoOMyWxT9l9IjpD0()
	{
		return oDSr3KOMlQdKGy7gX1U4;
	}
}
