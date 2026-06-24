// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.PassPhrase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime
{
  /// <summary>Класс для работы с кодовой фразой</summary>
  public class PassPhrase
  {
    private static string configPath;
    private readonly string passPhraseFilename;
    private string passPhrase;
    private static PassPhrase UkNjJVWovmyZAhCXgQUp;

    /// <summary>Конструктор</summary>
    /// <param name="path">Путь с именем файла относительно корневого каталога фраз</param>
    public PassPhrase(string path)
    {
      PassPhrase.bjalkHWoukERhy1eZLDE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Generate();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 2;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (!PassPhrase.CYN4WHWoIWE4ZfufNjIF((object) path))
            {
              this.passPhraseFilename = (string) PassPhrase.hm9E3YWoS8nto2UQL3d9((object) PassPhrase.ConfigPath, PassPhrase.Cpq2a3WoVCgYhjSTY2wP(1574260816 ^ 1574231918), (object) path);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return;
label_3:
      throw new ArgumentException(EleWise.ELMA.SR.T((string) PassPhrase.Cpq2a3WoVCgYhjSTY2wP(-1088304168 ^ -1088404210)));
    }

    /// <summary>полный путь к файлу, который хранит фразу</summary>
    public string AbsolutePath => this.passPhraseFilename;

    /// <summary>Сгенерировать фразу и сохранить её в файле</summary>
    public void Generate()
    {
      int num1 = 1;
      StreamWriter streamWriter;
      while (true)
      {
        int num2 = num1;
        string directoryName;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.passPhrase = PassPhrase.qDtihLWoih2LFRsYJZXY().ToString((string) PassPhrase.Cpq2a3WoVCgYhjSTY2wP(-1204263869 ^ -1341583247 ^ 137430076));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            case 2:
              if (!Directory.Exists(directoryName))
              {
                num2 = 6;
                continue;
              }
              goto label_4;
            case 3:
              goto label_14;
            case 4:
              goto label_4;
            case 5:
              goto label_6;
            case 6:
              PassPhrase.PpqZl4WoRa04G2UIRhPZ((object) directoryName);
              num2 = 4;
              continue;
            default:
              directoryName = Path.GetDirectoryName(this.passPhraseFilename);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 2;
              continue;
          }
        }
label_4:
        streamWriter = (StreamWriter) PassPhrase.TIsV2BWoqUr2TfZSPAVS((object) this.passPhraseFilename);
        num1 = 5;
      }
label_14:
      return;
label_6:
      try
      {
        PassPhrase.kvvxZ1WoKfSdlybyL6FZ((object) streamWriter, (object) this.passPhrase);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_13;
            default:
              streamWriter.Flush();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 0;
              continue;
          }
        }
label_13:;
      }
      finally
      {
        int num4;
        if (streamWriter == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 1;
        else
          goto label_15;
label_12:
        switch (num4)
        {
          case 1:
          case 2:
        }
label_15:
        PassPhrase.WSYP7jWoXYY2GQX1cAQm((object) streamWriter);
        num4 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        {
          num4 = 2;
          goto label_12;
        }
        else
          goto label_12;
      }
    }

    /// <summary>Сравнить предоставленную строку с оригинальной фразой</summary>
    /// <param name="value">фраза, предоставленная пользователем</param>
    /// <returns>true - фразы совпадают, false - не совпадают</returns>
    public bool IsValid(string value) => PassPhrase.mXwwPhWoTm0DAmGLQexj((object) this.passPhrase, (object) value);

    /// <summary>Удалить файл с фразой</summary>
    public void Delete()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            PassPhrase.ihuUXMWonfi3qtHKaxBU((object) this.passPhraseFilename);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (!PassPhrase.YiittNWok3XpKGATBc95((object) this.passPhraseFilename))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 2;
              continue;
            }
            goto case 1;
          default:
            goto label_7;
        }
      }
label_5:
      return;
label_2:
      return;
label_7:;
    }

    private static string ConfigPath
    {
      get
      {
        int num1 = 3;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            string path2;
            string str;
            switch (num2)
            {
              case 1:
                if (PassPhrase.WV5lmqWoeQNMLAGjLAdK((object) path2))
                {
                  str = path2;
                  break;
                }
                goto label_6;
              case 2:
                path2 = (string) PassPhrase.blolojWo2VCOKHRJUWRH((object) ((ConnectionStringSettingsCollection) PassPhrase.zyV2qZWoOdgCRCU33Vc4())[(string) PassPhrase.Cpq2a3WoVCgYhjSTY2wP(1994213607 >> 4 ^ 124541888)]);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 1;
                continue;
              case 3:
                if (PassPhrase.configPath == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 2 : 0;
                  continue;
                }
                goto label_3;
              case 4:
                str = Path.Combine((string) PassPhrase.TT6ToxWo1nTPNgR4IbWw(PassPhrase.wMwuMbWoPqR0u3NwdEyU()), path2);
                break;
              default:
                goto label_3;
            }
            PassPhrase.configPath = (string) PassPhrase.kY0p4DWoNBT2LaDDula6((object) str);
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
          }
label_6:
          num1 = 4;
        }
label_3:
        return PassPhrase.configPath;
      }
    }

    internal static void bjalkHWoukERhy1eZLDE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool CYN4WHWoIWE4ZfufNjIF([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object Cpq2a3WoVCgYhjSTY2wP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object hm9E3YWoS8nto2UQL3d9([In] object obj0, [In] object obj1, [In] object obj2) => (object) Path.Combine((string) obj0, (string) obj1, (string) obj2);

    internal static bool MCm9HmWo8gkFt8AFnZEZ() => PassPhrase.UkNjJVWovmyZAhCXgQUp == null;

    internal static PassPhrase elFxhIWoZ6GQadk5O5ON() => PassPhrase.UkNjJVWovmyZAhCXgQUp;

    internal static Guid qDtihLWoih2LFRsYJZXY() => Guid.NewGuid();

    internal static object PpqZl4WoRa04G2UIRhPZ([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static object TIsV2BWoqUr2TfZSPAVS([In] object obj0) => (object) File.CreateText((string) obj0);

    internal static void kvvxZ1WoKfSdlybyL6FZ([In] object obj0, [In] object obj1) => ((TextWriter) obj0).WriteLine((string) obj1);

    internal static void WSYP7jWoXYY2GQX1cAQm([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool mXwwPhWoTm0DAmGLQexj([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool YiittNWok3XpKGATBc95([In] object obj0) => File.Exists((string) obj0);

    internal static void ihuUXMWonfi3qtHKaxBU([In] object obj0) => File.Delete((string) obj0);

    internal static object zyV2qZWoOdgCRCU33Vc4() => (object) ConfigurationManager.ConnectionStrings;

    internal static object blolojWo2VCOKHRJUWRH([In] object obj0) => (object) ((ConnectionStringSettings) obj0).ConnectionString;

    internal static bool WV5lmqWoeQNMLAGjLAdK([In] object obj0) => Path.IsPathRooted((string) obj0);

    internal static object wMwuMbWoPqR0u3NwdEyU() => (object) AppDomain.CurrentDomain;

    internal static object TT6ToxWo1nTPNgR4IbWw([In] object obj0) => (object) ((AppDomain) obj0).BaseDirectory;

    internal static object kY0p4DWoNBT2LaDDula6([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);
  }
}
