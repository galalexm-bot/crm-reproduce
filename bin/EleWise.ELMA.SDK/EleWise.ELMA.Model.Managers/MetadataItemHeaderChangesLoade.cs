using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Managers;

internal sealed class MetadataItemHeaderChangesLoader : EntityChangesLoader
{
	internal static MetadataItemHeaderChangesLoader pWxaethh5cFxGMtRwdSX;

	public override bool IsTypeSupported(Guid typeUid)
	{
		int num = 2;
		int num2 = num;
		ClassMetadata classMetadata = default(ClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (InterfaceActivator.LoadMetadata<IMetadataItemHeader>() != classMetadata)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			default:
				return MetadataLoader.IsBaseClass(InterfaceActivator.UID<IMetadataItemHeader>(), classMetadata);
			case 2:
				if ((classMetadata = MetadataLoader.LoadMetadata(typeUid) as ClassMetadata) == null)
				{
					return false;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public MetadataItemHeaderChangesLoader()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RrBWrxhhLriO2hjiNSnY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool B6lssghhjdhb0yud2lQT()
	{
		return pWxaethh5cFxGMtRwdSX == null;
	}

	internal static MetadataItemHeaderChangesLoader gUrYTphhY3P1ZbFhljlY()
	{
		return pWxaethh5cFxGMtRwdSX;
	}

	internal static void RrBWrxhhLriO2hjiNSnY()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
