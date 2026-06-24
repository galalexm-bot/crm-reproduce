// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Packaging.ManifestStoreComponentInfo
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
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Packaging
{
  /// <summary>
  /// Информация о компоненте ELMA Store на основании манифеста
  /// </summary>
  public class ManifestStoreComponentInfo : StoreComponentInfoBase
  {
    private ElmaStoreComponentManifest _manifest;
    private string _imagePath;
    private static ManifestStoreComponentInfo XQdm0FBnnm8wVjsLyn43;

    /// <summary>Ctor</summary>
    /// <param name="installedManifest">Описание установленного компонента Elma Store</param>
    /// <param name="lastManifest">Описание компонента Elma Store последней версии</param>
    /// <param name="installedFile">Файл установленного компонента Elma Store</param>
    /// <param name="lastFile">Файл компонента Elma Store последней версии</param>
    /// <param name="isDeprecated">Является ли устаревшим?</param>
    public ManifestStoreComponentInfo(
      ElmaStoreComponentManifest installedManifest,
      ElmaStoreComponentManifest lastManifest,
      ElmaStoreComponentFile installedFile,
      ElmaStoreComponentFile lastFile,
      bool isDeprecated = false)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(isDeprecated);
      int num1 = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num1 = 0;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            if (installedManifest != null)
            {
              num1 = 10;
              continue;
            }
            goto case 3;
          case 2:
            this.LastManifest = lastManifest;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
            continue;
          case 3:
            if (lastManifest == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 3 : 8;
              continue;
            }
            goto case 10;
          case 4:
            this._imagePath = installedFile != null ? (string) ManifestStoreComponentInfo.hKD5NWBnP3qgeQVr3HKe((object) installedFile) : (lastFile == null ? (string) (object) null : lastFile.IconPath);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 6 : 5;
            continue;
          case 5:
            this.ElmaPackages = new List<PackageDescription>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 9;
            continue;
          case 6:
            goto label_18;
          case 7:
            this.LastFile = lastFile;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 11;
            continue;
          case 8:
            goto label_14;
          case 9:
            this.Modules = new List<IModule>();
            num2 = 12;
            break;
          case 10:
            this.Packages = new List<PackageDescription>();
            num2 = 5;
            break;
          case 11:
            ElmaStoreComponentManifest componentManifest = installedManifest;
            this._manifest = componentManifest == null ? lastManifest : componentManifest;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 3 : 4;
            continue;
          case 12:
            this.InstalledManifest = installedManifest;
            num1 = 2;
            continue;
          default:
            this.InstalledFile = installedFile;
            num1 = 7;
            continue;
        }
        num1 = num2;
      }
label_18:
      return;
label_14:
      throw new ArgumentNullException((string) ManifestStoreComponentInfo.HbVZdNBnesf89mYQoQKK(--1333735954 ^ 1333658362));
    }

    /// <summary>Ссылка на иконку компонента</summary>
    public override string ImagePath => this._imagePath;

    /// <summary>Манифест установленной версии</summary>
    public ElmaStoreComponentManifest InstalledManifest
    {
      get => this.\u003CInstalledManifest\u003Ek__BackingField;
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
              this.\u003CInstalledManifest\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
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

    /// <summary>Файл компонента установленной версии (если доступен)</summary>
    public ElmaStoreComponentFile InstalledFile
    {
      get => this.\u003CInstalledFile\u003Ek__BackingField;
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
              this.\u003CInstalledFile\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
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

    /// <summary>Манифест последней версии</summary>
    public ElmaStoreComponentManifest LastManifest
    {
      get => this.\u003CLastManifest\u003Ek__BackingField;
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
              this.\u003CLastManifest\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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

    /// <summary>Файл компонента последней версии (если доступен)</summary>
    public ElmaStoreComponentFile LastFile
    {
      get => this.\u003CLastFile\u003Ek__BackingField;
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
              this.\u003CLastFile\u003Ek__BackingField = value;
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

    /// <summary>
    /// Список пакетов ELMA (без учета системных), входящих в данный компонент
    /// </summary>
    public List<PackageDescription> ElmaPackages { get; private set; }

    /// <summary>Список пакетов, входящих в данный компонент</summary>
    public List<PackageDescription> Packages { get; private set; }

    /// <summary>Список модулей, входящих в данный компонент</summary>
    public List<IModule> Modules { get; private set; }

    public override string Id => (string) ManifestStoreComponentInfo.CAyL5gBn1OgEW5mq2yoc((object) this._manifest);

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
              if (!ManifestStoreComponentInfo.uItG3ZBn30C43aqQIa7D(ManifestStoreComponentInfo.En03bMBnN9f5ksAZHhkX((object) this._manifest)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
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
        return (string) ManifestStoreComponentInfo.CAyL5gBn1OgEW5mq2yoc((object) this._manifest);
label_5:
        return (string) ManifestStoreComponentInfo.En03bMBnN9f5ksAZHhkX((object) this._manifest);
      }
    }

    public override string Description => (string) ManifestStoreComponentInfo.EKM6JRBnp3QG68afe3fc((object) this._manifest);

    public override string Author => this._manifest.Author;

    public override string Site => (string) ManifestStoreComponentInfo.ul4SgWBna0SuXx6JTRBh((object) this._manifest);

    public override ManifestComponentType Type => ManifestStoreComponentInfo.QwofqYBnD3CLfLReYA7C((object) this._manifest);

    public override IEnumerable<PackageDescription> AllPackages => (IEnumerable<PackageDescription>) this.Packages;

    public override IEnumerable<IModule> AllModules => (IEnumerable<IModule>) this.Modules;

    public override bool IsInstalled
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.InstalledManifest != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_7;
            case 3:
              goto label_4;
            default:
              if (this.ElmaPackages.Any<PackageDescription>())
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 2;
                continue;
              }
              goto label_8;
          }
        }
label_4:
        return false;
label_7:
        return this.ElmaPackages.All<PackageDescription>((Func<PackageDescription, bool>) (p => ManifestStoreComponentInfo.\u003C\u003Ec.psGCOCQVuSSC1nStVhlQ((object) p)));
label_8:
        return true;
      }
    }

    public override SemanticVersion InstalledVersion
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
              if (this.InstalledManifest != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return (SemanticVersion) null;
label_3:
        return (SemanticVersion) ManifestStoreComponentInfo.cRKe6tBntNPI70eiZC0w((object) this.InstalledManifest);
      }
    }

    public override SemanticVersion LastVersion
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (this.LastManifest != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return (SemanticVersion) null;
label_5:
        return (SemanticVersion) ManifestStoreComponentInfo.cRKe6tBntNPI70eiZC0w((object) this.LastManifest);
      }
    }

    /// <summary>
    /// Требуется ли перезагрузка сервера после установки/обновления Store-компонента.
    /// </summary>
    public override bool DoesInstallOrUpdateRequireRestart
    {
      get
      {
        int num = 1;
        ElmaStoreComponentManifest lastManifest;
        while (true)
        {
          switch (num)
          {
            case 1:
              lastManifest = this.LastManifest;
              if (lastManifest == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return false;
label_5:
        return lastManifest.Packages.Count > 0;
      }
    }

    internal static object HbVZdNBnesf89mYQoQKK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object hKD5NWBnP3qgeQVr3HKe([In] object obj0) => (object) ((ElmaStoreComponentFile) obj0).IconPath;

    internal static bool X4sasEBnO0Ca5X4dfEaZ() => ManifestStoreComponentInfo.XQdm0FBnnm8wVjsLyn43 == null;

    internal static ManifestStoreComponentInfo AfQYyqBn2N4LhnulM4Er() => ManifestStoreComponentInfo.XQdm0FBnnm8wVjsLyn43;

    internal static object CAyL5gBn1OgEW5mq2yoc([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Id;

    internal static object En03bMBnN9f5ksAZHhkX([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Title;

    internal static bool uItG3ZBn30C43aqQIa7D([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object EKM6JRBnp3QG68afe3fc([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Description;

    internal static object ul4SgWBna0SuXx6JTRBh([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Site;

    internal static ManifestComponentType QwofqYBnD3CLfLReYA7C([In] object obj0) => ((ElmaStoreComponentManifest) obj0).ProductType;

    internal static object cRKe6tBntNPI70eiZC0w([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).SemanticVersion;
  }
}
