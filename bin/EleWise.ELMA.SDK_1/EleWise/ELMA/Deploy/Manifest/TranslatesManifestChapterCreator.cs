// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Manifest.TranslatesManifestChapterCreator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Manifest
{
  /// <summary>Точка расширения манифеста экспорта переводов</summary>
  [Component]
  internal class TranslatesManifestChapterCreator : IManifestChapterCreator
  {
    private static TranslatesManifestChapterCreator g6jrqBEpxqQS7WwycXGA;

    /// <inheritdoc />
    public void Resolve(ConfigExportSettings settings, ExportedObjectsDescription desc)
    {
      int num = 4;
      TranslateExportSettings customSetting;
      string path;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_11;
          case 2:
            if (customSetting == null)
            {
              num = 5;
              continue;
            }
            goto case 7;
          case 3:
            customSetting = settings.CustomSettings[TranslateExportConst.ExportExtensionUid] as TranslateExportSettings;
            num = 2;
            continue;
          case 4:
            if (settings.Manifest != null)
            {
              num = 3;
              continue;
            }
            goto label_16;
          case 5:
            goto label_2;
          case 6:
            this.DeleteDirectory(path);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
            continue;
          case 7:
            if (TranslatesManifestChapterCreator.QCTbBnEpyLKRxAaIVY1p((object) customSetting))
            {
              num = 8;
              continue;
            }
            goto label_6;
          case 8:
            path = (string) TranslatesManifestChapterCreator.LlVXruEpMyRbjJS7iHEf();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          case 9:
            goto label_5;
          default:
            this.AddExportPackages((IDictionary<string, IPackage>) desc.ExportPackages, (ICollection<PackageManifest>) settings.Manifest.Packages);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 6 : 1;
            continue;
        }
      }
label_11:
      return;
label_2:
      return;
label_5:
      return;
label_6:
      return;
label_16:;
    }

    private void AddExportPackages(
      IDictionary<string, IPackage> packages,
      ICollection<PackageManifest> packageManifest)
    {
      foreach (KeyValuePair<string, IPackage> package in (IEnumerable<KeyValuePair<string, IPackage>>) packages)
      {
        KeyValuePair<string, IPackage> exportTranslate = package;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (!packageManifest.Any<PackageManifest>((Func<PackageManifest, bool>) (x => TranslatesManifestChapterCreator.\u003C\u003Ec__DisplayClass1_0.TtWnaK82CXC89ZUYPtw8(TranslatesManifestChapterCreator.\u003C\u003Ec__DisplayClass1_0.sXAVEY82fhi6wB9TOO6p((object) x), TranslatesManifestChapterCreator.\u003C\u003Ec__DisplayClass1_0.O8ZVRv82QWcq68YWXxZg((object) exportTranslate.Value)))))
        {
          PackageManifest packageManifest1 = new PackageManifest()
          {
            Id = exportTranslate.Value.Id,
            Author = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852856616), exportTranslate.Value.Authors),
            Version = exportTranslate.Value.Version.ToString(),
            Title = exportTranslate.Value.Title,
            Description = exportTranslate.Value.Description,
            Dependencies = ManifestGeneratorHelper.GetDepedenciesFromPackage(exportTranslate.Value),
            Tags = exportTranslate.Value.Tags
          };
          packageManifest.AddIfNotContains<PackageManifest>(packageManifest1);
        }
      }
    }

    private void DeleteDirectory(string path)
    {
      switch (1)
      {
        case 1:
          try
          {
            TranslatesManifestChapterCreator.JtY5G7EpJAZkVSWULKPu((object) path, true);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
          catch (Exception ex)
          {
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_1;
                case 1:
                  TranslatesManifestChapterCreator.WSrxUqEpluyLyWwyvQec(TranslatesManifestChapterCreator.BoUiOQEp9JF4UTXD6Xvl(), TranslatesManifestChapterCreator.gdwOETEpd3gY6l9XvVKh((object) ex), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_13;
              }
            }
label_1:
            break;
label_13:
            break;
          }
      }
    }

    public TranslatesManifestChapterCreator()
    {
      TranslatesManifestChapterCreator.yO6FSnEprc8hBgqbrjmv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool QCTbBnEpyLKRxAaIVY1p([In] object obj0) => ((TranslateExportSettings) obj0).ExportTranslate;

    internal static object LlVXruEpMyRbjJS7iHEf() => (object) ManifestGeneratorHelper.CreateBaseDirForRemoteDomain();

    internal static bool WwZ926Ep0XpDjbl4SCaC() => TranslatesManifestChapterCreator.g6jrqBEpxqQS7WwycXGA == null;

    internal static TranslatesManifestChapterCreator vGoJXTEpmO0QBEPVp4KG() => TranslatesManifestChapterCreator.g6jrqBEpxqQS7WwycXGA;

    internal static void JtY5G7EpJAZkVSWULKPu([In] object obj0, [In] bool obj1) => Directory.Delete((string) obj0, obj1);

    internal static object BoUiOQEp9JF4UTXD6Xvl() => (object) Logger.Log;

    internal static object gdwOETEpd3gY6l9XvVKh([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void WSrxUqEpluyLyWwyvQec([In] object obj0, [In] object obj1, [In] object obj2) => ((EleWise.ELMA.Logging.ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void yO6FSnEprc8hBgqbrjmv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
