using System;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[Component]
public class EntityMetadataImport : MetadataImport
{
	internal static EntityMetadataImport s8VSZWEr4tf7wDIZBcZO;

	public override void CreateFakeChapter(NamedMetadata namedMd, BPMAppFakeManifest fakeManifest, BPMAppManifest manifest)
	{
		//Discarded unreachable code: IL_0133, IL_0142, IL_01e1, IL_01f0, IL_01ff, IL_02a0, IL_02af, IL_0341, IL_0350, IL_0395, IL_04b8, IL_059a, IL_05a9, IL_05b8
		int num = 21;
		int num2 = num;
		EntityBAItem entityBAItem2 = default(EntityBAItem);
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		ObjectsBAChapter objectsBAChapter = default(ObjectsBAChapter);
		EntityBAItem entityBAItem = default(EntityBAItem);
		string title = default(string);
		Guid uid = default(Guid);
		BPMAppManifestFakeChapter orCreateChapterByUid = default(BPMAppManifestFakeChapter);
		BPMAppManifestFakeItem bPMAppManifestFakeItem = default(BPMAppManifestFakeItem);
		BPMAppManifestChapter bPMAppManifestChapter = default(BPMAppManifestChapter);
		while (true)
		{
			switch (num2)
			{
			case 34:
				if (!yH5V8QEr9KrSosScY3bW(entityBAItem2))
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 13;
					}
					continue;
				}
				goto case 29;
			case 5:
				if (_003C_003Ec__DisplayClass0_.entityMd != null)
				{
					num2 = 24;
					continue;
				}
				return;
			case 17:
				if (objectsBAChapter.Catalogs == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 10;
					}
					continue;
				}
				goto case 23;
			case 37:
				if (entityBAItem == null)
				{
					num2 = 9;
					continue;
				}
				goto case 7;
			case 21:
				if (fakeManifest != null)
				{
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 20;
					}
					continue;
				}
				return;
			case 29:
				title = SR.T((string)O4T40WErd5G3dnuV2XHt(-1088304168 ^ -1088081708), _003C_003Ec__DisplayClass0_.entityMd.DisplayName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				uid = zbFHLMErmESh9yCgcq6S(_003C_003Ec__DisplayClass0_.entityMd);
				num2 = 39;
				continue;
			case 36:
				orCreateChapterByUid = fakeManifest.GetOrCreateChapterByUid(ObjectsExportConsts.ExportExtensionUidEntity);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 3;
				}
				continue;
			case 39:
				bPMAppManifestFakeItem = (BPMAppManifestFakeItem)H3mDA7Erywrpr0HB72nu(orCreateChapterByUid, uid);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 14;
				}
				continue;
			case 40:
				if (!z3xjrLErMGnIanTtqvKN(bPMAppManifestFakeItem.Title))
				{
					num2 = 25;
					continue;
				}
				goto IL_0378;
			case 23:
				entityBAItem2 = objectsBAChapter.Catalogs.FirstOrDefault(_003C_003Ec__DisplayClass0_._003CCreateFakeChapter_003Eb__1);
				num2 = 35;
				continue;
			case 7:
				if (!yH5V8QEr9KrSosScY3bW(entityBAItem))
				{
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 31;
					}
					continue;
				}
				goto case 32;
			case 22:
				return;
			case 24:
				uid = Guid.Empty;
				num2 = 33;
				continue;
			case 16:
				if (manifest == null)
				{
					num2 = 41;
					continue;
				}
				goto case 11;
			case 2:
				objectsBAChapter = bPMAppManifestChapter as ObjectsBAChapter;
				num2 = 19;
				continue;
			case 27:
				if (!KrPFZ2Er7V0hs8Yg1Vo5(namedMd.GetType(), ajbY9eErAAItLlJ9DcJn(typeof(EntityMetadata).TypeHandle)))
				{
					num2 = 4;
					continue;
				}
				goto case 18;
			case 4:
				return;
			case 33:
				if (sB2cXMErxxGflVoryEjD(_003C_003Ec__DisplayClass0_.entityMd) == EntityMetadataType.Interface)
				{
					num2 = 28;
					continue;
				}
				goto case 43;
			case 25:
				return;
			case 3:
				_003C_003Ec__DisplayClass0_.entityMd = namedMd as EntityMetadata;
				num2 = 5;
				continue;
			case 18:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 36;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 22;
				}
				continue;
			case 28:
				uid = NHjCEREr0Ufyh4ZIZ0Ji(_003C_003Ec__DisplayClass0_.entityMd);
				num2 = 43;
				continue;
			case 32:
				title = SR.T((string)O4T40WErd5G3dnuV2XHt(-583745292 ^ -584041510), _003C_003Ec__DisplayClass0_.entityMd.DisplayName);
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 38;
				}
				continue;
			case 14:
				if (bPMAppManifestFakeItem != null)
				{
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 40;
					}
					continue;
				}
				goto IL_0378;
			case 8:
				if (bPMAppManifestChapter == null)
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto case 2;
			case 11:
				if (manifest.Chapters == null)
				{
					num2 = 30;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 17;
					}
					continue;
				}
				break;
			case 19:
				if (objectsBAChapter == null)
				{
					num2 = 15;
					continue;
				}
				goto case 17;
			case 20:
				if (namedMd != null)
				{
					num2 = 27;
					continue;
				}
				return;
			case 43:
				if (sB2cXMErxxGflVoryEjD(_003C_003Ec__DisplayClass0_.entityMd) == EntityMetadataType.InterfaceExtension)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto IL_0378;
			case 35:
				if (entityBAItem2 != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 34;
					}
					continue;
				}
				goto case 1;
			case 1:
			case 10:
			case 13:
				if (objectsBAChapter.SysCatalogs != null)
				{
					num2 = 42;
					continue;
				}
				goto case 9;
			case 9:
			case 12:
			case 15:
			case 30:
			case 31:
			case 38:
			case 41:
				orCreateChapterByUid.GetOrCreateItemByUid(uid, title);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 26;
				}
				continue;
			case 26:
				return;
			case 42:
				entityBAItem = objectsBAChapter.SysCatalogs.FirstOrDefault(_003C_003Ec__DisplayClass0_._003CCreateFakeChapter_003Eb__2);
				num2 = 37;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 37;
				}
				continue;
			case 6:
				break;
				IL_0378:
				title = (string)Vw5KkHErJGI7hhf4MNsA(_003C_003Ec__DisplayClass0_.entityMd);
				num2 = 16;
				continue;
			}
			bPMAppManifestChapter = manifest.Chapters.FirstOrDefault((BPMAppManifestChapter c) => _003C_003Ec.mQWLDY876yDtSxN20MMV(c) == ObjectsExportConsts.ExportExtensionUid);
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
			{
				num2 = 8;
			}
		}
	}

	public EntityMetadataImport()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		aEaA1aErlXx0tVYGeky7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type ajbY9eErAAItLlJ9DcJn(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool KrPFZ2Er7V0hs8Yg1Vo5(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static EntityMetadataType sB2cXMErxxGflVoryEjD(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid NHjCEREr0Ufyh4ZIZ0Ji(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Guid zbFHLMErmESh9yCgcq6S(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static object H3mDA7Erywrpr0HB72nu(object P_0, Guid uid)
	{
		return ((BPMAppManifestFakeChapter)P_0).GetItemByUid(uid);
	}

	internal static bool z3xjrLErMGnIanTtqvKN(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object Vw5KkHErJGI7hhf4MNsA(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static bool yH5V8QEr9KrSosScY3bW(object P_0)
	{
		return ((EntityBAItem)P_0).ExportData;
	}

	internal static object O4T40WErd5G3dnuV2XHt(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool M6GMJoEr63FOKtP8JS9r()
	{
		return s8VSZWEr4tf7wDIZBcZO == null;
	}

	internal static EntityMetadataImport YnWNe6ErHy61bPnmj85b()
	{
		return s8VSZWEr4tf7wDIZBcZO;
	}

	internal static void aEaA1aErlXx0tVYGeky7()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
