using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Services.Public;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.API.Models;

[Serializable]
[DataContract]
[Description("Ответ на запрос объектов")]
public class EntityQueryResponse
{
	internal static EntityQueryResponse vvDJI6f1mP0A3lW7KjCD;

	[DataMember]
	[Description("Количество объектов в результате")]
	public long Count
	{
		[CompilerGenerated]
		get
		{
			return _003CCount_003Ek__BackingField;
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
					_003CCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	[Description("Объекты")]
	public IEnumerable<WebData> Data { get; set; }

	[Description("Ошибка запроса")]
	[DataMember]
	public PublicServiceException Exception
	{
		[CompilerGenerated]
		get
		{
			return _003CException_003Ek__BackingField;
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
					_003CException_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public EntityQueryResponse()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dwFTKIf1JRvxN9bDauZw();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool FWWJCjf1yyaNyeZq053W()
	{
		return vvDJI6f1mP0A3lW7KjCD == null;
	}

	internal static EntityQueryResponse tbW44Sf1MORCR5Y2nK3m()
	{
		return vvDJI6f1mP0A3lW7KjCD;
	}

	internal static void dwFTKIf1JRvxN9bDauZw()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
