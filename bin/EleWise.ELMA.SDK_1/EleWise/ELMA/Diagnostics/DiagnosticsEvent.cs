// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.DiagnosticsEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Событие диагностики системы</summary>
  public abstract class DiagnosticsEvent
  {
    private static DiagnosticsEvent Mx8GI6EWNUimnUAPyEpR;

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информаиция о текущем потоке выполнения</param>
    protected DiagnosticsEvent(CallContextInfo callContextInfo)
    {
      DiagnosticsEvent.RgULxAEWa08CKBjn7ApT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
        num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            goto label_4;
          case 3:
            this.CallContextInfo = callContextInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
            continue;
          case 4:
            if (callContextInfo != null)
            {
              this.CallContextInfoId = DiagnosticsEvent.LVouAgEWtwTgQeDvq9Ea((object) callContextInfo);
              num = 3;
              continue;
            }
            num = 2;
            continue;
          case 5:
            this.Exception = (Exception) DiagnosticsEvent.MnKJlEEWwBNaYm8KBU69((object) callContextInfo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
            continue;
          default:
            this.Level = EleWise.ELMA.Logging.LogLevel.Debug;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 5;
            continue;
        }
      }
label_3:
      return;
label_4:
      throw new ArgumentNullException((string) DiagnosticsEvent.tgee1GEWDlWsFHpAiLAZ(~1767720452 ^ -1767468129));
    }

    /// <summary>Сtor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке обработки</param>
    /// <param name="message">Сообщение</param>
    protected DiagnosticsEvent(CallContextInfo callContextInfo, string message)
    {
      DiagnosticsEvent.RgULxAEWa08CKBjn7ApT();
      // ISSUE: explicit constructor call
      this.\u002Ector(callContextInfo);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Message = message;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Идентификатор блока обработки</summary>
    public long CallContextInfoId
    {
      get => this.\u003CCallContextInfoId\u003Ek__BackingField;
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
              this.\u003CCallContextInfoId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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

    /// <summary>Уровень логирования</summary>
    public EleWise.ELMA.Logging.LogLevel Level
    {
      get => this.\u003CLevel\u003Ek__BackingField;
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
              this.\u003CLevel\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
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

    /// <summary>Время события</summary>
    public DateTime TimeStamp
    {
      get => this.\u003CTimeStamp\u003Ek__BackingField;
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
              this.\u003CTimeStamp\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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

    /// <summary>Контекст вызова привязанный к событию</summary>
    public CallContextInfo CallContextInfo
    {
      get => this.\u003CCallContextInfo\u003Ek__BackingField;
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
              this.\u003CCallContextInfo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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

    /// <summary>Сообщение</summary>
    public string Message
    {
      get => this.\u003CMessage\u003Ek__BackingField;
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
              this.\u003CMessage\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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

    /// <summary>Исключение (ошибка)</summary>
    public Exception Exception
    {
      get => this.\u003CException\u003Ek__BackingField;
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
              this.\u003CException\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
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

    internal static void RgULxAEWa08CKBjn7ApT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object tgee1GEWDlWsFHpAiLAZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static long LVouAgEWtwTgQeDvq9Ea([In] object obj0) => ((CallContextInfo) obj0).Id;

    internal static object MnKJlEEWwBNaYm8KBU69([In] object obj0) => (object) ((CallContextInfo) obj0).Exception;

    internal static bool xHFvtEEW3CpKdwIiXvQt() => DiagnosticsEvent.Mx8GI6EWNUimnUAPyEpR == null;

    internal static DiagnosticsEvent EW0WLGEWpO4NFAN98vVA() => DiagnosticsEvent.Mx8GI6EWNUimnUAPyEpR;
  }
}
