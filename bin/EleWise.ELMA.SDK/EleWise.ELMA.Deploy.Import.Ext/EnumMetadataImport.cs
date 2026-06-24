using System;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[Component]
public class EnumMetadataImport : MetadataImport
{
	internal static EnumMetadataImport q1oZFlErNTsf4HtRN7lX;

	public override void CreateFakeChapter(NamedMetadata namedMd, BPMAppFakeManifest fakeManifest, BPMAppManifest manifest)
	{
		//Discarded unreachable code: IL_00b1, IL_00c0, IL_00f0, IL_00ff, IL_010f, IL_011e
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (namedMd == null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 7;
			default:
				fakeManifest.GetOrCreateChapterByUid(ObjectsExportConsts.ExportExtensionUidEnum).GetOrCreateItemByUid(namedMd.Uid, (string)FVjX8sErt5kX6TcWQ1hy(namedMd));
				num2 = 4;
				break;
			case 7:
				if (!u9ttAIErDGOnoeFChpKV(namedMd.GetType(), n3HpafEraDTh6wU1FAxG(typeof(EnumMetadata).TypeHandle)))
				{
					num2 = 5;
					break;
				}
				goto default;
			case 5:
				return;
			case 2:
				if (fakeManifest == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 6:
				return;
			case 1:
				return;
			case 4:
				return;
			}
		}
	}

	public EnumMetadataImport()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TD0JwaErwdEXiFMaHIUr();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type n3HpafEraDTh6wU1FAxG(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool u9ttAIErDGOnoeFChpKV(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object FVjX8sErt5kX6TcWQ1hy(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static bool MnedMiEr3BHLwdW6sjb5()
	{
		return q1oZFlErNTsf4HtRN7lX == null;
	}

	internal static EnumMetadataImport TQAEfIErpcvNGtuhyo1r()
	{
		return q1oZFlErNTsf4HtRN7lX;
	}

	internal static void TD0JwaErwdEXiFMaHIUr()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
