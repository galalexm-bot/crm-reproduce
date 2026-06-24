// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.ActionCheckResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Actions
{
  /// <summary>Результат проверки возможности выполнения действия</summary>
  [DataContract]
  [Serializable]
  public struct ActionCheckResult
  {
    private static object XSeoDRftyLqor6TUYmWn;

    public static ActionCheckResult True => new ActionCheckResult(true, (string) null);

    public static ActionCheckResult False(string errorMessage) => new ActionCheckResult(false, errorMessage);

    public unsafe ActionCheckResult(bool result, string errorMessage)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        goto label_3;
label_1:
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ErrorMessage = errorMessage;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 2 : 1;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.Result = result;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
            continue;
          default:
            *(ActionCheckResult*) ref this = new ActionCheckResult();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 3 : 1;
            continue;
        }
      }
label_2:
      return;
label_3:
      num = 0;
      goto label_1;
    }

    /// <summary>
    /// Результат проверки - <c>true</c>, если выполнение действия разрешено
    /// </summary>
    [DataMember]
    public bool Result
    {
      get => this.\u003CResult\u003Ek__BackingField;
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
              this.\u003CResult\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
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

    /// <summary>
    /// Текст ошибки. Заполняется в случае, когда <see cref="P:EleWise.ELMA.Actions.ActionCheckResult.Result" /> равен <c>false</c>
    /// </summary>
    [DataMember]
    public string ErrorMessage
    {
      get => this.\u003CErrorMessage\u003Ek__BackingField;
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
              this.\u003CErrorMessage\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
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

    public static implicit operator bool(ActionCheckResult actionCheckResult) => actionCheckResult.Result;

    internal static bool GJJO1NftMR463jFVQjd6() => ActionCheckResult.XSeoDRftyLqor6TUYmWn == null;

    internal static object TwouRKftJLLkitnNWtu0() => ActionCheckResult.XSeoDRftyLqor6TUYmWn;
  }
}
