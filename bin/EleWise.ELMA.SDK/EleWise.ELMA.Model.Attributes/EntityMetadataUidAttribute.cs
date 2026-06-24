using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class EntityMetadataUidAttribute : Attribute
{
	internal static EntityMetadataUidAttribute fZpRs9ofVSiHUfSalwow;

	internal Guid Uid { get; }

	public EntityMetadataUidAttribute(string uid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool Cl9NIhofS1OGmfLH3Qev()
	{
		return fZpRs9ofVSiHUfSalwow == null;
	}

	internal static EntityMetadataUidAttribute eDAi3fofiINmSmHiyllv()
	{
		return fZpRs9ofVSiHUfSalwow;
	}
}
