// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.EnumMetadataImport
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  [Component]
  public class EnumMetadataImport : MetadataImport
  {
    internal static EnumMetadataImport q1oZFlErNTsf4HtRN7lX;

    public override void CreateFakeChapter(
      NamedMetadata namedMd,
      BPMAppFakeManifest fakeManifest,
      BPMAppManifest manifest)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_12;
          case 2:
            if (fakeManifest == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (namedMd == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 6 : 2;
              continue;
            }
            goto case 7;
          case 4:
            goto label_11;
          case 5:
            goto label_8;
          case 6:
            goto label_2;
          case 7:
            // ISSUE: type reference
            if (!EnumMetadataImport.u9ttAIErDGOnoeFChpKV(namedMd.GetType(), EnumMetadataImport.n3HpafEraDTh6wU1FAxG(__typeref (EnumMetadata))))
            {
              num = 5;
              continue;
            }
            break;
        }
        fakeManifest.GetOrCreateChapterByUid(ObjectsExportConsts.ExportExtensionUidEnum).GetOrCreateItemByUid(namedMd.Uid, (string) EnumMetadataImport.FVjX8sErt5kX6TcWQ1hy((object) namedMd));
        num = 4;
      }
label_12:
      return;
label_11:
      return;
label_8:
      return;
label_2:;
    }

    public EnumMetadataImport()
    {
      EnumMetadataImport.TD0JwaErwdEXiFMaHIUr();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type n3HpafEraDTh6wU1FAxG([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool u9ttAIErDGOnoeFChpKV([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object FVjX8sErt5kX6TcWQ1hy([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static bool MnedMiEr3BHLwdW6sjb5() => EnumMetadataImport.q1oZFlErNTsf4HtRN7lX == null;

    internal static EnumMetadataImport TQAEfIErpcvNGtuhyo1r() => EnumMetadataImport.q1oZFlErNTsf4HtRN7lX;

    internal static void TD0JwaErwdEXiFMaHIUr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
