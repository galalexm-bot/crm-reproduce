// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.EntityMetadataImport
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  [Component]
  public class EntityMetadataImport : MetadataImport
  {
    internal static EntityMetadataImport s8VSZWEr4tf7wDIZBcZO;

    public override void CreateFakeChapter(
      NamedMetadata namedMd,
      BPMAppFakeManifest fakeManifest,
      BPMAppManifest manifest)
    {
      int num1 = 21;
      while (true)
      {
        EntityBAItem entityBaItem1;
        ObjectsBAChapter objectsBaChapter;
        EntityBAItem entityBaItem2;
        string title;
        Guid uid;
        BPMAppManifestFakeChapter chapterByUid;
        BPMAppManifestFakeItem manifestFakeItem;
        BPMAppManifestChapter appManifestChapter;
        EntityMetadata entityMd;
        switch (num1)
        {
          case 1:
          case 10:
          case 13:
            if (objectsBaChapter.SysCatalogs != null)
            {
              num1 = 42;
              continue;
            }
            goto case 9;
          case 2:
            objectsBaChapter = appManifestChapter as ObjectsBAChapter;
            num1 = 19;
            continue;
          case 3:
            entityMd = namedMd as EntityMetadata;
            num1 = 5;
            continue;
          case 4:
            goto label_31;
          case 5:
            if (entityMd != null)
            {
              num1 = 24;
              continue;
            }
            goto label_57;
          case 6:
            // ISSUE: reference to a compiler-generated method
            appManifestChapter = manifest.Chapters.FirstOrDefault<BPMAppManifestChapter>((Func<BPMAppManifestChapter, bool>) (c => EntityMetadataImport.\u003C\u003Ec.mQWLDY876yDtSxN20MMV((object) c) == ObjectsExportConsts.ExportExtensionUid));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 8;
            continue;
          case 7:
            if (!EntityMetadataImport.yH5V8QEr9KrSosScY3bW((object) entityBaItem2))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 25 : 31;
              continue;
            }
            goto case 32;
          case 8:
            if (appManifestChapter == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 12 : 9;
              continue;
            }
            goto case 2;
          case 9:
          case 12:
          case 15:
          case 30:
          case 31:
          case 38:
          case 41:
            chapterByUid.GetOrCreateItemByUid(uid, title);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 10 : 26;
            continue;
          case 11:
            if (manifest.Chapters == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 30 : 17;
              continue;
            }
            goto case 6;
          case 14:
            if (manifestFakeItem != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 17 : 40;
              continue;
            }
            break;
          case 16:
            if (manifest == null)
            {
              num1 = 41;
              continue;
            }
            goto case 11;
          case 17:
            if (objectsBaChapter.Catalogs == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 10;
              continue;
            }
            goto case 23;
          case 18:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 36 : 22;
            continue;
          case 19:
            if (objectsBaChapter == null)
            {
              num1 = 15;
              continue;
            }
            goto case 17;
          case 20:
            if (namedMd != null)
            {
              num1 = 27;
              continue;
            }
            goto label_33;
          case 21:
            if (fakeManifest != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 20 : 20;
              continue;
            }
            goto label_46;
          case 22:
            goto label_58;
          case 23:
            entityBaItem1 = objectsBaChapter.Catalogs.FirstOrDefault<EntityBAItem>((Func<EntityBAItem, bool>) (c =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (EntityMetadataImport.\u003C\u003Ec__DisplayClass0_0.mYe8d287ps9jXRYg7JxH(EntityMetadataImport.\u003C\u003Ec__DisplayClass0_0.Nw92Ik87NNGj9QuWA2tV((object) c), EntityMetadataImport.\u003C\u003Ec__DisplayClass0_0.aTmv4P873q7X8Zmjeyem((object) entityMd)))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_2;
                  case 2:
                    goto label_2;
                  default:
                    goto label_3;
                }
              }
label_2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return EntityMetadataImport.\u003C\u003Ec__DisplayClass0_0.mYe8d287ps9jXRYg7JxH(EntityMetadataImport.\u003C\u003Ec__DisplayClass0_0.Nw92Ik87NNGj9QuWA2tV((object) c), EntityMetadataImport.\u003C\u003Ec__DisplayClass0_0.gl75vd87anXeab0FDg7t((object) entityMd));
label_3:
              return true;
            }));
            num1 = 35;
            continue;
          case 24:
            uid = Guid.Empty;
            num1 = 33;
            continue;
          case 25:
            goto label_21;
          case 26:
            goto label_28;
          case 27:
            // ISSUE: type reference
            if (!EntityMetadataImport.KrPFZ2Er7V0hs8Yg1Vo5(namedMd.GetType(), EntityMetadataImport.ajbY9eErAAItLlJ9DcJn(__typeref (EntityMetadata))))
            {
              num1 = 4;
              continue;
            }
            goto case 18;
          case 28:
            uid = EntityMetadataImport.NHjCEREr0Ufyh4ZIZ0Ji((object) entityMd);
            num1 = 43;
            continue;
          case 29:
            title = EleWise.ELMA.SR.T((string) EntityMetadataImport.O4T40WErd5G3dnuV2XHt(-1088304168 ^ -1088081708), (object) entityMd.DisplayName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
            continue;
          case 32:
            title = EleWise.ELMA.SR.T((string) EntityMetadataImport.O4T40WErd5G3dnuV2XHt(-1426456882 ^ 2009939514 ^ -584041510), (object) entityMd.DisplayName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 12 : 38;
            continue;
          case 33:
            if (EntityMetadataImport.sB2cXMErxxGflVoryEjD((object) entityMd) == EntityMetadataType.Interface)
            {
              num1 = 28;
              continue;
            }
            goto case 43;
          case 34:
            if (!EntityMetadataImport.yH5V8QEr9KrSosScY3bW((object) entityBaItem1))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 9 : 13;
              continue;
            }
            goto case 29;
          case 35:
            if (entityBaItem1 != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 2 : 34;
              continue;
            }
            goto case 1;
          case 36:
            chapterByUid = fakeManifest.GetOrCreateChapterByUid(ObjectsExportConsts.ExportExtensionUidEntity);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 2 : 3;
            continue;
          case 37:
            if (entityBaItem2 == null)
            {
              num1 = 9;
              continue;
            }
            goto case 7;
          case 39:
            manifestFakeItem = (BPMAppManifestFakeItem) EntityMetadataImport.H3mDA7Erywrpr0HB72nu((object) chapterByUid, uid);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 5 : 14;
            continue;
          case 40:
            if (!EntityMetadataImport.z3xjrLErMGnIanTtqvKN((object) manifestFakeItem.Title))
            {
              num1 = 25;
              continue;
            }
            break;
          case 42:
            entityBaItem2 = objectsBaChapter.SysCatalogs.FirstOrDefault<EntityBAItem>((Func<EntityBAItem, bool>) (c =>
            {
              int num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (EntityMetadataImport.\u003C\u003Ec__DisplayClass0_0.Nw92Ik87NNGj9QuWA2tV((object) c) == EntityMetadataImport.\u003C\u003Ec__DisplayClass0_0.aTmv4P873q7X8Zmjeyem((object) entityMd))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_4;
                  case 2:
                    goto label_4;
                  default:
                    goto label_5;
                }
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return EntityMetadataImport.\u003C\u003Ec__DisplayClass0_0.mYe8d287ps9jXRYg7JxH(EntityMetadataImport.\u003C\u003Ec__DisplayClass0_0.Nw92Ik87NNGj9QuWA2tV((object) c), EntityMetadataImport.\u003C\u003Ec__DisplayClass0_0.gl75vd87anXeab0FDg7t((object) entityMd));
label_5:
              return true;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 37 : 37;
            continue;
          case 43:
            if (EntityMetadataImport.sB2cXMErxxGflVoryEjD((object) entityMd) == EntityMetadataType.InterfaceExtension)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
              continue;
            }
            break;
          default:
            uid = EntityMetadataImport.zbFHLMErmESh9yCgcq6S((object) entityMd);
            num1 = 39;
            continue;
        }
        title = (string) EntityMetadataImport.Vw5KkHErJGI7hhf4MNsA((object) entityMd);
        num1 = 16;
      }
label_31:
      return;
label_58:
      return;
label_21:
      return;
label_28:
      return;
label_57:
      return;
label_46:
      return;
label_33:;
    }

    public EntityMetadataImport()
    {
      EntityMetadataImport.aEaA1aErlXx0tVYGeky7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type ajbY9eErAAItLlJ9DcJn([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool KrPFZ2Er7V0hs8Yg1Vo5([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static EntityMetadataType sB2cXMErxxGflVoryEjD([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static Guid NHjCEREr0Ufyh4ZIZ0Ji([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static Guid zbFHLMErmESh9yCgcq6S([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static object H3mDA7Erywrpr0HB72nu([In] object obj0, Guid uid) => (object) ((BPMAppManifestFakeChapter) obj0).GetItemByUid(uid);

    internal static bool z3xjrLErMGnIanTtqvKN([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object Vw5KkHErJGI7hhf4MNsA([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static bool yH5V8QEr9KrSosScY3bW([In] object obj0) => ((EntityBAItem) obj0).ExportData;

    internal static object O4T40WErd5G3dnuV2XHt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool M6GMJoEr63FOKtP8JS9r() => EntityMetadataImport.s8VSZWEr4tf7wDIZBcZO == null;

    internal static EntityMetadataImport YnWNe6ErHy61bPnmj85b() => EntityMetadataImport.s8VSZWEr4tf7wDIZBcZO;

    internal static void aEaA1aErlXx0tVYGeky7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
