// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.FilesExportSetting
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Конфигурация экспорта файлов</summary>
  [Serializable]
  public class FilesExportSetting
  {
    private static FilesExportSetting Thj7DPEjO6b9lLfagWur;

    /// <summary>Ctor</summary>
    public FilesExportSetting()
    {
      FilesExportSetting.L1keR0EjPgoh8Noj3DBU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Имя файла справки</summary>
    public string HelpFileName
    {
      get => this.\u003CHelpFileName\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CHelpFileName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
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

    /// <summary>Полный путь до файла справки в момент загрузки</summary>
    public string HelpOriginalFullFileName
    {
      get => this.\u003CHelpOriginalFullFileName\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CHelpOriginalFullFileName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
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

    /// <summary>Содержимое файла справки</summary>
    public byte[] HelpFileContent
    {
      get => this.\u003CHelpFileContent\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CHelpFileContent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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

    /// <summary>Полный путь до папки с доп. файлами в момент загрузки</summary>
    public string AdditionalFilesOriginalFolder
    {
      get => this.\u003CAdditionalFilesOriginalFolder\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CAdditionalFilesOriginalFolder\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
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

    /// <summary>Архив дополнительных файлов</summary>
    public byte[] AdditionalFilesContent
    {
      get => this.\u003CAdditionalFilesContent\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CAdditionalFilesContent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор экспортируемого BpmApp</summary>
    public long BpmAppId
    {
      get => this.\u003CBpmAppId\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CBpmAppId\u003Ek__BackingField = value;
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

    /// <summary>Загрузить архив дополнительных файлов из папки</summary>
    /// <param name="folder">Путь к папке</param>
    public void LoadAdditionalContent(string folder)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNullOrEmpty(folder, (string) FilesExportSetting.q3CVB0Ej1twkfb7wTMLB(-1921202237 ^ -1921496635));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_3;
          default:
            if (FilesExportSetting.pZuHMQEjN4x5vQ6EdEAM((object) folder))
            {
              this.AdditionalFilesContent = ZipHelper.CreateZipByteArrayFromFolder(folder);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 3 : 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:
      return;
label_3:;
    }

    /// <summary>
    /// Сохранить в указанную папку архив дополнительных файлов
    /// </summary>
    /// <param name="folder"></param>
    public void SaveAdditionalContent(string folder)
    {
      int num = 7;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            FilesExportSetting.HR324tEjpe2YP9FmyUnp((object) this.AdditionalFilesContent, (object) folder);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 5 : 0;
            continue;
          case 2:
            goto label_3;
          case 4:
            goto label_7;
          case 5:
            goto label_8;
          case 6:
            if (this.AdditionalFilesContent == null)
            {
              num = 2;
              continue;
            }
            goto case 8;
          case 7:
            Contract.ArgumentNotNullOrEmpty(folder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234073834));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 6 : 2;
            continue;
          case 8:
            if (this.AdditionalFilesContent.Length != 0)
            {
              if (FilesExportSetting.pZuHMQEjN4x5vQ6EdEAM((object) folder))
              {
                num = 3;
                continue;
              }
              break;
            }
            num = 4;
            continue;
        }
        FilesExportSetting.bLYutCEj3bG2XoWhm4Wd((object) folder);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
      }
label_3:
      return;
label_7:
      return;
label_8:;
    }

    internal static void L1keR0EjPgoh8Noj3DBU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool cVbMHeEj2ucjY29PB5pN() => FilesExportSetting.Thj7DPEjO6b9lLfagWur == null;

    internal static FilesExportSetting EXYSChEjeGvmKj9yUapC() => FilesExportSetting.Thj7DPEjO6b9lLfagWur;

    internal static object q3CVB0Ej1twkfb7wTMLB(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool pZuHMQEjN4x5vQ6EdEAM([In] object obj0) => Directory.Exists((string) obj0);

    internal static object bLYutCEj3bG2XoWhm4Wd([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static void HR324tEjpe2YP9FmyUnp([In] object obj0, [In] object obj1) => ZipHelper.ExtractZipFolder((byte[]) obj0, (string) obj1);
  }
}
