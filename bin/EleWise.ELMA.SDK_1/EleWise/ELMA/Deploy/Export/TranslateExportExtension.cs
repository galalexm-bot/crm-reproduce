// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.TranslateExportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.Managers;
using EleWise.ELMA.Packaging;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Точка расширения экспорта переводов</summary>
  [Component(Order = 500)]
  internal class TranslateExportExtension : IConfigExportExtension
  {
    private readonly IDeployManager deployManager;
    private readonly PackageService packageService;
    private readonly string version;
    private readonly List<string> pathsSavingPO;
    private readonly string basePathSave;
    internal static TranslateExportExtension t4iC5dE5quoRGSgnhpsx;

    /// <summary>Ctor</summary>
    /// <param name="deployManager">Менеджера экспорта-импорта</param>
    /// <param name="packageService">Сервис пакетной системы</param>
    public TranslateExportExtension(IDeployManager deployManager, PackageService packageService)
    {
      TranslateExportExtension.oVIY5AE5TNSvHyajOOIN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.pathsSavingPO = new List<string>()
            {
              string.Format((string) TranslateExportExtension.VvgcP5E5nnKc3F5Hnt0h(-1921202237 ^ -1921500397), TranslateExportExtension.U5oIw6E5OWn16rnXF5vG()),
              string.Format((string) TranslateExportExtension.VvgcP5E5nnKc3F5Hnt0h(2045296739 + 1688595713 ^ -561360494), TranslateExportExtension.U5oIw6E5OWn16rnXF5vG())
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 3 : 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.basePathSave = (string) TranslateExportExtension.wc8MbfE52k8OFp4cMold((object) packageService);
            num = 2;
            continue;
          case 4:
            this.deployManager = deployManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 4 : 5;
            continue;
          case 5:
            this.packageService = packageService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          default:
            this.version = VersionInfo.GetVersion(TranslateExportExtension.VXgMiuE5ki3HoDlUE8vO((object) this)).ToString();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public void AddExportObjects(ExportExtensionParams parameters)
    {
      int num = 2;
      IEnumerable<PackageDescription> translates;
      TranslateExportSettings translateSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (translateSettings != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 4 : 1;
              continue;
            }
            goto label_2;
          case 2:
            translateSettings = this.GetTranslateSettings(parameters);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_4;
          case 4:
            translates = this.FindTranslates();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_3;
          default:
            this.AddPackageDescriptions(parameters, translates, translateSettings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 3 : 0;
            continue;
        }
      }
label_4:
      return;
label_3:
      return;
label_2:;
    }

    private void AddPackageDescriptions(
      ExportExtensionParams parameters,
      IEnumerable<PackageDescription> translates,
      TranslateExportSettings settings)
    {
      foreach (CultureInfo translate in settings.Translates)
      {
        CultureInfo item = translate;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        PackageDescription packageDescription = translates.FirstOrDefault<PackageDescription>((Func<PackageDescription, bool>) (p => TranslateExportExtension.\u003C\u003Ec__DisplayClass8_0.zlTZ8L8xKVA1hTEkgGvP(TranslateExportExtension.\u003C\u003Ec__DisplayClass8_0.i6PaWs8xqR34BlCXLDpl((object) p), (object) item.ToString())));
        if (packageDescription == null)
          parameters.PackageDescriptions.Add(this.CreatePackage(item));
        else
          parameters.PackageDescriptions.Add(packageDescription);
      }
    }

    private TranslateExportSettings GetTranslateSettings(ExportExtensionParams parameters)
    {
      int num = 2;
      TranslateExportSettings parameter;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parameter == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            parameter = parameters.Parameters[TranslateExportConst.ExportExtensionUid] as TranslateExportSettings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 1;
            continue;
          case 4:
            if (parameter.ExportTranslate)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 5 : 4;
              continue;
            }
            goto label_4;
          case 5:
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (TranslateExportSettings) null;
label_5:
      return parameter;
    }

    private IEnumerable<PackageDescription> FindTranslates() => (IEnumerable<PackageDescription>) this.deployManager.FindPackages(new PackageFilter()
    {
      Level = PackageLevel.All,
      Status = PackageStatus.Any
    });

    /// <inheritdoc />
    public Dictionary<Guid, object> GetNewSettingObj() => new Dictionary<Guid, object>()
    {
      {
        TranslateExportConst.ExportExtensionUid,
        (object) new TranslateExportSettings()
      }
    };

    /// <summary>Формирование пакета</summary>
    /// <param name="info">Культура</param>
    /// <returns></returns>
    private PackageDescription CreatePackage(CultureInfo info)
    {
      int num = 2;
      PackageDescription packageDescription;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.SaveManifestMetadata(packageDescription, info);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          case 2:
            packageDescription = this.CreatePackageDescription(info);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            this.BuildPackage(packageDescription, info);
            num = 3;
            continue;
        }
      }
label_3:
      return packageDescription;
    }

    private PackageDescription CreatePackageDescription(CultureInfo info)
    {
      PackageDescription packageDescription = new PackageDescription();
      packageDescription.Id = (string) TranslateExportExtension.HPFANAE5PLWFevX9sukw(TranslateExportExtension.VvgcP5E5nnKc3F5Hnt0h(1251470110 >> 2 ^ 312850629), TranslateExportExtension.VvgcP5E5nnKc3F5Hnt0h(-2106517564 ^ -2106201386), TranslateExportExtension.HcEWX3E5ecY2OG0XrRiV((object) info));
      TranslateExportExtension.UjaQcoE51J6eY69knYyK((object) packageDescription, (object) info.NativeName);
      packageDescription.Authors = (IEnumerable<string>) new List<string>()
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113874935)
      };
      packageDescription.InstalledVersion = new SemanticVersion(this.version);
      packageDescription.Description = (string) TranslateExportExtension.Hbr3tnE5NAjOZA8yKj0b(TranslateExportExtension.VvgcP5E5nnKc3F5Hnt0h(1199946765 ^ 1199653171), (object) info.DisplayName);
      TranslateExportExtension.IhgHcgE53vtwnNIPUBox((object) packageDescription, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479226070));
      TranslateExportExtension.FnviIZE5pYTEcdXyeOwE((object) packageDescription, (object) new SemanticVersion(this.version));
      TranslateExportExtension.MGGwY4E5aRysVCtVrGPD((object) packageDescription, ElmaPackageType.Translates);
      return packageDescription;
    }

    private ManifestMetadata CreateManifestMetadata(
      PackageDescription packageDescription,
      CultureInfo info)
    {
      ManifestMetadata manifestMetadata = new ManifestMetadata();
      TranslateExportExtension.V935fkE5tIGvtmIIvrtQ((object) manifestMetadata, TranslateExportExtension.bkTHHpE5DBXhm2HLQRYu((object) packageDescription));
      manifestMetadata.Authors = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858880269), packageDescription.Authors);
      TranslateExportExtension.Yf4YXuE5wBRkWbtnZnIQ((object) manifestMetadata, (object) this.version);
      TranslateExportExtension.HP9AaSE56QwmGYHd7Hc7((object) manifestMetadata, TranslateExportExtension.H6ndXFE54C9CEawxriTF((object) packageDescription));
      TranslateExportExtension.uKuRLvE5HtIyKnEByBhC((object) manifestMetadata, TranslateExportExtension.HcEWX3E5ecY2OG0XrRiV((object) info));
      TranslateExportExtension.IueUVwE57AJvvw1Dfkii((object) manifestMetadata, TranslateExportExtension.WX7XaYE5AhGtcdCqGNjQ((object) packageDescription));
      return manifestMetadata;
    }

    private void SaveManifestMetadata(PackageDescription packageDescription, CultureInfo info)
    {
      int num1 = 2;
      Manifest manifest;
      FileStream fileStream;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_13;
          case 1:
            fileStream = (FileStream) TranslateExportExtension.swREo3E5mehiGhjF4CLj(TranslateExportExtension.FDWee6E50JeldIDlw6y0(TranslateExportExtension.VvgcP5E5nnKc3F5Hnt0h(-710283084 ^ -537863435 ^ 173922195), (object) new object[4]
            {
              (object) this.basePathSave,
              TranslateExportExtension.VvgcP5E5nnKc3F5Hnt0h(874012245 ^ 874292039),
              TranslateExportExtension.HcEWX3E5ecY2OG0XrRiV((object) info),
              (object) this.version
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 2 : 3;
            continue;
          case 2:
            manifest = (Manifest) TranslateExportExtension.Y6YqXwE5xKSLGy8epxe6((object) this.CreateManifestMetadata(packageDescription, info));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_4;
          default:
            goto label_8;
        }
      }
label_13:
      return;
label_8:
      return;
label_4:
      try
      {
        manifest.Save((Stream) fileStream);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (fileStream != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_15;
              default:
                TranslateExportExtension.Gq7SriE5yFXes5wvLeoB((object) fileStream);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 0;
                continue;
            }
          }
        }
label_15:;
      }
    }

    private void BuildPackage(PackageDescription packageDescription, CultureInfo info)
    {
      int num = 4;
      PackageBuilder packageBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.SavePackage(packageBuilder, info);
            num = 2;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.SetDependencePackage(packageBuilder);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 4:
            packageBuilder = this.CreatePackageBuilder(packageDescription, info);
            num = 3;
            continue;
          default:
            this.CopyFiles(packageBuilder, info, (string) TranslateExportExtension.HPFANAE5PLWFevX9sukw((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70010987), (object) EleWise.ELMA.SR.Dir, TranslateExportExtension.HcEWX3E5ecY2OG0XrRiV((object) info)), (string) TranslateExportExtension.HPFANAE5PLWFevX9sukw(TranslateExportExtension.VvgcP5E5nnKc3F5Hnt0h(-1487388570 ^ -1487392514), (object) EleWise.ELMA.SR.Dir, (object) info.Name));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
            continue;
        }
      }
label_2:;
    }

    private void CopyFiles(
      PackageBuilder builder,
      CultureInfo info,
      string path,
      string fullFolder)
    {
      int num1 = 16;
      while (true)
      {
        int num2 = num1;
        int index;
        string[] strArray;
        string path1;
        List<string>.Enumerator enumerator;
        string path2;
        string fileName;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_25;
            case 1:
            case 11:
              if (index < strArray.Length)
              {
                num2 = 7;
                continue;
              }
              goto case 6;
            case 2:
              ++index;
              num2 = 11;
              continue;
            case 3:
            case 5:
              if (index >= strArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
                continue;
              }
              goto label_19;
            case 4:
              goto label_19;
            case 6:
              strArray = (string[]) TranslateExportExtension.ubthiuE5J3dKpb1Lrg7t((object) path);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 13 : 5;
              continue;
            case 7:
            case 10:
              path1 = strArray[index];
              num2 = 17;
              continue;
            case 8:
              enumerator = this.pathsSavingPO.GetEnumerator();
              num2 = 9;
              continue;
            case 9:
              try
              {
label_10:
                if (enumerator.MoveNext())
                  goto label_13;
                else
                  goto label_11;
label_9:
                string current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_20;
                    case 2:
                      Collection<IPackageFile> files = builder.Files;
                      PhysicalPackageFile physicalPackageFile1 = new PhysicalPackageFile();
                      TranslateExportExtension.QaY69rE59nDYxA741Vcl((object) physicalPackageFile1, (object) path2);
                      TranslateExportExtension.dK1x8yE5lYjsEKIVgoo1((object) physicalPackageFile1, TranslateExportExtension.FDWee6E50JeldIDlw6y0(TranslateExportExtension.VvgcP5E5nnKc3F5Hnt0h(1149433385 + 173655049 ^ 1322796080), (object) new object[4]
                      {
                        (object) current,
                        TranslateExportExtension.HcEWX3E5ecY2OG0XrRiV((object) info),
                        TranslateExportExtension.jKULa5E5dTRBmgVIcVvu((object) path, (object) fullFolder, (object) ""),
                        (object) fileName
                      }));
                      PhysicalPackageFile physicalPackageFile2 = physicalPackageFile1;
                      files.Add((IPackageFile) physicalPackageFile2);
                      num3 = 3;
                      continue;
                    case 3:
                      goto label_10;
                    default:
                      goto label_13;
                  }
                }
label_11:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
                goto label_9;
label_13:
                current = enumerator.Current;
                num3 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
                {
                  num3 = 0;
                  goto label_9;
                }
                else
                  goto label_9;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 12:
              fileName = Path.GetFileName(path2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 8 : 1;
              continue;
            case 13:
              index = 0;
              num2 = 5;
              continue;
            case 14:
label_20:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 3 : 3;
              continue;
            case 15:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 1;
              continue;
            case 16:
              strArray = (string[]) TranslateExportExtension.V7Mn5RE5M10VLEavxqPH((object) path);
              num2 = 15;
              continue;
            case 17:
              this.CopyFiles(builder, info, path1, fullFolder);
              num2 = 2;
              continue;
            default:
              goto label_22;
          }
        }
label_19:
        path2 = strArray[index];
        num1 = 12;
      }
label_25:
      return;
label_22:;
    }

    private PackageBuilder CreatePackageBuilder(
      PackageDescription packageDescription,
      CultureInfo info)
    {
      int num1 = 7;
      PackageBuilder packageBuilder;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              TranslateExportExtension.Vv9isqE5g50by0rd9v1c((object) packageBuilder, TranslateExportExtension.ijFcQdE5rRRWGxxGOoMM((object) info));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_7;
            case 4:
              packageBuilder.Authors.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712492099));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
              continue;
            case 5:
              TranslateExportExtension.e5xgpHE5jrO7BRe4X3Qg((object) packageBuilder, (object) info.Name);
              num2 = 8;
              continue;
            case 6:
              packageBuilder.Id = (string) TranslateExportExtension.bkTHHpE5DBXhm2HLQRYu((object) packageDescription);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 2 : 2;
              continue;
            case 7:
              packageBuilder = new PackageBuilder();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 6;
              continue;
            case 8:
              goto label_9;
            default:
              TranslateExportExtension.wH2fyBE55qsVhcAjrFxV((object) packageBuilder, TranslateExportExtension.H6ndXFE54C9CEawxriTF((object) packageDescription));
              num2 = 5;
              continue;
          }
        }
label_4:
        packageBuilder.Tags.AddRange<string>((IEnumerable<string>) TranslateExportExtension.jbVGwVE5YFWct5yGRCtX((object) packageDescription.Tags, (object) new char[1]
        {
          ' '
        }));
        num1 = 3;
        continue;
label_9:
        packageBuilder.Version = packageDescription.InstalledVersion;
        num1 = 4;
      }
label_7:
      return packageBuilder;
    }

    private void SetDependencePackage(PackageBuilder builder)
    {
      int num = 4;
      List<PackageDependency> dependencies;
      PackageDependencySet packageDependencySet;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            packageDependencySet = new PackageDependencySet((FrameworkName) null, (IEnumerable<PackageDependency>) dependencies);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          case 3:
            dependencies.Add(new PackageDependency((string) TranslateExportExtension.VvgcP5E5nnKc3F5Hnt0h(92412609 - 1050237057 ^ -957596574)));
            num = 2;
            continue;
          case 4:
            dependencies = new List<PackageDependency>();
            num = 3;
            continue;
          default:
            builder.DependencySets.Add(packageDependencySet);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    private void SavePackage(PackageBuilder builder, CultureInfo info)
    {
      int num1 = 1;
      FileStream fileStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            fileStream = File.Create((string) TranslateExportExtension.FDWee6E50JeldIDlw6y0((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642656490), (object) new object[4]
            {
              (object) this.basePathSave,
              TranslateExportExtension.VvgcP5E5nnKc3F5Hnt0h(1051802738 - -1831968059 ^ -1410980673),
              (object) info.Name,
              (object) this.version
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_11;
          default:
            goto label_2;
        }
      }
label_11:
      return;
label_2:
      try
      {
        TranslateExportExtension.nq38BdE5L4Jtq1mCDLFE((object) builder, (object) fileStream);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        int num3;
        if (fileStream == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
        else
          goto label_12;
label_9:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_12:
        TranslateExportExtension.Gq7SriE5yFXes5wvLeoB((object) fileStream);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
        {
          num3 = 1;
          goto label_9;
        }
        else
          goto label_9;
      }
    }

    internal static void oVIY5AE5TNSvHyajOOIN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type VXgMiuE5ki3HoDlUE8vO([In] object obj0) => obj0.GetType();

    internal static object VvgcP5E5nnKc3F5Hnt0h(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object U5oIw6E5OWn16rnXF5vG() => (object) EleWise.ELMA.SR.ResourcesDirectory;

    internal static object wc8MbfE52k8OFp4cMold([In] object obj0) => (object) ((PackageService) obj0).LocalRepositoryPath;

    internal static bool lScZZhE5K6fDn0aDseiY() => TranslateExportExtension.t4iC5dE5quoRGSgnhpsx == null;

    internal static TranslateExportExtension YOvK9BE5XTIbi25Bo8n8() => TranslateExportExtension.t4iC5dE5quoRGSgnhpsx;

    internal static object HcEWX3E5ecY2OG0XrRiV([In] object obj0) => (object) ((CultureInfo) obj0).Name;

    internal static object HPFANAE5PLWFevX9sukw([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void UjaQcoE51J6eY69knYyK([In] object obj0, [In] object obj1) => ((PackageDescription) obj0).Title = (string) obj1;

    internal static object Hbr3tnE5NAjOZA8yKj0b([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void IhgHcgE53vtwnNIPUBox([In] object obj0, [In] object obj1) => ((PackageDescription) obj0).Tags = (string) obj1;

    internal static void FnviIZE5pYTEcdXyeOwE([In] object obj0, [In] object obj1) => ((PackageDescription) obj0).LastVersion = (SemanticVersion) obj1;

    internal static void MGGwY4E5aRysVCtVrGPD([In] object obj0, ElmaPackageType value) => ((PackageDescription) obj0).Type = value;

    internal static object bkTHHpE5DBXhm2HLQRYu([In] object obj0) => (object) ((PackageDescription) obj0).Id;

    internal static void V935fkE5tIGvtmIIvrtQ([In] object obj0, [In] object obj1) => ((ManifestMetadata) obj0).Id = (string) obj1;

    internal static void Yf4YXuE5wBRkWbtnZnIQ([In] object obj0, [In] object obj1) => ((ManifestMetadata) obj0).Version = (string) obj1;

    internal static object H6ndXFE54C9CEawxriTF([In] object obj0) => (object) ((PackageDescription) obj0).Description;

    internal static void HP9AaSE56QwmGYHd7Hc7([In] object obj0, [In] object obj1) => ((ManifestMetadata) obj0).Description = (string) obj1;

    internal static void uKuRLvE5HtIyKnEByBhC([In] object obj0, [In] object obj1) => ((ManifestMetadata) obj0).Language = (string) obj1;

    internal static object WX7XaYE5AhGtcdCqGNjQ([In] object obj0) => (object) ((PackageDescription) obj0).Tags;

    internal static void IueUVwE57AJvvw1Dfkii([In] object obj0, [In] object obj1) => ((ManifestMetadata) obj0).Tags = (string) obj1;

    internal static object Y6YqXwE5xKSLGy8epxe6([In] object obj0) => (object) Manifest.Create((IPackageMetadata) obj0);

    internal static object FDWee6E50JeldIDlw6y0([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, (object[]) obj1);

    internal static object swREo3E5mehiGhjF4CLj([In] object obj0) => (object) File.Create((string) obj0);

    internal static void Gq7SriE5yFXes5wvLeoB([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object V7Mn5RE5M10VLEavxqPH([In] object obj0) => (object) Directory.GetDirectories((string) obj0);

    internal static object ubthiuE5J3dKpb1Lrg7t([In] object obj0) => (object) Directory.GetFiles((string) obj0);

    internal static void QaY69rE59nDYxA741Vcl([In] object obj0, [In] object obj1) => ((PhysicalPackageFile) obj0).SourcePath = (string) obj1;

    internal static object jKULa5E5dTRBmgVIcVvu([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static void dK1x8yE5lYjsEKIVgoo1([In] object obj0, [In] object obj1) => ((PhysicalPackageFile) obj0).TargetPath = (string) obj1;

    internal static object ijFcQdE5rRRWGxxGOoMM([In] object obj0) => (object) ((CultureInfo) obj0).NativeName;

    internal static void Vv9isqE5g50by0rd9v1c([In] object obj0, [In] object obj1) => ((PackageBuilder) obj0).Title = (string) obj1;

    internal static void wH2fyBE55qsVhcAjrFxV([In] object obj0, [In] object obj1) => ((PackageBuilder) obj0).Description = (string) obj1;

    internal static void e5xgpHE5jrO7BRe4X3Qg([In] object obj0, [In] object obj1) => ((PackageBuilder) obj0).Language = (string) obj1;

    internal static object jbVGwVE5YFWct5yGRCtX([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static void nq38BdE5L4Jtq1mCDLFE([In] object obj0, [In] object obj1) => ((PackageBuilder) obj0).Save((Stream) obj1);
  }
}
