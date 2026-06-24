using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.API.Models;

[Serializable]
[DataContract(Name = "Auth")]
[Description("SR.M('Результат авторизации')")]
public class AuthResponse
{
	private static AuthResponse kQGCmsf184DWviDQvVRh;

	[Description("SR.M('Токен авторизации')")]
	[DataMember]
	public Guid AuthToken
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	[Description("SR.M('Токен сессии. Храните его в приложении как можно дольше')")]
	public string SessionToken
	{
		[CompilerGenerated]
		get
		{
			return _003CSessionToken_003Ek__BackingField;
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
					_003CSessionToken_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	[Description("SR.M('Идентификатор текущего пользователя')")]
	public string CurrentUserId
	{
		[CompilerGenerated]
		get
		{
			return _003CCurrentUserId_003Ek__BackingField;
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
					_003CCurrentUserId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
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
	[Description("SR.M('Имя текущего пользователя')")]
	public string CurrentUserName
	{
		[CompilerGenerated]
		get
		{
			return _003CCurrentUserName_003Ek__BackingField;
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
					_003CCurrentUserName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	[Description("SR.M('Язык текущего пользователя')")]
	public string Lang
	{
		[CompilerGenerated]
		get
		{
			return _003CLang_003Ek__BackingField;
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
					_003CLang_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public AuthResponse()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iNmE7Tf1IsC4EdacdLo5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool IIKuXPf1Zud9SOWngFtp()
	{
		return kQGCmsf184DWviDQvVRh == null;
	}

	internal static AuthResponse jC4xauf1u5Ihsi3ma0nP()
	{
		return kQGCmsf184DWviDQvVRh;
	}

	internal static void iNmE7Tf1IsC4EdacdLo5()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
