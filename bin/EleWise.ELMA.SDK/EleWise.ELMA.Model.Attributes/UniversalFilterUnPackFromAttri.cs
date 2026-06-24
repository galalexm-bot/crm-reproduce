using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class UniversalFilterUnPackFromAttribute : Attribute
{
	private readonly Guid propertyUid;

	private static UniversalFilterUnPackFromAttribute qB4Qb6ovhRySXnoZU8NA;

	public Guid PropertyUid => propertyUid;

	public UniversalFilterUnPackFromAttribute(string propertyUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
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
			this.propertyUid = new Guid(propertyUid);
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
			{
				num = 1;
			}
		}
	}

	internal static bool UJ3I3aovGRj3QJHX70oU()
	{
		return qB4Qb6ovhRySXnoZU8NA == null;
	}

	internal static UniversalFilterUnPackFromAttribute fYi6GhovEZ2S9Bqj9AF3()
	{
		return qB4Qb6ovhRySXnoZU8NA;
	}
}
