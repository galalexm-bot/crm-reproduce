// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.AssemblyStoreComponentInfo
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
  /// Информация о компоненте ELMA Store на основании сборки
  /// </summary>
  public class AssemblyStoreComponentInfo : StoreComponentInfoBase
  {
    internal static AssemblyStoreComponentInfo EKanfZBnIcxjuCh4s4uj;

    /// <summary>Ctor</summary>
    /// <param name="module">Модуль приложения</param>
    /// <param name="isDeprecated">Является ли устаревшим?</param>
    public AssemblyStoreComponentInfo(IModule module, bool isDeprecated = false)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(isDeprecated);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (module != null)
            {
              num = 3;
              continue;
            }
            goto label_4;
          case 2:
            goto label_3;
          case 3:
            this.Module = module;
            num = 2;
            continue;
          default:
            goto label_4;
        }
      }
label_3:
      return;
label_4:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154018317));
    }

    /// <summary>Манифест</summary>
    public IModule Module
    {
      get => this.\u003CModule\u003Ek__BackingField;
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
              this.\u003CModule\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
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

    public override string Id => (string) AssemblyStoreComponentInfo.xLGcInBnisnpBZTUl4Bc((object) this.Module);

    public override string Title
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (!AssemblyStoreComponentInfo.UAUYWxBnqAL5DU03VQuV(AssemblyStoreComponentInfo.Fn6cwmBnR9D42XE93QOj((object) this.Module)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return (string) AssemblyStoreComponentInfo.xLGcInBnisnpBZTUl4Bc((object) this.Module);
label_3:
        return this.Module.Title;
      }
    }

    public override string Description => (string) AssemblyStoreComponentInfo.U8C56nBnKjOYswQT5ocy((object) this.Module);

    public override string Author => (string) AssemblyStoreComponentInfo.vIGLe1BnXavh5ebnfcHM((object) this.Module);

    public override string Site => (string) AssemblyStoreComponentInfo.fWOkOsBnTvnDsZDfmebk((object) this.Module);

    public override ManifestComponentType Type => ManifestComponentType.Module;

    public override IEnumerable<PackageDescription> AllPackages => (IEnumerable<PackageDescription>) new PackageDescription[0];

    public override IEnumerable<IModule> AllModules => (IEnumerable<IModule>) new IModule[1]
    {
      this.Module
    };

    public override bool IsInstalled => true;

    public override SemanticVersion InstalledVersion
    {
      get
      {
        int num = 1;
        SemanticVersion installedVersion;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!AssemblyStoreComponentInfo.UAUYWxBnqAL5DU03VQuV(AssemblyStoreComponentInfo.HKOZ8DBnkWy0l1PWS5bY((object) this.Module)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              goto label_2;
            default:
              if (SemanticVersion.TryParse(this.Module.Version, out installedVersion))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 1;
                continue;
              }
              goto label_3;
          }
        }
label_2:
        return installedVersion;
label_3:
        return (SemanticVersion) null;
      }
    }

    public override SemanticVersion LastVersion => (SemanticVersion) null;

    internal static bool iXCOViBnViGcG3osoeNV() => AssemblyStoreComponentInfo.EKanfZBnIcxjuCh4s4uj == null;

    internal static AssemblyStoreComponentInfo v1ER6lBnSumMwf8uD9ij() => AssemblyStoreComponentInfo.EKanfZBnIcxjuCh4s4uj;

    internal static object xLGcInBnisnpBZTUl4Bc([In] object obj0) => (object) ((IApplicationUnit) obj0).Id;

    internal static object Fn6cwmBnR9D42XE93QOj([In] object obj0) => (object) ((IApplicationUnit) obj0).Title;

    internal static bool UAUYWxBnqAL5DU03VQuV([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object U8C56nBnKjOYswQT5ocy([In] object obj0) => (object) ((IApplicationUnit) obj0).Description;

    internal static object vIGLe1BnXavh5ebnfcHM([In] object obj0) => (object) ((IApplicationUnit) obj0).Author;

    internal static object fWOkOsBnTvnDsZDfmebk([In] object obj0) => (object) ((IModule) obj0).WebSite;

    internal static object HKOZ8DBnkWy0l1PWS5bY([In] object obj0) => (object) ((IApplicationUnit) obj0).Version;
  }
}
