// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.FilesExportConsts
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Константы для экспорта файлов (справки и прочее)</summary>
  public static class FilesExportConsts
  {
    /// <summary>
    /// Uid реализации точки расширения конфигурации экспорта файлов
    /// </summary>
    public static readonly Guid ExportExtensionUid;
    /// <summary>Ключ для хранения имени файла справки</summary>
    public const string HelpFileNameServiceDataKey = "StoreComponentHelpFileName";
    /// <summary>
    /// Ключ для хранения пути расположения дополнительных файлов после импорта
    /// </summary>
    public const string AdditionalFilesImportedFolderKey = "AdditionalFilesImportedFolder";
    /// <summary>
    /// Первая версия хранения документации в пакетах BPMApp.
    /// Если версия не задана - она считается первой. Все файлы и папки лежат в ComponentFiles\
    /// </summary>
    internal const string DocumentationFirstVersion = null;
    /// <summary>
    /// Вторая версия хранения документации в пакетах BPMApp.
    /// Вторая версия - прикрепленный файл с инструкцией хранится в пакете в подпапке ComponentFiles\,
    /// все остальные прикрепленные файлы хранятся в подпапке ComponentFiles\Files
    /// </summary>
    internal const string DocumentationSecondVersion = "2";
    private static FilesExportConsts G9USPCEjEmCcgYLRbyxR;

    static FilesExportConsts()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FilesExportConsts.ExportExtensionUid = new Guid((string) FilesExportConsts.T3CTXCEjvhxbFpOmFR57(-2138160520 ^ -2138391372));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          case 2:
            FilesExportConsts.dHHxNiEjCPt6A0eQidXW();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void dHHxNiEjCPt6A0eQidXW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object T3CTXCEjvhxbFpOmFR57(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool eOBGgAEjfEYaQUtIymxo() => FilesExportConsts.G9USPCEjEmCcgYLRbyxR == null;

    internal static FilesExportConsts uuaBYWEjQyUQBGuMBUlE() => FilesExportConsts.G9USPCEjEmCcgYLRbyxR;
  }
}
