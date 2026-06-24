using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services.Public;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public class PublicServiceMethodExecutor
{
	private readonly WebData parameters;

	protected Func<WebData, WebData> methodBody;

	internal static PublicServiceMethodExecutor wfS5SFBmIehmPRe4wPUn;

	public virtual WebData Parameters => parameters;

	public virtual Func<WebData, WebData> MethodBody => methodBody;

	public PublicServiceMethodExecutor(WebData parameters, Func<WebData, WebData> methodBody)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.parameters = parameters;
		this.methodBody = methodBody;
	}

	protected PublicServiceMethodExecutor(WebData parameters)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OXINQ0Bmi6esOrZQusw5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
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
			this.parameters = parameters;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
			{
				num = 1;
			}
		}
	}

	public virtual WebData Execute()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (MethodBody == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					break;
				}
				return MethodBody(Parameters);
			default:
				throw new NotImplementedException((string)CyvihMBmqm0lj6kPWecM(WnWmDMBmRXOu73V1DPud(0x12441CA4 ^ 0x12457E06)));
			}
		}
	}

	internal static void OXINQ0Bmi6esOrZQusw5()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ty147oBmVRZDB1xFgJSr()
	{
		return wfS5SFBmIehmPRe4wPUn == null;
	}

	internal static PublicServiceMethodExecutor BV4r8QBmSiRwO2TsLU7m()
	{
		return wfS5SFBmIehmPRe4wPUn;
	}

	internal static object WnWmDMBmRXOu73V1DPud(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object CyvihMBmqm0lj6kPWecM(object P_0)
	{
		return SR.T((string)P_0);
	}
}
