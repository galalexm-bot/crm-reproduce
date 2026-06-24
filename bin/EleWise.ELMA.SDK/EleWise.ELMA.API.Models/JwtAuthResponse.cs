using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.API.Models;

[Serializable]
[DataContract(Name = "JwtAuth")]
[Description("SR.M('Результат авторизации в виде JWT токена')")]
public class JwtAuthResponse
{
	private static JwtAuthResponse iOiZeXfNfqUFaaQVNwAm;

	[Description("SR.M('JWT токен авторизации, содержит идентификатор пользователя (userId), токен приложения (appToken), а так же сведения о пользовательской локали (lang)')")]
	[DataMember]
	public string AuthToken
	{
		[CompilerGenerated]
		get
		{
			return _003CAuthToken_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CAuthToken_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Description("SR.M('Токен обновления авторизации, одноразовый')")]
	[DataMember]
	public string RefreshToken
	{
		[CompilerGenerated]
		get
		{
			return _003CRefreshToken_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CRefreshToken_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
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

	public JwtAuthResponse()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool NPF9HnfNQVWHxxeA2V8a()
	{
		return iOiZeXfNfqUFaaQVNwAm == null;
	}

	internal static JwtAuthResponse mKwOWUfNCgeTT2AL3DBY()
	{
		return iOiZeXfNfqUFaaQVNwAm;
	}
}
