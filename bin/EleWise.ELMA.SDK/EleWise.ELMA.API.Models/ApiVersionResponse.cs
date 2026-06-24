using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.API.Models;

[Serializable]
[DataContract(Name = "ApiVersion")]
public class ApiVersionResponse
{
	internal static ApiVersionResponse I9UUbPf1FnPHbmauOvUN;

	[DataMember]
	public string Version
	{
		[CompilerGenerated]
		get
		{
			return _003CVersion_003Ek__BackingField;
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
					_003CVersion_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public ApiServiceVersionResponse[] Services
	{
		[CompilerGenerated]
		get
		{
			return _003CServices_003Ek__BackingField;
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
					_003CServices_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ApiVersionResponse()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		x3vie0f1oSq5S1aOtaKJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool aDQQn5f1BmiSJmuLFc9i()
	{
		return I9UUbPf1FnPHbmauOvUN == null;
	}

	internal static ApiVersionResponse Tj8p9wf1WiRLIlrR7jZy()
	{
		return I9UUbPf1FnPHbmauOvUN;
	}

	internal static void x3vie0f1oSq5S1aOtaKJ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
