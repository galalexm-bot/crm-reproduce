// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.Services.PackagesBAConverter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.BPMApps.Services
{
  [Component(Order = 2500)]
  public class PackagesBAConverter : IBPMAppItemsConverter
  {
    private static readonly Guid _exportPackagesUid;
    private static PackagesBAConverter vnxqpkf2ljsNUlyHxOUN;

    public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
    {
      int num = 9;
      PackageExportSettings packageExportSettings;
      PackagesBAChapter packagesBaChapter1;
      object obj;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_11;
          case 1:
            PackagesBAConverter.dJDB9of2UlYGiy7g2GBD((object) bpmAppManifest, PackagesBAConverter._exportPackagesUid, PackagesBAConverter.pg4Toof2LOWO173tM9Cb((object) packageExportSettings));
            num = 10;
            continue;
          case 2:
            goto label_12;
          case 3:
            if (packagesBaChapter1.Packages != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 11 : 2;
              continue;
            }
            goto label_26;
          case 4:
            packagesBaChapter1.Packages = packageExportSettings.Packages.Select<PackageDescription, PackageBAItem>((Func<PackageDescription, PackageBAItem>) (p =>
            {
              PackageBAItem bpmAppManifest1 = new PackageBAItem();
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              PackagesBAConverter.\u003C\u003Ec.swCb7h8zjoeaCFg2wiGa((object) bpmAppManifest1, PackagesBAConverter.\u003C\u003Ec.Ra2RbQ8z5rTgESMaJG7I((object) p));
              // ISSUE: reference to a compiler-generated method
              bpmAppManifest1.PackageTitle = (string) PackagesBAConverter.\u003C\u003Ec.hpi8v98zYS8XKulFFds4((object) p);
              return bpmAppManifest1;
            })).ToList<PackageBAItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 3 : 2;
            continue;
          case 5:
            if (packageExportSettings != null)
            {
              PackagesBAChapter packagesBaChapter2 = new PackagesBAChapter();
              PackagesBAConverter.tAGD2Of2YytoMhj0bTHE((object) packagesBaChapter2, PackageExportConsts.ExportExtensionUid);
              packagesBaChapter1 = packagesBaChapter2;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 1;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          case 6:
            goto label_27;
          case 7:
            if (packageExportSettings.Packages != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 4 : 4;
              continue;
            }
            goto case 3;
          case 8:
            PackagesBAConverter.x4D3mUf2j2S2PNrpJTcM((object) settings, PackagesBAConverter.HNrBAdf25goZ99MBqxsi(-1867198571 ^ -1867242213));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 13 : 2;
            continue;
          case 9:
            Contract.ArgumentNotNull((object) bpmAppManifest, (string) PackagesBAConverter.HNrBAdf25goZ99MBqxsi(-1998538950 ^ -1998192728));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 8 : 2;
            continue;
          case 10:
            if (PackagesBAConverter.pg4Toof2LOWO173tM9Cb((object) packageExportSettings))
            {
              num = 7;
              continue;
            }
            goto case 3;
          case 11:
            if (packagesBaChapter1.Packages.Count <= 0)
            {
              num = 6;
              continue;
            }
            goto case 15;
          case 12:
            packageExportSettings = obj as PackageExportSettings;
            num = 5;
            continue;
          case 13:
            if (settings.CustomSettings.TryGetValue(PackageExportConsts.ExportExtensionUid, out obj))
            {
              num = 12;
              continue;
            }
            goto label_2;
          case 14:
            goto label_9;
          case 15:
            PackagesBAConverter.qgQuhHf2smSt1jAXLfoG((object) bpmAppManifest, (object) packagesBaChapter1);
            num = 2;
            continue;
          default:
            goto label_8;
        }
      }
label_11:
      return;
label_12:
      return;
label_27:
      return;
label_9:
      return;
label_8:
      return;
label_2:
      return;
label_26:;
    }

    public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
    {
      int num1 = 4;
      while (true)
      {
        PackagesBAChapter packagesBaChapter;
        PackageExportSettings packageExportSettings;
        List<PackageBAItem>.Enumerator enumerator;
        List<PackageDescription> list;
        switch (num1)
        {
          case 1:
            packageExportSettings = new PackageExportSettings();
            num1 = 2;
            continue;
          case 2:
            packageExportSettings.ExportPackages = bpmAppManifest.GetFlag(PackagesBAConverter._exportPackagesUid, PackagesBAConverter.pg4Toof2LOWO173tM9Cb((object) packageExportSettings));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 8 : 14;
            continue;
          case 3:
            PackagesBAConverter.x4D3mUf2j2S2PNrpJTcM((object) settings, PackagesBAConverter.HNrBAdf25goZ99MBqxsi(-1380439818 << 3 ^ 1841409342));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 1;
            continue;
          case 4:
            PackagesBAConverter.x4D3mUf2j2S2PNrpJTcM((object) bpmAppManifest, PackagesBAConverter.HNrBAdf25goZ99MBqxsi(~541731958 ^ -542074085));
            num1 = 3;
            continue;
          case 5:
            IDeployManager serviceNotNull = Locator.GetServiceNotNull<IDeployManager>();
            PackageFilter packageFilter = new PackageFilter();
            PackagesBAConverter.QRoJwvfeF5JcrPrZEZV6((object) packageFilter, PackageLevel.All);
            PackagesBAConverter.U5yoSnfeBJrIt1Rk8Fe8((object) packageFilter, PackageStatus.Any);
            PackageFilter filter = packageFilter;
            list = serviceNotNull.FindPackages(filter).ToList<PackageDescription>();
            num1 = 9;
            continue;
          case 6:
            if (packagesBaChapter.Packages != null)
            {
              num1 = 12;
              continue;
            }
            break;
          case 7:
            if (packagesBaChapter != null)
            {
              num1 = 6;
              continue;
            }
            break;
          case 8:
            goto label_34;
          case 9:
            enumerator = packagesBaChapter.Packages.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 4 : 10;
            continue;
          case 10:
            try
            {
label_11:
              if (enumerator.MoveNext())
                goto label_15;
              else
                goto label_12;
label_6:
              PackageDescription packageDescription;
              PackageBAItem current;
              IEnumerable<PackageDescription> source;
              int num2;
              PackageBAItem pkg1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                  case 5:
                    if (packageDescription == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                      continue;
                    }
                    goto case 6;
                  case 2:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 11 : 6;
                    continue;
                  case 3:
                    goto label_15;
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    packageDescription = source.FirstOrDefault<PackageDescription>((Func<PackageDescription, bool>) (p => PackagesBAConverter.\u003C\u003Ec.aKGRVN8zLey0MmaLDUTC((object) p)));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 7 : 6;
                    continue;
                  case 6:
                    packageExportSettings.Packages.Add(packageDescription);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 9;
                    continue;
                  case 7:
                    if (packageDescription != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
                      continue;
                    }
                    goto case 10;
                  case 8:
                    goto label_31;
                  case 10:
                    packageDescription = source.FirstOrDefault<PackageDescription>();
                    num2 = 5;
                    continue;
                  case 11:
                    pkg1 = current;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 12 : 2;
                    continue;
                  case 12:
                    source = list.Where<PackageDescription>((Func<PackageDescription, bool>) (p =>
                    {
                      int num3 = 1;
                      while (true)
                      {
                        switch (num3)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            if (PackagesBAConverter.\u003C\u003Ec__DisplayClass1_0.M7NM3uZFFyCMDZ6Cok43((object) p) != null)
                            {
                              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                              continue;
                            }
                            goto label_3;
                          default:
                            goto label_2;
                        }
                      }
label_2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      return PackagesBAConverter.\u003C\u003Ec__DisplayClass1_0.J7GB7IZFByw6ttHcZJ5g(PackagesBAConverter.\u003C\u003Ec__DisplayClass1_0.M7NM3uZFFyCMDZ6Cok43((object) p), (object) pkg1.PackageId, StringComparison.CurrentCultureIgnoreCase);
label_3:
                      return false;
                    }));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 4 : 4;
                    continue;
                  default:
                    goto label_11;
                }
              }
label_12:
              num2 = 8;
              goto label_6;
label_15:
              current = enumerator.Current;
              num2 = 2;
              goto label_6;
            }
            finally
            {
              enumerator.Dispose();
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
                num4 = 0;
              switch (num4)
              {
                default:
              }
            }
          case 11:
            packageExportSettings.Packages = new List<PackageDescription>();
            num1 = 5;
            continue;
          case 12:
            if (PackagesBAConverter.XlMvH9f2zkQpgwbAKyfC((object) packagesBaChapter.Packages) <= 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            }
            goto case 11;
          case 14:
            packagesBaChapter = PackagesBAConverter.mHgY5Yf2conm1j43K0Xf((object) bpmAppManifest, PackageExportConsts.ExportExtensionUid) as PackagesBAChapter;
            num1 = 7;
            continue;
        }
label_31:
        settings.CustomSettings[PackageExportConsts.ExportExtensionUid] = (object) packageExportSettings;
        num1 = 8;
      }
label_34:;
    }

    public PackagesBAConverter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PackagesBAConverter()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PackagesBAConverter._exportPackagesUid = new Guid((string) PackagesBAConverter.HNrBAdf25goZ99MBqxsi(-606654180 ^ -606963522));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
            continue;
          case 2:
            PackagesBAConverter.MLeh88feWiV9NJcgVb8V();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object HNrBAdf25goZ99MBqxsi(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void x4D3mUf2j2S2PNrpJTcM([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void tAGD2Of2YytoMhj0bTHE([In] object obj0, Guid value) => ((BPMAppManifestChapter) obj0).Uid = value;

    internal static bool pg4Toof2LOWO173tM9Cb([In] object obj0) => ((PackageExportSettings) obj0).ExportPackages;

    internal static void dJDB9of2UlYGiy7g2GBD([In] object obj0, Guid uid, bool value) => ((BPMAppManifest) obj0).SetFlag(uid, value);

    internal static void qgQuhHf2smSt1jAXLfoG([In] object obj0, [In] object obj1) => ((BPMAppManifest) obj0).SetChapter((BPMAppManifestChapter) obj1);

    internal static bool R7vnNDf2rWXBQflce80d() => PackagesBAConverter.vnxqpkf2ljsNUlyHxOUN == null;

    internal static PackagesBAConverter fWeaWbf2g5vq0Ci2Zb0W() => PackagesBAConverter.vnxqpkf2ljsNUlyHxOUN;

    internal static object mHgY5Yf2conm1j43K0Xf([In] object obj0, Guid uid) => (object) ((BPMAppManifest) obj0).GetChapter(uid);

    internal static int XlMvH9f2zkQpgwbAKyfC([In] object obj0) => ((List<PackageBAItem>) obj0).Count;

    internal static void QRoJwvfeF5JcrPrZEZV6([In] object obj0, PackageLevel value) => ((PackageFilter) obj0).Level = value;

    internal static void U5yoSnfeBJrIt1Rk8Fe8([In] object obj0, PackageStatus value) => ((PackageFilter) obj0).Status = value;

    internal static void MLeh88feWiV9NJcgVb8V() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
