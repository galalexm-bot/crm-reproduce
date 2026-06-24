// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Manifest.PackagesManifestChapterCreator
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
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Manifest
{
  [Component]
  public class PackagesManifestChapterCreator : IManifestChapterCreator
  {
    private static PackagesManifestChapterCreator mH6LUpEauq986n6RulCB;

    public void Resolve(ConfigExportSettings settings, ExportedObjectsDescription desc)
    {
      int num1 = 5;
      string tmpPath;
      PackageExportSettings customSetting;
      Dictionary<string, IPackage>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            tmpPath = (string) PackagesManifestChapterCreator.QwgYEMEaRw5Uka9MwUD5();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 10 : 3;
            continue;
          case 2:
            goto label_41;
          case 3:
            try
            {
label_21:
              if (enumerator.MoveNext())
                goto label_29;
              else
                goto label_22;
label_17:
              PackageManifest packageManifest1;
              List<Assembly> packageAssemblies;
              KeyValuePair<string, IPackage> current;
              List<string> extPoints;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    packageAssemblies = ManifestGeneratorHelper.GetPackageAssemblies(tmpPath, current.Value);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 6 : 3;
                    continue;
                  case 2:
                    packageManifest1.StoredProcedures = ManifestGeneratorHelper.GetStoredProceduresFromAssemblies(packageAssemblies);
                    num2 = 10;
                    continue;
                  case 3:
                    goto label_29;
                  case 4:
                    goto label_21;
                  case 5:
                    PackageManifest packageManifest2 = new PackageManifest();
                    PackagesManifestChapterCreator.pGSgFTEaKrXfAKdWtCIs((object) packageManifest2, PackagesManifestChapterCreator.NcCMBuEaqncmDxR8vq4v((object) current.Value));
                    PackagesManifestChapterCreator.aAJSvFEaTcFE8LGHdxAx((object) packageManifest2, (object) string.Join((string) PackagesManifestChapterCreator.i0vcyBEaXR7t2KW0OJ8J(132912447 ^ 132923875), current.Value.Authors));
                    packageManifest2.Version = current.Value.Version.ToString();
                    packageManifest2.Title = (string) PackagesManifestChapterCreator.EUpTcBEakPvYg0oWW77w((object) current.Value);
                    packageManifest2.Description = (string) PackagesManifestChapterCreator.d292hmEanUXZQfyIRW3p((object) current.Value);
                    packageManifest2.Dependencies = ManifestGeneratorHelper.GetDepedenciesFromPackage(current.Value);
                    packageManifest1 = packageManifest2;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
                    continue;
                  case 6:
                    packageManifest1.Enums = ManifestGeneratorHelper.GetEnumsFromAssemblies(packageAssemblies);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 9;
                    continue;
                  case 7:
                    packageManifest1.Components = ManifestGeneratorHelper.GetComponentsFromAssemblies(packageAssemblies, extPoints);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 8 : 6;
                    continue;
                  case 8:
                    ((ElmaStoreComponentManifest) PackagesManifestChapterCreator.zaUeM3EaSxTUxTjoXu1C((object) settings)).Packages.Add(packageManifest1);
                    num2 = 4;
                    continue;
                  case 9:
                    packageManifest1.Entities = ManifestGeneratorHelper.GetEntitiesFromAssemblies(packageAssemblies);
                    num2 = 2;
                    continue;
                  case 10:
                    packageManifest1.ExtensionPoints = ManifestGeneratorHelper.GetExtensionPointsFromAssemblies(packageAssemblies, out extPoints);
                    num2 = 7;
                    continue;
                  default:
                    goto label_14;
                }
              }
label_22:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              goto label_17;
label_29:
              current = enumerator.Current;
              num2 = 5;
              goto label_17;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 4:
            customSetting = settings.CustomSettings[PackageExportConsts.ExportExtensionUid] as PackageExportSettings;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          case 5:
            if (PackagesManifestChapterCreator.zaUeM3EaSxTUxTjoXu1C((object) settings) != null)
            {
              num1 = 4;
              continue;
            }
            goto label_36;
          case 6:
            goto label_2;
          case 7:
label_14:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 3 : 6;
            continue;
          case 8:
            goto label_38;
          case 9:
            if (!PackagesManifestChapterCreator.XmdGD6EaiyFbs3ERalhw((object) customSetting))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 0;
              continue;
            }
            goto case 1;
          case 10:
            enumerator = desc.ExportPackages.GetEnumerator();
            num1 = 3;
            continue;
          case 11:
            goto label_5;
          default:
            if (customSetting != null)
            {
              num1 = 9;
              continue;
            }
            goto label_34;
        }
      }
label_41:
      return;
label_38:
      return;
label_5:
      return;
label_2:
      try
      {
        PackagesManifestChapterCreator.rlhqgPEaOUyjN8OQISug((object) tmpPath, true);
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
          num4 = 0;
        switch (num4)
        {
          case 0:
            return;
          default:
            return;
        }
      }
      catch (Exception ex)
      {
        int num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
          num5 = 1;
        while (true)
        {
          switch (num5)
          {
            case 0:
              goto label_11;
            case 1:
              PackagesManifestChapterCreator.KVcaWLEaPjEIkhDdQcBt(PackagesManifestChapterCreator.J81ifsEa2dXcQM5RXddQ(), PackagesManifestChapterCreator.WkqWNiEaeRgQ0B8sH5Av((object) ex), (object) ex);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
              continue;
            default:
              goto label_9;
          }
        }
label_11:
        return;
label_9:
        return;
      }
label_34:
      return;
label_36:;
    }

    public PackagesManifestChapterCreator()
    {
      PackagesManifestChapterCreator.g4ciYtEa1Sdcsb1iNScf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object zaUeM3EaSxTUxTjoXu1C([In] object obj0) => (object) ((ConfigExportSettings) obj0).Manifest;

    internal static bool XmdGD6EaiyFbs3ERalhw([In] object obj0) => ((PackageExportSettings) obj0).ExportPackages;

    internal static object QwgYEMEaRw5Uka9MwUD5() => (object) ManifestGeneratorHelper.CreateBaseDirForRemoteDomain();

    internal static object NcCMBuEaqncmDxR8vq4v([In] object obj0) => (object) ((IPackageName) obj0).Id;

    internal static void pGSgFTEaKrXfAKdWtCIs([In] object obj0, [In] object obj1) => ((PackageManifest) obj0).Id = (string) obj1;

    internal static object i0vcyBEaXR7t2KW0OJ8J(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void aAJSvFEaTcFE8LGHdxAx([In] object obj0, [In] object obj1) => ((PackageManifest) obj0).Author = (string) obj1;

    internal static object EUpTcBEakPvYg0oWW77w([In] object obj0) => (object) ((IPackageMetadata) obj0).Title;

    internal static object d292hmEanUXZQfyIRW3p([In] object obj0) => (object) ((IPackageMetadata) obj0).Description;

    internal static void rlhqgPEaOUyjN8OQISug([In] object obj0, [In] bool obj1) => Directory.Delete((string) obj0, obj1);

    internal static object J81ifsEa2dXcQM5RXddQ() => (object) Logger.Log;

    internal static object WkqWNiEaeRgQ0B8sH5Av([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void KVcaWLEaPjEIkhDdQcBt([In] object obj0, [In] object obj1, [In] object obj2) => ((EleWise.ELMA.Logging.ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static bool ThThCcEaIoPXeHjMHa1l() => PackagesManifestChapterCreator.mH6LUpEauq986n6RulCB == null;

    internal static PackagesManifestChapterCreator aBhrepEaVBIRSN8S4fRY() => PackagesManifestChapterCreator.mH6LUpEauq986n6RulCB;

    internal static void g4ciYtEa1Sdcsb1iNScf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
