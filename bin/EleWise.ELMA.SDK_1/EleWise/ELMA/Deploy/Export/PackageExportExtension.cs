// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.PackageExportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Export
{
  [Component(Order = 400)]
  public class PackageExportExtension : IConfigExportExtension
  {
    public const string ServiceDataPrefix = "PackageToExport";
    internal static PackageExportExtension JWfkVLEjsEkXS1b40mEA;

    public Dictionary<Guid, object> GetNewSettingObj() => new Dictionary<Guid, object>()
    {
      {
        PackageExportConsts.ExportExtensionUid,
        (object) new PackageExportSettings()
      }
    };

    public void AddExportObjects(ExportExtensionParams parameters)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        PackageExportSettings parameter;
        PackageService serviceNotNull;
        IEnumerable<PackageDescription> allPackages;
        ExportExtensionParams parameters1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_6;
            case 1:
              parameter.Packages.ForEach((Action<PackageDescription>) (package =>
              {
                int num3 = 4;
                PackageDescription packageDescription;
                PackageDescription package1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      packageDescription = allPackages.FirstOrDefault<PackageDescription>((Func<PackageDescription, bool>) (p => PackageExportExtension.\u003C\u003Ec__DisplayClass2_1.DHYwOH8xzvrjEfsUWgtr(PackageExportExtension.\u003C\u003Ec__DisplayClass2_1.eraEGA8xcka0oamcfevy((object) p), PackageExportExtension.\u003C\u003Ec__DisplayClass2_1.eraEGA8xcka0oamcfevy((object) package1), StringComparison.Ordinal)));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 2;
                      continue;
                    case 2:
                      parameters1.PackageDescriptions.Add(packageDescription);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                      continue;
                    case 3:
                      package1 = package;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
                      continue;
                    case 4:
                      num3 = 3;
                      continue;
                    default:
                      goto label_7;
                  }
                }
label_2:
                return;
label_7:;
              }));
              num2 = 6;
              continue;
            case 2:
              if (PackageExportExtension.sWvumLEYFhDE0k2FDE68((object) parameter))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 5 : 5;
                continue;
              }
              goto label_16;
            case 3:
              goto label_7;
            case 4:
              PackageService packageService = serviceNotNull;
              PackageFilter filter = new PackageFilter();
              PackageExportExtension.Pocb2AEYBhwu9ML70QAT((object) filter, PackageLevel.All);
              PackageExportExtension.eQHZbDEYW7RRlbqRoWQ0((object) filter, PackageStatus.Any);
              allPackages = packageService.Find(filter);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
              continue;
            case 5:
              serviceNotNull = Locator.GetServiceNotNull<PackageService>();
              num2 = 4;
              continue;
            case 6:
              goto label_9;
            case 7:
              parameter = parameters1.Parameters[PackageExportConsts.ExportExtensionUid] as PackageExportSettings;
              num2 = 3;
              continue;
            case 8:
              parameters1 = parameters;
              num2 = 7;
              continue;
            case 9:
              num2 = 8;
              continue;
            default:
              goto label_17;
          }
        }
label_7:
        if (parameter != null)
          num1 = 2;
        else
          goto label_3;
      }
label_6:
      return;
label_9:
      return;
label_17:
      return;
label_3:
      return;
label_16:;
    }

    public PackageExportExtension()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool sWvumLEYFhDE0k2FDE68([In] object obj0) => ((PackageExportSettings) obj0).ExportPackages;

    internal static void Pocb2AEYBhwu9ML70QAT([In] object obj0, PackageLevel value) => ((PackageFilter) obj0).Level = value;

    internal static void eQHZbDEYW7RRlbqRoWQ0([In] object obj0, PackageStatus value) => ((PackageFilter) obj0).Status = value;

    internal static bool h2JKZuEjc8bjKmkGfrM2() => PackageExportExtension.JWfkVLEjsEkXS1b40mEA == null;

    internal static PackageExportExtension JDfYH8EjzC5hPngiMCC9() => PackageExportExtension.JWfkVLEjsEkXS1b40mEA;
  }
}
