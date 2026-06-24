// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.PackageStoreComponentInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Packaging
{
  /// <summary>
  /// Информация о компоненте ELMA Store на основании пакета
  /// </summary>
  public class PackageStoreComponentInfo : StoreComponentInfoBase
  {
    private static PackageStoreComponentInfo urdhC9BnzQHTXG6GVXgZ;

    /// <summary>Ctor</summary>
    /// <param name="package">Описание пакета</param>
    /// <param name="isDeprecated">Является ли устаревшим?</param>
    public PackageStoreComponentInfo(PackageDescription package, bool isDeprecated = false)
    {
      PackageStoreComponentInfo.vAGlP8BOWg508P3XQ4Cb();
      // ISSUE: explicit constructor call
      base.\u002Ector(isDeprecated);
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_3;
          case 3:
            if (package != null)
            {
              this.Package = package;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 2 : 2;
            continue;
          default:
            this.Modules = new List<IModule>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 1;
            continue;
        }
      }
label_2:
      return;
label_3:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210656621));
    }

    /// <summary>Пакет</summary>
    public PackageDescription Package
    {
      get => this.\u003CPackage\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CPackage\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Список модулей, входящих в данный компонент</summary>
    public List<IModule> Modules { get; private set; }

    public override string Id => (string) PackageStoreComponentInfo.EEjuxyBOoG8SRthc6xJ7((object) this.Package);

    public override string Title
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!string.IsNullOrEmpty((string) PackageStoreComponentInfo.LEqEppBObVeYQCQSFn2n((object) this.Package)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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
        return this.Package.Id;
label_5:
        return this.Package.Title;
      }
    }

    public override string Description => (string) PackageStoreComponentInfo.g21eIhBOh9sGqRISVx8l((object) this.Package);

    public override string Author => string.Join((string) PackageStoreComponentInfo.aKdLYJBOGtiePaJkwfhR(1232639661 >> 3 ^ 154083031), this.Package.Authors);

    public override string Site => (string) null;

    public override ManifestComponentType Type => ManifestComponentType.Module;

    public override IEnumerable<PackageDescription> AllPackages => (IEnumerable<PackageDescription>) new PackageDescription[1]
    {
      this.Package
    };

    public override IEnumerable<IModule> AllModules => (IEnumerable<IModule>) this.Modules;

    public override bool IsInstalled => PackageStoreComponentInfo.quNYshBOE7nuCjhY9feh((object) this.Package);

    public override SemanticVersion InstalledVersion => (SemanticVersion) PackageStoreComponentInfo.qaajPKBOfC87TYKy3DWr((object) this.Package);

    public override SemanticVersion LastVersion => (SemanticVersion) PackageStoreComponentInfo.m9NMsIBOQkghEh9esM2G((object) this.Package);

    internal static void vAGlP8BOWg508P3XQ4Cb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ADOk0QBOFSg2USVgemNM() => PackageStoreComponentInfo.urdhC9BnzQHTXG6GVXgZ == null;

    internal static PackageStoreComponentInfo fQH4FwBOBw2s1RXvqwdw() => PackageStoreComponentInfo.urdhC9BnzQHTXG6GVXgZ;

    internal static object EEjuxyBOoG8SRthc6xJ7([In] object obj0) => (object) ((PackageDescription) obj0).Id;

    internal static object LEqEppBObVeYQCQSFn2n([In] object obj0) => (object) ((PackageDescription) obj0).Title;

    internal static object g21eIhBOh9sGqRISVx8l([In] object obj0) => (object) ((PackageDescription) obj0).Description;

    internal static object aKdLYJBOGtiePaJkwfhR(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool quNYshBOE7nuCjhY9feh([In] object obj0) => ((PackageDescription) obj0).IsInstalled;

    internal static object qaajPKBOfC87TYKy3DWr([In] object obj0) => (object) ((PackageDescription) obj0).InstalledVersion;

    internal static object m9NMsIBOQkghEh9esM2G([In] object obj0) => (object) ((PackageDescription) obj0).LastVersion;
  }
}
