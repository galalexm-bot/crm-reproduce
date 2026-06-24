// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.FolderPreviewUpdateHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>
  /// Очистка папки с превью при преобразовании структуры БД
  /// </summary>
  internal class FolderPreviewUpdateHandler : DbUpdateHandler
  {
    private static FolderPreviewUpdateHandler uyN9W0G2FBpvlYosjxuS;

    /// <summary>Сервис для работы с папкой предпросмотра файлов</summary>
    public IFolderPreviewService FolderPreviewService
    {
      get => this.\u003CFolderPreviewService\u003Ek__BackingField;
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
              this.\u003CFolderPreviewService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
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

    /// <summary>Для всех провайдеров</summary>
    public override Guid ProviderUid => Guid.Empty;

    /// <summary>Всегда false</summary>
    public override bool HasChanges => false;

    /// <summary>
    /// Нужно ли пересоздавать все ограничения, индексы и внешние ключи
    /// </summary>
    public override bool NeedRecreateConstraints => false;

    /// <summary>Завершение преобразования</summary>
    public override void OnComplete()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            FolderPreviewUpdateHandler.yR2iHqG2oFxuRog0UXru((object) (ThreadStart) (() =>
            {
              int num7 = 1;
              while (true)
              {
                switch (num7)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: type reference
                    new BackgroundTask((System.Action) (() =>
                    {
                      int num8 = 4;
                      List<string> list;
                      Guid result;
                      List<string>.Enumerator enumerator;
                      while (true)
                      {
                        switch (num8)
                        {
                          case 0:
                            goto label_35;
                          case 1:
                            goto label_11;
                          case 2:
                            goto label_4;
                          case 3:
                            if (list.Count == 0)
                            {
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                              continue;
                            }
                            result = Guid.Empty;
                            num8 = 5;
                            continue;
                          case 4:
                            list = Directory.EnumerateDirectories((string) FolderPreviewUpdateHandler.WO3lPdG2fHY1X9hqPPFF((object) this.FolderPreviewService)).ToList<string>();
                            num8 = 3;
                            continue;
                          case 5:
                            if (Guid.TryParse((string) FolderPreviewUpdateHandler.y0c5AhG2CBZg3jSYyy04((object) list[0].Replace((string) FolderPreviewUpdateHandler.GE8xE4G2QAmrbR8qoD4N((object) list[0]), ""), 1), out result))
                            {
                              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 7 : 1;
                              continue;
                            }
                            goto label_27;
                          case 6:
                            goto label_6;
                          case 7:
                            enumerator = list.GetEnumerator();
                            num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
                            continue;
                          default:
                            goto label_31;
                        }
                      }
label_35:
                      return;
label_4:
                      return;
label_6:
                      return;
label_31:
                      return;
label_27:
                      return;
label_11:
                      try
                      {
label_14:
                        if (enumerator.MoveNext())
                          goto label_28;
                        else
                          goto label_15;
label_12:
                        string current;
                        int num9;
                        while (true)
                        {
                          string str;
                          switch (num9)
                          {
                            case 1:
                              goto label_25;
                            case 2:
                              str = current.Replace((string) FolderPreviewUpdateHandler.GE8xE4G2QAmrbR8qoD4N((object) current), "");
                              num9 = 3;
                              continue;
                            case 3:
                              if ((int) str[0] == (int) Path.DirectorySeparatorChar)
                              {
                                num9 = 6;
                                continue;
                              }
                              break;
                            case 4:
                              goto label_28;
                            case 5:
                              goto label_19;
                            case 6:
                              str = str.Substring(1);
                              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                              continue;
                            case 7:
                              goto label_14;
                          }
                          if (FolderPreviewUpdateHandler.KMAdcTG2vi555XJnZ58u((object) str) > 2)
                            num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 4 : 5;
                          else
                            goto label_14;
                        }
label_25:
                        return;
label_19:
                        try
                        {
                          FolderPreviewUpdateHandler.oJoHNiG28tfS9RMGJNON((object) current, true);
                          int num10 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
                            num10 = 0;
                          switch (num10)
                          {
                            default:
                              goto label_14;
                          }
                        }
                        catch (Exception ex)
                        {
                          int num11 = 1;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
                            num11 = 1;
                          while (true)
                          {
                            switch (num11)
                            {
                              case 1:
                                FolderPreviewUpdateHandler.ew9uvnG2uhOdEFKhsM1B(FolderPreviewUpdateHandler.zanvfOG2ZSetTXx3OT2j(), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088280382)), (object) ex);
                                num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                                continue;
                              default:
                                goto label_14;
                            }
                          }
                        }
label_15:
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 0;
                        goto label_12;
label_28:
                        current = enumerator.Current;
                        num9 = 2;
                        goto label_12;
                      }
                      finally
                      {
                        enumerator.Dispose();
                        int num12 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
                          num12 = 0;
                        switch (num12)
                        {
                          default:
                        }
                      }
                    }), FolderPreviewUpdateHandler.TnlapZG2hCviYT89Q4KB(__typeref (EleWise.ELMA.Files.Previews.FolderPreviewService)), (string) FolderPreviewUpdateHandler.s6F1w4G2EXpcKQDwDiwj(FolderPreviewUpdateHandler.p3DiZEG2GvUc2YaelPQb(-1146510045 ^ -1146468807)), (string) FolderPreviewUpdateHandler.s6F1w4G2EXpcKQDwDiwj(FolderPreviewUpdateHandler.p3DiZEG2GvUc2YaelPQb(1253244298 - 1829393894 ^ -575978306))).Execute();
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            base.OnComplete();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    public FolderPreviewUpdateHandler()
    {
      FolderPreviewUpdateHandler.nGZoiNG2bAOgKQcNwhO0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool DG56vWG2BNQLArklAjCb() => FolderPreviewUpdateHandler.uyN9W0G2FBpvlYosjxuS == null;

    internal static FolderPreviewUpdateHandler k4QMj9G2WNyrqxYbN4Kp() => FolderPreviewUpdateHandler.uyN9W0G2FBpvlYosjxuS;

    internal static bool yR2iHqG2oFxuRog0UXru([In] object obj0) => ThreadStarter.QueueThread((ThreadStart) obj0);

    internal static void nGZoiNG2bAOgKQcNwhO0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type TnlapZG2hCviYT89Q4KB([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object p3DiZEG2GvUc2YaelPQb(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object s6F1w4G2EXpcKQDwDiwj([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object WO3lPdG2fHY1X9hqPPFF([In] object obj0) => (object) ((IFolderPreviewService) obj0).PreviewsPath;

    internal static object GE8xE4G2QAmrbR8qoD4N([In] object obj0) => (object) Path.GetDirectoryName((string) obj0);

    internal static object y0c5AhG2CBZg3jSYyy04([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static int KMAdcTG2vi555XJnZ58u([In] object obj0) => ((string) obj0).Length;

    internal static void oJoHNiG28tfS9RMGJNON([In] object obj0, [In] bool obj1) => Directory.Delete((string) obj0, obj1);

    internal static object zanvfOG2ZSetTXx3OT2j() => (object) Logger.Log;

    internal static void ew9uvnG2uhOdEFKhsM1B([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);
  }
}
