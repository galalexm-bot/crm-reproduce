using System;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.Managers;

internal sealed class DataClassItemHeaderChangesLoader : EntityChangesLoader
{
	private static DataClassItemHeaderChangesLoader RLk3pMbLJQQOrx6RXZGP;

	public override bool IsTypeSupported(Guid typeUid)
	{
		//Discarded unreachable code: IL_009b, IL_00aa
		int num = 3;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return MetadataLoader.IsBaseClass(InterfaceActivator.UID<DataClassMetadataItemHeader>(), classMetadata);
			case 2:
				return false;
			default:
				if (InterfaceActivator.LoadMetadata<DataClassMetadataItemHeader>() == classMetadata)
				{
					return true;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if ((classMetadata = MetadataLoader.LoadMetadata(typeUid) as ClassMetadata) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			}
		}
	}

	public DataClassItemHeaderChangesLoader()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dkEJgHbLl1Dw4puW5BwR();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool wkL6q2bL9KW5vkK2dYcK()
	{
		return RLk3pMbLJQQOrx6RXZGP == null;
	}

	internal static DataClassItemHeaderChangesLoader vuAA4ObLduVRrcmCvkD5()
	{
		return RLk3pMbLJQQOrx6RXZGP;
	}

	internal static void dkEJgHbLl1Dw4puW5BwR()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
