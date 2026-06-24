using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ComponentModel;

[AttributeUsage(AttributeTargets.All)]
public sealed class LocalizationRequiredAttribute : Attribute
{
	internal static LocalizationRequiredAttribute RRCg0yffkVcChuttcLNF;

	public bool Required
	{
		[CompilerGenerated]
		get
		{
			return _003CRequired_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CRequired_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public LocalizationRequiredAttribute()
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(required: true);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public LocalizationRequiredAttribute(bool required)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MdvSLwff2pwj9OKCpQIc();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
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
			Required = required;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
			{
				num = 0;
			}
		}
	}

	internal static bool ltiTdpffnAB8KFF7cHT3()
	{
		return RRCg0yffkVcChuttcLNF == null;
	}

	internal static LocalizationRequiredAttribute jqAtOjffOaUkhrpZFbLD()
	{
		return RRCg0yffkVcChuttcLNF;
	}

	internal static void MdvSLwff2pwj9OKCpQIc()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
