// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Glimpse.DbCommandExecuteMessage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Glimpse.Ado.Message;
using Glimpse.Core.Message;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Diagnostics.Glimpse
{
  /// <summary>
  /// Внутренний класс для взаимодействия с Glimpse.Ado.Message.CommandExecutedMessage
  /// </summary>
  internal class DbCommandExecuteMessage : 
    CommandExecutedMessage,
    ITimelineMessage,
    ITimedMessage,
    IMessage
  {
    internal static DbCommandExecuteMessage VM5xHMEiSsM1pofg3fd8;

    /// <summary>Ctor</summary>
    public DbCommandExecuteMessage(
      Guid connectionId,
      Guid commandId,
      string commandText,
      IList<CommandExecutedParamater> parameters,
      bool hasTransaction)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(connectionId, commandId, commandText, parameters, hasTransaction, false);
    }

    /// <summary>Название событие</summary>
    public string EventName
    {
      get => this.\u003CEventName\u003Ek__BackingField;
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
              this.\u003CEventName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
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

    /// <summary>Категория события</summary>
    public TimelineCategoryItem EventCategory
    {
      get => this.\u003CEventCategory\u003Ek__BackingField;
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
              this.\u003CEventCategory\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
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

    /// <summary>Вспомогательный текст события</summary>
    public string EventSubText
    {
      get => this.\u003CEventSubText\u003Ek__BackingField;
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
              this.\u003CEventSubText\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
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

    internal static bool YwiEF1EiiGYruaFlq38N() => DbCommandExecuteMessage.VM5xHMEiSsM1pofg3fd8 == null;

    internal static DbCommandExecuteMessage DSlPBKEiRctxj59wId2C() => DbCommandExecuteMessage.VM5xHMEiSsM1pofg3fd8;
  }
}
