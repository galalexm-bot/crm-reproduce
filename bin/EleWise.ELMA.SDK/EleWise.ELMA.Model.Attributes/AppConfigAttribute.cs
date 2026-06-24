using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Interface)]
public class AppConfigAttribute : Attribute
{
	private static AppConfigAttribute aYgVm5oQQiXHvx2kbgVE;

	public string Content
	{
		[CompilerGenerated]
		get
		{
			return _003CContent_003Ek__BackingField;
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
					_003CContent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
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

	public string CreationDate
	{
		[CompilerGenerated]
		get
		{
			return _003CCreationDate_003Ek__BackingField;
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
					_003CCreationDate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Url
	{
		[CompilerGenerated]
		get
		{
			return _003CUrl_003Ek__BackingField;
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
					_003CUrl_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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

	public AppConfigAttribute(string content, string creationDate, string url)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		gnOutwoQ8dLXUhckFLrf();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 3:
				Url = url;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num = 0;
				}
				break;
			default:
				Content = content;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num = 1;
				}
				break;
			case 1:
				CreationDate = creationDate;
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool psqYYAoQCp2FZAYegVMi()
	{
		return aYgVm5oQQiXHvx2kbgVE == null;
	}

	internal static AppConfigAttribute qT3Sa3oQvirgXTm9Mnv1()
	{
		return aYgVm5oQQiXHvx2kbgVE;
	}

	internal static void gnOutwoQ8dLXUhckFLrf()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
