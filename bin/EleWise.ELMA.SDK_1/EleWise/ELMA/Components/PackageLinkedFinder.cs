// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.PackageLinkedFinder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Packaging;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components
{
  /// <summary>Расширение для поиска связных пакетов</summary>
  [Component]
  internal sealed class PackageLinkedFinder : StringKeyLinkedFinder
  {
    private readonly IDeployManager deployManager;
    internal static PackageLinkedFinder hEVpPafGb3RhePr2y60C;

    /// <summary>Ctor</summary>
    /// <param name="deployManager">Менеджер деплоя</param>
    public PackageLinkedFinder(IDeployManager deployManager)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.deployManager = deployManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public override FindLinkedObjectsResult FindLinkedObjects(
      ICollection<ILinkedObject> objectsToSearch,
      LinkedObjectsContext context)
    {
      FindLinkedObjectsResult resultObj = new FindLinkedObjectsResult();
      foreach (IStringKeyLinkedObject stringKeyLinkedObject in objectsToSearch.OfType<IStringKeyLinkedObject>())
      {
        if (this.GetData(stringKeyLinkedObject.UidStr, context) is PackageDescription data)
        {
          foreach (PackageDescription packageDependency in this.deployManager.FindPackageDependencies(data))
            this.FillStrObj(resultObj, context, packageDependency.Id);
        }
      }
      return resultObj;
    }

    /// <inheritdoc />
    protected override object GetDataWithUidStr(string uidStr, LinkedObjectsContext context)
    {
      int num = 1;
      PackageFilter filter;
      List<PackageDescription> packages;
      while (true)
      {
        switch (num)
        {
          case 1:
            PackageFilter packageFilter = new PackageFilter();
            PackageLinkedFinder.HJ5KwGfGE2m2NFuQGL1p((object) packageFilter, PackageLevel.All);
            PackageLinkedFinder.WDPT0sfGfhFLEDcWS3dY((object) packageFilter, PackageStatus.Any);
            packageFilter.SearchString = uidStr;
            filter = packageFilter;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            packages = this.deployManager.FindPackages(filter);
            if (packages == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 2;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return (object) null;
label_6:
      return (object) packages.FirstOrDefault<PackageDescription>();
    }

    internal static bool gPqyksfGhdYmLNTd8sSC() => PackageLinkedFinder.hEVpPafGb3RhePr2y60C == null;

    internal static PackageLinkedFinder dPjwsKfGG7c3vNGBg84I() => PackageLinkedFinder.hEVpPafGb3RhePr2y60C;

    internal static void HJ5KwGfGE2m2NFuQGL1p([In] object obj0, PackageLevel value) => ((PackageFilter) obj0).Level = value;

    internal static void WDPT0sfGfhFLEDcWS3dY([In] object obj0, PackageStatus value) => ((PackageFilter) obj0).Status = value;
  }
}
