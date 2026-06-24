using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class IncludeAttribute : Attribute
{
	private static IncludeAttribute SRsGT6ofRixnajlpD22X;

	internal Guid Uid { get; }

	public IncludeAttribute(string uid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EXixLDofX727XhXniyQs();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Uid = new Guid(uid);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void EXixLDofX727XhXniyQs()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool UKeURPofqjuSLhjB3rtI()
	{
		return SRsGT6ofRixnajlpD22X == null;
	}

	internal static IncludeAttribute lZvSo2ofKwfmgMJELnUr()
	{
		return SRsGT6ofRixnajlpD22X;
	}
}
