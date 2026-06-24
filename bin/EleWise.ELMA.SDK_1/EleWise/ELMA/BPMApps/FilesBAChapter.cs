// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.FilesBAChapter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.BPMApps
{
  public class FilesBAChapter : BPMAppManifestChapter
  {
    private static FilesBAChapter YRmRndfkAXiClJGemTfi;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
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

    public FilesBAChapter()
    {
      FilesBAChapter.a8SggWfk0beqPd24oyg5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool UjDk5Xfk767VQRGFBESS() => FilesBAChapter.YRmRndfkAXiClJGemTfi == null;

    internal static FilesBAChapter gZWtmafkxn317PNWRGJL() => FilesBAChapter.YRmRndfkAXiClJGemTfi;

    internal static void a8SggWfk0beqPd24oyg5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
