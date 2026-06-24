// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.CustomMessage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Messaging
{
  [Serializable]
  public class CustomMessage
  {
    private static CustomMessage UkkGJ7hmrK28JYNb3Bml;

    /// <summary>
    /// Ключ, содержит название расширяемого оповещения и формат e-mail сообщения
    /// </summary>
    /// <example>Documents.Task/CreateApprovement, Rich</example>
    public Pair<string, string> Key { get; set; }

    /// <summary>Содержание сообщения</summary>
    public string Content
    {
      get => this.\u003CContent\u003Ek__BackingField;
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
              this.\u003CContent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
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

    public CustomMessage()
    {
      CustomMessage.r2yhCVhmjPCNvCljXLG8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool p8oE8GhmgMMRBUiCFuku() => CustomMessage.UkkGJ7hmrK28JYNb3Bml == null;

    internal static CustomMessage EmqIpVhm5JryBZqsyN6o() => CustomMessage.UkkGJ7hmrK28JYNb3Bml;

    internal static void r2yhCVhmjPCNvCljXLG8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
