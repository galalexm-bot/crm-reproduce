// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.Services.FilesBAConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.BPMApps.Services
{
  [Component(Order = 5000)]
  public class FilesBAConverter : IBPMAppItemsConverter
  {
    private static FilesBAConverter n2UIKhf2Ia5mbsXIHQF0;

    public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        FilesBAChapter chapter;
        FilesExportSetting filesExportSetting;
        object obj;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_12;
            case 1:
              goto label_10;
            case 2:
              if (settings.CustomSettings.TryGetValue(FilesExportConsts.ExportExtensionUid, out obj))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 9 : 5;
                continue;
              }
              goto label_9;
            case 3:
              FilesBAConverter.VAykEif2R49M1xopjxoD((object) settings, FilesBAConverter.F1lcwPf2iL39mNsevqhj(-1858887263 ^ -1858909393));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 2;
              continue;
            case 4:
              FilesBAConverter.VAykEif2R49M1xopjxoD((object) bpmAppManifest, FilesBAConverter.F1lcwPf2iL39mNsevqhj(1178210108 ^ 1178552238));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 3 : 3;
              continue;
            case 5:
              FilesBAConverter.OefZXJf2TLRcf6n2l0vU((object) chapter, FilesBAConverter.MoctEgf2Xt2oRBv3hsHS((object) filesExportSetting));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 8 : 2;
              continue;
            case 6:
              if (filesExportSetting != null)
              {
                num2 = 12;
                continue;
              }
              goto label_3;
            case 7:
              goto label_25;
            case 8:
              if (!FilesBAConverter.duLJ1If2nGm9NbYjclP2(FilesBAConverter.W9X54kf2kKA2KpLwNMWE((object) chapter)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 4 : 14;
                continue;
              }
              goto case 11;
            case 9:
              filesExportSetting = obj as FilesExportSetting;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 6;
              continue;
            case 10:
            case 14:
              bpmAppManifest.SetChapter((BPMAppManifestChapter) chapter);
              num2 = 7;
              continue;
            case 11:
              if (FilesBAConverter.duLJ1If2nGm9NbYjclP2((object) chapter.HelpOriginalFullFileName))
              {
                num2 = 15;
                continue;
              }
              goto case 10;
            case 12:
              FilesBAChapter filesBaChapter = new FilesBAChapter();
              filesBaChapter.Uid = FilesExportConsts.ExportExtensionUid;
              chapter = filesBaChapter;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 16 : 16;
              continue;
            case 13:
              FilesBAConverter.ejYLbef2KAy6sAdKhYB1((object) chapter, (object) filesExportSetting.HelpOriginalFullFileName);
              num2 = 5;
              continue;
            case 15:
              if (!FilesBAConverter.duLJ1If2nGm9NbYjclP2(FilesBAConverter.jSAarqf2OXUQpePOHH2r((object) chapter)))
              {
                num2 = 10;
                continue;
              }
              goto label_27;
            case 16:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        FilesBAConverter.LXXV1Xf2qTCP9Yt21HML((object) chapter, (object) filesExportSetting.HelpFileName);
        num1 = 13;
      }
label_12:
      return;
label_10:
      return;
label_25:
      return;
label_5:
      return;
label_9:
      return;
label_27:
      return;
label_3:;
    }

    public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
    {
      int num = 4;
      FilesExportSetting filesExportSetting;
      FilesBAChapter filesBaChapter;
      while (true)
      {
        switch (num)
        {
          case 1:
            filesBaChapter = FilesBAConverter.b755Ysf22naGtHo8inbc((object) bpmAppManifest, FilesExportConsts.ExportExtensionUid) as FilesBAChapter;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 10 : 7;
            continue;
          case 2:
            filesExportSetting = new FilesExportSetting();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
            continue;
          case 3:
            Contract.ArgumentNotNull((object) settings, (string) FilesBAConverter.F1lcwPf2iL39mNsevqhj(-740338220 ^ -740311206));
            num = 2;
            continue;
          case 4:
            Contract.ArgumentNotNull((object) bpmAppManifest, (string) FilesBAConverter.F1lcwPf2iL39mNsevqhj(-1317790512 ^ -1317972926));
            num = 3;
            continue;
          case 6:
            goto label_5;
          case 7:
            FilesBAConverter.VAYeIAf2PqiXyXDoqWrW((object) filesExportSetting, (object) filesBaChapter.HelpOriginalFullFileName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 6 : 8;
            continue;
          case 8:
            FilesBAConverter.F5q1wYf210WJ6Yj8PQXt((object) filesExportSetting, FilesBAConverter.jSAarqf2OXUQpePOHH2r((object) filesBaChapter));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
            continue;
          case 9:
            FilesBAConverter.vI2Zi9f2eVhBan4J0wOs((object) filesExportSetting, FilesBAConverter.W9X54kf2kKA2KpLwNMWE((object) filesBaChapter));
            num = 7;
            continue;
          case 10:
            if (filesBaChapter == null)
            {
              num = 5;
              continue;
            }
            goto case 9;
          default:
            settings.CustomSettings[FilesExportConsts.ExportExtensionUid] = (object) filesExportSetting;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 4 : 6;
            continue;
        }
      }
label_5:;
    }

    public FilesBAConverter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object F1lcwPf2iL39mNsevqhj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void VAykEif2R49M1xopjxoD([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void LXXV1Xf2qTCP9Yt21HML([In] object obj0, [In] object obj1) => ((FilesBAChapter) obj0).HelpFileName = (string) obj1;

    internal static void ejYLbef2KAy6sAdKhYB1([In] object obj0, [In] object obj1) => ((FilesBAChapter) obj0).HelpOriginalFullFileName = (string) obj1;

    internal static object MoctEgf2Xt2oRBv3hsHS([In] object obj0) => (object) ((FilesExportSetting) obj0).AdditionalFilesOriginalFolder;

    internal static void OefZXJf2TLRcf6n2l0vU([In] object obj0, [In] object obj1) => ((FilesBAChapter) obj0).AdditionalFilesOriginalFolder = (string) obj1;

    internal static object W9X54kf2kKA2KpLwNMWE([In] object obj0) => (object) ((FilesBAChapter) obj0).HelpFileName;

    internal static bool duLJ1If2nGm9NbYjclP2([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object jSAarqf2OXUQpePOHH2r([In] object obj0) => (object) ((FilesBAChapter) obj0).AdditionalFilesOriginalFolder;

    internal static bool ABjqqff2VjKjrRbbk2Hs() => FilesBAConverter.n2UIKhf2Ia5mbsXIHQF0 == null;

    internal static FilesBAConverter knwQEDf2SjExu1qL4M9u() => FilesBAConverter.n2UIKhf2Ia5mbsXIHQF0;

    internal static object b755Ysf22naGtHo8inbc([In] object obj0, Guid uid) => (object) ((BPMAppManifest) obj0).GetChapter(uid);

    internal static void vI2Zi9f2eVhBan4J0wOs([In] object obj0, [In] object obj1) => ((FilesExportSetting) obj0).HelpFileName = (string) obj1;

    internal static void VAYeIAf2PqiXyXDoqWrW([In] object obj0, [In] object obj1) => ((FilesExportSetting) obj0).HelpOriginalFullFileName = (string) obj1;

    internal static void F5q1wYf210WJ6Yj8PQXt([In] object obj0, [In] object obj1) => ((FilesExportSetting) obj0).AdditionalFilesOriginalFolder = (string) obj1;
  }
}
