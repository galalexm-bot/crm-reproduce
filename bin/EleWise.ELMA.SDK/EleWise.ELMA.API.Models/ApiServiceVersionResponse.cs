using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.API.Models;

[Serializable]
[DataContract(Name = "ApiService")]
public class ApiServiceVersionResponse
{
	internal static ApiServiceVersionResponse yYniqAf1bDk4X8DdJBq9;

	[DataMember]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
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

	[DataMember]
	public ApiMethodResponse[] Methods
	{
		[CompilerGenerated]
		get
		{
			return _003CMethods_003Ek__BackingField;
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
					_003CMethods_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ApiServiceVersionResponse()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cDWwGLf1ElKQr181qQZU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool oHTHYSf1h8MaKOd8nCx0()
	{
		return yYniqAf1bDk4X8DdJBq9 == null;
	}

	internal static ApiServiceVersionResponse fjNRGIf1GPmcTyqscl1d()
	{
		return yYniqAf1bDk4X8DdJBq9;
	}

	internal static void cDWwGLf1ElKQr181qQZU()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
