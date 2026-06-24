// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.FilesExportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Расширение экспорта конфигурации для файлов</summary>
  [Component(Order = 50)]
  public class FilesExportExtension : IConfigExportExtension
  {
    /// <summary>
    /// Ключ для получения/сохранения версии хранения инструкций
    /// </summary>
    internal const string DocumentationVersionServiceDataKey = "DocumentationVersions";
    /// <summary>
    /// Корневая подпапка для пользовательской папки с инструкциями
    /// </summary>
    internal const string RootSubFolderForAdditionalFiles = "Files";
    /// <summary>Папка в пакете для дополнительных файлов</summary>
    internal const string ComponentFilesFolder = "ComponentFiles";
    internal static FilesExportExtension DBu1KaEj8B6WHGh9rB07;

    public Dictionary<Guid, object> GetNewSettingObj() => new Dictionary<Guid, object>()
    {
      {
        FilesExportConsts.ExportExtensionUid,
        (object) new FilesExportSetting()
      }
    };

    public void AddExportObjects(ExportExtensionParams parameters)
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        byte[] helpFileContent;
        byte[] additionalFilesContent;
        FilesExportSetting setting;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_24;
            case 2:
              goto label_10;
            case 3:
              FilesExportExtension.vtqeVmEjSqaTq0alRHIM((object) setting, (object) helpFileContent);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            case 4:
              if (FilesExportExtension.BDAtVkEjRNr4pihYawox((object) setting) != null)
              {
                num2 = 5;
                continue;
              }
              goto label_7;
            case 5:
              parameters.ServiceData.Add((string) FilesExportExtension.r6pYvnEjqi3NSNmXa6lV(~541731958 ^ -542003737), FilesExportExtension.r6pYvnEjqi3NSNmXa6lV(-105199646 ^ -104941186));
              num2 = 13;
              continue;
            case 6:
            case 14:
              if (FilesExportExtension.yieTUbEjIopGJTWeIGPL((object) setting) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 3 : 4;
                continue;
              }
              goto case 5;
            case 7:
              parameters.WriteComponentFileActions.Add((Action<IExportImportFileService, string>) ((filesService, fileName) =>
              {
                int num3 = 3;
                string deployFolderName;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.SyWSwC8xD77eUpSSmU4o((object) setting) != null)
                      {
                        num3 = 6;
                        continue;
                      }
                      goto label_17;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      if (!FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.e9rwZj8x2AtSuuiFkbV8((object) deployFolderName))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 9 : 5;
                        continue;
                      }
                      goto case 4;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      deployFolderName = filesService.CreateDeployFolderName(fileName, (string) FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.OiDObl8xOYQRQwVgXvRU(87862435 ^ 87610093));
                      num3 = 2;
                      continue;
                    case 4:
                      // ISSUE: reference to a compiler-generated method
                      if (FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.j2kf1A8xPpMdMXnmO6j6((object) setting) != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 5 : 1;
                        continue;
                      }
                      goto case 7;
                    case 5:
                      if (setting.AdditionalFilesContent.Length != 0)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
                        continue;
                      }
                      goto case 7;
                    case 6:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.C16Eyi8xt4lwsdVkT5j8(FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.s7nGlX8x1UapPyHmi9iI((object) deployFolderName, FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.g3tfek8xpI8IuP156OYg((object) setting)), FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.SyWSwC8xD77eUpSSmU4o((object) setting));
                      num3 = 8;
                      continue;
                    case 7:
label_27:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.QXXGw38xaKBANjSTW2XK(FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.g3tfek8xpI8IuP156OYg((object) setting)))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 1;
                        continue;
                      }
                      goto label_12;
                    case 8:
                      goto label_21;
                    case 9:
                      // ISSUE: reference to a compiler-generated method
                      FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.au2V1R8xeDH0Ce5Fp6T8((object) deployFolderName);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 4 : 4;
                      continue;
                    default:
                      try
                      {
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        string path = (string) FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.s7nGlX8x1UapPyHmi9iI((object) deployFolderName, FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.OiDObl8xOYQRQwVgXvRU(-2099751081 ^ -2099694433));
                        int num4 = 3;
                        while (true)
                        {
                          switch (num4)
                          {
                            case 1:
                              Directory.CreateDirectory(path);
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                              continue;
                            case 2:
                              goto label_27;
                            case 3:
                              // ISSUE: reference to a compiler-generated method
                              if (!FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.e9rwZj8x2AtSuuiFkbV8((object) path))
                              {
                                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 1;
                                continue;
                              }
                              break;
                          }
                          // ISSUE: reference to a compiler-generated method
                          FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.wIMfPf8xNvej2lM7HscU((object) setting, (object) path);
                          num4 = 2;
                        }
                      }
                      catch (Exception ex)
                      {
                        int num5 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
                          num5 = 0;
                        switch (num5)
                        {
                          default:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            throw new InvalidOperationException((string) FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.JDHemg8x3DA6R3a3Dfqy(FilesExportExtension.\u003C\u003Ec__DisplayClass4_0.OiDObl8xOYQRQwVgXvRU(44884861 ^ 44755499)), ex);
                        }
                      }
                  }
                }
label_21:
                return;
label_17:
                return;
label_12:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
              continue;
            case 8:
              if (FilesExportExtension.ceLm2XEjVTqcklc7WSCn((object) setting) == 0L)
              {
                num2 = 6;
                continue;
              }
              goto case 16;
            case 9:
              setting = parameters.Parameters[FilesExportConsts.ExportExtensionUid] as FilesExportSetting;
              num2 = 12;
              continue;
            case 10:
              num2 = 9;
              continue;
            case 11:
              if (FilesExportExtension.yieTUbEjIopGJTWeIGPL((object) setting) == null)
              {
                num2 = 17;
                continue;
              }
              goto case 6;
            case 12:
              if (setting != null)
              {
                num2 = 11;
                continue;
              }
              goto label_17;
            case 13:
              FilesExportExtension.k9DSpeEjkNbS4e3exrHP(FilesExportExtension.Db3kbvEjKmklHfxajIcO((object) parameters), !FilesExportExtension.umPGSeEjTxxkJ3cOvNG3(FilesExportExtension.fmmkQJEjXIA6JYB6JDtU((object) setting)) ? FilesExportExtension.fmmkQJEjXIA6JYB6JDtU((object) setting) : (object) "");
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 7;
              continue;
            case 15:
              goto label_18;
            case 16:
              Locator.GetServiceNotNull<IBpmAppService>().LoadFiles(FilesExportExtension.ceLm2XEjVTqcklc7WSCn((object) setting), out helpFileContent, out additionalFilesContent);
              num2 = 3;
              continue;
            case 17:
              if (setting.AdditionalFilesContent == null)
              {
                num2 = 8;
                continue;
              }
              goto case 6;
            default:
              goto label_19;
          }
        }
label_19:
        FilesExportExtension.hOUxdmEji0JrBs7UpeUw((object) setting, (object) additionalFilesContent);
        num1 = 14;
      }
label_24:
      return;
label_10:
      return;
label_18:
      return;
label_17:
      return;
label_7:;
    }

    public FilesExportExtension()
    {
      FilesExportExtension.Clta1DEjnF3Q8kVGls08();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object yieTUbEjIopGJTWeIGPL([In] object obj0) => (object) ((FilesExportSetting) obj0).HelpFileContent;

    internal static long ceLm2XEjVTqcklc7WSCn([In] object obj0) => ((FilesExportSetting) obj0).BpmAppId;

    internal static void vtqeVmEjSqaTq0alRHIM([In] object obj0, [In] object obj1) => ((FilesExportSetting) obj0).HelpFileContent = (byte[]) obj1;

    internal static void hOUxdmEji0JrBs7UpeUw([In] object obj0, [In] object obj1) => ((FilesExportSetting) obj0).AdditionalFilesContent = (byte[]) obj1;

    internal static object BDAtVkEjRNr4pihYawox([In] object obj0) => (object) ((FilesExportSetting) obj0).AdditionalFilesContent;

    internal static object r6pYvnEjqi3NSNmXa6lV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Db3kbvEjKmklHfxajIcO([In] object obj0) => (object) ((ExportExtensionParams) obj0).Manifest;

    internal static object fmmkQJEjXIA6JYB6JDtU([In] object obj0) => (object) ((FilesExportSetting) obj0).HelpFileName;

    internal static bool umPGSeEjTxxkJ3cOvNG3([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static void k9DSpeEjkNbS4e3exrHP([In] object obj0, [In] object obj1) => ((ElmaStoreComponentManifest) obj0).HelpFileName = (string) obj1;

    internal static bool H1ZIMEEjZaEmsBqFvC3E() => FilesExportExtension.DBu1KaEj8B6WHGh9rB07 == null;

    internal static FilesExportExtension Gw7RBqEjuaANrLoUYCfW() => FilesExportExtension.DBu1KaEj8B6WHGh9rB07;

    internal static void Clta1DEjnF3Q8kVGls08() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
