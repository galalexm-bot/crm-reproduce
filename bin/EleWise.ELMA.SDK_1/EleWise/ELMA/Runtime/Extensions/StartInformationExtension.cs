// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Extensions.StartInformationExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Extensions
{
  /// <summary>Методы расширения к StartInformation</summary>
  public static class StartInformationExtension
  {
    internal static StartInformationExtension l4b5U6Wvx7Wljpww8WtL;

    public static void SetInfo(this IStartInformation startInformation, string message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            StartInformationExtension.ciISBhWvMHqVN71sYyby((object) startInformation, ((IStartInformation) StartInformationExtension.HiE73iWvyMgPKPTscRAu()).Percent, (object) message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Если текущий этап является этапом преобразования бд, то получаем номер этого этапа. Иначе - 0
    /// </summary>
    /// <returns>Номер текущего статуса</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static int GetCurrentDBConversionStage()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (StartInformationExtension.HiE73iWvyMgPKPTscRAu() is DBStartInformation startInformation)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return 0;
label_5:
      return (int) StartInformationExtension.etvheBWvJDRUiC9NiWkI((object) startInformation);
    }

    /// <summary>Получить количество этапов преобразования бд</summary>
    /// <returns>Количество статусов преобразования базы данных</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static int NumberOfDBConversionStages { get; }

    static StartInformationExtension()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: type reference
            StartInformationExtension.NumberOfDBConversionStages = StartInformationExtension.YqiYNDWvdgNTBCk5pNbB(StartInformationExtension.KcVnPOWv90M4KaqfGfEQ(__typeref (DatabaseConversionStage))).Length;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object HiE73iWvyMgPKPTscRAu() => (object) StartInformation.Current;

    internal static void ciISBhWvMHqVN71sYyby([In] object obj0, double percent, [In] object obj2) => ((IStartInformation) obj0).SetInfo(percent, (string) obj2);

    internal static bool dqBGSIWv0QYGwpF2hiyL() => StartInformationExtension.l4b5U6Wvx7Wljpww8WtL == null;

    internal static StartInformationExtension iB1ib4WvmWjywLuvFc15() => StartInformationExtension.l4b5U6Wvx7Wljpww8WtL;

    internal static DatabaseConversionStage etvheBWvJDRUiC9NiWkI([In] object obj0) => ((DBStartInformation) obj0).CurrentDatabaseConversionStage;

    internal static Type KcVnPOWv90M4KaqfGfEQ([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object YqiYNDWvdgNTBCk5pNbB([In] Type obj0) => (object) Enum.GetNames(obj0);
  }
}
